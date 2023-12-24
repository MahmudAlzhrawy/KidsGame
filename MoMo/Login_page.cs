
using MoMo.Data;
using System.Configuration;

namespace MoMo
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void login_btn_Click(object sender, EventArgs e)
        {
            // Retrieve the entered username and password
            string User = User_text.Text, Pass = Pass_text.Text;
            if (!string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(Pass))
            {
                //Retrieve the user from the database based on the entered username
                var repo = db.Users.Where(u => u.user_name == User).FirstOrDefault();
                if (repo != null && repo.VerifyPassword(Pass))
                {
                   // Display a success message and navigate to the Features form
                    MessageBox.Show("Successfully Login!", repo.user_name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string enteredusername = User_text.Text;
                    Featuers opject = new Featuers(enteredusername);
                    opject.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Wrong:\n Username or password is not correct ", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show($"Something Wrong :\n Empty Feild", "Worng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_page_Load(object sender, EventArgs e)
        {

        }
        // Event handler for the signup link click
        private void toSignup_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp opject = new SignUp();
            this.Hide();
            opject.Show();
        }
    }
} 

