using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgSorter
{
    public partial class DocumentSorter : Form
    {

        List<string> FilesPath = new List<string>();
        public Bitmap source_Bmp = null;
        public DocumentSorter()
        {

            InitializeComponent();

            Central_Static_Value.DocumentSorter = this;

            this.circularProgressBar1.Value = 0;

            backgroundWorker1.DoWork += backgroundWorker1_DoWork;

            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            
            backgroundWorker1.WorkerReportsProgress = true;


        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (FilesPath.Count != 0)
            {


                for (int i = 0; i < FilesPath.Count; i++)
                {
                    try
                    {
                        bool Match = false;

                        Bitmap refs = new Bitmap(FilesPath[i]);

                        OpenCvSharp.Mat reference = OpenCvSharp.Extensions.BitmapConverter.ToMat(refs);

                        if (!reference.IsDisposed)
                        {
                            
                               OpenCvSharp.Mat template = OpenCvSharp.Extensions.BitmapConverter.ToMat(source_Bmp);
                               
                               
                                
                                ImageProcessor imageProcessor = new ImageProcessor();

                                List<TemplateMatch> TemplateMatchs = imageProcessor.TemplateMatch(reference, template);

                                if (TemplateMatchs.Count != 0)
                                {

                                    TemplateMatch templateMatch = TemplateMatchs[0];

                                    Match = templateMatch.ElemenstFound;

                                    if (Match)
                                    {

                                        this.dataGridView1.Rows[i].Cells[3].Value = this.shape_name.Text;

                                        string templatename = this.shape_name.Text;

                                        string targetPath = this.Target_folder_path_button.Text + "/" + (i + 1).ToString() + " - " + " " + templatename + ".png";

                                        refs.Save(targetPath);



                                    }



                                }
                                //   else this.dataGridView1.Rows[i].Cells[3].Value = "no match";


                            
                        }

                        if (Match == false) this.dataGridView1.Rows[i].Cells[3].Value = "no match found";

                    }
                    catch (Exception ex)
                    {

                        if (this.dataGridView1.Rows.Count != 0)

                            this.dataGridView1.Rows[i].Cells[3].Value = ex.Message;
                        
                       

                    }


                    backgroundWorker1.ReportProgress(((i + 1) * 100) / FilesPath.Count);

                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            circularProgressBar1.Value = e.ProgressPercentage;
            this.label1.Text = e.ProgressPercentage.ToString()+"%";
        }


        private void open_snipping_logo_Click(object sender, EventArgs e)
        {
            
            Snipping_Tool snipping_Tool = new Snipping_Tool();
            snipping_Tool.ShowDialog();

        }

        private void Images_folder_button_Click(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    this.Images_folder_path_button.Text = fbd.SelectedPath;

                }
            }

            getFielslFromFolderInDatagrid();

        }

        private void Target_folder_button_Click(object sender, EventArgs e)
        {

            using (var fbd = new FolderBrowserDialog())
            {

                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                   this.Target_folder_path_button.Text = fbd.SelectedPath;

                }
            }

        }

        

        private void getFielslFromFolderInDatagrid()
        {

            try
            {

                string supportedExtensions = "*.jpg,*.gif,*.png,*.bmp,*.jpe,*.jpeg,*.tif,*.tiff";

                if (this.dataGridView1.Rows.Count == 0)
                {
                    string[] files = Directory.GetFiles(this.Images_folder_path_button.Text, "*.*", SearchOption.AllDirectories).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())).ToArray();

                    if (files != null)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {

                            FilesPath.Add(files[i]);

                            string fileName = Path.GetFileName(files[i]);

                            this.dataGridView1.Rows.Add((i + 1).ToString(), fileName);

                        }
                    }
                }
                else
                {

                    this.dataGridView1.Rows.Clear();

                    string[] files = Directory.GetFiles(this.Images_folder_path_button.Text).Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())).ToArray();

                    if (files != null)
                    {
                        for (int i = 0; i < files.Length; i++)
                        {

                            FilesPath.Add(files[i]);

                            string fileName = Path.GetFileName(files[i]);

                            this.dataGridView1.Rows.Add((i + 1).ToString(), fileName);

                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void Satrt_processing_Click(object sender, EventArgs e)
        {

            if (this.backgroundWorker1.IsBusy)
            { }
            else
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }
    }
}
