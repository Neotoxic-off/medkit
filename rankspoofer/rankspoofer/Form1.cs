using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace rankspoofer
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
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

        private string game(int levelversion, string type)
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
                        ",\"platformVersion\":\"steam\",\"playerType\":\"" + type + "\"}}";

            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/extensions/playerLevels/earnPlayerXp"
            };
            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", cookie.Text);
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
            var response = game(number, "survivor");
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
            }
            else
            {
                MessageBox.Show("Incorrect BHVR cookie");
                return (-1);
            }
            return (number);
        }

        private string rank(decimal survivor, decimal killer)
        {
            string json = "{" +
                "\"forceReset\": true,"+
                "\"killerPips\":" + killer + "," +
                "\"survivorPips\":" + survivor + "}";

            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/ranks/pips"
            };
            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", cookie.Text);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);
            Console.WriteLine("\nRequest:\n" + json);
            return (response.Content);
        }

        private void inject_Click(object sender, EventArgs e)
        {
            string response_game = null;
            string response_rank = null;
            int levelversion = levelVersion();
            inject.Enabled = false;
            inject.ForeColor = Color.Gray;
            inject.BackColor = Color.Gray;
            inject.Refresh();

            if (levelversion > 0 && (level_survivor.Value > 0 || level_killer.Value > 0))
            {
                // Survivor
                for (int i = 1; i <= level_survivor.Value; i++)
                {
                    response_game = game(levelversion, "survivor");
                    response_rank = rank(i, 0);
                    Console.WriteLine("SRG: " + response_game);
                    Console.WriteLine("SRR: " + response_rank);
                    Console.WriteLine("SLV: " + levelversion);
                    levelversion++;
                    if (i < 10)
                    {
                        survivor_rank.Text = "0" + i.ToString();
                        survivor_rank.Refresh();
                    }
                }
                // Killer
                for (int i = 1; i <= level_killer.Value; i++)
                {
                    response_game = game(levelversion, "killer");
                    response_rank = rank(0, i);
                    Console.WriteLine("KRG: " + response_game);
                    Console.WriteLine("KRR: " + response_rank);
                    Console.WriteLine("KLV: " + levelversion);
                    levelversion++;
                    if (i < 10)
                    {
                        killer_rank.Text = "0" + i.ToString();
                        killer_rank.Refresh();
                    }
                }
                MessageBox.Show("Pips injected");
            }
            inject.Enabled = true;
            inject.ForeColor = Color.White;
            inject.BackColor = Color.Transparent;
            inject.Refresh();
        }
    }
}
