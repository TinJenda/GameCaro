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
    public partial class NewGame : Form
    {
        event SendUsername send;
        public NewGame(SendUsername sender)
        {
            InitializeComponent();
            this.send = sender;
        }
        
        public NewGame()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewGame_Load(object sender, EventArgs e)
        {
            cbuser.Items.Add("User 1");
            cbuser.Items.Add("User 2");
            cbuser.SelectedIndex = 0;
            cbKieuChoi.Items.Add("Không đếm giờ");
            cbKieuChoi.Items.Add("Đếm giờ");
            cbKieuChoi.SelectedIndex = 0;
         
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            if(txtMuc.Text==""|| txtMuc.Text == null)
            {
                this.send(txtUser1.Text, txtUser2.Text, cbuser.Text, cbKieuChoi.Text, txtMuc.Text);
                this.Close();
            }
            else
            { 
            if ((Int32.Parse(txtMuc.Text)<1 || Int32.Parse(txtMuc.Text) > 60) && txtMuc.Enabled==true)
            {
                    toolTip1.Show("Giá trị từ 1->60!!!", txtMuc);
                }
            else
            {
            // gửi user name qua FormMAIN        
              this.send(txtUser1.Text, txtUser2.Text, cbuser.Text, cbKieuChoi.Text,txtMuc.Text);
              this.Close();
            }
            }
        }

        private void cbuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbKieuChoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKieuChoi.Text== "Không đếm giờ")
            {
                txtMuc.Enabled = false;
            }
            else
            {
                txtMuc.Enabled = true;
            }
        }

        private void txtMuc_TextChanged(object sender, EventArgs e)
        {
          
        }
        //private int kiemtra()
        //{
        //    int n = 0;
        //    if (int.TryParse(this.txtMuc.Text, out n))
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}

        private void txtMuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtMuc_MouseHover(object sender, EventArgs e)
        {
           // toolTip1.Show("Giá trị từ 1->60!!!",txtMuc);
        }
    }
}
