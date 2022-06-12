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
using System.Drawing.Drawing2D;

namespace YouTube_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String LocalArquivo;
        private bool verificaDownload = false;

        public bool BloqueiaClick(bool verificaDownload)
        {
            if(verificaDownload == true)
            {
                MessageBox.Show("Aguarde o download acabar!!");
                return true;
            }
            else
            {
                return false;
            }
        }
        public String SalvaLocalDownload()
        {
            if (LerArquivoText() == false)
            {
                if (FDB.ShowDialog() == DialogResult.OK)
                {
                    LocalArquivo = FDB.SelectedPath;

                    StreamWriter sw = new StreamWriter("LocalDownload.txt");
                    sw.WriteLine(FDB.SelectedPath);

                    sw.Close();
                }
                else
                {
                    Btn_baixar.Text = "Download";
                    MessageBox.Show("Selecione a pasta onde o video/áudio deve ser salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UseWaitCursor = false;
                }
            }
            return LocalArquivo;
        }
        public void GravarLocalArquivo()
        {
            if (BloqueiaClick(verificaDownload) == false)
            {
                if (FDB.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter("LocalDownload.txt");
                    sw.WriteLine(FDB.SelectedPath);
                    sw.Close();
                }
                else
                {
                    Btn_baixar.Text = "Download";
                    MessageBox.Show("Selecione a pasta onde o video/áudio deve ser salvo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public bool LerArquivoText()
        {
            if (File.Exists("LocalDownload.txt"))
            {
                foreach (string line in System.IO.File.ReadLines(@"LocalDownload.txt"))
                {
                    LocalArquivo = line;
                    Console.ReadLine();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public void VerificaCampos(String LocalArquivo)
        {
            if (CB_Formato.Text == "" || txt_URL.Text == "")
            {
                MessageBox.Show("Favor, verificar se você inseriu o link ou se selecionou o formato do arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UseWaitCursor = false;
            }
            else
            {
                SalvaLocalDownload();
            }
        }
        public async Task RealizaDownload(String LocalArquivo)
        {
            if (BloqueiaClick(verificaDownload) == false)
            {
                progressBar1.Value = 0;
                UseWaitCursor = true;
                verificaDownload = true;

                var yt = YouTube.Default;
                var video = await yt.GetVideoAsync(txt_URL.Text);
                var nomeDArq = txt_nomeArq.Text;

                Btn_baixar.Text = "Baixando...";

                File.WriteAllBytes(LocalArquivo + @"\" + nomeDArq + ".mp4", await video.GetBytesAsync());

                var outputfile = new MediaToolkit.Model.MediaFile { Filename = $"{ LocalArquivo + @"\" + nomeDArq + "" }.mp3" };
                var inputfile = new MediaToolkit.Model.MediaFile { Filename = LocalArquivo + @"\" + nomeDArq + ".mp4" };


                var engine = new Engine();
                engine.GetMetadata(inputfile);
                engine.Convert(inputfile, outputfile);

                if (CB_Formato.Text == "MP3 (Áudio)")
                {
                    File.Delete(LocalArquivo + @"\" + nomeDArq + ".mp4");
                }
                else if (CB_Formato.Text == "MP4 (Video)")
                {
                    File.Delete($"{LocalArquivo + @"\" + nomeDArq + ""}.mp3");
                }
                ConcluidoEvent();
            }
        }
        public void ConcluidoEvent()
        {
            progressBar1.Value = 100;
            Btn_baixar.Text = "Download";
            MessageBox.Show("Download Concluido!", "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UseWaitCursor = false;
            verificaDownload = false;
            progressBar1.Value = 0;
        }
        private void Btn_baixar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampos(LocalArquivo);
                RealizaDownload(LocalArquivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" +
                    "n\n" +
                    ex.Message);
            }
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            try
            {
                GravarLocalArquivo();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" +
                    "n\n" +
                    ex.Message);
            }
        }
    }
}
