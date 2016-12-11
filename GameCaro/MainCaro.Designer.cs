namespace GameCaro
{
    partial class MainCaro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCaro));
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRedo = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.btnSetName = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.prcbTime = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.Timer_Time = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Timer(this.components);
            this.userImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlBanCo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBanCo.Location = new System.Drawing.Point(265, 12);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(536, 513);
            this.pnlBanCo.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.btnRedo);
            this.panel3.Controls.Add(this.UserName);
            this.panel3.Controls.Add(this.btnSetName);
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnUndo);
            this.panel3.Controls.Add(this.btnNewGame);
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.prcbTime);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.userImage);
            this.panel3.Controls.Add(this.user);
            this.panel3.Location = new System.Drawing.Point(12, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 259);
            this.panel3.TabIndex = 2;
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedo.Font = new System.Drawing.Font("UTM Caviar", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.ForeColor = System.Drawing.Color.Maroon;
            this.btnRedo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedo.ImageKey = "(none)";
            this.btnRedo.Location = new System.Drawing.Point(126, 170);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(115, 36);
            this.btnRedo.TabIndex = 15;
            this.btnRedo.Text = "Redo";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click_1);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("UTM Avo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(60, 5);
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Size = new System.Drawing.Size(99, 29);
            this.UserName.TabIndex = 14;
            // 
            // btnSetName
            // 
            this.btnSetName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSetName.Font = new System.Drawing.Font("UTM Caviar", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetName.ForeColor = System.Drawing.Color.Maroon;
            this.btnSetName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetName.ImageKey = "(none)";
            this.btnSetName.Location = new System.Drawing.Point(8, 212);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(112, 36);
            this.btnSetName.TabIndex = 13;
            this.btnSetName.Text = "Option";
            this.btnSetName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetName.UseVisualStyleBackColor = false;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click_1);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("UTM Caviar", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Maroon;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPause.ImageKey = "(none)";
            this.btnPause.Location = new System.Drawing.Point(126, 128);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(112, 36);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "Pause";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "NEXT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.Font = new System.Drawing.Font("UTM Caviar", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.Maroon;
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.ImageKey = "(none)";
            this.btnUndo.Location = new System.Drawing.Point(8, 170);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(112, 36);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "Undo";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.Enabled = false;
            this.btnNewGame.Font = new System.Drawing.Font("UTM Caviar", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Maroon;
            this.btnNewGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGame.ImageKey = "(none)";
            this.btnNewGame.Location = new System.Drawing.Point(6, 128);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(117, 36);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("UTM Caviar", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.ImageKey = "(none)";
            this.btnThoat.Location = new System.Drawing.Point(126, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 36);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Quit";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // prcbTime
            // 
            this.prcbTime.Location = new System.Drawing.Point(8, 37);
            this.prcbTime.Name = "prcbTime";
            this.prcbTime.Size = new System.Drawing.Size(152, 23);
            this.prcbTime.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_info);
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 56);
            this.panel1.TabIndex = 3;
            // 
            // label_info
            // 
            this.label_info.Font = new System.Drawing.Font("UTM Caviar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(1, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(240, 53);
            this.label_info.TabIndex = 10;
            this.label_info.Text = "BÀI TẬP CUỐI KỲ\r\nCẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT\r\nGVGD: MAI TUẤN KHÔI\r\nSinh viên: " +
    "Trương Thành Tín\r\nMSSV: 14110205";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(56, 9);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(0, 25);
            this.user.TabIndex = 1;
            // 
            // Timer_Time
            // 
            this.Timer_Time.Tick += new System.EventHandler(this.Timer_Time_Tick);
            // 
            // time_label
            // 
            this.time_label.Enabled = true;
            this.time_label.Tick += new System.EventHandler(this.time_label_Tick);
            // 
            // userImage
            // 
            this.userImage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userImage.Location = new System.Drawing.Point(166, 3);
            this.userImage.Name = "userImage";
            this.userImage.Size = new System.Drawing.Size(75, 60);
            this.userImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userImage.TabIndex = 2;
            this.userImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GameCaro.Properties.Resources.Untitled_1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 248);
            this.panel2.TabIndex = 1;
            // 
            // MainCaro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 526);
            this.Controls.Add(this.pnlBanCo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainCaro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro V3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainCaro_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox userImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.ProgressBar prcbTime;
        private System.Windows.Forms.Timer Timer_Time;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer time_label;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button btnRedo;
    }
}

