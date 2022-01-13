using Emgu.CV;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgSorter
{
    public class ImageProcessor
    {

        public string ImageLocation = string.Empty;

        public Image image = null;

        public Image<Bgr, byte> imgeBgrByte = null;


        public ImageProcessor()
        {


        }

        public ImageProcessor(string Img)
        {

            this.ImageLocation = Img;
            this.imgeBgrByte = new Image<Bgr, byte>(Img);

        }


        public ImageProcessor(Image<Bgr, byte> Img)
        {

            this.imgeBgrByte = Img;

        }

        public Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public Bitmap CutImage(Rectangle rect)
        {


            if (this.imgeBgrByte != null)
            {
                this.imgeBgrByte.ROI = rect;

                Image<Bgr, byte> temp = this.imgeBgrByte.CopyBlank();

                imgeBgrByte.CopyTo(temp);

                imgeBgrByte.ROI = Rectangle.Empty;

                return temp.ToBitmap();

            }
            else return null;

        }

        public Bitmap selectHomographyInImage(Image<Bgr, byte> targetImg, VectorOfPoint vectorOfPoint)
        {

            var ImageSecnce = this.imgeBgrByte.Convert<Gray, Byte>();
            var ImageTemplate = targetImg.Convert<Gray, Byte>();

            var vp = getHomographyPointsandCount(ImageTemplate, ImageSecnce);

            if (vp != null)
            {
                CvInvoke.Polylines(ImageSecnce, vp.HomographyPts, true, new MCvScalar(0, 0, 255), 5);
            }

            return ImageSecnce.AsBitmap();

        }


        public ImagesHomography getHomographyPointsandCount(Image<Gray, byte> template, Image<Gray, byte> sceneImage)
        {
            try
            {
                // initialization
                ImagesHomography ImagesHomography = null;
                Mat homography = null;
                VectorOfKeyPoint templateKeyPoints = new VectorOfKeyPoint();
                VectorOfKeyPoint sceneKeyPoints = new VectorOfKeyPoint();
                Mat tempalteDescriptor = new Mat();
                Mat sceneDescriptor = new Mat();

                Mat mask;
                int k = 2;
                double uniquenessthreshold = 0.80;
                VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch();

                // feature detectino and description
                Brisk featureDetector = new Brisk();
                featureDetector.DetectAndCompute(template, null, templateKeyPoints, tempalteDescriptor, false);
                featureDetector.DetectAndCompute(sceneImage, null, sceneKeyPoints, sceneDescriptor, false);

                // Matching
                BFMatcher matcher = new BFMatcher(DistanceType.Hamming);
                matcher.Add(tempalteDescriptor);
                matcher.KnnMatch(sceneDescriptor, matches, k);

                mask = new Mat(matches.Size, 1, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
                mask.SetTo(new MCvScalar(255));

                Features2DToolbox.VoteForUniqueness(matches, uniquenessthreshold, mask);

                int count = Features2DToolbox.VoteForSizeAndOrientation(templateKeyPoints, sceneKeyPoints, matches, mask, 1.5, 20);

                if (count >= 30)
                {
                    homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(templateKeyPoints,
                        sceneKeyPoints, matches, mask, 5);
                }

                if (homography != null)
                {
                    Rectangle rect = new Rectangle(Point.Empty, template.Size);
                    PointF[] pts = new PointF[]
                    {
                        new PointF(rect.Left,rect.Bottom),
                        new PointF(rect.Right,rect.Bottom),
                        new PointF(rect.Right,rect.Top),
                        new PointF(rect.Left,rect.Top)
                    };

                    pts = CvInvoke.PerspectiveTransform(pts, homography);
                    Point[] points = Array.ConvertAll<PointF, Point>(pts, Point.Round);
                    ImagesHomography = new ImagesHomography(count, new VectorOfPoint(points));
                }
                else ImagesHomography = new ImagesHomography(count);


                return ImagesHomography;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<TemplateMatch> TemplateMatch(OpenCvSharp.Mat reference, OpenCvSharp.Mat template)
        {
            try
            {
                bool ElementFounded = false;
                List<TemplateMatch> templateMatch = new List<TemplateMatch>();
                OpenCvSharp.Mat refMat = reference;
                OpenCvSharp.Mat tplMat = template;
                refMat = reference;
                OpenCvSharp.Mat res = new OpenCvSharp.Mat(refMat.Rows - tplMat.Rows + 1, refMat.Cols - tplMat.Cols + 1, OpenCvSharp.MatType.CV_32FC1);
                // OpenCvSharp.Mat res = new OpenCvSharp.Mat( tplMat.Rows + 1,  tplMat.Cols + 1, OpenCvSharp.MatType.CV_32FC1);
                //Convert input images to gray
                OpenCvSharp.Mat gref = refMat.CvtColor(OpenCvSharp.ColorConversionCodes.BGR2GRAY);
                OpenCvSharp.Mat gtpl = tplMat.CvtColor(OpenCvSharp.ColorConversionCodes.BGR2GRAY);

                OpenCvSharp.Cv2.MatchTemplate(gref, gtpl, res, OpenCvSharp.TemplateMatchModes.CCoeffNormed);
                OpenCvSharp.Cv2.Threshold(res, res, 0.8, 1.0, OpenCvSharp.ThresholdTypes.Tozero);
                while (true)
                {
                    double minval, maxval, threshold = 0.8;
                    OpenCvSharp.Point minloc, maxloc;
                    OpenCvSharp.Cv2.MinMaxLoc(res, out minval, out maxval, out minloc, out maxloc);

                    if (maxval >= threshold)
                    {
                        ElementFounded = true;

                        //Setup the rectangle to draw
                        ElementsCordinate ElementsCordinate = new ElementsCordinate(new OpenCvSharp.Point(maxloc.X, maxloc.Y), new OpenCvSharp.Size(tplMat.Width, tplMat.Height));

                        //Fill in the res Mat so you don't find the same area again in the MinMaxLoc
                        OpenCvSharp.Rect outRect;
                        OpenCvSharp.Cv2.FloodFill(res, maxloc, new OpenCvSharp.Scalar(0), out outRect, new OpenCvSharp.Scalar(0.1), new OpenCvSharp.Scalar(1.0));
                        templateMatch.Add(new TemplateMatch(ElementFounded, ElementsCordinate, refMat));



                    }
                    else
                        break;
                }


                res.Dispose();
                res.Release();
                res = null;

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();


                return templateMatch;


            }
            catch (Exception ex) { throw new Exception(ex.Message); }

        }

    }



    public class ImagesHomography
    {

        public bool MatchFound = false;

        public int HomographyCount = 0;

        public VectorOfPoint HomographyPts = null;

        public ImagesHomography(int _HomographyCount, VectorOfPoint _HomographyPts)
        {

            this.MatchFound = (HomographyCount > 5) ? true : false;
            this.HomographyCount = _HomographyCount;
            this.HomographyPts = _HomographyPts;

        }

        public ImagesHomography(int _HomographyCount)
        {

            this.MatchFound = (HomographyCount > 25) ? true : false;
            this.HomographyCount = _HomographyCount;

        }

    }

    public class TemplateMatch
    {

        public OpenCvSharp.Mat SourceImage = new OpenCvSharp.Mat();

        public bool ElemenstFound = false;

        public ElementsCordinate ElementsCordinates = null;

        public TemplateMatch(bool ElementFound_, ElementsCordinate ElementsCordinates_, OpenCvSharp.Mat SourceImage_)
        {

            ElemenstFound = ElementFound_;

            ElementsCordinates = ElementsCordinates_;

            SourceImage = SourceImage_;

        }

    }

    public class ElementsCordinate
    {

        public OpenCvSharp.Point Point = new OpenCvSharp.Point();

        public OpenCvSharp.Size Size = new OpenCvSharp.Size();

        public ElementsCordinate(OpenCvSharp.Point Point_, OpenCvSharp.Size Size_)
        {
            this.Point = Point_;
            this.Size = Size_;

        }

    }
}
