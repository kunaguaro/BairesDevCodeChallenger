using System;
using System.Data;

using System.IO;
using System.Linq;
using System.Windows.Forms;

using WinBairesCC.Estructura.DataAccess;
using WinBairesCC.Estructura.Repositories;
using WinBairesCC.Estructura.StringMetrics;
using WinBairesCC.Estructura.Models;
using System.Collections.Generic;

namespace WinBairesCC
{
    public partial class Form1 : Form
    {
        string directoryPath;
        public Form1()
        {
            InitializeComponent();
        }

     
        private void ButtonGetDataFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "people.in";
            openFileDialog1.Filter = "Text Files (*.in)|*.in|All Files (*.in)|*.in";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelPathOriginalFile.Text = openFileDialog1.FileName;
                directoryPath = Path.GetDirectoryName(openFileDialog1.FileName);
                buttonSaveParsedDataFile.Enabled = true;
                labelPathParsedFile.Text = "...";

            }
           
           
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonSaveParsedDataFile.Enabled = false;
        }

        private void ButtonSaveParsedDataFile_Click(object sender, EventArgs e)
        {
            IProfileRank pr = new ProfileRank(new MilestoneWordsRepository(), new IndustryWordsRepository(),  new Tokenizer());
            ILinkedinUserProfileDataAccess parser = new LinkedinUserProfileParser(labelPathOriginalFile.Text, pr);
            var profiles = parser.getAll().OrderByDescending(x => x.Ranking).ToList();
            LinkedinParsedStringList linkedinparsedstringlist = new LinkedinParsedStringList();
            List<string> listText = new List<string>();
            listText = linkedinparsedstringlist.ListToString(profiles);
            TextWriter tw = new StreamWriter(directoryPath+"\\people.out");
            foreach (string s in listText)
                tw.WriteLine(s);
            tw.Close();
            labelPathParsedFile.Text = directoryPath + "\\people.out";
            MessageBox.Show("Archivo generado");
        }
    }
}
