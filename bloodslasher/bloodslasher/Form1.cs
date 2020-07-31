using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;
using RestSharp;

namespace bloodslasher
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private string request(int balance, string type)
        {
            string json = "{" +
                    "\"data\":{" + 
                        "\"rewardType\": \"" + type + "\"," +
                        "\"walletToGrant\": {" +
                            "\"balance\":" +
                            balance + 
                        ",\"currency\": \"Bloodpoints\"}}}";

            var client = new RestClient();
            var bhvr_request = new RestRequest()
            {
                Resource = "https://steam.live.bhvrdbd.com/api/v1/extensions/rewards/grantCurrency/"
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

        private int check()
        {
            if (cookie.Text.Length > 0)
            {
                if (maximum.Text.Length > 0)
                {

                } else
                {
                    MessageBox.Show("Number of bloodpoint you want");
                    return (-1);
                }
            } else
            {
                MessageBox.Show("Enter your bhvr cookie");
                return (-1);
            }
            return (0);
        }

        private int goal(int balance)
        {
            int limit = 999999;
            int max = Int32.Parse(maximum.Text);
            Console.WriteLine("balance: " + balance);
            Console.WriteLine("max:     " + max);
            Console.WriteLine("limit:   " + limit);

            if (balance > limit || balance > max)
            {
                return (1);
            }
            else
            {
                return (0);
            }
        }

        private int counter(string response)
        {
            if (response.Contains("Reached the maximum number of grants"))
            {
                MessageBox.Show("You can't inject anymore, you need to wait. You reached the maximum number of grants (100) per hour");
                return (-1);
            } else if (response.Contains("Invalid input: The balance is exceeding the maximum value"))
            {
                MessageBox.Show("The balance is at the maximum value");
                return (-1);
            }
            int value = Int32.Parse(response.Split(':')[2].Split('}')[0]);
            return (value);
        }

        private int increase()
        {
            int[] array = { 10000, 12000, 15000 };
            return (array[rnd.Next(0, array.Length)]);
        }

        private void resume(int balance)
        {
            if (balance > -1)
            {
                Console.WriteLine("update");
                allbloodpoint.Text = balance.ToString();
                allbloodpoint.Refresh();
                Console.WriteLine("update: " + allbloodpoint.Text);
            }
        }

        private void inject_Click(object sender, EventArgs e)
        {
            bool limit = false;
            int total = 0;

            if (check() == 0)
            {
                inject.BackColor = Color.Gray;
                inject.ForeColor = Color.Gray;
                inject.Enabled = false;

                if (total != -1)
                {
                    allbloodpoint.Text = total.ToString();
                    for (int i = 0; i < 100; i++)
                    {
                        total += increase();
                        if (goal(total) == 0)
                        {
                            if (i < 4)
                            {
                                if (counter(request(150000, "shrineReward")) == -1)
                                {
                                    limit = true;
                                    break;
                                }
                            } else
                            {
                                if (counter(request(total, "Story")) == -1)
                                {
                                    limit = true;
                                    break;
                                }
                            }
                        } else
                        {
                            limit = true;
                            break;
                        }
                        resume(total);
                    }
                    if (limit == false)
                    {
                        resume(total);
                        MessageBox.Show("Bloodpoints injected");
                        limit = false;
                    }
                }
                inject.ForeColor = Color.White;
                inject.BackColor = Color.Transparent;
                inject.Enabled = true;
            }
        }
    }
}
