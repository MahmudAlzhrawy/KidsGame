namespace MoMo
{
    partial class Featuers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Featuers));
            toAlphabet = new Button();
            toQuestions = new Button();
            toNumbers = new Button();
            pictureBox_Logout = new PictureBox();
            pictureBox_exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logout).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_exit).BeginInit();
            SuspendLayout();
            // 
            // toAlphabet
            // 
            toAlphabet.BackgroundImage = Properties.Resources.MoMo32;
            toAlphabet.Font = new Font("Akhbar MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            toAlphabet.ForeColor = Color.WhiteSmoke;
            toAlphabet.Location = new Point(107, 214);
            toAlphabet.Name = "toAlphabet";
            toAlphabet.Size = new Size(150, 47);
            toAlphabet.TabIndex = 0;
            toAlphabet.Text = "Learn Alphabet ";
            toAlphabet.UseVisualStyleBackColor = true;
            toAlphabet.Click += toAlphabet_Click;
            // 
            // toQuestions
            // 
            toQuestions.BackColor = Color.Transparent;
            toQuestions.BackgroundImage = Properties.Resources.MoMo33;
            toQuestions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            toQuestions.ForeColor = Color.WhiteSmoke;
            toQuestions.Location = new Point(334, 42);
            toQuestions.Name = "toQuestions";
            toQuestions.Size = new Size(150, 48);
            toQuestions.TabIndex = 1;
            toQuestions.Text = "Questions";
            toQuestions.UseVisualStyleBackColor = false;
            toQuestions.Click += toQuestions_Click;
            // 
            // toNumbers
            // 
            toNumbers.BackgroundImage = Properties.Resources.MoMo3;
            toNumbers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            toNumbers.ForeColor = Color.WhiteSmoke;
            toNumbers.Location = new Point(675, 214);
            toNumbers.Name = "toNumbers";
            toNumbers.Size = new Size(150, 48);
            toNumbers.TabIndex = 2;
            toNumbers.Text = "Learn Numbers";
            toNumbers.UseVisualStyleBackColor = true;
            toNumbers.Click += toNumbers_Click;
            // 
            // pictureBox_Logout
            // 
            pictureBox_Logout.BackColor = Color.Transparent;
            pictureBox_Logout.Image = (Image)resources.GetObject("pictureBox_Logout.Image");
            pictureBox_Logout.Location = new Point(12, 4);
            pictureBox_Logout.Name = "pictureBox_Logout";
            pictureBox_Logout.Size = new Size(41, 48);
            pictureBox_Logout.TabIndex = 9;
            pictureBox_Logout.TabStop = false;
            pictureBox_Logout.Click += pictureBox_Logout_Click;
            // 
            // pictureBox_exit
            // 
            pictureBox_exit.BackColor = Color.Transparent;
            pictureBox_exit.Image = Properties.Resources.exit;
            pictureBox_exit.Location = new Point(860, 4);
            pictureBox_exit.Name = "pictureBox_exit";
            pictureBox_exit.Size = new Size(61, 73);
            pictureBox_exit.TabIndex = 10;
            pictureBox_exit.TabStop = false;
            pictureBox_exit.Click += pictureBox_exit_Click;
            // 
            // Featuers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MoMo3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 527);
            Controls.Add(pictureBox_exit);
            Controls.Add(pictureBox_Logout);
            Controls.Add(toNumbers);
            Controls.Add(toQuestions);
            Controls.Add(toAlphabet);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(924, 527);
            MinimumSize = new Size(924, 527);
            Name = "Featuers";
            Text = "MoMo";
            Load += Featuers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logout).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button toAlphabet;
        private Button toQuestions;
        private Button toNumbers;
        private PictureBox pictureBox_Logout;
        private PictureBox pictureBox_exit;
    }
}