namespace bloodslasher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inject = new System.Windows.Forms.Button();
            this.cookie = new System.Windows.Forms.TextBox();
            this.maximum = new System.Windows.Forms.TextBox();
            this.bloodpoint = new System.Windows.Forms.Label();
            this.allbloodpoint = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.secret = new System.Windows.Forms.CheckBox();
            this.message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "made by Neo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(225, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bhvr cookie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(186, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bloodpoints to inject:";
            // 
            // inject
            // 
            this.inject.BackColor = System.Drawing.Color.Transparent;
            this.inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inject.ForeColor = System.Drawing.SystemColors.Window;
            this.inject.Location = new System.Drawing.Point(413, 187);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(75, 23);
            this.inject.TabIndex = 8;
            this.inject.Text = "Inject";
            this.inject.UseVisualStyleBackColor = false;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // cookie
            // 
            this.cookie.BackColor = System.Drawing.SystemColors.WindowText;
            this.cookie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cookie.ForeColor = System.Drawing.SystemColors.Window;
            this.cookie.Location = new System.Drawing.Point(299, 66);
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(189, 20);
            this.cookie.TabIndex = 10;
            // 
            // maximum
            // 
            this.maximum.BackColor = System.Drawing.SystemColors.WindowText;
            this.maximum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maximum.ForeColor = System.Drawing.SystemColors.Window;
            this.maximum.Location = new System.Drawing.Point(299, 108);
            this.maximum.MaxLength = 6;
            this.maximum.Name = "maximum";
            this.maximum.Size = new System.Drawing.Size(189, 20);
            this.maximum.TabIndex = 12;
            this.maximum.TextChanged += new System.EventHandler(this.maximum_TextChanged);
            // 
            // bloodpoint
            // 
            this.bloodpoint.AutoSize = true;
            this.bloodpoint.BackColor = System.Drawing.Color.Transparent;
            this.bloodpoint.Location = new System.Drawing.Point(12, 192);
            this.bloodpoint.Name = "bloodpoint";
            this.bloodpoint.Size = new System.Drawing.Size(41, 13);
            this.bloodpoint.TabIndex = 13;
            this.bloodpoint.Text = "Added:";
            // 
            // allbloodpoint
            // 
            this.allbloodpoint.AutoSize = true;
            this.allbloodpoint.BackColor = System.Drawing.Color.Transparent;
            this.allbloodpoint.Location = new System.Drawing.Point(59, 192);
            this.allbloodpoint.Name = "allbloodpoint";
            this.allbloodpoint.Size = new System.Drawing.Size(22, 13);
            this.allbloodpoint.TabIndex = 14;
            this.allbloodpoint.Text = ". . .";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "thanks to Black";
            // 
            // secret
            // 
            this.secret.AutoSize = true;
            this.secret.BackColor = System.Drawing.Color.Transparent;
            this.secret.Location = new System.Drawing.Point(383, 144);
            this.secret.Name = "secret";
            this.secret.Size = new System.Drawing.Size(105, 17);
            this.secret.TabIndex = 18;
            this.secret.Text = "Shrine of secrets";
            this.secret.UseVisualStyleBackColor = false;
            this.secret.CheckedChanged += new System.EventHandler(this.secret_CheckedChanged);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.BackColor = System.Drawing.Color.Transparent;
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(186, 145);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 19;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 222);
            this.Controls.Add(this.message);
            this.Controls.Add(this.secret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.allbloodpoint);
            this.Controls.Add(this.bloodpoint);
            this.Controls.Add(this.maximum);
            this.Controls.Add(this.cookie);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<3 BloodySlasher by И е о#3212 <3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button inject;
        private System.Windows.Forms.TextBox cookie;
        private System.Windows.Forms.TextBox maximum;
        private System.Windows.Forms.Label bloodpoint;
        private System.Windows.Forms.Label allbloodpoint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox secret;
        private System.Windows.Forms.Label message;
    }
}

