using System;
using System.Drawing;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace EAC_Challenger
{
    public partial class Form1 : Form
    {
        public class Rootobject
        {
            public string challenge { get; set; }
        }

        public class Rootobject_valid
        {
            public bool valid { get; set; }
            public bool stateUpdated { get; set; }
        }

        string bhvr_cookie = null;

        public Form1()
        {
            InitializeComponent();
        }

        public int parser(string response)
        {
            Rootobject weps = JsonConvert.DeserializeObject<Rootobject>(response);
            generated.Text = weps.challenge;
            generated.Refresh();
            return (0);
        }

        public int parser_valid(string response)
        {
            Rootobject_valid weps = JsonConvert.DeserializeObject<Rootobject_valid>(response);
            if (weps != null)
            {
                if (weps.valid == true)
                {
                    status.ForeColor = Color.LimeGreen;
                    status.Text = "Valid";
                }
                else
                {
                    status.ForeColor = Color.Red;
                    status.Text = "Invalid";
                }

                if (weps.stateUpdated == true)
                {
                    updated.ForeColor = Color.LimeGreen;
                    updated.Text = "True";
                }
                else
                {
                    updated.ForeColor = Color.Red;
                    updated.Text = "False";
                }
                status.Refresh();
                updated.Refresh();
            } else
            {
                generated.ForeColor = Color.Red;
                generated.Text = "Incorrect bhvr cookie";
                generated.ForeColor = Color.White;
                generated.Refresh();
                return (-1);
            }
            return (0);
        }

        private string generate()
        {
            string json = "{\"data\":{}}";

            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/extensions/eac/generateChallenge"
            };

            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", bhvr_cookie);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);
            Console.WriteLine("\nRequest:\n" + json);
            Console.WriteLine("\nResponse:\n" + response.Content);
            return (response.Content);
        }

        private string validate(string challenge)
        {
            string json = "{\"data\":{\"challengeResponse\":\"" + challenge + "\"}}";

            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/extensions/eac/validateChallengeResponse"
            };

            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", bhvr_cookie);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);
            Console.WriteLine("\nRequest:\n" + json);
            Console.WriteLine("\nResponse:\n" + response.Content);
            return (response.Content);
        }

        private void challenge_Click(object sender, EventArgs e)
        {
            string corrupted = "0100000080eca57458fab2643f67c1f74626a2d84ef727f8e10699d40df1db36394278da7785b71a5f6574717e60e978af1b74dc4704688a1e78735dec305e717710bb8eb226750031821a64b77a41c15606a2425415da53be50ef13beb08de662e8788f6ea6fbf9fe1267698cd49bafd76da81808e3f49463cfd09c60777a0b";
            string response = generate();
            parser(response);

            if (auto.Checked == true)
            {
                if (corrupt.Checked == true) 
                    parser_valid(validate(corrupted));
                else
                    parser_valid(validate(generated.Text));
            } else
            {
                status.ForeColor = Color.Yellow;
                status.Text = "Not validated";
                updated.ForeColor = Color.Yellow;
                updated.Text = "Not validated";
                status.Refresh();
                updated.Refresh();
            }
        }

        private void cookie_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                bhvr_cookie = Clipboard.GetText(TextDataFormat.Text);
                cookie.Enabled = false;
                cookie.ForeColor = Color.Black;
                cookie.BackColor = Color.Gray;
            }
        }

        private void auto_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
