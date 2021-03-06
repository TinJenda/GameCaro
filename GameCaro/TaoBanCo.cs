﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    //public delegate void SendUsername(string Username1, string Username2);
    public class TaoBanCo
    {
        #region khaibao
        private Panel BanCo;
        public Panel BanCo1
        {
            get
            {
                return BanCo;
            }

            set
            {
                BanCo = value;
            }
        }
        private int chonNguoiChoi;
        public int ChonNguoiChoi
        {
            get
            {
                return chonNguoiChoi;
            }

            set
            {
                chonNguoiChoi = value;
            }
        }
       
        private Stack<Point> taoredo;
        private Stack<Point> lichsuchoi;//ham nay luu toa do, xu ly theo toa do 

        public Stack<Point> Lichsuchoi
        {
            get
            {
                return lichsuchoi;
            }

            set
            {
                lichsuchoi = value;
            }
        }
        #endregion
        public TaoBanCo(Panel BanCo,PictureBox anh) //ve tren pane
        {
            this.BanCo1 = BanCo;
            
            this.anh = anh;
            this.Player = new List<Player>() //2 phayer
            {
                new Player(Image.FromFile(Application.StartupPath+"\\Resources\\x.png")),
                new Player(Image.FromFile(Application.StartupPath+"\\Resources\\o.png"))
            }; //list player, ở đây 2 người.
            lichsuchoi = new Stack<Point>();
            taoredo = new Stack<Point>();
        }
        public bool undo()
        {
            if(lichsuchoi.Count()!=0)
            {
            Point oldPoint = lichsuchoi.Pop(); //Gỡ bỏ và trả về đối tượng tại trên cùng của Stack
            Button btn = matrix[oldPoint.X][oldPoint.Y];
            taoredo.Push(oldPoint);
            btn.BackgroundImage = null;
            chonNguoiChoi = chonNguoiChoi == 1 ? 0 : 1; //xem lại
            doiNguoiChoi();
            }
              return false;   
        }
        //int chonnguoichoi()
        //{
        //    if(chonNguoiChoi==1)
        //    {
        //        chonNguoiChoi = 0; 
        //    }
        //    else
        //    {
        //        chonNguoiChoi = 1;
        //    }
        //    return chonNguoiChoi;
        //}
        public bool redo()
        {
            if(taoredo.Count()!=0)
            {  
            Point poinredo = taoredo.Pop();
            Button btn = matrix[poinredo.X][poinredo.Y];
            lichsuchoi.Push(layToaDo(btn));
            xetNguoiChoi(btn);
            chonNguoiChoi = chonNguoiChoi == 1 ? 0 : 1; //xem lại
            doiNguoiChoi();
            }
            return false;
        }
        public TaoBanCo()
        {
        }
        private PictureBox anh;
        private List<Player> Player;
        public List<Player> Player1
        {
            get
            {
                return Player;
            }

            set
            {
                Player = value;
            }
        }

      

        public PictureBox Anh
        {
            get
            {
                return anh;
            }

            set
            {
                anh = value;
            }
        }  
        public void veBanCo()
        {
            BanCo.Enabled = true;
            BanCo.Controls.Clear();

            ChonNguoiChoi = 0;
            doiNguoiChoi();

            Matrix = new List<List<Button>>(); //lấy list 
            Button btnFirst = new Button()
            { Width = 0, Location = new Point(5, 5) }; //set vi tri ban dau bang 5 de dep ti.
            for (int i = 0; i < LuuBien.banco_cao; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < LuuBien.banco_rong; j++)
                {
                    Button btn = new Button()
                    {
                        Width = LuuBien.oco_rong,
                        Height = LuuBien.oco_cao,
                        Location = new Point(btnFirst.Location.X + btnFirst.Width,
                        btnFirst.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString() //lưu text truoc xuốg dòng sau lay' i=> doc de hon
                    };
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.GhostWhite;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Name = "btn" + i.ToString() + "" + j.ToString();
                    btn.FlatAppearance.BorderColor = Color.SteelBlue;
                    btn.FlatAppearance.MouseOverBackColor = Color.PaleTurquoise;
                 //btn.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
                    btn.Click += Btn_Click; //sự kiện click btn
                    BanCo1.Controls.Add(btn);
                    Matrix[i].Add(btn); //add các button vào mảng
                    btnFirst = btn;
                }
                btnFirst.Location = new Point(5, btnFirst.Location.Y + LuuBien.oco_cao); //vẽ tiếp dòng tiếp theo
                btnFirst.Width = 0;
                btnFirst.Height = 0;
            }
        }
        //lỗi lun bắt đầu từ thèn trước, cải thiện nó... chọn người chơi trước.
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackgroundImage != null)
                return;

            xetNguoiChoi(btn); //xem dang danh la hinh j
            chonNguoiChoi = chonNguoiChoi == 1 ? 0 : 1; //xem lại
            doiNguoiChoi(); //đổi người chơi <anh choi>
            lichsuchoi.Push(layToaDo(btn));
           // taoredo.Push(layToaDo(btn));
            if (playerClickEvent != null)
            {
                playerClickEvent(this, new EventArgs());
            }
            if (kiemTraGame(btn)) 
            {
                ketThucGame();//kết thúc gọi tới đây
            }  
        }
        
        private void xetNguoiChoi(Button btn) //btn nguoi choi
        {
            btn.BackgroundImage = Player[chonNguoiChoi].Anh;   
        }
        private void doiNguoiChoi() //anh nguoi choi
        {
            anh.Image = Player[chonNguoiChoi].Anh;
        }
       
        private List<List<Button>> matrix; //tạo ma trận lưu thành mảng

      

        public List<List<Button>> Matrix
        {
            get
            {
                return matrix;
            }

            set
            {
                matrix = value;
            }
        }

        public Stack<Point> Taoredo
        {
            get
            {
                return taoredo;
            }

            set
            {
                taoredo = value;
            }
        }

        private Point layToaDo(Button btn) //lấy tọa đó btn hiện tại
        {
            int toaDoDoc = Convert.ToInt32(btn.Tag); //tag định nghĩa để lấy i-cao ở trên
            int toaDoNgang = Matrix[toaDoDoc].IndexOf(btn); //lấy tọa độ btn nằm trong ma trận
            Point point = new Point(toaDoDoc,toaDoNgang);
            return point;
        }
        #region thangthua
        private bool kiemTraGame(Button btn) //mặc định là sai, kiểm tra game kthúc chưa
        {
            return kiemTraNgang(btn) || kiemTraDoc(btn) || kiemTraCheoPhu(btn) || kiemTraCheoChinh(btn);
        }
        private bool kiemTraNgang(Button btn) //mặc định là sai, kiểm tra game kthúc chưa
        {
            Point point = layToaDo(btn);
            int demTrai = 0;
            for(int i=point.Y;i>=0;i--) //giữ thèn xm thay đổi thèn y, (x,y) đếm sang trái
            {
                if (Matrix[point.X][i].BackgroundImage == btn.BackgroundImage)
                    demTrai++;
                else
                    break;
            }
            int demPhai = 0;
            for (int i = point.Y+1; i < LuuBien.banco_rong; i++)
            {
                if (Matrix[point.X][i].BackgroundImage == btn.BackgroundImage)
                    demPhai++;
                else
                    break;
            }
            return demTrai+demPhai>=5;
        }
        private bool kiemTraDoc(Button btn) //mặc định là sai, kiểm tra game kthúc chưa
        {
            Point point = layToaDo(btn);
            int demTren = 0;
            for (int i = point.X; i >= 0; i--) // (giữ tọa độ i, thay đỗi X đếm trên.)
            {
                if (Matrix[i][point.Y].BackgroundImage == btn.BackgroundImage)
                    demTren++;
                else
                    break;
            }
            int demDuoi = 0;
            for (int i = point.X + 1; i < LuuBien.banco_cao; i++) // (giữ tọa độ i, thay đỗi X đếm dưới.)
            {
                if (Matrix[i][point.Y].BackgroundImage == btn.BackgroundImage)
                    demDuoi++;
                else
                    break;
            }
            return demTren + demDuoi >= 5;
        }
        private bool kiemTraCheoChinh(Button btn) //mặc định là sai, kiểm tra game kthúc chưa
        {
            Point point = layToaDo(btn);
            int demCheoTren = 0; //đếm số lần image giống nắm ở trên
            for (int i = 0; i <=point.X; i++) 
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (Matrix[point.X-i][point.Y-i].BackgroundImage == btn.BackgroundImage)
                    demCheoTren++;
                else
                    break;
            }
            int demCheoDuoi = 0;
            for (int i = 1 ; i < LuuBien.banco_cao-point.X; i++)  //chạy với số lần chiều cao-đi tọa độ điẻm x, tiết kiệm bọ nhớ
            {
                if (point.X + i > LuuBien.banco_cao || point.Y+i> LuuBien.banco_rong)
                    break;         
                if (Matrix[point.X+i][point.Y+i].BackgroundImage == btn.BackgroundImage)
                    demCheoDuoi++;
                else
                    break;
            }
            return demCheoTren + demCheoDuoi >= 5;
           
        }
        private bool kiemTraCheoPhu(Button btn) //mặc định là sai, kiểm tra game kthúc chưa
        {
            Point point = layToaDo(btn);
            int demCheoTren = 0; //đếm số lần image giống nắm /ở trên
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y + i > LuuBien.banco_rong)
                    break;
                if (Matrix[point.X - i][point.Y + i].BackgroundImage == btn.BackgroundImage)
                    demCheoTren++;
                else
                    break;
            }
            int demCheoDuoi = 0;
            for (int i = 1; i < LuuBien.banco_cao - point.X; i++)  //chạy với số lần chiều cao-đi tọa độ điẻm x, tiết kiệm bọ nhớ
            {
                if (point.X + i > LuuBien.banco_cao || point.Y - i <0)
                    break;
                if (Matrix[point.X + i][point.Y - i].BackgroundImage == btn.BackgroundImage)
                    demCheoDuoi++;
                else
                    break;
            }
            return demCheoTren + demCheoDuoi >= 5;
        }


        #endregion
        #region Tạo sự kiện EndGame và clickgame
        private event EventHandler playerClickEvent; //tạo event thôg báo người chơi đã click
        public event EventHandler PlayerClickEvent
        {
            add
            {
                playerClickEvent += value;
            }
            remove
            {
                playerClickEvent -= value;
            }
        }

        private event EventHandler ketThucGameEvent;
        public event EventHandler KetThucGameEvent //tạo event kết thúc game
        {
            add
            {
                ketThucGameEvent += value;
            }
            remove
            {
                ketThucGameEvent -= value;
            }
        }
        public void ketThucGame() //nếu kết thúc thì gọi tới đây
        {
            if(ketThucGameEvent!=null)
            {
                ketThucGameEvent(this, new EventArgs()); //kích hoạt event.
            }
        }
        #endregion
    }
}
