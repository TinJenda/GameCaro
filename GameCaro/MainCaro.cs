using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public delegate void SendUsername(string Username1, string Username2, string Userfirst);
    
    public partial class MainCaro : Form
    {
        public string user1;
        public string user2;
        public string userfirst;
        public string userWin;
        TaoBanCo BanCo;
        public void setValue(string Username1, string Username2, string Userfirst)
        {
            // ten mà muốn hiển thị ở frm chính (txtUs1: textBox mình đặt tên)
            user1 = Username1.ToUpper();
            user2 = Username2.ToUpper();
            userfirst = Userfirst;
        }

        public MainCaro()
        {
            InitializeComponent();
            BanCo = new TaoBanCo(pnlBanCo, userImage);
            BanCo.KetThucGameEvent += BanCo_KetThucGameEvent;
            BanCo.PlayerClickEvent += BanCo_PlayerClickEvent;
            //prcbtime
            prcbTime.Step = LuuBien.STEP; //số lần nhãy trong prcb
            prcbTime.Maximum = LuuBien.TIME; //maximum timer trong prcb
            prcbTime.Value = 0; //giá trị ban đầu 

            //timer
            Timer_Time.Interval = LuuBien.INTERVAL; //số lần để sự kiện timer nhãy
            NewGame();
        }
        int dem = 0;
        private void EndGame()
        {

            Timer_Time.Stop();
            if(User1.Text==user1)
            {
                userWin = user2;
            }
            else
            {
                userWin = user1;
            }
            TaoBanCo banco = new TaoBanCo();
                    MessageBox.Show("NGƯỜI CHƠI " + userWin + " THẮNG SAU " + dem + " LƯỢT CHƠI!", "WINNNNN",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);   
                     DialogResult traloi = (MessageBox.Show("BẠN MUỐN ĐẤU LẠI HAY KHÔNG", "THÔNG BÁO",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question));
                    if (traloi == DialogResult.Yes)
                    {
                        NewGame();
                    }
                    else
                    {
                        pnlBanCo.Enabled = false;
                        dem = 0;
                     }
            
        }
     
        private void BanCo_PlayerClickEvent(object sender, EventArgs e)
        {
            Timer_Time.Start();
            prcbTime.Value = 0;
            dem++;
            if (User1.Text == user1)
            {
                User1.Text = user2;
            }
            else
            {
                User1.Text = user1;
            }
        }

        private void BanCo_KetThucGameEvent(object sender, EventArgs e)
        {
            EndGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBanCo.Enabled = false;
        }

        private void Timer_Time_Tick(object sender, EventArgs e)
        {
            prcbTime.PerformStep();     //khởi động nè  
            if (prcbTime.Value >= prcbTime.Maximum)
            {
                EndGame();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void NewGame()
        {
            if(userfirst== "User 1")
            {
                User1.Text = user1;
            }
            else
            {
                User1.Text = user2;
            }
            prcbTime.Value = 0;
            Timer_Time.Stop();
            BanCo.veBanCo();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame frmNG = new NewGame(setValue);
            frmNG.ShowDialog();
            NewGame();
        }

        private void MainCaro_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult traloi = (MessageBox.Show("ĐỒNG Ý THOÁT GAME?", "EXIT",
             MessageBoxButtons.OKCancel,
             MessageBoxIcon.Question));
            if (traloi != DialogResult.OK)
            {
                e.Cancel = true;
            };

        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            // TaoBanCo banc2o=new TaoBanCo();

        }
       
        private void time_label_Tick(object sender, EventArgs e)
        {  
            if (label_info.Top<-50)
            {
                label_info.Top += 100;
            }
            else
            {
               label_info.Top -= 1; ;
            }

        }
        public void btn()
        {

            //for (int i = 0; i < LuuBien.banco_cao; i++)
            //{
            //    for (int j = 0; j < LuuBien.banco_rong; j++)
            //    {
            //        btn.FlatStyle = FlatStyle.Flat;
            //        btn.BackColor = Color.GhostWhite;
            //        btn.FlatAppearance.BorderSize = 1;
            //        btn.Name = "btn" + i + j;
            //        btn.FlatAppearance.BorderColor = Color.SteelBlue;
            //        btn.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
            //        //btn.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            //        btn.Click += Btn_Click; //sự kiện click btn
            //        BanCo1.Controls.Add(btn);
            //        Matrix[i].Add(btn); //add các button vào mảng
            //        btnFirst = btn;
            //    }
            //    btnFirst.Location = new Point(5, btnFirst.Location.Y + LuuBien.oco_cao); //vẽ tiếp dòng tiếp theo
            //    btnFirst.Width = 0;
            //    btnFirst.Height = 0;
            //}
        }
    }
}
