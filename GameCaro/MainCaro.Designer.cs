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
            this.User1 = new System.Windows.Forms.Label();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.prcbTime = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_info = new System.Windows.Forms.Label();
            this.userImage = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.Timer_Time = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.time_label = new System.Windows.Forms.Timer(this.components);
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
            this.panel3.Controls.Add(this.User1);
            this.panel3.Controls.Add(this.btnCaiDat);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnUndo);
            this.panel3.Controls.Add(this.btnRedo);
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
            // User1
            // 
            this.User1.AutoSize = true;
            this.User1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User1.Location = new System.Drawing.Point(56, 9);
            this.User1.Name = "User1";
            this.User1.Size = new System.Drawing.Size(93, 25);
            this.User1.TabIndex = 2;
            this.User1.Text = "Tên User";
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaiDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaiDat.Font = new System.Drawing.Font("Pristina", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.Maroon;
            this.btnCaiDat.Location = new System.Drawing.Point(13, 212);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(111, 36);
            this.btnCaiDat.TabIndex = 12;
            this.btnCaiDat.Text = "CÀI ĐẶT";
            this.btnCaiDat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaiDat.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "NEXT";
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUndo.Font = new System.Drawing.Font("Pristina", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.Maroon;
            this.btnUndo.Location = new System.Drawing.Point(8, 170);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(111, 36);
            this.btnUndo.TabIndex = 10;
            this.btnUndo.Text = "UNDO";
            this.btnUndo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUndo.UseVisualStyleBackColor = false;
            // 
            // btnRedo
            // 
            this.btnRedo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRedo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRedo.Font = new System.Drawing.Font("Pristina", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedo.ForeColor = System.Drawing.Color.Maroon;
            this.btnRedo.Location = new System.Drawing.Point(130, 170);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(111, 36);
            this.btnRedo.TabIndex = 9;
            this.btnRedo.Text = "REDO";
            this.btnRedo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.Font = new System.Drawing.Font("Pristina", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Maroon;
            this.btnNewGame.Location = new System.Drawing.Point(6, 128);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(235, 36);
            this.btnNewGame.TabIndex = 6;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThoat.Font = new System.Drawing.Font("Pristina", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Maroon;
            this.btnThoat.Location = new System.Drawing.Point(130, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 36);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.label_info.Font = new System.Drawing.Font("UTM Nyala", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(1, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(240, 53);
            this.label_info.TabIndex = 10;
            this.label_info.Text = "BÀI TẬP CUỐI KỲ\r\nCẤU TRÚC DỮ LIỆU VÀ GIẢI THUẬT\r\nGVHD: MAI TUẤN KHÔI\r\nSinh viên: " +
    "Trương Thành Tín\r\nMSSV: 14110205";
            this.label_info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // panel2
            // 
            this.panel2.BackgroundImage = global::GameCaro.Properties.Resources.caro;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 248);
            this.panel2.TabIndex = 1;
            // 
            // time_label
            // 
            this.time_label.Enabled = true;
            this.time_label.Tick += new System.EventHandler(this.time_label_Tick);
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
            this.Text = "Game Caro V1.0";
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
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Timer time_label;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label User1;
    }
}

