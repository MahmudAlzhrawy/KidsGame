using Microsoft.Data.SqlClient;
using MoMo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using MoMo.Data;
using System.Media;

namespace MoMo
{
    public partial class Alphbets : Form
    {

        
        string user;
        public Alphbets(string user)
        {
            InitializeComponent();
            this.user = user;

        }
        AppDbContext db = new AppDbContext();
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private List<Alphabet> GetAlphabets()
        {
            return db.Alphabets.ToList();
        }
        private List<Image> imagesList = new List<Image>();
        List<byte[]> audiosList = new List<byte[]>();
        private void Alphbets_Load(object sender, EventArgs e)
        {
            List<Alphabet> alphabets = GetAlphabets();
            foreach (Alphabet alphabet in alphabets)
            {
                try
                {
                    byte[] imageData = alphabet.Image;
                    Image image = byteArrayToImage(imageData);
                    imagesList.Add(image);
                    byte[] audioData = alphabet.Audio;
                    audiosList.Add(audioData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error loading image: " + ex.Message);
                }
            }

            if (imagesList.Count > 0)
            {
                alphabetImage.Image = imagesList[0];
            }
        }

        private void PlayAudio(byte[] audioData)
        {

            WaveFormat waveFormat = new WaveFormat(25000,16, 2);
            WaveStream waveStream = new RawSourceWaveStream(new MemoryStream(audioData), waveFormat);


            WaveOut waveOut = new WaveOut();
            waveOut.Init(waveStream);
            waveOut.Play();
        }
        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        int currentImageIndex = 0;
        private void Next_Click(object sender, EventArgs e)
        {
            if (currentImageIndex <= 24)
            {
                currentImageIndex++;
                alphabetImage.Image = imagesList[currentImageIndex];

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
                alphabetImage.Image = imagesList[currentImageIndex];
            }
            else
            {

                alphabetImage.Image = imagesList[currentImageIndex];
            }
        }

        private void voice_Click(object sender, EventArgs e)
        {
            PlayAudio(audiosList[currentImageIndex]);
        }

        private void toFeatures_Click(object sender, EventArgs e)
        {
            Featuers opj = new Featuers(user);
            opj.Show();
            this.Close();
        }
    }
}
