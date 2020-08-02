using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace sharpinjector
{
    public partial class Main : Form
    {
        Random rnd = new Random();

        public class Rootobject_error
        {
            public string type { get; set; }
            public string localizationCode { get; set; }
            public string message { get; set; }
        }

        public class Rootobject
        {
            public Levelinfo levelInfo { get; set; }
            public Xpgainbreakdown xpGainBreakdown { get; set; }
            public string extensionProgress { get; set; }
        }

        public class Levelinfo
        {
            public int totalXp { get; set; }
            public int currentXp { get; set; }
            public int level { get; set; }
            public int currentXpUpperBound { get; set; }
            public int levelVersion { get; set; }
            public int prestigeLevel { get; set; }
        }

        public class Xpgainbreakdown
        {
            public int consecutiveMatchMultiplier { get; set; }
            public int emblemsBonus { get; set; }
            public int baseMatchXp { get; set; }
            public string playerType { get; set; }
        }

        public Main()
        {
            InitializeComponent();
        }

        private string emblem()
        {
            string[] emblems = { "\"Bronze\"", "\"Silver\"", "\"Gold\"", "\"Iridescent\"" };

            return (emblems[rnd.Next(0, emblems.Length)]);
        }

        public int parser(string response)
        {
            Rootobject weps = JsonConvert.DeserializeObject<Rootobject>(response);
            content.Text = "Level:  " + weps.levelInfo.level.ToString() +
                "   Prestige:  " + weps.levelInfo.prestigeLevel.ToString() +
                "   Xp:  " + weps.levelInfo.totalXp.ToString();
            content.Refresh();
            return (0);
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
            int level = 0;
            var response = request(level);
            Rootobject_error data = JsonConvert.DeserializeObject<Rootobject_error>(response);
            Rootobject weps = JsonConvert.DeserializeObject<Rootobject>(response);

            if (data == null || data.message == "Operation not allowed, invalid authTokenId")
            {
                MessageBox.Show("Incorrect BHVR cookie");
                return (-1);
            }
            else
            {
                level = weps.levelInfo.levelVersion;
            }
            return (level);
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
            }
            else
            {
                levelversion = levelVersion();
                if (levelversion >= 0)
                {
                    played = Int32.Parse(Game_played.Text);
                    for (int i = 0; i < played; i++)
                    {
                        response = request(levelversion);
                        parser(response);
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
