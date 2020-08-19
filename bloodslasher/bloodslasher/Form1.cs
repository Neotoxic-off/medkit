using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace bloodslasher
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public class Rootobject
        {
            public List[] list { get; set; }
        }

        public class List
        {
            public int balance { get; set; }
            public string currency { get; set; }
        }

        public class Rootobject_error
        {
            public string type { get; set; }
            public string localizationCode { get; set; }
            public string message { get; set; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private int maximum_wallet(string cookie)
        {
            var response = request("https://steam.live.bhvrdbd.com/api/v1/wallet/currencies", null, cookie, 1);

            Rootobject weps = JsonConvert.DeserializeObject<Rootobject>(response);
            Rootobject_error weps_error = JsonConvert.DeserializeObject<Rootobject_error>(response);

            Console.WriteLine("Error: " + weps_error);
            if (weps != null)
            {
                foreach (List item in weps.list)
                {
                    if (item.currency == "Bloodpoints")
                    {
                        allbloodpoint.Text = "Bloodpoints: " + item.balance.ToString();
                        allbloodpoint.Refresh();
                        if (item.balance == 1000000)
                            return (1);
                    }
                }
            }
            else
            {
                boxer("Your cookie is incorrect", "Incorrect cookie", MessageBoxIcon.Error);
                return (-1);
            }
            return (0);
        }

        private string request(string url, string json, string cookie, int method)
        {
            IRestResponse response;
            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = url
            };
            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", cookie);
            if (json != null)
                bhvr_request.AddJsonBody(json);
            if (method == 0)
                response = client.Post(bhvr_request);
            else
                response = client.Get(bhvr_request);
            Console.WriteLine("\nResponse:\n" + response.Content);
            return (response.Content);
        }

        private void boxer(string message, string title, System.Windows.Forms.MessageBoxIcon type)
        {
            const MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, title, buttons, type);
        }

        private int counter(string response)
        {
            if (response.Contains("Reached the maximum number of grants"))
            {
                boxer("You can't inject anymore, you need to wait. You reached the maximum number of grants per hour", "Maximum requests reached", MessageBoxIcon.Information);
                return (-1);
            }
            return (0);
        }

        private int increase()
        {
            int[] array = { 10000, 12000, 15000 };
            return (array[rnd.Next(0, array.Length)]);
        }

        private void update(Button button)
        {
            if (button.Enabled == true)
            {
                button.BackColor = Color.Gray;
                button.ForeColor = Color.Gray;
                button.Enabled = false;
            }
            else
            {
                button.ForeColor = Color.White;
                button.BackColor = Color.Transparent;
                button.Enabled = true;
            }
        }

        private int brain()
        {
            int stat = 0;
            string cookie = null;

            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                update(inject);
                cookie = Clipboard.GetText(TextDataFormat.Text);
                stat = maximum_wallet(cookie);

                for (int i = 0; stat == 0; i++)
                {
                    if (i < 4 && secret.Checked == true)
                    {
                        if (counter(request("https://steam.live.bhvrdbd.com/api/v1/extensions/rewards/grantCurrency/", "{\"data\":{\"rewardType\": \"shrineReward\",\"walletToGrant\": {\"balance\":150000,\"currency\": \"Bloodpoints\"}}}", cookie, 0)) == -1)
                        {
                            return (-1);
                        }
                    }
                    else
                    {
                        if (counter(request("https://steam.live.bhvrdbd.com/api/v1/extensions/rewards/grantCurrency/", "{\"data\":{\"rewardType\": \"Story\",\"walletToGrant\": {\"balance\":" + increase() + ",\"currency\": \"Bloodpoints\"}}}", cookie, 0)) == -1)
                        {
                            return (-1);
                        }
                    }
                    stat = maximum_wallet(cookie);
                }
                if (stat == 1)
                {
                    boxer("You reached the maximum of bloodpoints in your account", "Maximum reached", MessageBoxIcon.Information);
                }
                update(inject);
            }
            else
            {
                boxer("Copy your bhvr cookie", "No cookie found", MessageBoxIcon.Error);
                return (-1);
            }
            return (0);
        }

        private void inject_Click(object sender, EventArgs e)
        {
            brain();
        }

        private void secret_CheckedChanged(object sender, EventArgs e)
        {
            if (secret.Checked == true)
            {
                boxer("Use it only if you don't have already purchased any perk on\nthe Shrine of secrets and use it only 1 time and wait Shrine reset", "Shrine of secrets", MessageBoxIcon.Information);
            }
        }
    }
}
