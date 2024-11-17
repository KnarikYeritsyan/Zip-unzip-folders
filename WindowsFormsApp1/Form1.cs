using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
//using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnfolderzip_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select your path";
            if (fbd.ShowDialog() == DialogResult.OK)
                textfolderzip.Text = fbd.SelectedPath;

        }

        private void textfolderzip_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnzipfolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textfolderzip.Text))
            {
                MessageBox.Show("Please select your folder.");
                textfolderzip.Focus();
                return;
            }

            string path = textfolderzip.Text;
            string parent = Path.GetDirectoryName(path);
            string name = Path.GetFileName(path);
            string filename = Path.Combine(parent, name + ".zip");
            ZipFile.CreateFromDirectory(path, filename, CompressionLevel.Optimal, true);

      
        }

        private void btnfolderunzip_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbdun = new OpenFileDialog();
            //fbdun.Description = "Select your path";
            if (fbdun.ShowDialog() == DialogResult.OK)
                textfolderunzip.Text = fbdun.FileName;
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnunzipfolder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textfolderunzip.Text))
            {
                MessageBox.Show("Please select your folder.");
                textfolderunzip.Focus();
                return;
            }
            string pathun = textfolderunzip.Text;
            string parentun = Path.GetDirectoryName(pathun);
            string nameun = Path.GetFileName(pathun);
            string filenameun = Path.ChangeExtension(parentun, null);
            ZipFile.ExtractToDirectory(pathun, filenameun);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
