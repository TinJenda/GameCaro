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
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
           
              // gửi user name qua FormMAIN
                this.send(txtUser1.Text, txtUser2.Text, cbuser.Text);
            
                this.Close();
        }

        private void cbuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
