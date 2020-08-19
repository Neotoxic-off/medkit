namespace EAC_Challenger
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
            this.challenge = new System.Windows.Forms.Button();
            this.cookie = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.generated = new System.Windows.Forms.TextBox();
            this.auto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updated = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.corrupt = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // challenge
            // 
            this.challenge.BackColor = System.Drawing.Color.Transparent;
            this.challenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.challenge.ForeColor = System.Drawing.SystemColors.Window;
            this.challenge.Location = new System.Drawing.Point(23, 37);
            this.challenge.Name = "challenge";
            this.challenge.Size = new System.Drawing.Size(145, 23);
            this.challenge.TabIndex = 0;
            this.challenge.Text = "Generate challenge";
            this.challenge.UseVisualStyleBackColor = false;
            this.challenge.Click += new System.EventHandler(this.challenge_Click);
            // 
            // cookie
            // 
            this.cookie.BackColor = System.Drawing.Color.Transparent;
            this.cookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cookie.ForeColor = System.Drawing.SystemColors.Window;
            this.cookie.Location = new System.Drawing.Point(20, 37);
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(145, 23);
            this.cookie.TabIndex = 1;
            this.cookie.Text = "Cookie from clipboard";
            this.cookie.UseVisualStyleBackColor = false;
            this.cookie.Click += new System.EventHandler(this.cookie_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cookie);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(36, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "STEP 1: Cookie";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.corrupt);
            this.groupBox2.Controls.Add(this.updated);
            this.groupBox2.Controls.Add(this.auto);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.status);
            this.groupBox2.Controls.Add(this.challenge);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(276, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 193);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "STEP 2: Challenge";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.generated);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(36, 152);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 87);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EAC Challenge Generated";
            // 
            // generated
            // 
            this.generated.BackColor = System.Drawing.SystemColors.WindowText;
            this.generated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generated.ForeColor = System.Drawing.SystemColors.Window;
            this.generated.Location = new System.Drawing.Point(15, 29);
            this.generated.Multiline = true;
            this.generated.Name = "generated";
            this.generated.Size = new System.Drawing.Size(150, 42);
            this.generated.TabIndex = 6;
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.BackColor = System.Drawing.Color.Transparent;
            this.auto.ForeColor = System.Drawing.SystemColors.Window;
            this.auto.Location = new System.Drawing.Point(31, 88);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(137, 17);
            this.auto.TabIndex = 6;
            this.auto.Text = "Auto validate challenge";
            this.auto.UseVisualStyleBackColor = false;
            this.auto.CheckedChanged += new System.EventHandler(this.auto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(20, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Challenge status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "made by neo";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.ForeColor = System.Drawing.Color.Yellow;
            this.status.Location = new System.Drawing.Point(106, 165);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(68, 13);
            this.status.TabIndex = 8;
            this.status.Text = "no challenge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "State updated:";
            // 
            // updated
            // 
            this.updated.AutoSize = true;
            this.updated.BackColor = System.Drawing.Color.Transparent;
            this.updated.ForeColor = System.Drawing.Color.Yellow;
            this.updated.Location = new System.Drawing.Point(106, 152);
            this.updated.Name = "updated";
            this.updated.Size = new System.Drawing.Size(68, 13);
            this.updated.TabIndex = 10;
            this.updated.Text = "no challenge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(207, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "hang1ng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(98, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "thanks to my patron:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(460, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "v1.0";
            // 
            // corrupt
            // 
            this.corrupt.AutoSize = true;
            this.corrupt.BackColor = System.Drawing.Color.Transparent;
            this.corrupt.ForeColor = System.Drawing.SystemColors.Window;
            this.corrupt.Location = new System.Drawing.Point(31, 106);
            this.corrupt.Name = "corrupt";
            this.corrupt.Size = new System.Drawing.Size(109, 17);
            this.corrupt.TabIndex = 11;
            this.corrupt.Text = "Corrupt challenge";
            this.corrupt.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 251);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EAC Challenger";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button challenge;
        private System.Windows.Forms.Button cookie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox generated;
        private System.Windows.Forms.CheckBox auto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label updated;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox corrupt;
    }
}

