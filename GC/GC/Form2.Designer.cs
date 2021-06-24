namespace GC
{
    partial class Form2
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenu4 = new System.Windows.Forms.Panel();
            this.btnDeal = new System.Windows.Forms.Button();
            this.pnlMenu2 = new System.Windows.Forms.Panel();
            this.pnlMenu3 = new System.Windows.Forms.Panel();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.pnlMenu1 = new System.Windows.Forms.Panel();
            this.setting = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.pnlGround = new System.Windows.Forms.Panel();
            this.usrProfile1 = new GC.User_Control.UsrProfile();
            this.usrHistory1 = new GC.User_Control.UsrHistory();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Purple;
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.pnlMenu4);
            this.pnlMenu.Controls.Add(this.btnDeal);
            this.pnlMenu.Controls.Add(this.pnlMenu2);
            this.pnlMenu.Controls.Add(this.pnlMenu3);
            this.pnlMenu.Controls.Add(this.btnHistory);
            this.pnlMenu.Controls.Add(this.btnCalculator);
            this.pnlMenu.Controls.Add(this.btnBuy);
            this.pnlMenu.Controls.Add(this.pnlMenu1);
            this.pnlMenu.Controls.Add(this.setting);
            this.pnlMenu.Controls.Add(this.title);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(414, 158);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.Visible = false;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(259, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 99);
            this.panel1.TabIndex = 1;
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(0, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(125, 29);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 33);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(125, 34);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMenu4
            // 
            this.pnlMenu4.Location = new System.Drawing.Point(243, 144);
            this.pnlMenu4.Name = "pnlMenu4";
            this.pnlMenu4.Size = new System.Drawing.Size(76, 10);
            this.pnlMenu4.TabIndex = 12;
            // 
            // btnDeal
            // 
            this.btnDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeal.FlatAppearance.BorderSize = 0;
            this.btnDeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.ForeColor = System.Drawing.Color.White;
            this.btnDeal.Location = new System.Drawing.Point(245, 106);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(74, 32);
            this.btnDeal.TabIndex = 11;
            this.btnDeal.Text = "DEAL";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // pnlMenu2
            // 
            this.pnlMenu2.Location = new System.Drawing.Point(114, 145);
            this.pnlMenu2.Name = "pnlMenu2";
            this.pnlMenu2.Size = new System.Drawing.Size(104, 10);
            this.pnlMenu2.TabIndex = 8;
            // 
            // pnlMenu3
            // 
            this.pnlMenu3.Location = new System.Drawing.Point(330, 144);
            this.pnlMenu3.Name = "pnlMenu3";
            this.pnlMenu3.Size = new System.Drawing.Size(81, 10);
            this.pnlMenu3.TabIndex = 10;
            // 
            // btnHistory
            // 
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Location = new System.Drawing.Point(330, 106);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(81, 32);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Text = "HISTORY";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.White;
            this.btnCalculator.Location = new System.Drawing.Point(114, 107);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(104, 32);
            this.btnCalculator.TabIndex = 8;
            this.btnCalculator.Text = "CALCULATOR";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(0, 106);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(81, 32);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // pnlMenu1
            // 
            this.pnlMenu1.Location = new System.Drawing.Point(3, 144);
            this.pnlMenu1.Name = "pnlMenu1";
            this.pnlMenu1.Size = new System.Drawing.Size(78, 10);
            this.pnlMenu1.TabIndex = 6;
            // 
            // setting
            // 
            this.setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setting.FlatAppearance.BorderSize = 0;
            this.setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting.Image = global::GC.Properties.Resources.Untitled1;
            this.setting.Location = new System.Drawing.Point(378, 27);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(24, 30);
            this.setting.TabIndex = 1;
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(3, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(195, 19);
            this.title.TabIndex = 1;
            this.title.Text = "GARBAGE COLLECTOR";
            // 
            // pnlGround
            // 
            this.pnlGround.Controls.Add(this.usrHistory1);
            this.pnlGround.Controls.Add(this.usrProfile1);
            this.pnlGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGround.Location = new System.Drawing.Point(0, 158);
            this.pnlGround.Name = "pnlGround";
            this.pnlGround.Size = new System.Drawing.Size(414, 438);
            this.pnlGround.TabIndex = 2;
            // 
            // usrProfile1
            // 
            this.usrProfile1.Location = new System.Drawing.Point(0, 0);
            this.usrProfile1.Name = "usrProfile1";
            this.usrProfile1.Size = new System.Drawing.Size(414, 445);
            this.usrProfile1.TabIndex = 0;
            this.usrProfile1.Visible = false;
            // 
            // usrHistory1
            // 
            this.usrHistory1.Location = new System.Drawing.Point(0, 0);
            this.usrHistory1.Name = "usrHistory1";
            this.usrHistory1.Size = new System.Drawing.Size(414, 435);
            this.usrHistory1.TabIndex = 1;
            this.usrHistory1.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 596);
            this.Controls.Add(this.pnlGround);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlGround.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel pnlMenu2;
        private System.Windows.Forms.Panel pnlMenu3;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Panel pnlMenu1;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel pnlMenu4;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Panel pnlGround;
        private User_Control.UsrProfile usrProfile1;
        private User_Control.UsrHistory usrHistory1;
    }
}