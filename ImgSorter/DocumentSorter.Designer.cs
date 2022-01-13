
namespace ImgSorter
{
    partial class DocumentSorter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentSorter));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grardientPanel1 = new GrardientPanel.GrardientPanel();
            this.Images_folder_button = new GradientButton.GradientButton();
            this.shape_name = new System.Windows.Forms.Button();
            this.open_snipping_logo = new GradientButton.GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.Satrt_processing = new GradientButton.GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info_Column = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target_folder_path_button = new System.Windows.Forms.Button();
            this.Target_folder_button = new GradientButton.GradientButton();
            this.Images_folder_path_button = new System.Windows.Forms.Button();
            this.shape_pictureBox = new System.Windows.Forms.PictureBox();
            this.grardientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grardientPanel1
            // 
            this.grardientPanel1.Controls.Add(this.Images_folder_button);
            this.grardientPanel1.Controls.Add(this.shape_name);
            this.grardientPanel1.Controls.Add(this.open_snipping_logo);
            this.grardientPanel1.Controls.Add(this.label1);
            this.grardientPanel1.Controls.Add(this.circularProgressBar1);
            this.grardientPanel1.Controls.Add(this.Satrt_processing);
            this.grardientPanel1.Controls.Add(this.panel1);
            this.grardientPanel1.Controls.Add(this.Target_folder_path_button);
            this.grardientPanel1.Controls.Add(this.Target_folder_button);
            this.grardientPanel1.Controls.Add(this.Images_folder_path_button);
            this.grardientPanel1.Controls.Add(this.shape_pictureBox);
            this.grardientPanel1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.grardientPanel1.GradientAngle = 90;
            this.grardientPanel1.Location = new System.Drawing.Point(0, 0);
            this.grardientPanel1.Name = "grardientPanel1";
            this.grardientPanel1.Size = new System.Drawing.Size(710, 676);
            this.grardientPanel1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.grardientPanel1.TabIndex = 0;
            this.grardientPanel1.Transparent1 = 255;
            this.grardientPanel1.Transparent2 = 255;
            // 
            // Images_folder_button
            // 
            this.Images_folder_button.BackColor = System.Drawing.Color.Transparent;
            this.Images_folder_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.Images_folder_button.BorderWidth = 2;
            this.Images_folder_button.ButtonShape = GradientButton.GradientButton.ButtonsShapes.Rect;
            this.Images_folder_button.ButtonText = "Images Folder";
            this.Images_folder_button.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Images_folder_button.FlatAppearance.BorderSize = 0;
            this.Images_folder_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Images_folder_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Images_folder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Images_folder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Images_folder_button.GradientAngle = 0;
            this.Images_folder_button.Location = new System.Drawing.Point(54, 226);
            this.Images_folder_button.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Images_folder_button.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Images_folder_button.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.Images_folder_button.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.Images_folder_button.Name = "Images_folder_button";
            this.Images_folder_button.ShowButtontext = true;
            this.Images_folder_button.Size = new System.Drawing.Size(135, 37);
            this.Images_folder_button.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(169)))));
            this.Images_folder_button.TabIndex = 12;
            this.Images_folder_button.Text = "test";
            this.Images_folder_button.TextLocation_X = 30;
            this.Images_folder_button.TextLocation_Y = 13;
            this.Images_folder_button.Transparent1 = 250;
            this.Images_folder_button.Transparent2 = 250;
            this.Images_folder_button.UseVisualStyleBackColor = false;
            this.Images_folder_button.Click += new System.EventHandler(this.Images_folder_button_Click);
            // 
            // shape_name
            // 
            this.shape_name.BackColor = System.Drawing.Color.Transparent;
            this.shape_name.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.shape_name.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.shape_name.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.shape_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shape_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shape_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shape_name.Location = new System.Drawing.Point(483, 167);
            this.shape_name.Name = "shape_name";
            this.shape_name.Size = new System.Drawing.Size(189, 23);
            this.shape_name.TabIndex = 11;
            this.shape_name.Text = "Name";
            this.shape_name.UseVisualStyleBackColor = false;
            // 
            // open_snipping_logo
            // 
            this.open_snipping_logo.BackColor = System.Drawing.Color.Transparent;
            this.open_snipping_logo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.open_snipping_logo.BorderWidth = 2;
            this.open_snipping_logo.ButtonShape = GradientButton.GradientButton.ButtonsShapes.Rect;
            this.open_snipping_logo.ButtonText = "Snipping Logo";
            this.open_snipping_logo.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.open_snipping_logo.FlatAppearance.BorderSize = 0;
            this.open_snipping_logo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.open_snipping_logo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.open_snipping_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_snipping_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.open_snipping_logo.GradientAngle = 0;
            this.open_snipping_logo.Location = new System.Drawing.Point(263, 34);
            this.open_snipping_logo.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.open_snipping_logo.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.open_snipping_logo.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.open_snipping_logo.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.open_snipping_logo.Name = "open_snipping_logo";
            this.open_snipping_logo.ShowButtontext = true;
            this.open_snipping_logo.Size = new System.Drawing.Size(135, 37);
            this.open_snipping_logo.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(169)))));
            this.open_snipping_logo.TabIndex = 10;
            this.open_snipping_logo.Text = "test";
            this.open_snipping_logo.TextLocation_X = 30;
            this.open_snipping_logo.TextLocation_Y = 13;
            this.open_snipping_logo.Transparent1 = 250;
            this.open_snipping_logo.Transparent2 = 250;
            this.open_snipping_logo.UseVisualStyleBackColor = false;
            this.open_snipping_logo.Click += new System.EventHandler(this.open_snipping_logo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(154)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(576, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "0%";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(154)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(515, 371);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(129)))), ((int)(((byte)(154)))));
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(181, 186);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 8;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // Satrt_processing
            // 
            this.Satrt_processing.BackColor = System.Drawing.Color.Transparent;
            this.Satrt_processing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.Satrt_processing.BorderWidth = 2;
            this.Satrt_processing.ButtonShape = GradientButton.GradientButton.ButtonsShapes.RoundRect;
            this.Satrt_processing.ButtonText = "Start ";
            this.Satrt_processing.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Satrt_processing.FlatAppearance.BorderSize = 0;
            this.Satrt_processing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Satrt_processing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Satrt_processing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Satrt_processing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Satrt_processing.GradientAngle = 0;
            this.Satrt_processing.Location = new System.Drawing.Point(298, 593);
            this.Satrt_processing.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Satrt_processing.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Satrt_processing.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.Satrt_processing.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.Satrt_processing.Name = "Satrt_processing";
            this.Satrt_processing.ShowButtontext = true;
            this.Satrt_processing.Size = new System.Drawing.Size(125, 55);
            this.Satrt_processing.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(239)))), ((int)(((byte)(107)))));
            this.Satrt_processing.TabIndex = 7;
            this.Satrt_processing.Text = "test";
            this.Satrt_processing.TextLocation_X = 50;
            this.Satrt_processing.TextLocation_Y = 23;
            this.Satrt_processing.Transparent1 = 250;
            this.Satrt_processing.Transparent2 = 250;
            this.Satrt_processing.UseVisualStyleBackColor = false;
            this.Satrt_processing.Click += new System.EventHandler(this.Satrt_processing_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(54, 371);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(406, 186);
            this.panel1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Column,
            this.Name_Column,
            this.Info_Column,
            this.Status_Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(400, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id_Column
            // 
            this.Id_Column.HeaderText = "Id";
            this.Id_Column.Name = "Id_Column";
            this.Id_Column.ReadOnly = true;
            // 
            // Name_Column
            // 
            this.Name_Column.HeaderText = "Name";
            this.Name_Column.Name = "Name_Column";
            this.Name_Column.ReadOnly = true;
            // 
            // Info_Column
            // 
            this.Info_Column.HeaderText = "Info";
            this.Info_Column.Image = ((System.Drawing.Image)(resources.GetObject("Info_Column.Image")));
            this.Info_Column.Name = "Info_Column";
            this.Info_Column.ReadOnly = true;
            // 
            // Status_Column
            // 
            this.Status_Column.HeaderText = "Status";
            this.Status_Column.Name = "Status_Column";
            this.Status_Column.ReadOnly = true;
            // 
            // Target_folder_path_button
            // 
            this.Target_folder_path_button.BackColor = System.Drawing.Color.Transparent;
            this.Target_folder_path_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Target_folder_path_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Target_folder_path_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Target_folder_path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Target_folder_path_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target_folder_path_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Target_folder_path_button.Location = new System.Drawing.Point(205, 291);
            this.Target_folder_path_button.Name = "Target_folder_path_button";
            this.Target_folder_path_button.Size = new System.Drawing.Size(467, 29);
            this.Target_folder_path_button.TabIndex = 5;
            this.Target_folder_path_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Target_folder_path_button.UseVisualStyleBackColor = false;
            // 
            // Target_folder_button
            // 
            this.Target_folder_button.BackColor = System.Drawing.Color.Transparent;
            this.Target_folder_button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.Target_folder_button.BorderWidth = 2;
            this.Target_folder_button.ButtonShape = GradientButton.GradientButton.ButtonsShapes.Rect;
            this.Target_folder_button.ButtonText = "Target Folder";
            this.Target_folder_button.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Target_folder_button.FlatAppearance.BorderSize = 0;
            this.Target_folder_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Target_folder_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Target_folder_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Target_folder_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target_folder_button.GradientAngle = 0;
            this.Target_folder_button.Location = new System.Drawing.Point(54, 287);
            this.Target_folder_button.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Target_folder_button.MouseClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Target_folder_button.MouseHoverColor1 = System.Drawing.Color.Turquoise;
            this.Target_folder_button.MouseHoverColor2 = System.Drawing.Color.DarkSlateGray;
            this.Target_folder_button.Name = "Target_folder_button";
            this.Target_folder_button.ShowButtontext = true;
            this.Target_folder_button.Size = new System.Drawing.Size(135, 37);
            this.Target_folder_button.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(65)))), ((int)(((byte)(169)))));
            this.Target_folder_button.TabIndex = 4;
            this.Target_folder_button.Text = "test";
            this.Target_folder_button.TextLocation_X = 30;
            this.Target_folder_button.TextLocation_Y = 13;
            this.Target_folder_button.Transparent1 = 250;
            this.Target_folder_button.Transparent2 = 250;
            this.Target_folder_button.UseVisualStyleBackColor = false;
            this.Target_folder_button.Click += new System.EventHandler(this.Target_folder_button_Click);
            // 
            // Images_folder_path_button
            // 
            this.Images_folder_path_button.BackColor = System.Drawing.Color.Transparent;
            this.Images_folder_path_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(186)))), ((int)(((byte)(131)))));
            this.Images_folder_path_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Images_folder_path_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Images_folder_path_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Images_folder_path_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Images_folder_path_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Images_folder_path_button.Location = new System.Drawing.Point(205, 230);
            this.Images_folder_path_button.Name = "Images_folder_path_button";
            this.Images_folder_path_button.Size = new System.Drawing.Size(467, 29);
            this.Images_folder_path_button.TabIndex = 3;
            this.Images_folder_path_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Images_folder_path_button.UseVisualStyleBackColor = false;
            // 
            // shape_pictureBox
            // 
            this.shape_pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.shape_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shape_pictureBox.Location = new System.Drawing.Point(483, 34);
            this.shape_pictureBox.Name = "shape_pictureBox";
            this.shape_pictureBox.Size = new System.Drawing.Size(189, 127);
            this.shape_pictureBox.TabIndex = 1;
            this.shape_pictureBox.TabStop = false;
            // 
            // DocumentSorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(708, 673);
            this.Controls.Add(this.grardientPanel1);
            this.Name = "DocumentSorter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Sorter";
            this.grardientPanel1.ResumeLayout(false);
            this.grardientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shape_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GrardientPanel.GrardientPanel grardientPanel1;
        public System.Windows.Forms.PictureBox shape_pictureBox;
        private System.Windows.Forms.Button Target_folder_path_button;
        private GradientButton.GradientButton Target_folder_button;
        private System.Windows.Forms.Button Images_folder_path_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Column;
        private System.Windows.Forms.DataGridViewImageColumn Info_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Column;
        private GradientButton.GradientButton Satrt_processing;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label label1;
        private GradientButton.GradientButton open_snipping_logo;
        public System.Windows.Forms.Button shape_name;
        private GradientButton.GradientButton Images_folder_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

