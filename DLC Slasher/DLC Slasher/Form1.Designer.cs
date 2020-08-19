namespace DLC_Slasher
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.version = new System.Windows.Forms.ComboBox();
            this.unlock = new System.Windows.Forms.Button();
            this.cells = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cookie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(460, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "v1.8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "made by neo";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.version);
            this.groupBox1.Controls.Add(this.unlock);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(278, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 120);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 2: Unlock";
            // 
            // version
            // 
            this.version.BackColor = System.Drawing.SystemColors.WindowText;
            this.version.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.version.ForeColor = System.Drawing.SystemColors.Window;
            this.version.FormattingEnabled = true;
            this.version.Location = new System.Drawing.Point(18, 34);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(141, 21);
            this.version.TabIndex = 3;
            // 
            // unlock
            // 
            this.unlock.BackColor = System.Drawing.Color.Transparent;
            this.unlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlock.ForeColor = System.Drawing.SystemColors.Window;
            this.unlock.Location = new System.Drawing.Point(18, 77);
            this.unlock.Name = "unlock";
            this.unlock.Size = new System.Drawing.Size(141, 23);
            this.unlock.TabIndex = 2;
            this.unlock.Text = "Unlock DLC";
            this.unlock.UseVisualStyleBackColor = false;
            this.unlock.Click += new System.EventHandler(this.unlock_Click);
            // 
            // cells
            // 
            this.cells.AutoSize = true;
            this.cells.BackColor = System.Drawing.Color.Transparent;
            this.cells.ForeColor = System.Drawing.Color.Yellow;
            this.cells.Location = new System.Drawing.Point(79, 42);
            this.cells.Name = "cells";
            this.cells.Size = new System.Drawing.Size(51, 13);
            this.cells.TabIndex = 17;
            this.cells.Text = "unknown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(14, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Auric Cells:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cells);
            this.groupBox2.Controls.Add(this.cookie);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(45, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 120);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 1: Cookie";
            // 
            // cookie
            // 
            this.cookie.BackColor = System.Drawing.Color.Transparent;
            this.cookie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cookie.ForeColor = System.Drawing.SystemColors.Window;
            this.cookie.Location = new System.Drawing.Point(16, 77);
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(141, 23);
            this.cookie.TabIndex = 1;
            this.cookie.Text = "Cookie from clipoard";
            this.cookie.UseVisualStyleBackColor = false;
            this.cookie.Click += new System.EventHandler(this.cookie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 14;
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
            this.status.TabIndex = 15;
            this.status.Text = "initialisation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 212);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLC Slasher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cookie;
        private System.Windows.Forms.Button unlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label cells;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox version;
    }
}

