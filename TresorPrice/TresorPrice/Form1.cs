using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TresorPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateRate();
        }
        public static string usdeur = "";
        public static string mkdeur = "";
        public static string usdmkd = "";
        public static float feeP = 5;
        public static int ticks = 0;
        public static string CurrencyConvert(string fromCurrency, string toCurrency)
        {
            string apiURL = String.Format("https://wise.com/rates/live?source={1}&target={0}", fromCurrency, toCurrency);

            var request = WebRequest.Create(apiURL);

            var streamReader = new StreamReader(request.GetResponse().GetResponseStream(), System.Text.Encoding.ASCII);

            using (JsonTextReader reader = new JsonTextReader(streamReader))
            {
                JObject array = (JObject)JToken.ReadFrom(reader);
                return array["value"].ToString();


            }
        }



        public void updateRate()
        {
            usdeur = CurrencyConvert("eur", "usd");
            mkdeur = CurrencyConvert("mkd", "eur");
            usdmkd = CurrencyConvert("mkd", "usd");
            this.feeBadge.BadgeText = feeP.ToString();
            this.usdeurl.Text = usdeur;
            this.mkdeurl.Text = mkdeur;
            this.usdmkdl.Text = usdmkd;
            this.lastupdated.Text = DateTime.Now.ToString();
           }

        private void usdAmount_TextChanged(object sender, EventArgs e)
        {
            if (this.usdAmount.Text.Length >= 1) {
                float amnt = float.Parse(this.usdAmount.Text);
                if (amnt <= 499)
                {
                    feeP = 5;
                    updateRate();
                } else if (amnt >= 500 && amnt <= 999)
                {
                    feeP = 4;
                    updateRate();
                } else if (amnt >= 1000 && amnt <= 3499)
                {
                    feeP = 3;
                    updateRate();
                } else if (amnt >= 3500)
                {
                    feeP = float.Parse("2.5");
                    updateRate();
                }
          
            float fee = (feeP / 100) * float.Parse(this.usdAmount.Text);
            float feemkd = (fee * float.Parse(usdmkd));
            float feeeur = (fee * float.Parse(usdeur));
            float usdtAmount = float.Parse(this.usdAmount.Text);
            float eurAmount = float.Parse(usdeur);
            float mkdAmount = float.Parse(mkdeur);
            float usdmkdAmount = float.Parse(usdmkd);

            float mkdgive = (usdtAmount * usdmkdAmount);
            float eurgive = (usdtAmount * float.Parse(usdeur));
            this.metroSetTextBox4.Text = (mkdgive + feemkd).ToString();
            this.usdgive.Text = (usdtAmount + fee).ToString();
            this.eurgivet.Text = (eurgive + feeeur).ToString();
            } else
            {
                this.usdgive.Text = "0";
                this.eurgivet.Text = "0";
                this.metroSetTextBox4.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticks < 10)
            {
                this.pbar.Value = this.pbar.Value + 1;
                ticks++;
            } else if (ticks >= 10)
            {
                updateRate();
                ticks = 0;
                this.pbar.Value = 0;
            }
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            ticks = 0;
            this.pbar.Value = 0;
            updateRate();
        }
    }
}
