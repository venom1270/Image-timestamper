using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;

namespace IMG_Timestamper
{
    public partial class Form1 : Form
    {

        string path = "";

        public Form1()
        {
            InitializeComponent();
            colorDialog1.Color = Color.Red;
        }

        private string getTimestamp(string filename, Image image)
        {
            string timestamp = "";

            bool foundMetadata = false;


            // Try to find datetime using metadata
            foreach (PropertyItem propertyItem in image.PropertyItems)
            {
                if (propertyItem.Id == 0x0132)
                {
                    timestamp = Encoding.UTF8.GetString(propertyItem.Value);

                    // Timestamp is in format "YYYY:MM:DD hh:mm:ss"
                    // Reformat
                    string year = timestamp.Substring(0, 4);
                    string month = timestamp.Substring(5, 2);
                    string day = timestamp.Substring(8, 2);
                    string time = timestamp.Substring(11);
                    timestamp = day + "." + month + "." + year + " " + time;

                    foundMetadata = true;
                    Debug.WriteLine("METADATA");
                    break;
                }
            }

            // If metadata not found, use filename string
            if (!foundMetadata)
            {
                string year = filename.Substring(4, 4);
                string month = filename.Substring(8, 2);
                string day = filename.Substring(10, 2);
                string hours = filename.Substring(13, 2);
                string minutes = filename.Substring(15, 2);
                string seconds = filename.Substring(17, 2);
                timestamp = day + "." + month + "." + year + " " + hours + ":" + minutes + ":" + seconds;
                Debug.WriteLine("FILENAME");
            }
            

            return timestamp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bTimestampImages.Enabled = false;

            string[] files = Directory.GetFiles(path);
            Directory.CreateDirectory(path + "\\timestamped");

            int progress = 0;

            int fontScaled = 12000000;  //50em for 12M pixels (approx. 4000x3000)
            int xScale = 4000; // for 4000px width = 700
            int yScale = 3000; // for 3000px width = 100

            foreach (string imagePath in files)
            {

                string filename = imagePath.Substring(imagePath.LastIndexOf("\\") + 1);
                string savePath = path + "\\" + "timestamped\\" + filename; 

                Image image = Image.FromFile(imagePath);
                Bitmap b = new Bitmap(image);

                // Copy metadata
                foreach (PropertyItem propertyItem in image.PropertyItems)
                {
                    b.SetPropertyItem(propertyItem);
                }

                // Get timestamp string text
                string timestamp = getTimestamp(filename, image);

                Graphics graphics = Graphics.FromImage(b);

                // Set font
                int fontSize;
                if (cbScaled.Checked)
                {
                    fontSize = Math.Max(15, (int)(((image.Width * image.Height) / (float)fontScaled) * (int)tbFontSize.Value));
                }
                else
                {
                    fontSize = (int)tbFontSize.Value;
                }

                // Set offset
                int xPos, yPos;
                if (cbScaled.Checked)
                {
                    xPos = b.Width - Math.Max(220, ((int)tbOffsetX.Value * (int)((float)image.Width / xScale)));
                    yPos = b.Height - Math.Max(30, ((int)tbOffsetY.Value * (int)((float)image.Height / yScale)));
                }
                else
                {
                    xPos = b.Width - ((int)tbOffsetX.Value);
                    yPos = b.Height - ((int)tbOffsetY.Value);
                }

                // Draw
                Brush brush = new SolidBrush(colorDialog1.Color);
                graphics.DrawString(timestamp, new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold), brush, xPos, yPos);
                b.Save(savePath, image.RawFormat);
        
                image.Dispose();
                b.Dispose();

                progress++;
                progressBar1.Value = (int)(((float)progress / files.Length) * 100);

            }

            progressBar1.Value = 100;

            MessageBox.Show("Done!", "Success");
            Process.Start(path + "\\timestamped");

            bTimestampImages.Enabled = true;

        }

        private void bSelectFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Path.GetDirectoryName(Application.ExecutablePath);
            Debug.WriteLine(Application.ExecutablePath);
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                path = folderBrowserDialog1.SelectedPath;
                bTimestampImages.Enabled = true;
                MessageBox.Show("Files found: " + Directory.GetFiles(path).Length.ToString(), "Found files");
            }
            else
            {
                bTimestampImages.Enabled = false;
            }
        }

        private void bChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void cbScaled_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
