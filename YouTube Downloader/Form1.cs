using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using MediaToolkit;
using System.IO;

namespace YouTube_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private async void Btn_baixar_Click(object sender, EventArgs e)
        {

            if (CB_Formato.Text == "" || txt_URL.Text == "")
            {
                MessageBox.Show("Favor, verificar se você inseriu o link ou se selecionou o formato do arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (FDB.ShowDialog() == DialogResult.OK)
                {
                    var yt = YouTube.Default;
                    var video = await yt.GetVideoAsync(txt_URL.Text);

                    File.WriteAllBytes(FDB.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());


                    var inputfile = new MediaToolkit.Model.MediaFile { Filename = FDB.SelectedPath + @"\" + video.FullName };
                    var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{ FDB.SelectedPath + @"\" + video.FullName }.mp3" };


                    using (var engine = new Engine())
                    {
                        engine.GetMetadata(inputfile);
                        engine.Convert(inputfile, outputfile);
                    }
                    if (CB_Formato.Text == "MP3 (Áudio)")
                    {
                        File.Delete(FDB.SelectedPath + @"\" + video.FullName);
                    }
                    else if(CB_Formato.Text == "MP4 (Video)")
                    {
                        File.Delete($"{FDB.SelectedPath + @"\" + video.FullName}.mp3");
                    }
                    else
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a pasta onde o video/áudio deve ser salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                progressBar1.Value = 100;
                MessageBox.Show("Download Concluido!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
