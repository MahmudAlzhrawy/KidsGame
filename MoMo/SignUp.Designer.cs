namespace MoMo
{
    partial class SignUp
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
            Sign_user_box = new TextBox();
            Genbox = new ComboBox();
            label2 = new Label();
            Sign_pass_box = new TextBox();
            SingUp_btn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            aup_image = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Sign_user_box
            // 
            Sign_user_box.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Sign_user_box.Location = new Point(370, 118);
            Sign_user_box.Multiline = true;
            Sign_user_box.Name = "Sign_user_box";
            Sign_user_box.PlaceholderText = "Enter Your Username";
            Sign_user_box.Size = new Size(237, 44);
            Sign_user_box.TabIndex = 0;
            Sign_user_box.TextChanged += Sign_user_box_TextChanged;
            // 
            // Genbox
            // 
            Genbox.FormattingEnabled = true;
            Genbox.Items.AddRange(new object[] { "Male", "Female" });
            Genbox.Location = new Point(465, 278);
            Genbox.Margin = new Padding(15);
            Genbox.Name = "Genbox";
            Genbox.Size = new Size(142, 23);
            Genbox.TabIndex = 5;
            Genbox.SelectedIndexChanged += Genbox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(359, 265);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(102, 50);
            label2.TabIndex = 6;
            label2.Text = "Gender";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Sign_pass_box
            // 
            Sign_pass_box.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Sign_pass_box.Location = new Point(370, 197);
            Sign_pass_box.Multiline = true;
            Sign_pass_box.Name = "Sign_pass_box";
            Sign_pass_box.PasswordChar = '*';
            Sign_pass_box.PlaceholderText = "Enter Your Password";
            Sign_pass_box.Size = new Size(237, 44);
            Sign_pass_box.TabIndex = 7;
            Sign_pass_box.TextChanged += Sign_pass_box_TextChanged;
            // 
            // SingUp_btn
            // 
            SingUp_btn.BackColor = Color.DodgerBlue;
            SingUp_btn.Cursor = Cursors.Hand;
            SingUp_btn.FlatStyle = FlatStyle.Popup;
            SingUp_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            SingUp_btn.ForeColor = Color.White;
            SingUp_btn.Location = new Point(553, 401);
            SingUp_btn.Name = "SingUp_btn";
            SingUp_btn.Size = new Size(136, 45);
            SingUp_btn.TabIndex = 8;
            SingUp_btn.Text = "SignUp";
            SingUp_btn.UseVisualStyleBackColor = false;
            SingUp_btn.Click += SingUp_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(671, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 183);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.AppWorkspace;
            label1.Location = new Point(511, 33);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(82, 35);
            label1.TabIndex = 10;
            label1.Text = "Image:";
            label1.Click += label1_Click;
            // 
            // aup_image
            // 
            aup_image.BackColor = Color.DarkSeaGreen;
            aup_image.FlatStyle = FlatStyle.Popup;
            aup_image.Location = new Point(815, 301);
            aup_image.Name = "aup_image";
            aup_image.Size = new Size(75, 29);
            aup_image.TabIndex = 11;
            aup_image.Text = "Browse";
            aup_image.UseVisualStyleBackColor = false;
            aup_image.Click += aup_image_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.home3;
            pictureBox2.Location = new Point(6, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 68);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MoMo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(908, 488);
            Controls.Add(pictureBox2);
            Controls.Add(aup_image);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(SingUp_btn);
            Controls.Add(Sign_pass_box);
            Controls.Add(label2);
            Controls.Add(Genbox);
            Controls.Add(Sign_user_box);
            MaximumSize = new Size(924, 527);
            MinimumSize = new Size(924, 527);
            Name = "SignUp";
            Text = "MoMo";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Sign_user_box;
        private ComboBox Genbox;
        private Label label2;
        private TextBox Sign_pass_box;
        private Button SingUp_btn;
        private PictureBox pictureBox1;
        private Label label1;
        private Button aup_image;
        private PictureBox pictureBox2;
    }
}