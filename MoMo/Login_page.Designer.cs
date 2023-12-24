namespace MoMo
{
    partial class loginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginPage));
            panel1 = new Panel();
            toSignup = new LinkLabel();
            sinup_lapel = new Label();
            Pass_text = new TextBox();
            User_text = new TextBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(toSignup);
            panel1.Controls.Add(sinup_lapel);
            panel1.Controls.Add(Pass_text);
            panel1.Controls.Add(User_text);
            panel1.Controls.Add(login_btn);
            panel1.ForeColor = SystemColors.ControlDarkDark;
            panel1.Location = new Point(340, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 275);
            panel1.TabIndex = 5;
            // 
            // toSignup
            // 
            toSignup.ActiveLinkColor = Color.FromArgb(64, 0, 64);
            toSignup.AutoSize = true;
            toSignup.Location = new Point(97, 217);
            toSignup.Name = "toSignup";
            toSignup.Size = new Size(78, 15);
            toSignup.TabIndex = 7;
            toSignup.TabStop = true;
            toSignup.Text = "Go To SignUp";
            toSignup.LinkClicked += toSignup_LinkClicked_1;
            // 
            // sinup_lapel
            // 
            sinup_lapel.AutoSize = true;
            sinup_lapel.Location = new Point(97, 202);
            sinup_lapel.Name = "sinup_lapel";
            sinup_lapel.Size = new Size(122, 15);
            sinup_lapel.TabIndex = 6;
            sinup_lapel.Text = "Not have an acount! ?";
            // 
            // Pass_text
            // 
            Pass_text.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Pass_text.Location = new Point(16, 95);
            Pass_text.Multiline = true;
            Pass_text.Name = "Pass_text";
            Pass_text.PasswordChar = '*';
            Pass_text.PlaceholderText = "Password";
            Pass_text.Size = new Size(238, 42);
            Pass_text.TabIndex = 3;
            // 
            // User_text
            // 
            User_text.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            User_text.Location = new Point(16, 19);
            User_text.Multiline = true;
            User_text.Name = "User_text";
            User_text.PlaceholderText = "UserName";
            User_text.Size = new Size(238, 42);
            User_text.TabIndex = 2;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.LawnGreen;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatStyle = FlatStyle.Popup;
            login_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(82, 154);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(136, 45);
            login_btn.TabIndex = 0;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MoMO5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 484);
            Controls.Add(panel1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(924, 527);
            MinimumSize = new Size(924, 527);
            Name = "loginPage";
            RightToLeft = RightToLeft.No;
            Text = "MoMo";
            Load += Login_page_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox Pass_text;
        private TextBox User_text;
        private Button login_btn;
        private LinkLabel toSignup;
        private Label sinup_lapel;
        private Button button1;
    }
}
