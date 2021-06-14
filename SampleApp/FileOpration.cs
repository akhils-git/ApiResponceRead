using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class FileOpration : Form
    {
        List<string> names = new List<string>();

        public FileOpration()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
         string[] students=   File.ReadAllLines(@"C:\Users\Akhil\Desktop\MyFile\MyData.txt");
            this.Text = students[3];

        
            string data = File.ReadAllText(@"C:\Users\Akhil\Desktop\MyFile\MyData.txt");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            ////for (int i = 0; i < names.Count; i++)
            ////{
            ////    this.Text = i.ToString();
            ////}

            //foreach (string item in names)
            //{
            //    txtFileData.Text = item;
            //}
        }
    }
}
