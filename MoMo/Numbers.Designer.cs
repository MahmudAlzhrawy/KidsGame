namespace MoMo
{
    partial class Numbers
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
            toFeatures = new PictureBox();
            voice = new PictureBox();
            prev = new PictureBox();
            Next = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)toFeatures).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Next).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toFeatures
            // 
            toFeatures.BackColor = Color.Transparent;
            toFeatures.Image = Properties.Resources.home4;
            toFeatures.Location = new Point(0, -1);
            toFeatures.Name = "toFeatures";
            toFeatures.Size = new Size(57, 68);
            toFeatures.TabIndex = 18;
            toFeatures.TabStop = false;
            toFeatures.Click += toFeatures_Click;
            // 
            // voice
            // 
            voice.BackColor = Color.Transparent;
            voice.Cursor = Cursors.Hand;
            voice.Image = Properties.Resources.audio;
            voice.Location = new Point(693, 54);
            voice.Name = "voice";
            voice.Size = new Size(55, 44);
            voice.SizeMode = PictureBoxSizeMode.CenterImage;
            voice.TabIndex = 17;
            voice.TabStop = false;
            voice.Click += voice_Click;
            // 
            // prev
            // 
            prev.BackColor = Color.Transparent;
            prev.Cursor = Cursors.Hand;
            prev.Image = Properties.Resources.previous11;
            prev.Location = new Point(186, 213);
            prev.Name = "prev";
            prev.Size = new Size(62, 66);
            prev.TabIndex = 16;
            prev.TabStop = false;
            prev.Click += prev_Click;
            // 
            // Next
            // 
            Next.BackColor = Color.Transparent;
            Next.Cursor = Cursors.Hand;
            Next.Image = Properties.Resources.next2;
            Next.Location = new Point(693, 218);
            Next.Name = "Next";
            Next.Size = new Size(67, 61);
            Next.TabIndex = 15;
            Next.TabStop = false;
            Next.Click += Next_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.OldLace;
            pictureBox1.Location = new Point(254, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Numbers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MoMo4;
            ClientSize = new Size(908, 488);
            Controls.Add(toFeatures);
            Controls.Add(voice);
            Controls.Add(prev);
            Controls.Add(Next);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(924, 527);
            MinimumSize = new Size(924, 527);
            Name = "Numbers";
            Text = "MoMo";
            Load += Numbers_Load;
            ((System.ComponentModel.ISupportInitialize)toFeatures).EndInit();
            ((System.ComponentModel.ISupportInitialize)voice).EndInit();
            ((System.ComponentModel.ISupportInitialize)prev).EndInit();
            ((System.ComponentModel.ISupportInitialize)Next).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox toFeatures;
        private PictureBox voice;
        private PictureBox prev;
        private PictureBox Next;
        private PictureBox pictureBox1;
    }
}