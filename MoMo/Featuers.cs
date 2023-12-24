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
        private void toQuestions_Click(object sender, EventArgs e)
        {
            Questions question = new Questions(userName);
            this.Close();
            question.Show();
        }

        private void Featuers_Load(object sender, EventArgs e)
        {

        }

        private void toAlphabet_Click(object sender, EventArgs e)
        {
            Alphbets Alphbet = new Alphbets(userName);
            Alphbet.Show();
            this.Close();
        }
        private void toNumbers_Click(object sender, EventArgs e)
        {
            Numbers numbers = new Numbers(userName);
            numbers.Show();
            this.Close();
        }
        private void pictureBox_Logout_Click(object sender, EventArgs e)
        {
            loginPage mainPage = new loginPage();
            this.Close();
            mainPage.Show();
        }

      

        private void pictureBox_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
