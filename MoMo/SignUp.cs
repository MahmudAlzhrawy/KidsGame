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

namespace MoMo
{
    public partial class SignUp : Form
    {
        string imagePath;
        public SignUp()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void SingUp_btn_Click(object sender, EventArgs e)
        {
            var check = db.Users.Where(u => u.user_name == Sign_user_box.Text).FirstOrDefault();
            if (check != null)
            {
                MessageBox.Show($"Wrong :\n Username or password is not correct ", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User newUser = new User()
                {
                    user_name = Sign_user_box.Text,
                    Gender = (_Gender)Genbox.SelectedIndex,
                    Image = imagePath,
                    Score = 0,

                };
                newUser.SetPassword(Sign_pass_box.Text);
                if (!string.IsNullOrEmpty(Sign_user_box.Text) && !string.IsNullOrEmpty(Sign_pass_box.Text) && Genbox.SelectedIndex >= 0)
                {
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        db.Users.Add(newUser);
                        List<Question> allQuestions = db.Questions.ToList();
                        if (allQuestions.Count >= 15)
                        {
                            Random rand = new Random();
                            List<Question> selectedQuestions = allQuestions.OrderBy(q => rand.Next()).Take(15).ToList();
                            foreach (Question question in selectedQuestions)
                            {
                                Result result = new Result()
                                {
                                    User_name = Sign_user_box.Text,
                                    QuestionId = question.QuestionId,
                                };
                                db.Results.Add(result);
                            }

                        }
                        string newpath = Environment.CurrentDirectory + newUser.user_name + ".jpg";
                        // File.Copy(imagepath, newpath);
                        newUser.Image = newpath;
                        db.SaveChanges();
                        MessageBox.Show($"Successfully Added", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loginPage log = new loginPage();
                        this.Close();
                        log.Show();
                    }
                    else
                    {
                        MessageBox.Show($"Image feild is empty :\n Add Image", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Something Wrong :\n Empty feild", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void aup_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = Dialog.FileName;
                pictureBox1.ImageLocation = Dialog.FileName;
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        private void toLogin_Click(object sender, EventArgs e)
        {
            loginPage opj = new loginPage();
            opj.Show();
            this.Close();

        }
    }
}
