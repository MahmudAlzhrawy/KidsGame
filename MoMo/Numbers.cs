using MoMo.Data;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoMo.Data;
using Microsoft.VisualBasic.ApplicationServices;

namespace MoMo
{
    public partial class Numbers : Form
    {
        string userName;
        public Numbers(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        AppDbContext db = new AppDbContext();
        private List<Number> GetNumbers()
        {
            return db.Numbers.ToList();
        }
        private List<Image> images = new List<Image>();
        List<byte[]> audiosList = new List<byte[]>();
        private void Numbers_Load(object sender, EventArgs e)
        {
            // Load images and audio data from the database into lists
            List<Number> numbers = GetNumbers();
            foreach (Number num in numbers)
            {
                try
                {
                    byte[] imageData = num.Image;
                    Console.WriteLine($"Image Data Length: {imageData.Length}");
                    Image image = byteArrayToImage(imageData);
                    images.Add(image);
                    byte[] audioData = num.Audio;
                    audiosList.Add(audioData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                }
            }

            if (images.Count > 0)
            {
                pictureBox1.Image = images[0];
            }
        }
        // Method to play audio based on the provided audio data
        private void PlayAudio(byte[] audioData)
        {

            WaveFormat waveFormat = new WaveFormat(25000, 16, 2);
            WaveStream waveStream = new RawSourceWaveStream(new MemoryStream(audioData), waveFormat);


            WaveOut waveOut = new WaveOut();
            waveOut.Init(waveStream);
            waveOut.Play();
        }
        // Method to convert a byte array to an Image
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        int currentImageIndex = 0;

        private void voice_Click(object sender, EventArgs e)
        {
            PlayAudio(audiosList[currentImageIndex]);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currentImageIndex <= images.Count - 2)
            {
                
                currentImageIndex++;
                pictureBox1.Image = images[currentImageIndex];

            }
            else
            {
                Console.WriteLine("The end");
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (currentImageIndex > 0)
            {
                currentImageIndex--;
                pictureBox1.Image = images[currentImageIndex];
            }
            else
            {

                pictureBox1.Image = images[currentImageIndex];
            }
        }

        private void toFeatures_Click(object sender, EventArgs e)
        {
            Featuers opj = new Featuers(userName);
            opj.Show();
            this.Close();
        }
    }
}
