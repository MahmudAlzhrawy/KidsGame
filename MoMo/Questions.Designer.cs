namespace MoMo
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            TextLable = new Label();
            Scorelbl = new Label();
            pictureBox_Home = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Home).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(272, 229);
            button1.Name = "button1";
            button1.Size = new Size(78, 42);
            button1.TabIndex = 28;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(595, 306);
            button2.Name = "button2";
            button2.Size = new Size(73, 39);
            button2.TabIndex = 29;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(595, 229);
            button3.Name = "button3";
            button3.Size = new Size(73, 42);
            button3.TabIndex = 30;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(272, 306);
            button4.Name = "button4";
            button4.Size = new Size(78, 39);
            button4.TabIndex = 31;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // TextLable
            // 
            TextLable.BackColor = Color.Transparent;
            TextLable.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TextLable.Location = new Point(197, 120);
            TextLable.Name = "TextLable";
            TextLable.Size = new Size(540, 73);
            TextLable.TabIndex = 37;
            TextLable.Text = "Question";
            TextLable.Click += label1_Click;
            // 
            // Scorelbl
            // 
            Scorelbl.BackColor = Color.Transparent;
            Scorelbl.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Scorelbl.Location = new Point(380, 26);
            Scorelbl.Name = "Scorelbl";
            Scorelbl.Size = new Size(163, 44);
            Scorelbl.TabIndex = 38;
            Scorelbl.Text = "Score:";
            Scorelbl.Click += Scorelbl_Click;
            // 
            // pictureBox_Home
            // 
            pictureBox_Home.BackColor = Color.Transparent;
            pictureBox_Home.Image = Properties.Resources.home3;
            pictureBox_Home.Location = new Point(95, 389);
            pictureBox_Home.Name = "pictureBox_Home";
            pictureBox_Home.Size = new Size(65, 64);
            pictureBox_Home.TabIndex = 39;
            pictureBox_Home.TabStop = false;
            pictureBox_Home.Click += pictureBox_Home_Click;
            // 
            // Questions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(927, 519);
            Controls.Add(pictureBox_Home);
            Controls.Add(Scorelbl);
            Controls.Add(TextLable);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(943, 558);
            MinimumSize = new Size(943, 558);
            Name = "Questions";
            Text = "MoMo";
            Load += Mathmatic_questions_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Home).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label TextLable;
        private Label Scorelbl;
        private PictureBox pictureBox_Home;
    }
}