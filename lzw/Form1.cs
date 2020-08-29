using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lzw;


namespace lzw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_compress_Click(object sender, EventArgs e)
        {
            string textFile = txtbox_filepath.Text;
          
            if (File.Exists(textFile))
            {
                List<int> compressed = lzw_cd.Compress(textFile);

                string path = "D:\\" + newfilename.Text + "_c.txt";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                var result = string.Join("\n", compressed);
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(result);
                }
            }
        }
        
        private void btn_decompress_Click(object sender, EventArgs e)
        {
            string textFile = txtbox_filepath.Text;
        
            if (File.Exists(textFile))
            {
                string decompressed = lzw_cd.Decompress(textFile);

                string path = "D:\\" + newfilename.Text + "_d.txt";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(decompressed);
                }
                //string text = File.ReadAllText(textFile);
                //Console.WriteLine(text);
            }
        }


        private void btn_openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                webBrowser1.Url = new Uri("D:\\");

                string filename = openFileDialog1.FileName;
                txtbox_filepath.Text = filename;
            }
            
            /*
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select the file" })
            {
                if(fbd.ShowDialog()==DialogResult.OK)
                {
                    webBrowser1.Url = new Uri(fbd.SelectedPath);
                    txtbox_filepath.Text = fbd.SelectedPath;
                   
                }
            }
            */
        }
        
        private void btn_left_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
                txtbox_filepath.Text = webBrowser1.Url.ToString();
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
                txtbox_filepath.Text = webBrowser1.Url.ToString();
            }
        }
        
    }
}
