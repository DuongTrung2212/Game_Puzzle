using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
namespace DuongVanTrung_GameXepHinh
{
    public partial class frmTrung : Form
    {
        public frmTrung()
        {
            InitializeComponent();
        }
        int top = 0;
        int left = 0;
        int row=0;int col=0;
        int width = 0;
        int time = 1800;
        Image[] cards;
        List<Image> arrImg = new List<Image>();
        List<Button> arrBtn = new List<Button>();
        Panel pnl = new Panel();
        public void renderBtn(int row,int col,String namePath)
        {
            top = 0;
            left = 0;
            pnl.Controls.Clear();
            arrBtn.Clear();
            cards = System.IO.Directory.GetFiles(@namePath, "*.*").Select(f => Image.FromFile(f)).ToArray();
            pnl.Location = new Point(20, 20);
            pnl.AutoSize = true;
            this.Controls.Add(pnl);
            int dem = 0;
            int sizeImg = row - col;
            switch (sizeImg)
            {
                case 0:
                    width = 100;
                    break;
                case 1:
                    width = 140;
                    break;
                case 2:
                    width = 170;
                    break;
            }
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Button btn = new Button();
                    btn.Tag = dem;
                    btn.Size = new Size(width, 100);
                    if (dem > 0)
                    {
                        btn.BackgroundImage = cards[dem-1];
                    }
                    btn.Click += new EventHandler(wrapBtn);
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                    dem++;
                    arrBtn.Add(btn);
                }
            }
            Shuffle(arrBtn);
            for(int i = 0; i < arrBtn.Count; i++)
            {
                if (left == col * width)
                {
                    top += 100;
                    left = 0;
                }
                arrBtn[i].Location = new Point(left, top);
                left += width;
                dem++;
                pnl.Controls.Add(arrBtn[i]);
            }
            btnPlay.Text = "Reset";
            pnlControls.Location = new Point(this.Width * 55 / 100, 50);
            lbOrigin.Visible = true;
            timer1.Stop();
            time = 1800;
            lbTime.Text = "";
            btnTime.Click += new EventHandler(btnTime_Click);
        }
        public static void Shuffle(List<Button> arr)
        {
            Random random = new Random();
            for (int i = arr.Count-1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                Button tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            int index = cb_size.SelectedIndex;
            switch (index)
            {
                case 0:
                    this.Size = new Size(1000, 600);
                    originImg.BackgroundImage = Properties.Resources._3x3;
                    row = 3;
                    col = 3;
                    renderBtn(row, col, "../../Resources/3x3/");
                    break;
                case 1:
                    this.Size = new Size(1100, 700);
                    originImg.BackgroundImage = Properties.Resources._4x3;
                    row = 4;
                    col = 3;
                    renderBtn(row, col, "../../Resources/4x3/");
                    break ;
                case 2:
                    this.Size = new Size(1150, 650);
                    originImg.BackgroundImage = Properties.Resources._5x3;
                    row = 5;
                    col = 3;
                    renderBtn(row, col, "../../Resources/5x3/");
                    break;
                case 3:
                    this.Size = new Size(1200, 650);
                    originImg.BackgroundImage = Properties.Resources._5x4;
                    row = 5;
                    col = 4;
                    renderBtn(row, col, "../../Resources/5x4/");
                    break;
                case 4:
                    this.Size = new Size(1300, 700);
                    originImg.BackgroundImage = Properties.Resources._6x6;
                    row = 6;
                    col = 6;
                    renderBtn(row, col, "../../Resources/6x6/");
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn size");
                    break;
            }
        }
        public void wrapBtn(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            Button btn= (Button)sender;
            Button tmp = null;
            if (btn.Tag.ToString() == "0")
            {
               return;
            }
            foreach (Button itemBtn in this.pnl.Controls)
            {
                if (itemBtn.Tag.ToString() == "0")
                {
                    tmp = itemBtn;
                    break;
                }
            }
            if (btn.TabIndex == tmp.TabIndex - 1 ||
                    btn.TabIndex == tmp.TabIndex + 1 ||
                    btn.TabIndex == tmp.TabIndex - col ||
                    btn.TabIndex == tmp.TabIndex + col
                    )
            {
                tmp.BackgroundImage = btn.BackgroundImage;
                tmp.Tag = btn.Tag;
                btn.BackgroundImage = null;
                btn.Tag = 0;
            }
            checkResult();
        }
        public void checkResult()
        {
            int index = 1;
            foreach (Button itemBtn in this.pnl.Controls)
            {
                if(int.Parse(itemBtn.Tag.ToString()) != 0 && int.Parse(itemBtn.Tag.ToString()) != index)
                {
                    return ;
                }
                index++;
            }
            MessageBox.Show("You win");
            deleteClick();
            btnPlay.Text = "Play";
        }
        public void deleteClick()
        {
            foreach (Button itemBtn in this.pnl.Controls)
            {
                itemBtn.Click -= wrapBtn;
            }
        }
        private void cb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            btnPlay.Text = "Play";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            lbTime.Text = "Time : " + time / 60 + ":" + time % 60; ;
            if (time == 0)
            {
                deleteClick();
                btnPlay.Text = "Play";
                timer1.Stop();
                MessageBox.Show("Bạn thua");
            }
        }
        private void btnTime_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (pnlAbout.Visible == true)
            {
                pnlAbout.Visible = false;
            }
            else
            {
                pnlAbout.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }
    }
}
