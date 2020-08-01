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
                if (maximum.Text.Length <= 0)
                {
                    MessageBox.Show("Enter the number of bloodpoint you want to inject");
                    return (-1);
                } else if (maximum.Text.StartsWith("0"))
                {
                    MessageBox.Show("Please remove useless characters on your Bloodpoint value");
                } else
                {
                    var isNumeric = int.TryParse(maximum.Text, out int n);
                    if (n == 0)
                    {
                        MessageBox.Show("Please enter a correct value for Bloodpoints to inject");
                        return (-1);
                    } else
                    {
                        if (n < 15000)
                        {
                            if (secret.Checked == false)
                            {
                                MessageBox.Show("Minimum Bloodpoint to inject: 15000");
                                return (-1);
                            } else
                            {
                                MessageBox.Show("By using the Shrine of secrets, the minimum Bloodpoint to inject: 150000");
                                return (-1);
                            }
                            
                        } else
                        {
                            if (counter(request(10000, "Story")) == -1)
                            {
                                return (-1);
                            }
                        }
                    }
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

            if (balance > limit || balance > max)
            {
                return (1);
            }
            return (0);
        }

        private int counter(string response)
        {
            int value = 0;

            if (response.Contains("Reached the maximum number of grants"))
            {
                if (response.Contains("Invalid input: Reached the maximum number of grants [4] within an hour"))
                {
                    MessageBox.Show("You can't inject anymore, you need to wait. You reached the maximum number of grants using the Shrine of secrets (4) per hour");
                    return (-1);
                } else if (response.Contains("Invalid input: Reached the maximum number of grants [100] within an hour"))
                {
                    MessageBox.Show("You can't inject anymore, you need to wait. You reached the maximum number of grants (100) per hour");
                    return (-1);
                }
            } else if (response.Contains("Invalid input: The balance is exceeding the maximum value"))
            {
                MessageBox.Show("The balance is at the maximum value");
                return (-1);
            } else if (response.Contains("Operation not allowed, invalid authTokenId"))
            {
                MessageBox.Show("Invalid Bhvr cookie");
                return (-1);
            }
            value = Int32.Parse(response.Split(':')[2].Split('}')[0]);
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
                            if (i < 4 && secret.Checked == true)
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

        private void secret_CheckedChanged(object sender, EventArgs e)
        {
            if (secret.Checked == true)
            {
                message.Text = "Use it only if you don't have\nalready purchased any perk on\nthe Shrine of secrets\nand use it only 1 time and\nwait Shrine reset";
            } else
            {
                message.Text = "";
            }
            message.Refresh();
            
        }

        private void maximum_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
