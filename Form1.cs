using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;



// todo list:
//
//make zip functionality

namespace NetFileCreateLinkList
{
    public partial class Form1 : Form
    {
        
        string fileFolderPath = "";
        string[] filesInFolder = new string[1000];
        int itemCounter = 0;
        public Form1()
        {
            InitializeComponent();
            domainTextbox.Text = "/";
        }

        private void fileFolderButton_Click(object sender, EventArgs e)  // get folder path
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
               fileFolderPath = folderBrowserDialog1.SelectedPath;
               fileFolderTextbox.Text = fileFolderPath;
            }
        }

        private void getFilesButton_Click(object sender, EventArgs e) // get files
        {
            string[] filePaths = Directory.GetFiles(fileFolderPath);

            itemCounter = 0;
            foreach (string linje in filePaths)
            {
                string fileName = Path.GetFileName(linje);
                fileName = RemoveSpecialCharacters(fileName);

                richTextBox1.Text += "<br>" + " <a href=\"" + domainTextbox.Text + fileName + "\">" + fileName +  "</a>" + "\n";

                
                filesInFolder[itemCounter] = linje;
                itemCounter++;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void makeIndexButton_Click(object sender, EventArgs e) // make index.htm
        {
            File.WriteAllText(destFolderTextBox.Text + "\\index.html", richTextBox1.Text);
            
        }

        private void zipFilesButton_Click(object sender, EventArgs e) // make .zip to destDir
        {
            MessageBox.Show("Some day in the future this button might actually do something...\nNot today, sorry");
        }

        private void copyContentButton_Click(object sender, EventArgs e) // copy files to destDir
        {
            while (itemCounter > 0)
            {
                itemCounter--; // starts one too high

                string item = filesInFolder[itemCounter];

                File.Copy(item, destFolderTextBox.Text + "\\" + RemoveSpecialCharacters(Path.GetFileName(item)));
                
            }

        }

        private void destFolderButton_Click(object sender, EventArgs e) // choose destFolder
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                destFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
                domainTextbox.Text += Path.GetFileName(folderBrowserDialog1.SelectedPath) + "/";

            }
        }

        public static string RemoveSpecialCharacters(string str)  // remove special characters to comply with web
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if ((str[i] >= '0' && str[i] <= '9') || (str[i] >= 'A' && str[i] <= 'z' || (str[i] == '.' || str[i] == '_')))
                    sb.Append(str[i]);
            }

            return sb.ToString();
        }



    }
}
