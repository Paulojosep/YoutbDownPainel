using MediaToolkit.Model;
using MediaToolkit;
using VideoLibrary;

namespace YoutbDown
{
    public partial class Form1 : Form
    {
        public string Mensage { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Download();
        }

        private void Download()
        {
            try
            {
                txtInfo.Text = string.Empty;
                string path = @"YoutubDown";
                string fullPath;
                fullPath = Path.GetFullPath(path);
                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                }
                fullPath = fullPath + "\\";
                string? url = textUrl.Text;
                bool mp3 = checkMP3.Checked;
                var youtube = YouTube.Default;
                txtInfo.Text = "Fazendo Download do video...";
                var video = youtube.GetVideo(url);
                txtInfo.Text = "Download Concluido!";
                txtInfo.Text = "Criando Arquivo MP4...";
                File.WriteAllBytes(fullPath + video.FullName, video.GetBytes());

                if (mp3.Equals(true))
                {
                    txtInfo.Text = "Convertendo arquivo para MP3...";
                    SalvarMp3(fullPath, video.FullName, txtInfo.Text);
                }
                txtInfo.Text = String.Empty;
                MessageBox.Show("Conversão Concluida na pasta: " + fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        void VideoDownloadFinished(object source, EventArgs e)
        {
            MessageBox.Show("Download foi concluido");
        }

        private static void SalvarMp3(string path, string mp3Name, string mensage)
        {
            try
            {
                var inputFile = new MediaFile { Filename = path + mp3Name };
                var outputFile = new MediaFile { Filename = $"{path + mp3Name}.mp3" };

                using (var engine = new Engine())
                {
                    engine.GetMetadata(inputFile);
                    engine.Convert(inputFile, outputFile);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}