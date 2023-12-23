using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoMo
{
    public partial class Featuers : Form
    {
        private string userName;
        public Featuers(string userFromLogin)
        {
            InitializeComponent();
            userName = userFromLogin;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginPage mainPage = new loginPage();
            this.Close();
            mainPage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Questions question = new Questions(userName);
            this.Close();
            question.Show();
        }

        private void Featuers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alphbets Alphbet = new Alphbets(userName);
            Alphbet.Show();
            this.Close();
        }

        private void lblF_Click(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Numbers numbers = new Numbers(userName);
            numbers.Show();
            this.Close();
        }

        /*private void button4_Click_1(object sender, EventArgs e)
        {
            Settings setting = new Settings(userName);
            setting.ShowDialog();
        }*/

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            loginPage mainPage = new loginPage();
            this.Close();
            mainPage.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
