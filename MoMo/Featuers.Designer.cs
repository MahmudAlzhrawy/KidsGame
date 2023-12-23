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
            button1 = new Button();
            button2 = new Button();
            Nums = new Button();
            pictureBox1 = new PictureBox();
            pictureBox_exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_exit).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.MoMo32;
            button1.Font = new Font("Akhbar MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(107, 214);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 0;
            button1.Text = "Learn Alphabet ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.MoMo33;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(334, 42);
            button2.Name = "button2";
            button2.Size = new Size(150, 48);
            button2.TabIndex = 1;
            button2.Text = "Questions";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Nums
            // 
            Nums.BackgroundImage = Properties.Resources.MoMo3;
            Nums.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Nums.ForeColor = Color.WhiteSmoke;
            Nums.Location = new Point(675, 214);
            Nums.Name = "Nums";
            Nums.Size = new Size(150, 48);
            Nums.TabIndex = 2;
            Nums.Text = "Learn Numbers";
            Nums.UseVisualStyleBackColor = true;
            Nums.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 48);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
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
            pictureBox_exit.Click += pictureBox2_Click;
            // 
            // Featuers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MoMo3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(924, 527);
            Controls.Add(pictureBox_exit);
            Controls.Add(pictureBox1);
            Controls.Add(Nums);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(924, 527);
            MinimumSize = new Size(924, 527);
            Name = "Featuers";
            Text = "MoMo";
            Load += Featuers_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button Nums;
        private PictureBox pictureBox1;
        private PictureBox pictureBox_exit;
    }
}