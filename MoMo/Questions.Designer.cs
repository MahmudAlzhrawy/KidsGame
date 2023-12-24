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
            option1 = new Button();
            option2 = new Button();
            option3 = new Button();
            option4 = new Button();
            TextLable = new Label();
            Scorelbl = new Label();
            pictureBox_Home = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Home).BeginInit();
            SuspendLayout();
            // 
            // option1
            // 
            option1.BackColor = Color.Transparent;
            option1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            option1.Location = new Point(272, 229);
            option1.Name = "option1";
            option1.Size = new Size(78, 42);
            option1.TabIndex = 28;
            option1.Text = "option";
            option1.UseVisualStyleBackColor = false;
            option1.Click += option1_Click;
            // 
            // option2
            // 
            option2.BackColor = Color.Transparent;
            option2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            option2.Location = new Point(595, 306);
            option2.Name = "option2";
            option2.Size = new Size(73, 39);
            option2.TabIndex = 29;
            option2.Text = "option";
            option2.UseVisualStyleBackColor = false;
            option2.Click += option2_Click;
            // 
            // option3
            // 
            option3.BackColor = Color.Transparent;
            option3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            option3.Location = new Point(595, 229);
            option3.Name = "option3";
            option3.Size = new Size(73, 42);
            option3.TabIndex = 30;
            option3.Text = "option3";
            option3.UseVisualStyleBackColor = false;
            option3.Click += option3_Click;
            // 
            // option4
            // 
            option4.BackColor = Color.Transparent;
            option4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            option4.Location = new Point(272, 306);
            option4.Name = "option4";
            option4.Size = new Size(78, 39);
            option4.TabIndex = 31;
            option4.Text = "option";
            option4.UseVisualStyleBackColor = false;
            option4.Click += option4_Click;
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
            Controls.Add(option4);
            Controls.Add(option3);
            Controls.Add(option2);
            Controls.Add(option1);
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
        private Button option1;
        private Button option2;
        private Button option3;
        private Button option4;
        private Label TextLable;
        private Label Scorelbl;
        private PictureBox pictureBox_Home;
    }
}