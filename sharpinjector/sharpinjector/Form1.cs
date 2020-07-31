using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using RestSharp;

namespace sharpinjector
{
    public partial class Main : Form
    {
        Random rnd = new Random();
        public Main()
        {
            InitializeComponent();
        }

        private string emblem()
        {
            string[] emblems = { "\"Bronze\"", "\"Silver\"", "\"Gold\"", "\"Iridescent\"" };

            return (emblems[rnd.Next(0, emblems.Length)]);
        }

        private int gameTime()
        {
            return (rnd.Next(1, 1000) + 700);
        }

        private string request(int levelversion)
        {
            string json = "{" +
                "\"data\":" +
                    "{\"consecutiveMatch\":1," +
                    "\"emblemQualities\":[" +
                            emblem() + "," +
                            emblem() + "," +
                            emblem() + "," +
                            emblem() +
                        "],\"isFirstMatch\":false," +
                        "\"levelVersion\":" + levelversion +
                        ",\"matchTime\":" + gameTime() +
                        ",\"platformVersion\":\"steam\",\"playerType\":\"survivor\"}}";

            var client = new RestClient();
            var bhvr_request = new RestRequest()
            { 
                Resource = "https://steam.live.bhvrdbd.com/api/v1/extensions/playerLevels/earnPlayerXp"
            };
            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", Bhvr_cookie.Text);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);
            Console.WriteLine("\nRequest:\n" + json);
            Console.WriteLine("\nResponse:\n" + response.Content);
            return (response.Content);
        }

        private int levelVersion()
        {
            int number = 0;
            string tmp = null;
            var response = request(number);
            string[] cleanned = response.Split('"');
            if (response.Contains("levelInfo"))
            {
                for (int i = 0; i < cleanned.Length; i++)
                {
                    if (cleanned[i].StartsWith("levelVersion"))
                    {
                        tmp = cleanned[i + 1];
                        number = Int32.Parse(tmp.Split(':')[1].Split(',')[0]);
                        return (number);
                    }
                }
            } else
            {
                MessageBox.Show("Incorrect BHVR cookie");
                return (-1);
            }
            return (number);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int levelversion = 0;
            int played = 0;
            string response = null;
            inject.ForeColor = Color.Gray;
            inject.BackColor = Color.Gray;
            inject.Enabled = false;

            if (Bhvr_cookie.Text.Length == 0)
            {
                MessageBox.Show("Enter your BHVR cookie");
            } else
            {
                levelversion = levelVersion();

                if (levelversion >= 0)
                {
                    played = Int32.Parse(Game_played.Text);
                    for (int i = 0; i < played; i++)
                    {
                        response = request(levelversion);
                        levelversion++;
                    }
                    MessageBox.Show("Content injected");
                }
            }
            inject.ForeColor = Color.White;
            inject.BackColor = Color.Transparent;
            inject.Enabled = true;
        }
    }
}
