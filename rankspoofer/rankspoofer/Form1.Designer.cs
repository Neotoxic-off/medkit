namespace rankspoofer
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
            this.inject = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.survivor_rank = new System.Windows.Forms.Label();
            this.killer_rank = new System.Windows.Forms.Label();
            this.cookie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.level_killer = new System.Windows.Forms.NumericUpDown();
            this.level_survivor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_killer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_survivor)).BeginInit();
            this.SuspendLayout();
            // 
            // inject
            // 
            this.inject.BackColor = System.Drawing.Color.Black;
            this.inject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inject.ForeColor = System.Drawing.SystemColors.Window;
            this.inject.Location = new System.Drawing.Point(341, 262);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(75, 23);
            this.inject.TabIndex = 0;
            this.inject.Text = "Inject";
            this.inject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inject.UseVisualStyleBackColor = false;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 140);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(316, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 140);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // survivor_rank
            // 
            this.survivor_rank.AutoSize = true;
            this.survivor_rank.BackColor = System.Drawing.SystemColors.WindowText;
            this.survivor_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivor_rank.ForeColor = System.Drawing.Color.Red;
            this.survivor_rank.Location = new System.Drawing.Point(157, 65);
            this.survivor_rank.Name = "survivor_rank";
            this.survivor_rank.Size = new System.Drawing.Size(44, 31);
            this.survivor_rank.TabIndex = 3;
            this.survivor_rank.Text = "00";
            // 
            // killer_rank
            // 
            this.killer_rank.AutoSize = true;
            this.killer_rank.BackColor = System.Drawing.SystemColors.WindowText;
            this.killer_rank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.killer_rank.ForeColor = System.Drawing.Color.Red;
            this.killer_rank.Location = new System.Drawing.Point(346, 65);
            this.killer_rank.Name = "killer_rank";
            this.killer_rank.Size = new System.Drawing.Size(44, 31);
            this.killer_rank.TabIndex = 4;
            this.killer_rank.Text = "00";
            // 
            // cookie
            // 
            this.cookie.BackColor = System.Drawing.SystemColors.WindowText;
            this.cookie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cookie.ForeColor = System.Drawing.SystemColors.Window;
            this.cookie.Location = new System.Drawing.Point(100, 265);
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(210, 20);
            this.cookie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(27, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bhvr cookie:";
            // 
            // level_killer
            // 
            this.level_killer.BackColor = System.Drawing.SystemColors.WindowText;
            this.level_killer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.level_killer.ForeColor = System.Drawing.SystemColors.Window;
            this.level_killer.Location = new System.Drawing.Point(344, 177);
            this.level_killer.Maximum = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.level_killer.Name = "level_killer";
            this.level_killer.Size = new System.Drawing.Size(46, 20);
            this.level_killer.TabIndex = 7;
            // 
            // level_survivor
            // 
            this.level_survivor.BackColor = System.Drawing.SystemColors.WindowText;
            this.level_survivor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.level_survivor.ForeColor = System.Drawing.SystemColors.Window;
            this.level_survivor.Location = new System.Drawing.Point(155, 177);
            this.level_survivor.Maximum = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.level_survivor.Name = "level_survivor";
            this.level_survivor.Size = new System.Drawing.Size(46, 20);
            this.level_survivor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "made by neo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(519, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.level_survivor);
            this.Controls.Add(this.level_killer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cookie);
            this.Controls.Add(this.killer_rank);
            this.Controls.Add(this.survivor_rank);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_killer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_survivor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label survivor_rank;
        private System.Windows.Forms.Label killer_rank;
        private System.Windows.Forms.TextBox cookie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown level_killer;
        private System.Windows.Forms.NumericUpDown level_survivor;
        private System.Windows.Forms.Label label2;
    }
}

