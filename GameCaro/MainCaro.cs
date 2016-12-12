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
    public delegate void SendUsername(string Username1, string Username2, string Userfirst, string Kieuchoi,String Muc);
    
    public partial class MainCaro : Form
    {
        public string user1;
        public string user2;
        public string kieuchoi;
        public string userfirst;
        public string userWin;
        public string muc;
        TaoBanCo BanCo;
        public void setValue(string Username1, string Username2, string Userfirst, string Kieuchoi, string Muc)
        {
            // ten mà muốn hiển thị ở frm chính (txtUs1: textBox mình đặt tên)
            //user1 = Username1.ToUpper();
            //user2 = Username2.ToUpper();
            user1 = Username1;
            user2 = Username2;
            kieuchoi = Kieuchoi;
            userfirst = Userfirst;
            muc = Muc;
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
        int dem = 0, demUndo = 0,demRedo=0;
        private void EndGame()
        { 
            Timer_Time.Stop();
            btnPause.Enabled = false;
            btnRedo.Enabled = false;
            btnUndo.Enabled = false;
            if (UserName.Text==user1)
            {
                userWin = user2;
            }
            else
            {
                userWin = user1;
            }
            TaoBanCo banco = new TaoBanCo();
                    MessageBox.Show("Người chơi " + userWin + " thắng sau " + dem + " lượt chơi!", "WINNNNN",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            // DialogResult traloi = (MessageBox.Show("BẠN MUỐN ĐẤU LẠI HAY KHÔNG", "THÔNG BÁO",
            // MessageBoxButtons.YesNo,
            // MessageBoxIcon.Question));
            //if (traloi == DialogResult.Yes)
            //{
            //    NewGame();
            //}
            //else
            //{
            //    pnlBanCo.Enabled = false;
            //    dem = 0;
            // }
            pnlBanCo.Enabled = false;
       
            dem = 0;
            demUndo = 0;
            demRedo = 0;
        }
       

        void undo()
        {
            BanCo.undo();
        }
        private void BanCo_PlayerClickEvent(object sender, EventArgs e) //sự kiện bàn cờ có người click /rất hay click_
        {
           
            if (kieuchoi == "Đếm giờ")
            {
                Timer_Time.Start();
            }
            else
            {
                  Timer_Time.Stop();
            }
            prcbTime.Value = 0;
            dem++;
            demUndo++;
            demRedo = 0;
            btnRedo.Enabled = false;
            doiten();
            btnUndo.Enabled = true;
        }
        void doiten()
        {
            if (UserName.Text == user1)
            {
                UserName.Text = user2;
            }
            else
            {
                UserName.Text = user1;
            }
        }
        private void BanCo_KetThucGameEvent(object sender, EventArgs e)
        {
            EndGame();
            btnUndo.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBanCo.Enabled = false;
            userImage.Visible = false;
            btnPause.Enabled = false;
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
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
        void nguoiChondau()
        {
            if (userfirst == "User 1")
            {
                UserName.Text = user1;
            }
            else
            {
                UserName.Text = user2;
            }
        }
        void NewGame()
        {
            nguoiChondau();
            prcbTime.Value = 0;
            Timer_Time.Stop();
            BanCo.veBanCo(); 
            userImage.Visible = true;
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
            demRedo = 0;
            demUndo = 0;
            dem = 0;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        { 
            if(kieuchoi=="Đếm giờ")
            {
                NewGame();
                prcbTime.Maximum = (Int32.Parse(muc)) * 1000;
                btnPause.Text = "Pause"; //khi kích vào có thể đang lúc btn bằng thằng resum... set lại giá trị
                btnPause.Image = (Image.FromFile(Application.StartupPath + "\\Resources\\play.png"));
                btnPause.Enabled = true;
            }
            else
            {
                NewGame();
                btnPause.Text = "Pause";
                btnPause.Image = (Image.FromFile(Application.StartupPath + "\\Resources\\play.png"));
                btnPause.Enabled = false;
            }
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
            Button btn = new Button();
            for (int i = 0; i < LuuBien.banco_cao; i++)
            {
                for (int j = 0; j < LuuBien.banco_rong; j++)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.GhostWhite;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Name = "btn" + i.ToString() + j.ToString();
                    btn.FlatAppearance.BorderColor = Color.Red;
                    btn.FlatAppearance.MouseOverBackColor = Color.Red;
                    //btn.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
                }
    
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //phím tắt
        {
            
            switch (keyData)
            {
                case (Keys.Control | Keys.N):
                    if (btnNewGame.Enabled == true)
                        btnNewGame_Click(null, null);
                    return true;
                case (Keys.Control | Keys.P):
                    if(btnPause.Enabled==true)
                     btnPause_Click(null, null);
                    return true;
                case (Keys.Control | Keys.Z):
                    if (btnUndo.Enabled == true)
                        btnUndo_Click(null, null);
                    return true;
                case (Keys.Control | Keys.R):
                    if (btnRedo.Enabled == true)
                        btnRedo_Click_1(null, null);
                    return true;
                case (Keys.Control | Keys.O):
                    btnSetName_Click_1(null, null);
                    return true;
                case (Keys.Control | Keys.Q):
                    Application.Exit();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            btnRedo.Enabled = true;
            undo();
            prcbTime.Value = 0;
            doiten();
            demUndo--;
            demRedo++;
            if (demUndo < 1)
            {
                btnUndo.Enabled = false;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(btnPause.Text=="Pause")
            {
                pnlBanCo.Enabled = false;
                btnPause.Text = "Resume";
                Timer_Time.Stop();
                btnPause.Image = (Image.FromFile(Application.StartupPath + "\\Resources\\play.png"));   
                // temp = prcbTime.Value;
            }
            else
            if (btnPause.Text == "Resume")
            {
                 
                pnlBanCo.Enabled = true;
                btnPause.Text = "Pause";
             //   prcbTime.Value = temp;
             if(kieuchoi=="Đếm giờ")
                  Timer_Time.Start();
                btnPause.Image = (Image.FromFile(Application.StartupPath + "\\Resources\\pause.png"));
               
                btnRedo.Enabled = true;
                btnUndo.Enabled = true;
            };
           
        }
        void redo()
        {
            BanCo.redo();
        }

    

        private void btnRedo_Click_1(object sender, EventArgs e)
        {
            redo();
            doiten();
            prcbTime.Value = 0;
            --demRedo;
            demUndo++;
            if(demRedo<1)
            {
                btnRedo.Enabled = false;
            }
            btnUndo.Enabled = true;
        }

        private void btnSetName_Click_1(object sender, EventArgs e)
        {
            Timer_Time.Stop();
            NewGame frmNG = new NewGame(setValue);
            frmNG.ShowDialog();
            //pnlBanCo.Enabled = false;
            //btnPause.Enabled = true;
            btnNewGame.Enabled = true;
        }

        
    }
}
