using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTClient
{
    public partial class Form1 : Form
    {
        public static bool PwChecked = false;

        public Form1()
        {
            InitializeComponent();
            Gridbeolvas();
        }
        public void Gridbeolvas()
        {
            RestClient client = new RestClient("http://127.0.0.1:3000/allatkert");
            var request = new RestRequest(Method.GET);

            var response = client.Execute<List<Allatkert>>(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription,"StatusCode");
                return;
            }

            List<Allatkert> allatkert = new JsonSerializer().Deserialize<List<Allatkert>>(response);
            Allatkert_Grid.DataSource = allatkert;
        }
        private void Allatkert_Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            allatkert_id.Text = Allatkert_Grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            allatkert_megnv.Text = Allatkert_Grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            allatkert_nem.Text = Allatkert_Grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            allatkert_eletkor.Text = Allatkert_Grid.Rows[e.RowIndex].Cells[3].Value.ToString();
            allatkert_szektor.Text = Allatkert_Grid.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Allatkert_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void hozzaad_bt_Click(object sender, EventArgs e)
        {
            if (PwChecked == false)
            {
                PwForm pwform = new PwForm();
                pwform.Show();
                return;
            }

            if ((allatkert_megnv.Text == "" || allatkert_megnv.Text == null) || (allatkert_nem.Text == "" || allatkert_nem.Text == null) || (allatkert_eletkor.Value < 0) || (allatkert_szektor.Value < 0))
            {
                MessageBox.Show("Ne hadj egy üres mezőt sem!");
                return;
            }

            RestClient client = new RestClient("http://127.0.0.1:3000/addallatkert/abc123");
            var request = new RestRequest(Method.POST);
            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                megnevezes = allatkert_megnv.Text,
                nem = allatkert_nem.Text,
                eletkor = allatkert_eletkor.Value,
                szektor = allatkert_szektor.Value
            });

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            allatkert_megnv.Text = "";
            allatkert_nem.Text = "";
            allatkert_eletkor.Value= 0;
            allatkert_szektor.Value = 0;
            Gridbeolvas();
        
        }

        private void modosit_bt_Click(object sender, EventArgs e)
        {
            if (PwChecked == false)
            {
                PwForm pwform = new PwForm();
                pwform.Show();
                return;
            }

            if ((allatkert_id.Value<0)||(allatkert_megnv.Text == "" || allatkert_megnv.Text == null) || (allatkert_nem.Text == "" || allatkert_nem.Text == null) || (allatkert_eletkor.Value < 0) || (allatkert_szektor.Value < 0))
            {
                MessageBox.Show("Ne hadj egy üres mezőt sem!");
                return;
            }

            RestClient client = new RestClient(String.Format("http://127.0.0.1:3000/updateallatkert/{0}/abc123", allatkert_id.Value));
            var request = new RestRequest(Method.PUT);

            request.RequestFormat = DataFormat.Json;

            request.AddJsonBody(new
            {
                megnevezes = allatkert_megnv.Text,
                nem = allatkert_nem.Text,
                eletkor = allatkert_eletkor.Value,
                szektor = allatkert_szektor.Value
            });

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            allatkert_megnv.Text = "";
            allatkert_nem.Text = "";
            allatkert_eletkor.Value = 0;
            allatkert_szektor.Value = 0;
            Gridbeolvas();
        }

        private void torol_bt_Click(object sender, EventArgs e)
        {
            if (PwChecked == false)
            {
                PwForm pwform = new PwForm();
                pwform.Show();
                return;
            }

            if (allatkert_id.Value<0)
            {
                MessageBox.Show("Az ID mező nem lehet 0-nál kisebb!!");
                return;
            }

            RestClient client = new RestClient(String.Format("http://127.0.0.1:3000/deleteallatkert/{0}/abc123", allatkert_id.Value));
            var request = new RestRequest(Method.DELETE);

            var response = client.Execute(request);

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.StatusDescription);
                return;
            }

            allatkert_megnv.Text = "";
            allatkert_nem.Text = "";
            allatkert_eletkor.Value = 0;
            allatkert_szektor.Value = 0;
            Gridbeolvas();
        }

       
        private void Exit_button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void allatkert_megnv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
