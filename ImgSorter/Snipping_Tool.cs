using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgSorter
{
    public partial class Snipping_Tool : Form
    {


        Image<Bgr, byte> ImgInput;
        Rectangle rect;
        Point StartLocation;
        Point EndLocation;
        bool IsMouseDown = false;
        ImageProcessor ImageProcessor = new ImageProcessor();
        Size DefaultImageSize = new Size();
        public Snipping_Tool()
        {
            InitializeComponent();
        }


        void addMenuListToIPB()
        {

            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Resize to PictureBox Size",new EventHandler(Resize_IMG_to_PictureBox_Size));
            Image_pictureBox.ContextMenu = cm;

        }

        private void Resize_IMG_to_PictureBox_Size(object sender, EventArgs e)
        {

            ImageProcessor.imgeBgrByte = this.ImgInput.Resize(panel1.Width, panel1.Height, Emgu.CV.CvEnum.Inter.Linear);

            Image_pictureBox.Image = this.ImgInput.Resize(panel1.Width, panel1.Height,Emgu.CV.CvEnum.Inter.Linear).ToBitmap();

        }

        private void open_Image_Button_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog getImag = new OpenFileDialog();

            getImag.Filter = "PNG,JPG|*.png;*.jpg";

            DialogResult result = getImag.ShowDialog();

            string Source_Logo_Link = string.Empty;


            if (result == DialogResult.OK)
            {

                this.ImgInput = new Image<Bgr, byte>(getImag.FileName);

                ImageProcessor.imgeBgrByte = ImgInput;

                Image_pictureBox.Image = this.ImgInput.ToBitmap() ;

                DefaultImageSize = Image_pictureBox.Image.Size;

            }

            addMenuListToIPB();


        }



        private void Image_pictureBox_MouseDown(object sender, MouseEventArgs e)
        {

            IsMouseDown = true;

            StartLocation = e.Location;

        }

        private void Image_pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (IsMouseDown == true)
            {

                EndLocation = e.Location;

                Image_pictureBox.Invalidate();

            }

        }

        private void Image_pictureBox_Paint(object sender, PaintEventArgs e)
        {

            if (rect != null)
            {

                e.Graphics.DrawRectangle(Pens.Black, GetRectangle());

            }

        }

        private Rectangle GetRectangle()
        {
            rect = new Rectangle();
            rect.X = Math.Min(StartLocation.X, EndLocation.X);
            rect.Y = Math.Min(StartLocation.Y, EndLocation.Y);
            rect.Width = Math.Abs(StartLocation.X - EndLocation.X);
            rect.Height = Math.Abs(StartLocation.Y - EndLocation.Y);

            return rect;
        }

        private void Image_pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

            if (IsMouseDown == true)
            {

                EndLocation = e.Location;

                IsMouseDown = false;

               
                    if (rect != null)
                    {

                        if (rect.Width > 1 || rect.Height > 1)
                        {

                    
                            snipped_image_pictureBox.Image = ImageProcessor.CutImage(rect);

                              Central_Static_Value.DocumentSorter.source_Bmp = ImageProcessor.CutImage(rect);


                        }
                
                    }
                
            }

        }

        private void Export_data_button_Click(object sender, EventArgs e)
        {

            string shape_name = shape_name_textBox.Text;

            Image shape = this.snipped_image_pictureBox.Image;

            if (shape_name != string.Empty && shape != null)
            {

                Central_Static_Value.DocumentSorter.shape_name.Text = shape_name;

                Central_Static_Value.DocumentSorter.shape_pictureBox.Image = shape;

                

                this.Close();

            }
            else {

                MessageBox.Show("you have to fill all requiret felde .. then Try Again","Wahrning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            }

        }

       

    }
}
