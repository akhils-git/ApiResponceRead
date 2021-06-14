using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class ApiTest : Form
    {
        public ApiTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            HttpClient webClient = new HttpClient();
            HttpResponseMessage response = webClient.GetAsync("https://cdn-api.co-vin.in/api/v2/admin/location/states").Result;
      
            txtData.Text = response.Content.ReadAsStringAsync().Result;


            // Api Responce(JSON) >> State List >> DropDwon 
        }
      
    }
}
