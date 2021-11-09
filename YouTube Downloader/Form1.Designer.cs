
namespace YouTube_Downloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_baixar = new System.Windows.Forms.Button();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.CB_Formato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FDB = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "YouTube Downloader";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(356, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_baixar
            // 
            this.Btn_baixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_baixar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_baixar.Location = new System.Drawing.Point(346, 339);
            this.Btn_baixar.Name = "Btn_baixar";
            this.Btn_baixar.Size = new System.Drawing.Size(132, 41);
            this.Btn_baixar.TabIndex = 2;
            this.Btn_baixar.Text = "Download";
            this.Btn_baixar.UseVisualStyleBackColor = true;
            this.Btn_baixar.Click += new System.EventHandler(this.Btn_baixar_Click);
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(67, 217);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.PlaceholderText = "URL do video";
            this.txt_URL.Size = new System.Drawing.Size(421, 23);
            this.txt_URL.TabIndex = 3;
            // 
            // CB_Formato
            // 
            this.CB_Formato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_Formato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Formato.FormattingEnabled = true;
            this.CB_Formato.Items.AddRange(new object[] {
            "",
            "MP4 (Video)",
            "MP3 (Áudio)",
            "Ambos"});
            this.CB_Formato.Location = new System.Drawing.Point(67, 349);
            this.CB_Formato.Name = "CB_Formato";
            this.CB_Formato.Size = new System.Drawing.Size(121, 23);
            this.CB_Formato.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formato:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(67, 462);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(411, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(545, 497);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Formato);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.Btn_baixar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_baixar;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.ComboBox CB_Formato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog FDB;
    }
}

