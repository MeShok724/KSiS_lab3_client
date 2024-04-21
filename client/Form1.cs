using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksis_lab3
{
    public partial class Form1 : Form
    {
        private Client _client = new Client();
        public Form1()
        {
            InitializeComponent();
            _client.ServerResponse += PrintResult;
            _client.ServerResponseFile += PrintFile;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = tbFilePath.Text;
            string pathToSave = tbPathToSave.Text;
            _client.PostFile(filePath, pathToSave);
        }

        private void PrintResult(string Text)
        {
            MessageBox.Show(Text);
        }
        private void PrintFile(string text)
        {
            rtbGetFile.Text = text;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                tbFilePath.Text = openFileDialog.FileName;
            }
        }
        private void btnGetFile_Click_1(object sender, EventArgs e)
        {
            string fileName = tbGetFilePath.Text;
            _client.GetFile(fileName);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                tbPutNewFile.Text = openFileDialog.FileName;
            }
        }

        private void btnPut_Click(object sender, EventArgs e)
        {
            string newFile = tbPutNewFile.Text;
            string filePath = tbPutFilePath.Text;
            _client.PutFile(filePath, newFile);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = tbDeleteFileName.Text;
            _client.DeleteFile(fileName);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string s1 = tbCopyFilePath.Text;
            string s2 = tbCopyDestPath.Text;
            _client.CopyFile(s1, s2);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            _client.MoveFile(tbMoveFilePath.Text, tbMoveDestPath.Text);
        }
    }
}