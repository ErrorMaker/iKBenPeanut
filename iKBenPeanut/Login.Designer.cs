namespace iKBenPeanut
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.HotelTxt = new System.Windows.Forms.ComboBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.HPGroup = new System.Windows.Forms.GroupBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.HEGroup = new System.Windows.Forms.GroupBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.LoginAnimation = new System.Windows.Forms.Timer(this.components);
            this.HPGroup.SuspendLayout();
            this.HEGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotelTxt
            // 
            this.HotelTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HotelTxt.FormattingEnabled = true;
            this.HotelTxt.Items.AddRange(new object[] {
            ".com",
            ".com.br",
            ".com.tr",
            ".de",
            ".dk",
            ".es",
            ".fi",
            ".fr",
            ".it",
            ".nl",
            ".no",
            ".se"});
            this.HotelTxt.Location = new System.Drawing.Point(174, 113);
            this.HotelTxt.Name = "HotelTxt";
            this.HotelTxt.Size = new System.Drawing.Size(60, 21);
            this.HotelTxt.TabIndex = 9;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(13, 112);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(157, 23);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Login/Connect";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // HPGroup
            // 
            this.HPGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HPGroup.Controls.Add(this.PasswordTxt);
            this.HPGroup.Location = new System.Drawing.Point(12, 60);
            this.HPGroup.Name = "HPGroup";
            this.HPGroup.Size = new System.Drawing.Size(222, 45);
            this.HPGroup.TabIndex = 7;
            this.HPGroup.TabStop = false;
            this.HPGroup.Text = "Habbo Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.Location = new System.Drawing.Point(6, 17);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(210, 20);
            this.PasswordTxt.TabIndex = 2;
            this.PasswordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTxt.UseSystemPasswordChar = true;
            // 
            // HEGroup
            // 
            this.HEGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HEGroup.Controls.Add(this.EmailTxt);
            this.HEGroup.Location = new System.Drawing.Point(13, 9);
            this.HEGroup.Name = "HEGroup";
            this.HEGroup.Size = new System.Drawing.Size(221, 45);
            this.HEGroup.TabIndex = 6;
            this.HEGroup.TabStop = false;
            this.HEGroup.Text = "Habbo Email";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTxt.Location = new System.Drawing.Point(6, 17);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(209, 20);
            this.EmailTxt.TabIndex = 2;
            this.EmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginAnimation
            // 
            this.LoginAnimation.Interval = 200;
            this.LoginAnimation.Tick += new System.EventHandler(this.LoginAnimation_Tick);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 145);
            this.Controls.Add(this.HotelTxt);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.HPGroup);
            this.Controls.Add(this.HEGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iKBenPeanut ~ Hotel Check-In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.HPGroup.ResumeLayout(false);
            this.HPGroup.PerformLayout();
            this.HEGroup.ResumeLayout(false);
            this.HEGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox HotelTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.GroupBox HPGroup;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.GroupBox HEGroup;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Timer LoginAnimation;

    }
}

