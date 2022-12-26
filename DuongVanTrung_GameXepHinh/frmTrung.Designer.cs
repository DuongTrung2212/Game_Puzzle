namespace DuongVanTrung_GameXepHinh
{
    partial class frmTrung
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
            this.components = new System.ComponentModel.Container();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.originImg = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTime = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lbOrigin = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originImg)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_size
            // 
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Items.AddRange(new object[] {
            "3x3",
            "4x3",
            "5x3",
            "5x4",
            "6x6"});
            this.cb_size.Location = new System.Drawing.Point(383, 239);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(121, 24);
            this.cb_size.TabIndex = 0;
            this.cb_size.SelectedIndexChanged += new System.EventHandler(this.cb_size_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(383, 291);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(121, 41);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // originImg
            // 
            this.originImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.originImg.Location = new System.Drawing.Point(206, 16);
            this.originImg.Name = "originImg";
            this.originImg.Size = new System.Drawing.Size(323, 169);
            this.originImg.TabIndex = 2;
            this.originImg.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.BlueViolet;
            this.btnTime.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.Location = new System.Drawing.Point(121, 367);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(121, 41);
            this.btnTime.TabIndex = 3;
            this.btnTime.Text = "Time";
            this.btnTime.UseVisualStyleBackColor = false;
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(56, 239);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(186, 45);
            this.lbTime.TabIndex = 4;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.lbOrigin);
            this.pnlControls.Controls.Add(this.btnAbout);
            this.pnlControls.Controls.Add(this.originImg);
            this.pnlControls.Controls.Add(this.lbTime);
            this.pnlControls.Controls.Add(this.cb_size);
            this.pnlControls.Controls.Add(this.btnTime);
            this.pnlControls.Controls.Add(this.btnPlay);
            this.pnlControls.Location = new System.Drawing.Point(494, 34);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(1);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(614, 559);
            this.pnlControls.TabIndex = 5;
            // 
            // lbOrigin
            // 
            this.lbOrigin.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrigin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbOrigin.Location = new System.Drawing.Point(35, 62);
            this.lbOrigin.Name = "lbOrigin";
            this.lbOrigin.Size = new System.Drawing.Size(125, 73);
            this.lbOrigin.TabIndex = 6;
            this.lbOrigin.Text = "Origin ------>";
            this.lbOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOrigin.Visible = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Turquoise;
            this.btnAbout.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(383, 367);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 41);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.Aquamarine;
            this.pnlAbout.Controls.Add(this.button1);
            this.pnlAbout.Controls.Add(this.label9);
            this.pnlAbout.Controls.Add(this.label8);
            this.pnlAbout.Controls.Add(this.label6);
            this.pnlAbout.Controls.Add(this.label7);
            this.pnlAbout.Controls.Add(this.label5);
            this.pnlAbout.Controls.Add(this.label4);
            this.pnlAbout.Controls.Add(this.label3);
            this.pnlAbout.Controls.Add(this.label2);
            this.pnlAbout.Location = new System.Drawing.Point(220, 172);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(600, 416);
            this.pnlAbout.TabIndex = 6;
            this.pnlAbout.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(559, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "3rd : Nguyễn Văn B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "2nd : Nguyễn Văn A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "1st : Dương Văn Trung";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(229, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Top Gamer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phiên bản: 22.12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tác giả : Dương Văn Trung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sản phẩm : Game Puzzle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(261, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Size :";
            // 
            // frmTrung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1136, 719);
            this.Controls.Add(this.pnlAbout);
            this.Controls.Add(this.pnlControls);
            this.Name = "frmTrung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originImg)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox originImg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lbOrigin;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

