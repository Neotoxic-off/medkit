namespace SSLBreaker
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.game_path = new System.Windows.Forms.TextBox();
            this.bypass_launch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.payloadfiles = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.game_path);
            this.groupBox1.Controls.Add(this.bypass_launch);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(287, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2: Bypass";
            // 
            // game_path
            // 
            this.game_path.BackColor = System.Drawing.SystemColors.WindowText;
            this.game_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_path.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.game_path.Location = new System.Drawing.Point(16, 31);
            this.game_path.Name = "game_path";
            this.game_path.Size = new System.Drawing.Size(141, 20);
            this.game_path.TabIndex = 7;
            this.game_path.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Dead by Daylight";
            this.game_path.TextChanged += new System.EventHandler(this.game_path_TextChanged);
            // 
            // bypass_launch
            // 
            this.bypass_launch.BackColor = System.Drawing.Color.Transparent;
            this.bypass_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bypass_launch.ForeColor = System.Drawing.SystemColors.Window;
            this.bypass_launch.Location = new System.Drawing.Point(16, 68);
            this.bypass_launch.Name = "bypass_launch";
            this.bypass_launch.Size = new System.Drawing.Size(141, 23);
            this.bypass_launch.TabIndex = 1;
            this.bypass_launch.Text = "Launch bypass";
            this.bypass_launch.UseVisualStyleBackColor = false;
            this.bypass_launch.Click += new System.EventHandler(this.bypass_launch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "made by neo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.ForeColor = System.Drawing.Color.Yellow;
            this.status.Location = new System.Drawing.Point(58, 190);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 13);
            this.status.TabIndex = 4;
            this.status.Text = "initialisating";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(460, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "v4.4";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.payloadfiles);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(49, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 73);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 1: SSL";
            // 
            // payloadfiles
            // 
            this.payloadfiles.BackColor = System.Drawing.SystemColors.WindowText;
            this.payloadfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payloadfiles.ForeColor = System.Drawing.SystemColors.Window;
            this.payloadfiles.FormattingEnabled = true;
            this.payloadfiles.Location = new System.Drawing.Point(25, 31);
            this.payloadfiles.Name = "payloadfiles";
            this.payloadfiles.Size = new System.Drawing.Size(126, 21);
            this.payloadfiles.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(84, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Remove bypass";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSL Slasher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bypass_launch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox game_path;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox payloadfiles;
        private System.Windows.Forms.Button button1;
    }
}

