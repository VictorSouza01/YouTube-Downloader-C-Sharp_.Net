
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FDB = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_nomeArq = new System.Windows.Forms.TextBox();
            this.CB_Formato = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConfig = new System.Windows.Forms.Button();
            this.Btn_baixar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downloader";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(63, 102);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.PlaceholderText = "URL do video";
            this.txt_URL.Size = new System.Drawing.Size(421, 23);
            this.txt_URL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Formato:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(63, 357);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(421, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // txt_nomeArq
            // 
            this.txt_nomeArq.Location = new System.Drawing.Point(63, 164);
            this.txt_nomeArq.Name = "txt_nomeArq";
            this.txt_nomeArq.PlaceholderText = "Nome do arquivo";
            this.txt_nomeArq.Size = new System.Drawing.Size(421, 23);
            this.txt_nomeArq.TabIndex = 9;
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
            this.CB_Formato.Location = new System.Drawing.Point(63, 274);
            this.CB_Formato.Name = "CB_Formato";
            this.CB_Formato.Size = new System.Drawing.Size(121, 23);
            this.CB_Formato.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(133, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "YouTube";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(260, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Downloader";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(133, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "YouTube";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(487, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "1.0.2";
            // 
            // btnConfig
            // 
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfig.BackgroundImage")));
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Location = new System.Drawing.Point(498, 25);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(33, 27);
            this.btnConfig.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnConfig, "Mudar local de download!");
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // Btn_baixar
            // 
            this.Btn_baixar.BackColor = System.Drawing.Color.Red;
            this.Btn_baixar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_baixar.FlatAppearance.BorderSize = 0;
            this.Btn_baixar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_baixar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_baixar.Font = new System.Drawing.Font("Segoe UI Historic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_baixar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_baixar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_baixar.Location = new System.Drawing.Point(375, 256);
            this.Btn_baixar.Name = "Btn_baixar";
            this.Btn_baixar.Size = new System.Drawing.Size(109, 40);
            this.Btn_baixar.TabIndex = 14;
            this.Btn_baixar.Text = "Download";
            this.toolTip1.SetToolTip(this.Btn_baixar, "Download");
            this.Btn_baixar.UseVisualStyleBackColor = false;
            this.Btn_baixar.Click += new System.EventHandler(this.Btn_baixar_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(543, 421);
            this.Controls.Add(this.Btn_baixar);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Formato);
            this.Controls.Add(this.txt_nomeArq);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog FDB;
        private System.Windows.Forms.TextBox txt_nomeArq;
        private System.Windows.Forms.ComboBox CB_Formato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button Btn_baixar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

