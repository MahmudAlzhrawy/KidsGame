namespace MoMo
{
    partial class Alphbets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alphbets));
            alphabetImage = new PictureBox();
            Next = new PictureBox();
            prev = new PictureBox();
            voice = new PictureBox();
            toFeatures = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)alphabetImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Next).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prev).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)toFeatures).BeginInit();
            SuspendLayout();
            // 
            // alphabetImage
            // 
            alphabetImage.BackColor = Color.OldLace;
            alphabetImage.Location = new Point(235, 57);
            alphabetImage.Name = "alphabetImage";
            alphabetImage.Size = new Size(456, 344);
            alphabetImage.SizeMode = PictureBoxSizeMode.StretchImage;
            alphabetImage.TabIndex = 0;
            alphabetImage.TabStop = false;
          //  alphabetImage.Click += alphabetImage_Click;
            // 
            // Next
            // 
            Next.BackColor = Color.Transparent;
            Next.Cursor = Cursors.Hand;
            Next.Image = Properties.Resources.next2;
            Next.Location = new Point(692, 225);
            Next.Name = "Next";
            Next.Size = new Size(69, 61);
            Next.TabIndex = 4;
            Next.TabStop = false;
            Next.Click += Next_Click;
            // 
            // prev
            // 
            prev.BackColor = Color.Transparent;
            prev.Cursor = Cursors.Hand;
            prev.Image = Properties.Resources.previous11;
            prev.Location = new Point(169, 225);
            prev.Name = "prev";
            prev.Size = new Size(66, 68);
            prev.TabIndex = 5;
            prev.TabStop = false;
            prev.Click += prev_Click;
            // 
            // voice
            // 
            voice.BackColor = Color.Transparent;
            voice.Cursor = Cursors.Hand;
            voice.Image = Properties.Resources.audio;
            voice.Location = new Point(691, 57);
            voice.Name = "voice";
            voice.Size = new Size(60, 46);
            voice.SizeMode = PictureBoxSizeMode.CenterImage;
            voice.TabIndex = 6;
            voice.TabStop = false;
            voice.Click += voice_Click;
            // 
            // toFeatures
            // 
            toFeatures.BackColor = Color.Transparent;
            toFeatures.Image = Properties.Resources.home4;
            toFeatures.Location = new Point(0, 0);
            toFeatures.Name = "toFeatures";
            toFeatures.Size = new Size(57, 68);
            toFeatures.TabIndex = 13;
            toFeatures.TabStop = false;
            toFeatures.Click += toFeatures_Click;
            // 
            // Alphbets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            BackgroundImage = Properties.Resources.MoMo4;
            ClientSize = new Size(908, 488);
            Controls.Add(toFeatures);
            Controls.Add(voice);
            Controls.Add(prev);
            Controls.Add(Next);
            Controls.Add(alphabetImage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(924, 527);
            MinimumSize = new Size(924, 527);
            Name = "Alphbets";
            Text = "MoMo";
            Load += Alphbets_Load;
            ((System.ComponentModel.ISupportInitialize)alphabetImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)Next).EndInit();
            ((System.ComponentModel.ISupportInitialize)prev).EndInit();
            ((System.ComponentModel.ISupportInitialize)voice).EndInit();
            ((System.ComponentModel.ISupportInitialize)toFeatures).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox alphabetImage;
        private Button button3;
        private PictureBox Next;
        private PictureBox pictureBox3;
        private PictureBox prev;
        private PictureBox voice;
        private PictureBox toFeatures;
    }
}