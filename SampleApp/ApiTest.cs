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

        private void ApiTest_Load(object sender, EventArgs e)
        {
            List<State> states = new List<State>();

            State s1 = new State();
            s1.state_id = 1;
            s1.state_name = "Kerala";

            State s2 = new State();
            s2.state_id = 2;
            s2.state_name = "Jammu";

            State s3 = new State();
            s3.state_id =3;
            s3.state_name = "Thamil Naduu";

            states.Add(s1);
            states.Add(s2);
            states.Add(s3);


            foreach (State item in states)
            {
                comboBox1.Items.Add(item.state_id + "." + item.state_name);
            }

            //for (int i = 0; i < states.Count; i++)
            //{
            //    comboBox1.Items.Add(states[i].state_id + "."+states[i].state_name);
            //}


        }
    }
}
