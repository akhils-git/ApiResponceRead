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
    public partial class Calk : Form
    {
        public Calk()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
          
          
        }

        private void Calk_Load(object sender, EventArgs e)
        {
            int a = 2;

            this.BackColor = a > 10 ? Color.Red : Color.Green;

            //int mobile = +919946096654;
        }
    }
}
