using System;
using System.Drawing;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace DLC_Slasher
{
    public partial class Form1 : Form
    {
        string bhvr_cookie = null;

        public class Rootobject
        {
            public List[] list { get; set; }
        }

        public class List
        {
            public int balance { get; set; }
            public string currency { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            init_files();
            update(unlock);
            Logs("Ready", Color.LimeGreen);
        }

        private int errors(string response)
        {
            if (response.Contains("invalid token") || response.Length == 0)
            {
                boxer("Your cookie is incorrect", "Incorrect cookie", MessageBoxIcon.Error);
                return (1);
            }
            return (0);
        }

        private int wallet(string cookie)
        {
            var response = request("https://steam.live.bhvrdbd.com/api/v1/wallet/currencies", null, cookie, 1);
            Rootobject weps = JsonConvert.DeserializeObject<Rootobject>(response);

            if (errors(response) == 0)
            {
                if (weps != null)
                {
                    foreach (List item in weps.list)
                    {
                        if (item.currency == "Cells")
                        {
                            cells.Text = item.balance.ToString();
                            cells.Refresh();
                            return (item.balance);
                        }
                    }
                }
                else
                {
                    boxer("Your cookie is incorrect", "Incorrect cookie", MessageBoxIcon.Error);
                    return (-1);
                }
            }
            return (-1);
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

        public void Logs(string message, System.Drawing.Color color)
        {
            status.ForeColor = color;
            status.Text = message;
            status.Refresh();
        }

        private void boxer(string message, string title, System.Windows.Forms.MessageBoxIcon type)
        {
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, type);
        }

        private int check_path(string path)
        {
            if (File.Exists(path))
                return (1);
            return (0);
        }

        private string[] init_files()
        {
            string[] files = Directory.GetFiles(".", "*.dlc");

            if (files.Length > 0)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    version.Items.Add(files[i].Split('\\')[1]);
                    version.SelectedIndex = 0;
                    version.Refresh();
                }
            }
            else
            {
                Logs("No dlc version found", Color.Red);
            }
            return (files);
        }

        private string[] load_dlc()
        {
            if (check_path(version.GetItemText(version.SelectedItem)) == 1)
            {
                Logs("Dlc version found", Color.LimeGreen);
                string text = File.ReadAllText(version.GetItemText(version.SelectedItem));
                string[] tokens = text.Split(' ');
                string[] data = new string[tokens.Length];

                Logs("Reading Dlc availables", Color.Yellow);
                for (int i = 0; i < tokens.Length; i++)
                {
                    data[i] = tokens[i];
                }
                return (data);
            }
            else
            {
                Logs("Dlc version not found", Color.Red);
                return (null);
            }
        }

        private void unlock_Click(object sender, EventArgs e)
        {
            if (wallet(bhvr_cookie) < 500)
            {
                boxer("To unlock DLC you need to have at least [500] Auric Cells on your account", "Requirements", MessageBoxIcon.Error);
            } else
            {
                update(unlock);
                string[] characters = load_dlc();
                if (characters.Length > 0)
                {
                    string json = "{\"currencyType\":\"Cells\",\"wantedQuantity\":1}";

                    for (int i = 0; i < characters.Length; i++)
                    {
                        request("https://steam.live.bhvrdbd.com/api/v1/purchases/consume/" + characters[i], json, bhvr_cookie, 0);
                        Logs(characters[i], Color.Purple);
                    }
                    Logs("DLC Unlocked", Color.LimeGreen);
                } else
                {
                    Logs("No Dlc found", Color.Red);
                }
            }
        }

        private void cookie_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                bhvr_cookie = Clipboard.GetText(TextDataFormat.Text);
                if (wallet(bhvr_cookie) != -1)
                {
                    update(unlock);
                    update(cookie);
                }
            }
        }
    }
}
