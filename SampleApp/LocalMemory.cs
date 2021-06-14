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
    public partial class LocalMemory : Form
    {
        public LocalMemory()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //int[] points = new int[10];
            //points[0] =45;
            //points[1] =56;
            //points[2] = 1;
            //points[3] = 56;

            //this.Text = names[Convert.ToInt32( txtIndex.Text)];

            List<int> points = new List<int>();
            points.Add(56);
            points.Add(67);
        }
    }
}
