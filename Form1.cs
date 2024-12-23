using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project15_GasPriceSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double dieselPrice = 0;
        double gasolinePrice = 0;
        double lpgPrice = 0;
        double gasAmount=0;
        double dieselAmount=0;
        double lpgAmount=0;
        double progressBarValue = 0;
        double totalPrice = 0;
        int count = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            gasAmount= Convert.ToDouble(txtGasAmount.Text);
            dieselAmount= Convert.ToDouble(txtGasAmount.Text);
            lpgAmount= Convert.ToDouble(txtGasAmount.Text);
            timer1.Start();
            timer1.Interval = 100;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
           this.Text=count.ToString();
            if(rdbGasoline.Checked) 
            {
                count++;
                if(count<=gasAmount)
                {
                    totalPrice += gasolinePrice;
                    txtTotalPrice.Text = totalPrice.ToString() +" ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() +" ₺";
                }
                
                progressBar1.Value += 1;
                if(progressBar1.Value==99)
                {
                    timer1.Stop();
                }
            }
            if (rdbDiesel.Checked)
            {
                count++;
                if (count <= dieselAmount)
                {
                    totalPrice += dieselPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
            if (rdbLpg.Checked)
            {
                count++;
                if (count <= lpgAmount)
                {
                    totalPrice += lpgPrice;
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }
                else
                {
                    txtTotalPrice.Text = totalPrice.ToString() + " ₺";
                }

                progressBar1.Value += 1;
                if (progressBar1.Value == 99)
                {
                    timer1.Stop();
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
             MessageBox.Show("API Yakıt Verileri Alınıyor..");

           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://akaryakit-fiyatlari.p.rapidapi.com/fuel/istanbul"),
                Headers =
             {
                     { "x-rapidapi-key", "18886d9fb0msh2e6d2ac268d0c25p151927jsn9c90c20268ed" },
                     { "x-rapidapi-host", "akaryakit-fiyatlari.p.rapidapi.com" },
             },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);

                
                var gasoline = json["data"][17]["prices"][0]["benzin"].ToString().Replace("₺", "").Replace(",", ".");
                gasolinePrice = double.Parse(gasoline, CultureInfo.InvariantCulture);

                var diesel = json["data"][17]["prices"][0]["motorin"].ToString().Replace("₺", "").Replace(",", ".");
                dieselPrice = double.Parse(diesel, CultureInfo.InvariantCulture);

                var lpg = json["data"][17]["prices"][0]["lpg"].ToString().Replace("₺", "").Replace(",", ".");
                lpgPrice = double.Parse(lpg, CultureInfo.InvariantCulture);

               
                txtGasolinePrice.Text = gasolinePrice.ToString("F2") + " ₺";
                txtDieselPrice.Text = dieselPrice.ToString("F2") + " ₺";
                txtLpgPrice.Text = lpgPrice.ToString("F2") + " ₺";
            }

        }
    }
}
