using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5WindowsForms
{
    public partial class Form1 : Form
    {
        public HttpClient Client { get; set; }
        public MatchCollection Matches { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Dictionary<Task<byte[]>, string> images = new Dictionary<Task<byte[]>, string>();
                    string[] links = textBoxoutput.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < links.Length; i++)
                    {
                        string match = links[i];

                        images.Add(Client.GetByteArrayAsync(match), match);
                    }

                    int count = 1;

                    while (images.Count > 0)
                    {
                        Task<byte[]> completedTask = await Task.WhenAny(images.Keys);
                        string checkType = "";
                        string fileType = "";
                        

                        foreach (KeyValuePair<Task<byte[]>, string> kvp in images)
                        {
                            if (kvp.Key == completedTask)
                            {
                                checkType = kvp.Value;
                                break;
                            }  
                        }
                        
                        if (checkType.Contains("png"))
                        {
                            fileType = "png";
                        }
                        else if (checkType.Contains("bmp"))
                        {
                            fileType = "bmp";
                        }
                        else if (checkType.Contains("gif"))
                        {
                            fileType = "gif";
                        }
                        else if (checkType.Contains("jpg"))
                        {
                            fileType = "jpg";
                        }
                        else if (checkType.Contains("jpeg"))
                        {
                            fileType = "jpeg";
                        }

                        string fileName = $@"{dialog.SelectedPath}\Image{count}.{fileType}";
                        var fs = new FileStream(fileName, FileMode.Create);

                        using (BinaryWriter binWriter = new BinaryWriter(fs))
                        {
                            foreach (byte data in completedTask.Result)
                            {
                                binWriter.Write(data);
                            }
                        }

                        images.Remove(completedTask);

                        count++;
                    }

                    MessageBox.Show("Download is complete");

                    textBoxoutput.Clear();
                    textBoxInput.Text = "Input link i.e 'google.com'";
                    labelLinkCount.Text = "Number of images found in input link: N/A";
                    buttonSave.Enabled = false;
                    buttonExtract.Enabled = true;
                    textBoxInput.Enabled = true;
                }
            }
        }

        private async void buttonExtract_Click(object sender, EventArgs e)
        {
            int pngImages = 0;
            Client = new HttpClient();
            string inputCorrectForm = $"http://{textBoxInput.Text.ToLower()}";
            textBoxInput.Text = inputCorrectForm;

            Task<string> download = Client.GetStringAsync(inputCorrectForm);
            Regex reSrc = new Regex("(?<=<img.+?data-src=)[\"'](.+?)[\"']", RegexOptions.IgnoreCase);

            await download;

            Matches = reSrc.Matches(download.Result);

            for ( int i = 0; i < Matches.Count; i++)
            {
                string match = Matches[i].Value.Trim('"');

                if (!string.IsNullOrEmpty(match))
                {
                    textBoxoutput.AppendText($"{inputCorrectForm}{match} {Environment.NewLine}");

                    pngImages++;
                }
            }

            labelLinkCount.Text = $"Number of images found in input link: {pngImages}";
            buttonSave.Enabled = true;
            buttonExtract.Enabled = false;
            textBoxInput.Enabled = false;
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonExtract.PerformClick();
        }
    }
}
