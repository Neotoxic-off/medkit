using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace SSLBreaker
{
    public partial class main : Form
    {
        const string dbd_process = "DeadByDaylight-Win64-Shipping";
        string dbd_folder_src = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Dead by Daylight\\DeadByDaylight\\Content\\Paks\\pakchunk1-WindowsNoEditor.pak";
        string dbd_folder_backup = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Dead by Daylight\\DeadByDaylight\\Content\\Paks\\pakchunk1-WindowsNoEditor.pak.orig";
        public main()
        {
            InitializeComponent();

            if (is_launched() == 1)
            {
                Logs("The game is already running close it first", Color.Red);
                bypass_launch.Enabled = false;
                bypass_launch.ForeColor = Color.Gray;
                bypass_launch.BackColor = Color.Gray;

                payloadfiles.Enabled = false;
                payloadfiles.ForeColor = Color.Gray;
                payloadfiles.BackColor = Color.Gray;
            } else
            {
                init_files();
                if (check_dir(game_path.Text) == 0)
                {
                    Logs("Game path not found", Color.Red);
                }
                else
                {
                    Logs("Game path found", Color.LimeGreen);
                }
            }
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

        private int check_dir(string path)
        {
            if (Directory.Exists(path))
                return (1);
            return (0);
        }

        private int check_path(string path)
        {
            if (File.Exists(path))
                return (1);
            return (0);
        }
        private int backup()
        {
            if (check_path(dbd_folder_backup) == 1)
            {
                Logs("Backup already saved", Color.Red);
                return (0);
            } else
            {
                File.Copy(dbd_folder_src, dbd_folder_backup);
                return (1);
            }
        }

        private int reset()
        {
            if (check_path(dbd_folder_backup) == 1)
            {
                Logs("Backup found", Color.LimeGreen);
                if (check_path(dbd_folder_src) == 1)
                {
                    Logs("Removing bypass", Color.LimeGreen);
                    File.Delete(dbd_folder_src);
                    File.Move(dbd_folder_backup, dbd_folder_src);
                    return (1);
                }
                else
                {
                    Logs("No bypass found", Color.Red);
                    return (0);
                }
            }
            else
            {
                Logs("No backup found", Color.Red);
                return (0);
            }
        }

        private int is_launched()
        {
            if (Process.GetProcessesByName(dbd_process).Length != 0)
                return (1);
            return (0);
        }

        private string[] init_files()
        {
            string[] files = Directory.GetFiles(".", "*.ssl");

            if (files.Length > 0)
            {
                for (int i = 0; i < files.Length; i++)
                {
                    payloadfiles.Items.Add(files[i].Split('\\')[1]);
                    payloadfiles.SelectedIndex = 0;
                    payloadfiles.Refresh();
                }
            } else
            {
                Logs("No payload found", Color.Red);
            }
            return (files);
        }

        private int[] load_payload()
        {
            if (check_path(payloadfiles.GetItemText(payloadfiles.SelectedItem)) == 1)
            {
                Logs("Payload found", Color.LimeGreen);
                string text = File.ReadAllText(payloadfiles.GetItemText(payloadfiles.SelectedItem));
                string[] tokens = text.Split(' ');
                int[] data = new int[tokens.Length];

                Logs("Reading payload", Color.Yellow);
                for (int i = 0; i < tokens.Length; i++)
                {
                    data[i] = Convert.ToInt32(tokens[i], 16);
                }
                return (data);
            }
            else
            {
                Logs("Payload not found", Color.Red);
                return (null);
            }
        }

        private int Bypass(int[] data)
        {
            int index = data[0];
            
            if (backup() == 1 && check_path(dbd_folder_src) == 1)
            {
                Logs("Injecting payload", Color.Yellow);
                BinaryWriter br = new BinaryWriter(File.OpenWrite(dbd_folder_src));
                for (int i = 1; i < data.Length; i++, index++)
                {
                    br.BaseStream.Position = index;
                    br.Write(data[i]);
                }
                br.Close();
                return (1);
            } else
            {
                Logs("Backup present make sure the bypass is not already injected", Color.Purple);
                return (0);
            }
        }

        private void bypass_launch_Click(object sender, EventArgs e)
        {
            int[] data = null;

            if (check_dir(game_path.Text) == 1)
            {
                dbd_folder_src = game_path.Text + "\\DeadByDaylight\\Content\\Paks\\pakchunk1-WindowsNoEditor.pak";
                dbd_folder_backup = game_path.Text + "\\DeadByDaylight\\Content\\Paks\\pakchunk1-WindowsNoEditor.pak.orig";
                if (check_path(dbd_folder_src) == 1)
                {
                    if (check_path(dbd_folder_backup) == 0)
                    {
                        Logs("Injecting the bypass", Color.Yellow);
                        bypass_launch.Enabled = false;
                        bypass_launch.ForeColor = Color.Gray;
                        bypass_launch.BackColor = Color.Gray;
                        data = load_payload();
                        if (data != null && data.Length > 1)
                        {
                            try
                            {
                                if (Bypass(data) == 1)
                                    Logs("Bypass injected", Color.LimeGreen);
                            } catch (Exception error)
                            {
                                boxer(error.Message, "Internal Error", MessageBoxIcon.Error);
                            }
                        } else
                            Logs("Your bypass is incorrect", Color.Red);
                    } else
                        Logs("Bypass already present", Color.Red);
                } else
                    Logs("Game path found but doesn't contain files to patch", Color.Red);
            } else
                Logs("Game path not found", Color.Red);
        }

        private void game_path_TextChanged(object sender, EventArgs e)
        {
            if (check_dir(game_path.Text) == 0)
            {
                Logs("Game path not found", Color.Red);
            } else
            {
                Logs("Game path found", Color.LimeGreen);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (check_dir(game_path.Text) == 0)
            {
                Logs("Game path not found", Color.Red);
            }
            else
            {
                Logs("Game path found", Color.LimeGreen);
                if (reset() == 1)
                {
                    Logs("Bypass removed", Color.LimeGreen);
                }
                
            }
        }
    }
}
