using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class DynamicUI : Form
    {
        public DynamicUI()
        {
            InitializeComponent();
        }

        private void DynamicUI_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "OK";
            b.Left = 300;
            b.Top = 90;

            b.Click += B_Click;
            b.MouseEnter += B_MouseEnter;

            this.Controls.Add(b);
        }

        private void B_MouseEnter(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            tempButton.BackColor = Color.Red;
        }

        private void B_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Akhil");
        }
    }
}
