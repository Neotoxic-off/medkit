using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Collections.Generic;

namespace SSLBreaker
{
    public partial class main : Form
    {
        const string dbd_steam = "steam://rungameid/381210";
        const string dbd_process = "DeadByDaylight-Win64-Shipping";
        string dbd_folder_src = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Dead by Daylight\\DeadByDaylight\\Content\\Paks\\pakchunk1-WindowsNoEditor.pak";
        string dbd_folder_backup = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Dead by Daylight\\DeadByDaylight\\Content\\Paks\\pakchunk1-WindowsNoEditor.pak.origin";
        public main()
        {
            InitializeComponent();

            while (is_launched() == 1)
            {
                if (status.Text != "The game is already running close it first")
                {
                    Logs("The game is already running close it first", Color.Red);
                    bypass_launch.Enabled = false;
                    bypass_launch.ForeColor = Color.Gray;
                    bypass_launch.BackColor = Color.Gray;
                }
                Thread.Sleep(2000);
            }
            Logs("Ready", Color.LimeGreen);
        }
        public void Logs(string message, System.Drawing.Color color)
        {
            status.ForeColor = color;
            status.Text = message;
            status.Refresh();
        }

        private void unlock()
        {
            dbd_launch.Enabled = true;
            dbd_launch.ForeColor = Color.White;
            dbd_launch.BackColor = Color.Transparent;
        }

        private int check_dir(string path)
        {
            if (Directory.Exists(path))
            {
                return (1);
            }
                return (0);
        }

        private int check_path(string path)
        {
            if (File.Exists(path))
            {
                return (1);
            }
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

        private int is_launched()
        {
            if (Process.GetProcessesByName(dbd_process).Length != 0)
                return (1);
            return (0);
        }

        private int launch_game()
        {
            Logs("Launching", Color.Yellow);
            if (is_launched() == 1)
            {
                Logs("The game is already running, close it first", Color.Red);
                return (0);
            } else
            {
                dbd_launch.Enabled = false;
                dbd_launch.ForeColor = Color.Gray;
                dbd_launch.BackColor = Color.Gray;
                Logs("Game launched", Color.LimeGreen);
                Process.Start(dbd_steam);
                return (1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (launch_game() == 1)
            {
                
                Console.WriteLine("Game launched");
            } else
            {
                Console.WriteLine("Game already launched");
                dbd_launch.Enabled = true;
                dbd_launch.ForeColor = Color.White;
                dbd_launch.BackColor = Color.Transparent;
            }
        }

        private int Bypass()
        {
            int index = 0x269DE4D;
            int[] data = { 0x5b, 0x2f, 0x53, 0x63, 0x72, 0x69, 0x70, 0x74, 0x2f, 0x45,
                           0x6e, 0x67, 0x69, 0x6e, 0x65, 0x2e, 0x4e, 0x65, 0x74, 0x77,
                           0x6f, 0x72, 0x6b, 0x53, 0x65, 0x74, 0x74, 0x69, 0x6e, 0x67,
                           0x73, 0x5d, 0x0d, 0x0a, 0x6e, 0x2e, 0x56, 0x65, 0x72, 0x69,
                           0x66, 0x79, 0x50, 0x65, 0x65, 0x72, 0x3d, 0x66, 0x61, 0x6c,
                           0x73, 0x65 };
            
            if (backup() == 1 && check_path(dbd_folder_src) == 1)
            {
                BinaryWriter br = new BinaryWriter(File.OpenWrite(dbd_folder_src));
                for (int i = 0; i < data.Length; i++, index++)
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
            if (check_dir(game_path.Text) == 1)
            {
                dbd_folder_src = game_path.Text + "\\DeadByDaylight\\Content\\Paks\\pakchunk1-WindowsNoEditor.pak";
                dbd_folder_backup = game_path.Text + "\\DeadByDaylight\\Content\\Paks\\pakchunk1-WindowsNoEditor.pak.origin";
                Console.WriteLine("SRC: " + dbd_folder_src);
                Console.WriteLine("Backup: " + dbd_folder_backup);
                if (check_path(dbd_folder_src) == 1)
                {
                    if (check_path(dbd_folder_backup) == 0)
                    {
                        Logs("Injecting the bypass", Color.Yellow);
                        bypass_launch.Enabled = false;
                        bypass_launch.ForeColor = Color.Gray;
                        bypass_launch.BackColor = Color.Gray;
                        if (Bypass() == 1)
                            Logs("Bypass injected", Color.LimeGreen);
                        unlock();
                    } else
                        Logs("Backup already present", Color.Red);
                } else
                {
                    Logs("Game path found but doesn't contain files to patch", Color.Red);
                }
            } else
            {
                Logs("Game path not found", Color.Red);
            }
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
    }
}
