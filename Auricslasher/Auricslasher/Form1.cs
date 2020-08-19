using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace Auricslasher
{
    public partial class Form1 : Form
    {
        string bhvr_cookie = null;
        string order_id = null;
        public Form1()
        {
            InitializeComponent();
            Logs("Ready", Color.LimeGreen);
        }

        public void Logs(string message, System.Drawing.Color color)
        {
            status.ForeColor = color;
            status.Text = message;
            status.Refresh();
        }
        private string validateIapPurchase()
        {
            string json = "{\"data\":{\"bundleId\":\"cellsPack1\",\"platform\":\"steam\",\"validationOptions\":{\"orderId\":\"" + order_id + "\"}}}";
            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/extensions/store/validateIapPurchase"
            };

            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", bhvr_cookie);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);
            Console.WriteLine("\nsteamFinalizeTransaction Request:\n" + json);
            Console.WriteLine("\nsteamFinalizeTransaction Response:\n" + response.Content);
            return (response.Content);
        }

        private string consume()
        {
            string json = "{\"objectId\":\"cellsPack1\",\"quantity\":1}";
            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/inventories/consume/v2"
            };

            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", bhvr_cookie);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);
            Console.WriteLine("\nvalidateIapPurchase Request:\n" + json);
            Console.WriteLine("\nvalidateIapPurchase Response:\n" + response.Content);
            return (response.Content);
        }

        private string steamFinalizeTransaction()
        {
            string json = "{\"data\":{\"isCancelled\": false,\"orderId\":\"" + order_id + "\"}}";
            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/extensions/store/steamFinalizeTransaction"
            };

            bhvr_request.AddHeader("Accept-Encoding", "deflate, gzip");
            bhvr_request.AddHeader("Accept", "*/*");
            bhvr_request.AddHeader("Content-Type", "application/json");
            client.UserAgent = "DeadByDaylight/++DeadByDaylight+Live-CL-321933 Windows/10.0.19041.1.768.64bit";
            bhvr_request.AddCookie("bhvrSession", bhvr_cookie);
            bhvr_request.AddJsonBody(json);
            IRestResponse response = client.Post(bhvr_request);
            Console.WriteLine("\nvalidateIapPurchase Request:\n" + json);
            Console.WriteLine("\nvalidateIapPurchase Response:\n" + response.Content);
            return (response.Content);
        }

        private void launch()
        {
            for (int i = 1; i <= repeat.Value; i++)
            {
                steamFinalizeTransaction();
                validateIapPurchase();
                consume();
                Logs("Transaction number: " + i, Color.Red);
            }
            MessageBox.Show("All completed");
            unlock();
        }
        /*
         * orderId=1597057995323
         * orderId=1597058001860
         * orderId=1597058007903
         * orderId=1597058115006
         * orderId=1597058122533
         * base: 1597057
        */
        private void unlock()
        {
            button2.Enabled = true;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                bhvr_cookie = Clipboard.GetText(TextDataFormat.Text);
                button1.Enabled = false;
                button1.ForeColor = Color.Black;
                button1.BackColor = Color.Gray;
                unlock();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                order_id = Clipboard.GetText(TextDataFormat.Text);
                button2.Enabled = false;
                button2.ForeColor = Color.Black;
                button2.BackColor = Color.Gray;
                launch();
            }
        }
    }
}
