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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dbd_launch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.game_path);
            this.groupBox1.Controls.Add(this.bypass_launch);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(52, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1: Bypass";
            // 
            // game_path
            // 
            this.game_path.BackColor = System.Drawing.SystemColors.WindowText;
            this.game_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_path.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.game_path.Location = new System.Drawing.Point(16, 72);
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
            this.bypass_launch.Location = new System.Drawing.Point(16, 31);
            this.bypass_launch.Name = "bypass_launch";
            this.bypass_launch.Size = new System.Drawing.Size(141, 23);
            this.bypass_launch.TabIndex = 1;
            this.bypass_launch.Text = "Launch the bypass";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dbd_launch);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(274, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 73);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2: Dead by Daylight";
            // 
            // dbd_launch
            // 
            this.dbd_launch.BackColor = System.Drawing.Color.Gray;
            this.dbd_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbd_launch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dbd_launch.Location = new System.Drawing.Point(16, 31);
            this.dbd_launch.Name = "dbd_launch";
            this.dbd_launch.Size = new System.Drawing.Size(141, 23);
            this.dbd_launch.TabIndex = 1;
            this.dbd_launch.Text = "Launch the game";
            this.dbd_launch.UseVisualStyleBackColor = false;
            this.dbd_launch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 200);
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
            this.status.Location = new System.Drawing.Point(58, 200);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 13);
            this.status.TabIndex = 4;
            this.status.Text = "initialisating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Doomed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(444, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "v3.5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, -82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 222);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<3 SSLSlasher by И е о#3212 <3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bypass_launch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dbd_launch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox game_path;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

