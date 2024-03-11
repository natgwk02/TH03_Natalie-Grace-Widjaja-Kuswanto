namespace TH03_Natalie_Grace_Widjaja_Kuswanto
{
    partial class Form1
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
            this.tb_username1 = new System.Windows.Forms.TextBox();
            this.tb_password1 = new System.Windows.Forms.TextBox();
            this.lb_ucbank = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.panel_login = new System.Windows.Forms.Panel();
            this.lb_username2 = new System.Windows.Forms.Label();
            this.lb_password2 = new System.Windows.Forms.Label();
            this.lb_ucbank2 = new System.Windows.Forms.Label();
            this.tb_username2 = new System.Windows.Forms.TextBox();
            this.tb_password2 = new System.Windows.Forms.TextBox();
            this.btn_register2 = new System.Windows.Forms.Button();
            this.panel_register = new System.Windows.Forms.Panel();
            this.panel_mainview = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_balance = new System.Windows.Forms.Label();
            this.btn_deposit = new System.Windows.Forms.Button();
            this.btn_withdraw = new System.Windows.Forms.Button();
            this.lb_ucbank3 = new System.Windows.Forms.Label();
            this.lb_balancenyaa = new System.Windows.Forms.Label();
            this.panel_deposit = new System.Windows.Forms.Panel();
            this.lb_deposit = new System.Windows.Forms.Label();
            this.tb_deposit = new System.Windows.Forms.TextBox();
            this.btn_logout2 = new System.Windows.Forms.Button();
            this.btn_deposit2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel_withdraww = new System.Windows.Forms.Panel();
            this.lb_withdraw = new System.Windows.Forms.Label();
            this.tb_withdraw = new System.Windows.Forms.TextBox();
            this.btn_logout3 = new System.Windows.Forms.Button();
            this.btn_withdraw2 = new System.Windows.Forms.Button();
            this.panel_withdraw = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_login.SuspendLayout();
            this.panel_register.SuspendLayout();
            this.panel_mainview.SuspendLayout();
            this.panel_deposit.SuspendLayout();
            this.panel_withdraww.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_username1
            // 
            this.tb_username1.Location = new System.Drawing.Point(90, 51);
            this.tb_username1.Name = "tb_username1";
            this.tb_username1.Size = new System.Drawing.Size(100, 20);
            this.tb_username1.TabIndex = 0;
            // 
            // tb_password1
            // 
            this.tb_password1.Location = new System.Drawing.Point(90, 80);
            this.tb_password1.Name = "tb_password1";
            this.tb_password1.Size = new System.Drawing.Size(100, 20);
            this.tb_password1.TabIndex = 1;
            // 
            // lb_ucbank
            // 
            this.lb_ucbank.AutoSize = true;
            this.lb_ucbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ucbank.Location = new System.Drawing.Point(38, 7);
            this.lb_ucbank.Name = "lb_ucbank";
            this.lb_ucbank.Size = new System.Drawing.Size(130, 31);
            this.lb_ucbank.TabIndex = 2;
            this.lb_ucbank.Text = "UC Bank";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(28, 54);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(58, 13);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(30, 83);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(56, 13);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(71, 116);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(71, 145);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.btn_register);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.lb_password);
            this.panel_login.Controls.Add(this.lb_username);
            this.panel_login.Controls.Add(this.lb_ucbank);
            this.panel_login.Controls.Add(this.tb_password1);
            this.panel_login.Controls.Add(this.tb_username1);
            this.panel_login.Location = new System.Drawing.Point(34, 10);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(213, 181);
            this.panel_login.TabIndex = 7;
            // 
            // lb_username2
            // 
            this.lb_username2.AutoSize = true;
            this.lb_username2.Location = new System.Drawing.Point(32, 54);
            this.lb_username2.Name = "lb_username2";
            this.lb_username2.Size = new System.Drawing.Size(61, 13);
            this.lb_username2.TabIndex = 8;
            this.lb_username2.Text = "Username: ";
            // 
            // lb_password2
            // 
            this.lb_password2.AutoSize = true;
            this.lb_password2.Location = new System.Drawing.Point(32, 80);
            this.lb_password2.Name = "lb_password2";
            this.lb_password2.Size = new System.Drawing.Size(56, 13);
            this.lb_password2.TabIndex = 9;
            this.lb_password2.Text = "Password:";
            // 
            // lb_ucbank2
            // 
            this.lb_ucbank2.AutoSize = true;
            this.lb_ucbank2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ucbank2.Location = new System.Drawing.Point(38, 17);
            this.lb_ucbank2.Name = "lb_ucbank2";
            this.lb_ucbank2.Size = new System.Drawing.Size(130, 31);
            this.lb_ucbank2.TabIndex = 10;
            this.lb_ucbank2.Text = "UC Bank";
            // 
            // tb_username2
            // 
            this.tb_username2.Location = new System.Drawing.Point(90, 51);
            this.tb_username2.Name = "tb_username2";
            this.tb_username2.Size = new System.Drawing.Size(100, 20);
            this.tb_username2.TabIndex = 11;
            // 
            // tb_password2
            // 
            this.tb_password2.Location = new System.Drawing.Point(90, 77);
            this.tb_password2.Name = "tb_password2";
            this.tb_password2.Size = new System.Drawing.Size(100, 20);
            this.tb_password2.TabIndex = 12;
            // 
            // btn_register2
            // 
            this.btn_register2.Location = new System.Drawing.Point(68, 113);
            this.btn_register2.Name = "btn_register2";
            this.btn_register2.Size = new System.Drawing.Size(75, 23);
            this.btn_register2.TabIndex = 13;
            this.btn_register2.Text = "Register";
            this.btn_register2.UseVisualStyleBackColor = true;
            this.btn_register2.Click += new System.EventHandler(this.btn_register2_Click);
            // 
            // panel_register
            // 
            this.panel_register.Controls.Add(this.btn_register2);
            this.panel_register.Controls.Add(this.tb_password2);
            this.panel_register.Controls.Add(this.tb_username2);
            this.panel_register.Controls.Add(this.lb_ucbank2);
            this.panel_register.Controls.Add(this.lb_password2);
            this.panel_register.Controls.Add(this.lb_username2);
            this.panel_register.Location = new System.Drawing.Point(15, 10);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(232, 181);
            this.panel_register.TabIndex = 14;
            // 
            // panel_mainview
            // 
            this.panel_mainview.Controls.Add(this.btn_logout);
            this.panel_mainview.Controls.Add(this.lb_balance);
            this.panel_mainview.Controls.Add(this.btn_deposit);
            this.panel_mainview.Controls.Add(this.btn_withdraw);
            this.panel_mainview.Controls.Add(this.lb_ucbank3);
            this.panel_mainview.Controls.Add(this.lb_balancenyaa);
            this.panel_mainview.Location = new System.Drawing.Point(15, 10);
            this.panel_mainview.Name = "panel_mainview";
            this.panel_mainview.Size = new System.Drawing.Size(264, 216);
            this.panel_mainview.TabIndex = 15;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(144, 45);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 16;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lb_balance
            // 
            this.lb_balance.AutoSize = true;
            this.lb_balance.Location = new System.Drawing.Point(96, 70);
            this.lb_balance.Name = "lb_balance";
            this.lb_balance.Size = new System.Drawing.Size(35, 13);
            this.lb_balance.TabIndex = 15;
            this.lb_balance.Text = "label1";
            // 
            // btn_deposit
            // 
            this.btn_deposit.Location = new System.Drawing.Point(78, 89);
            this.btn_deposit.Name = "btn_deposit";
            this.btn_deposit.Size = new System.Drawing.Size(75, 23);
            this.btn_deposit.TabIndex = 14;
            this.btn_deposit.Text = "Deposit";
            this.btn_deposit.UseVisualStyleBackColor = true;
            this.btn_deposit.Click += new System.EventHandler(this.btn_deposit_Click);
            // 
            // btn_withdraw
            // 
            this.btn_withdraw.Location = new System.Drawing.Point(78, 118);
            this.btn_withdraw.Name = "btn_withdraw";
            this.btn_withdraw.Size = new System.Drawing.Size(75, 23);
            this.btn_withdraw.TabIndex = 13;
            this.btn_withdraw.Text = "Withdraw";
            this.btn_withdraw.UseVisualStyleBackColor = true;
            this.btn_withdraw.Click += new System.EventHandler(this.btn_withdraw_Click);
            // 
            // lb_ucbank3
            // 
            this.lb_ucbank3.AutoSize = true;
            this.lb_ucbank3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ucbank3.Location = new System.Drawing.Point(26, 18);
            this.lb_ucbank3.Name = "lb_ucbank3";
            this.lb_ucbank3.Size = new System.Drawing.Size(104, 25);
            this.lb_ucbank3.TabIndex = 10;
            this.lb_ucbank3.Text = "UC Bank";
            // 
            // lb_balancenyaa
            // 
            this.lb_balancenyaa.AutoSize = true;
            this.lb_balancenyaa.Location = new System.Drawing.Point(28, 68);
            this.lb_balancenyaa.Name = "lb_balancenyaa";
            this.lb_balancenyaa.Size = new System.Drawing.Size(49, 13);
            this.lb_balancenyaa.TabIndex = 8;
            this.lb_balancenyaa.Text = "Balance:";
            // 
            // panel_deposit
            // 
            this.panel_deposit.Controls.Add(this.lb_deposit);
            this.panel_deposit.Controls.Add(this.tb_deposit);
            this.panel_deposit.Controls.Add(this.btn_logout2);
            this.panel_deposit.Controls.Add(this.btn_deposit2);
            this.panel_deposit.Controls.Add(this.label3);
            this.panel_deposit.Controls.Add(this.label4);
            this.panel_deposit.Location = new System.Drawing.Point(12, 10);
            this.panel_deposit.Name = "panel_deposit";
            this.panel_deposit.Size = new System.Drawing.Size(288, 233);
            this.panel_deposit.TabIndex = 17;
            // 
            // lb_deposit
            // 
            this.lb_deposit.AutoSize = true;
            this.lb_deposit.Location = new System.Drawing.Point(38, 49);
            this.lb_deposit.Name = "lb_deposit";
            this.lb_deposit.Size = new System.Drawing.Size(35, 13);
            this.lb_deposit.TabIndex = 18;
            this.lb_deposit.Text = "label1";
            // 
            // tb_deposit
            // 
            this.tb_deposit.Location = new System.Drawing.Point(70, 91);
            this.tb_deposit.Name = "tb_deposit";
            this.tb_deposit.Size = new System.Drawing.Size(100, 20);
            this.tb_deposit.TabIndex = 17;
            // 
            // btn_logout2
            // 
            this.btn_logout2.Location = new System.Drawing.Point(144, 45);
            this.btn_logout2.Name = "btn_logout2";
            this.btn_logout2.Size = new System.Drawing.Size(75, 23);
            this.btn_logout2.TabIndex = 16;
            this.btn_logout2.Text = "Log Out";
            this.btn_logout2.UseVisualStyleBackColor = true;
            this.btn_logout2.Click += new System.EventHandler(this.btn_logout2_Click);
            // 
            // btn_deposit2
            // 
            this.btn_deposit2.Location = new System.Drawing.Point(79, 117);
            this.btn_deposit2.Name = "btn_deposit2";
            this.btn_deposit2.Size = new System.Drawing.Size(75, 23);
            this.btn_deposit2.TabIndex = 14;
            this.btn_deposit2.Text = "Deposit";
            this.btn_deposit2.UseVisualStyleBackColor = true;
            this.btn_deposit2.Click += new System.EventHandler(this.btn_deposit2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "UC Bank";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input Deposit Amount:";
            // 
            // panel_withdraww
            // 
            this.panel_withdraww.Controls.Add(this.lb_withdraw);
            this.panel_withdraww.Controls.Add(this.tb_withdraw);
            this.panel_withdraww.Controls.Add(this.btn_logout3);
            this.panel_withdraww.Controls.Add(this.btn_withdraw2);
            this.panel_withdraww.Controls.Add(this.panel_withdraw);
            this.panel_withdraww.Controls.Add(this.label5);
            this.panel_withdraww.Location = new System.Drawing.Point(3, 10);
            this.panel_withdraww.Name = "panel_withdraww";
            this.panel_withdraww.Size = new System.Drawing.Size(341, 279);
            this.panel_withdraww.TabIndex = 18;
            // 
            // lb_withdraw
            // 
            this.lb_withdraw.AutoSize = true;
            this.lb_withdraw.Location = new System.Drawing.Point(40, 50);
            this.lb_withdraw.Name = "lb_withdraw";
            this.lb_withdraw.Size = new System.Drawing.Size(35, 13);
            this.lb_withdraw.TabIndex = 18;
            this.lb_withdraw.Text = "label2";
            // 
            // tb_withdraw
            // 
            this.tb_withdraw.Location = new System.Drawing.Point(70, 107);
            this.tb_withdraw.Name = "tb_withdraw";
            this.tb_withdraw.Size = new System.Drawing.Size(100, 20);
            this.tb_withdraw.TabIndex = 17;
            // 
            // btn_logout3
            // 
            this.btn_logout3.Location = new System.Drawing.Point(144, 45);
            this.btn_logout3.Name = "btn_logout3";
            this.btn_logout3.Size = new System.Drawing.Size(75, 23);
            this.btn_logout3.TabIndex = 16;
            this.btn_logout3.Text = "Log Out";
            this.btn_logout3.UseVisualStyleBackColor = true;
            this.btn_logout3.Click += new System.EventHandler(this.btn_logout3_Click);
            // 
            // btn_withdraw2
            // 
            this.btn_withdraw2.Location = new System.Drawing.Point(82, 133);
            this.btn_withdraw2.Name = "btn_withdraw2";
            this.btn_withdraw2.Size = new System.Drawing.Size(75, 23);
            this.btn_withdraw2.TabIndex = 14;
            this.btn_withdraw2.Text = "Withdraw";
            this.btn_withdraw2.UseVisualStyleBackColor = true;
            this.btn_withdraw2.Click += new System.EventHandler(this.btn_withdraw2_Click);
            // 
            // panel_withdraw
            // 
            this.panel_withdraw.AutoSize = true;
            this.panel_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_withdraw.Location = new System.Drawing.Point(26, 18);
            this.panel_withdraw.Name = "panel_withdraw";
            this.panel_withdraw.Size = new System.Drawing.Size(104, 25);
            this.panel_withdraw.TabIndex = 10;
            this.panel_withdraw.Text = "UC Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Input Withdraw Amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_withdraww);
            this.Controls.Add(this.panel_deposit);
            this.Controls.Add(this.panel_mainview);
            this.Controls.Add(this.panel_register);
            this.Controls.Add(this.panel_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            this.panel_mainview.ResumeLayout(false);
            this.panel_mainview.PerformLayout();
            this.panel_deposit.ResumeLayout(false);
            this.panel_deposit.PerformLayout();
            this.panel_withdraww.ResumeLayout(false);
            this.panel_withdraww.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_username1;
        private System.Windows.Forms.TextBox tb_password1;
        private System.Windows.Forms.Label lb_ucbank;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label lb_username2;
        private System.Windows.Forms.Label lb_password2;
        private System.Windows.Forms.Label lb_ucbank2;
        private System.Windows.Forms.TextBox tb_username2;
        private System.Windows.Forms.TextBox tb_password2;
        private System.Windows.Forms.Button btn_register2;
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.Panel panel_mainview;
        private System.Windows.Forms.Button btn_withdraw;
        private System.Windows.Forms.Label lb_ucbank3;
        private System.Windows.Forms.Label lb_balancenyaa;
        private System.Windows.Forms.Button btn_deposit;
        private System.Windows.Forms.Label lb_balance;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel_deposit;
        private System.Windows.Forms.TextBox tb_deposit;
        private System.Windows.Forms.Button btn_logout2;
        private System.Windows.Forms.Button btn_deposit2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel_withdraww;
        private System.Windows.Forms.TextBox tb_withdraw;
        private System.Windows.Forms.Button btn_logout3;
        private System.Windows.Forms.Button btn_withdraw2;
        private System.Windows.Forms.Label panel_withdraw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_deposit;
        private System.Windows.Forms.Label lb_withdraw;
    }
}

