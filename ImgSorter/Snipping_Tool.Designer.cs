
namespace ImgSorter
{
    partial class Snipping_Tool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grardientPanel1 = new GrardientPanel.GrardientPanel();
            this.shape_name_textBox = new System.Windows.Forms.TextBox();
            this.Export_data_button = new GradientButton.GradientButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gradientButton2 = new GradientButton.GradientButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.snipped_image_pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Image_pictureBox = new System.Windows.Forms.PictureBox();
            this.open_Image_Button = new GradientButton.GradientButton();
            this.grardientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snipped_image_pictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grardientPanel1
            // 
            this.grardientPanel1.Controls.Add(this.shape_name_textBox);
            this.grardientPanel1.Controls.Add(this.Export_data_button);
            this.grardientPanel1.Controls.Add(this.button1);
            this.grardientPanel1.Controls.Add(this.gradientButton2);
            this.grardientPanel1.Controls.Add(this.panel2);
            this.grardientPanel1.Controls.Add(this.panel1);
            this.grardientPanel1.Controls.Add(this.open_Image_Button);
            this.grardientPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.grardientPanel1.GradientAngle = 90;
            this.grardientPanel1.Location = new System.Drawing.Point(-1, -1);
            this.grardientPanel1.Name = "grardientPanel1";
            this.grardientPanel1.Size = new System.Drawing.Size(654, 488);
            this.grardientPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.grardientPanel1.TabIndex = 0;
            this.grardientPanel1.Transparent1 = 250;
            this.grardientPanel1.Transparent2 = 250;
            // 
            // shape_name_textBox
            // 
            this.shape_name_textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.shape_name_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shape_name_textBox.ForeColor = System.Drawing.Color.White;
            this.shape_name_textBox.Location = new System.Drawing.Point(436, 342);
            this.shape_name_textBox.Name = "shape_name_textBox";
            this.shape_name_textBox.Size = new System.Drawing.Size(172, 13);
            this.shape_name_textBox.TabIndex = 7;
            // 
            // Export_data_button
            // 
            this.Export_data_button.BackColor = System.Drawing.Color.Transparent;
            this.Export_data_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.Export_data_button.BorderWidth = 2;
            this.Export_data_button.ButtonShape = GradientButton.GradientButton.ButtonsShapes.Rect;
            this.Export_data_button.ButtonText = "Export";
            this.Export_data_button.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Export_data_button.FlatAppearance.BorderSize = 0;
            this.Export_data_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Export_data_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Export_data_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_data_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_data_button.GradientAngle = 0;
            this.Export_data_button.Location = new System.Drawing.Point(487, 432);
            this.Export_data_button.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Export_data_button.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Export_data_button.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.Export_data_button.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.Export_data_button.Name = "Export_data_button";
            this.Export_data_button.ShowButtontext = true;
            this.Export_data_button.Size = new System.Drawing.Size(135, 42);
            this.Export_data_button.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(169)))));
            this.Export_data_button.TabIndex = 6;
            this.Export_data_button.Text = "test";
            this.Export_data_button.TextLocation_X = 45;
            this.Export_data_button.TextLocation_Y = 15;
            this.Export_data_button.Transparent1 = 250;
            this.Export_data_button.Transparent2 = 250;
            this.Export_data_button.UseVisualStyleBackColor = false;
            this.Export_data_button.Click += new System.EventHandler(this.Export_data_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(413, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 39);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gradientButton2
            // 
            this.gradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.gradientButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.gradientButton2.BorderWidth = 2;
            this.gradientButton2.ButtonShape = GradientButton.GradientButton.ButtonsShapes.Rect;
            this.gradientButton2.ButtonText = "Name : ";
            this.gradientButton2.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.gradientButton2.FlatAppearance.BorderSize = 0;
            this.gradientButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.gradientButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.gradientButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientButton2.GradientAngle = 0;
            this.gradientButton2.Location = new System.Drawing.Point(413, 270);
            this.gradientButton2.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.gradientButton2.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.gradientButton2.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.gradientButton2.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.gradientButton2.Name = "gradientButton2";
            this.gradientButton2.ShowButtontext = true;
            this.gradientButton2.Size = new System.Drawing.Size(135, 42);
            this.gradientButton2.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(169)))));
            this.gradientButton2.TabIndex = 4;
            this.gradientButton2.Text = "test";
            this.gradientButton2.TextLocation_X = 30;
            this.gradientButton2.TextLocation_Y = 15;
            this.gradientButton2.Transparent1 = 250;
            this.gradientButton2.Transparent2 = 250;
            this.gradientButton2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.panel2.Controls.Add(this.snipped_image_pictureBox);
            this.panel2.Location = new System.Drawing.Point(413, 61);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(212, 189);
            this.panel2.TabIndex = 3;
            // 
            // snipped_image_pictureBox
            // 
            this.snipped_image_pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.snipped_image_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snipped_image_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.snipped_image_pictureBox.Name = "snipped_image_pictureBox";
            this.snipped_image_pictureBox.Size = new System.Drawing.Size(206, 183);
            this.snipped_image_pictureBox.TabIndex = 0;
            this.snipped_image_pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.Image_pictureBox);
            this.panel1.Location = new System.Drawing.Point(28, 61);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(343, 378);
            this.panel1.TabIndex = 2;
            // 
            // Image_pictureBox
            // 
            this.Image_pictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.Image_pictureBox.Location = new System.Drawing.Point(3, 3);
            this.Image_pictureBox.Name = "Image_pictureBox";
            this.Image_pictureBox.Size = new System.Drawing.Size(337, 372);
            this.Image_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_pictureBox.TabIndex = 0;
            this.Image_pictureBox.TabStop = false;
            this.Image_pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.Image_pictureBox_Paint);
            this.Image_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Image_pictureBox_MouseDown);
            this.Image_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Image_pictureBox_MouseMove);
            this.Image_pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Image_pictureBox_MouseUp);
            // 
            // open_Image_Button
            // 
            this.open_Image_Button.BackColor = System.Drawing.Color.Transparent;
            this.open_Image_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.open_Image_Button.BorderWidth = 2;
            this.open_Image_Button.ButtonShape = GradientButton.GradientButton.ButtonsShapes.Rect;
            this.open_Image_Button.ButtonText = "Open Image";
            this.open_Image_Button.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.open_Image_Button.FlatAppearance.BorderSize = 0;
            this.open_Image_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.open_Image_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.open_Image_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_Image_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_Image_Button.GradientAngle = 0;
            this.open_Image_Button.Location = new System.Drawing.Point(28, 13);
            this.open_Image_Button.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.open_Image_Button.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.open_Image_Button.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.open_Image_Button.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.open_Image_Button.Name = "open_Image_Button";
            this.open_Image_Button.ShowButtontext = true;
            this.open_Image_Button.Size = new System.Drawing.Size(135, 42);
            this.open_Image_Button.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(169)))));
            this.open_Image_Button.TabIndex = 1;
            this.open_Image_Button.Text = "test";
            this.open_Image_Button.TextLocation_X = 30;
            this.open_Image_Button.TextLocation_Y = 15;
            this.open_Image_Button.Transparent1 = 250;
            this.open_Image_Button.Transparent2 = 250;
            this.open_Image_Button.UseVisualStyleBackColor = false;
            this.open_Image_Button.Click += new System.EventHandler(this.open_Image_Button_Click);
            // 
            // Snipping_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 485);
            this.Controls.Add(this.grardientPanel1);
            this.Name = "Snipping_Tool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snipping_Tool";
            this.grardientPanel1.ResumeLayout(false);
            this.grardientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snipped_image_pictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrardientPanel.GrardientPanel grardientPanel1;
        private GradientButton.GradientButton open_Image_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Image_pictureBox;
        private System.Windows.Forms.TextBox shape_name_textBox;
        private GradientButton.GradientButton Export_data_button;
        private System.Windows.Forms.Button button1;
        private GradientButton.GradientButton gradientButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox snipped_image_pictureBox;
        private System.Windows.Forms.Timer timer1;
    }
}