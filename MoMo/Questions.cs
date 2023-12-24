using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MoMo.Data;
namespace MoMo
{
    public partial class Questions : Form
    {
        // Fields to store user information, question index, and score
        String User;
        int i = 0;
        int Score;
        public Questions(string User)
        {

            InitializeComponent();
            this.User = User;

        }
        AppDbContext db = new AppDbContext();

        private void LoadQuestion()
        {
            // Query to retrieve user specific questions and answers
            var userQuestions = from result in db.Results
                                join question in db.Questions on result.QuestionId equals question.QuestionId
                                where result.User_name == User
                                select new
                                {

                                    QuestionText = question.Question_Text,
                                    Answer = question.Q_Answer,
                                    Option2 = question.option_2,
                                    Option3 = question.option_3,
                                    Option4 = question.option_4,
                                };
            // Display the current score        
            Scorelbl.Text = $"Score:{this.Score}";

            // Retrieve the current question from the query result
            var Question = userQuestions.Skip(i).FirstOrDefault();

            if (Question != null)
            {
                // Display the question text
                string displayText = $"{i + 1}-{Question.QuestionText}\n";

                TextLable.Text = displayText;


                List<string> answers = new List<string>
                    {
                        Question.Option2,
                        Question.Option3,
                        Question.Answer,
                        Question.Option4
                    };
                // Randomize and display answer options
                answers = answers.OrderBy(x => Guid.NewGuid()).ToList();
                option1.Text = answers[0];
                option2.Text = answers[1];
                option3.Text = answers[2];
                option4.Text = answers[3];
            }

        }

        private void Mathmatic_questions_Load(object sender, EventArgs e)
        {
            LoadQuestion();


        }
        private void option1_Click(object sender, EventArgs e)
        {
            var userQuestions = from result in db.Results
                                join question in db.Questions on result.QuestionId equals question.QuestionId
                                where result.User_name == User
                                select new
                                {
                                    q_id = question.QuestionId,
                                    QuestionText = question.Question_Text,
                                    Answer = question.Q_Answer,
                                    option2 = question.option_2,
                                    option3 = question.option_3,
                                    option4 = question.option_4,

                                };
            var Question = userQuestions.Skip(i).FirstOrDefault();


            var selectedButton = (Button)sender;
            string selectedAnswer = selectedButton.Text;

            // اThe answer to the current question will be called
            string correctAnswer = Question.Answer;

            // Compare the chosen value with the correct answer
            var selectedUser = db.Users.Where(a => a.user_name == User).FirstOrDefault();
            if (selectedAnswer == correctAnswer)
            {
                selectedUser.Score += 50;
                db.Users.Update(selectedUser);
                db.SaveChanges();
                this.Score = selectedUser.Score;
                Scorelbl.Text = $"Score:{selectedUser.Score}";
                MessageBox.Show("True Ansawer ,you are very good kid");
                i++;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Wrong Answer");
                i++;
                LoadQuestion();
            }
            if (i > 14)
            {
                if (selectedUser.Score == 750)
                {
                    Congrtulation opj = new Congrtulation();
                    opj.Show();
                }
                else if (selectedUser.Score >= 500)
                {
                    TextLable.Text = "Excellant";
                    MessageBox.Show($" Excellant , MoMo So Happy ,  you earned " + selectedUser.Score + " Points.");
                }
                else if (selectedUser.Score >= 350)
                {
                    TextLable.Text = "Very Good";
                    MessageBox.Show(" Very Good , MoMo is Happy , you earned  " + selectedUser.Score + " Points.");
                }
                else if (selectedUser.Score >= 200)
                {
                    TextLable.Text = "Acceptable";
                    MessageBox.Show(" Not pad ,MoMo mapy Sad , you earned  " + selectedUser.Score + " Points.");
                }
                else
                {
                    TextLable.Text = "Im Sad";
                    MessageBox.Show(" You can do better than this result ,MoMo is Sad , you earned  " + selectedUser.Score + " Points.");
                }
                selectedUser.Score = 0;
                db.Users.Update(selectedUser);
                db.SaveChanges();
                Featuers featuers = new Featuers(User);
                this.Close();
                featuers.ShowDialog();

            }
        }
        private void option3_Click(object sender, EventArgs e)
        {
            var userQuestions = from result in db.Results
                                join question in db.Questions on result.QuestionId equals question.QuestionId
                                where result.User_name == User
                                select new
                                {
                                    q_id = question.QuestionId,
                                    QuestionText = question.Question_Text,
                                    Answer = question.Q_Answer,
                                    option2 = question.option_2,
                                    option3 = question.option_3,
                                    option4 = question.option_4,

                                };
            var Question = userQuestions.Skip(i).FirstOrDefault();


            var selectedButton = (Button)sender;
            string selectedAnswer = selectedButton.Text;

            // The answer to the current question will be called
            string correctAnswer = Question.Answer;

            // Compare the chosen value with the correct answer
            var selectedUser = db.Users.Where(a => a.user_name == User).FirstOrDefault();
            if (selectedAnswer == correctAnswer)
            {
                selectedUser.Score += 50;
                db.Users.Update(selectedUser);
                db.SaveChanges();
                this.Score = selectedUser.Score;
                Scorelbl.Text = $"Score:{selectedUser.Score}";
                MessageBox.Show("True Ansawer ,you are very good kid");
                i++;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Wrong Answer");
                i++;
                LoadQuestion();
            }
            if (i > 14)
            {
                if (selectedUser.Score == 750)
                {
                    Congrtulation opj = new Congrtulation();
                    opj.Show();
                }
                else if (selectedUser.Score >= 500)
                {
                    TextLable.Text = "Excellant";
                    MessageBox.Show($" Excellant , MoMo So Happy ,  you earned " + selectedUser.Score + " Points.");
                }
                else if (selectedUser.Score >= 350)
                {
                    TextLable.Text = "Very Good";
                    MessageBox.Show(" Very Good , MoMo is Happy , you earned  " + selectedUser.Score + " Points.");
                }
                else if (selectedUser.Score >= 200)
                {
                    TextLable.Text = "Acceptable";
                    MessageBox.Show(" Not pad ,MoMo mapy Sad , you earned  " + selectedUser.Score + " Points.");
                }
                else
                {
                    TextLable.Text = "Im Sad";
                    MessageBox.Show(" You can do better than this result ,MoMo is Sad , you earned  " + selectedUser.Score + " Points.");
                }
                selectedUser.Score = 0;
                db.Users.Update(selectedUser);
                db.SaveChanges();
                Featuers featuers = new Featuers(User);
                this.Close();
                featuers.ShowDialog();

            }
        }

        private void option4_Click(object sender, EventArgs e)
        {
            var userQuestions = from result in db.Results
                                join question in db.Questions on result.QuestionId equals question.QuestionId
                                where result.User_name == User
                                select new
                                {
                                    q_id = question.QuestionId,
                                    QuestionText = question.Question_Text,
                                    Answer = question.Q_Answer,
                                    option2 = question.option_2,
                                    option3 = question.option_3,
                                    option4 = question.option_4,

                                };
            var Question = userQuestions.Skip(i).FirstOrDefault();


            var selectedButton = (Button)sender;
            string selectedAnswer = selectedButton.Text;

            // The answer to the current question will be called
            string correctAnswer = Question.Answer;

            // Compare the chosen value with the correct answer
            var selectedUser = db.Users.Where(a => a.user_name == User).FirstOrDefault();
            if (selectedAnswer == correctAnswer)
            {
                selectedUser.Score += 50;
                db.Users.Update(selectedUser);
                db.SaveChanges();
                this.Score = selectedUser.Score;
                Scorelbl.Text = $"Score:{selectedUser.Score}";
                MessageBox.Show("True Ansawer ,you are very good kid");
                i++;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Wrong Answer");
                i++;
                LoadQuestion();
            }
            if (i > 14)
            {
                if (selectedUser.Score == 750)
                {
                    Congrtulation opj = new Congrtulation();
                    opj.Show();
                }
                else if (selectedUser.Score >= 500)
                {
                    TextLable.Text = "Excellant";
                    MessageBox.Show($" Excellant , MoMo So Happy ,  you earned " + selectedUser.Score + " Points.");
                }
                else if (selectedUser.Score >= 350)
                {
                    TextLable.Text = "Very Good";
                    MessageBox.Show(" Very Good , MoMo is Happy , you earned  " + selectedUser.Score + " Points.");
                }
                else if (selectedUser.Score >= 200)
                {
                    TextLable.Text = "Acceptable";
                    MessageBox.Show(" Not pad ,MoMo mapy Sad , you earned  " + selectedUser.Score + " Points.");
                }
                else
                {
                    TextLable.Text = "Im Sad";
                    MessageBox.Show(" You can do better than this result ,MoMo is Sad , you earned  " + selectedUser.Score + " Points.");
                }
                selectedUser.Score = 0;
                db.Users.Update(selectedUser);
                db.SaveChanges();
                Featuers featuers = new Featuers(User);
                this.Close();
                featuers.ShowDialog();

            }
        }

        private void option2_Click(object sender, EventArgs e)
        {
            var userQuestions = from result in db.Results
                                join question in db.Questions on result.QuestionId equals question.QuestionId
                                where result.User_name == User
                                select new
                                {
                                    q_id = question.QuestionId,
                                    QuestionText = question.Question_Text,
                                    Answer = question.Q_Answer,
                                    option2 = question.option_2,
                                    option3 = question.option_3,
                                    option4 = question.option_4,

                                };
            var Question = userQuestions.Skip(i).FirstOrDefault();

            var selectedButton = (Button)sender;
            string selectedAnswer = selectedButton.Text;

            // The answer to the current question will be called
            string correctAnswer = Question.Answer;

            // Compare the chosen value with the correct answer
            var selectedUser = db.Users.Where(a => a.user_name == User).FirstOrDefault();
            if (selectedAnswer == correctAnswer)
            {
                selectedUser.Score += 50;
                db.Users.Update(selectedUser);
                db.SaveChanges();
                this.Score = selectedUser.Score;
                Scorelbl.Text = $"Score:{selectedUser.Score}";
                MessageBox.Show("True Ansawer ,you are very good kid");
                i++;
                LoadQuestion();
            }
            else
            {
                MessageBox.Show("Wrong Answer");
                i++;
                LoadQuestion();
            }
            if (i > 14)
            {
                if (selectedUser.Score == 750)
                {
                    Congrtulation opj = new Congrtulation();
                    opj.Show();
                }
                else if (selectedUser.Score >= 500)
                {
                    TextLable.Text = "Excellant";
                    MessageBox.Show($" Excellant , MoMo So Happy ,  you earned " + selectedUser.Score + " Points.");
                }
                else if (selectedUser.Score >= 350)
                {
                    TextLable.Text = "Very Good";
                    MessageBox.Show(" Very Good , MoMo is Happy , you earned  " + selectedUser.Score + " Points.");
                }
                else if (selectedUser.Score >= 200)
                {
                    TextLable.Text = "Acceptable";
                    MessageBox.Show(" Not pad ,MoMo mapy Sad , you earned  " + selectedUser.Score + " Points.");
                }
                else
                {
                    TextLable.Text = "Im Sad";
                    MessageBox.Show(" You can do better than this result ,MoMo is Sad , you earned  " + selectedUser.Score + " Points.");
                }
                selectedUser.Score = 0;
                db.Users.Update(selectedUser);
                db.SaveChanges();
                Featuers featuers = new Featuers(User);
                this.Close();
                featuers.ShowDialog();

            }
        }
        private void pictureBox_Home_Click(object sender, EventArgs e)
        {
            var selectedUser = db.Users.Where(a => a.user_name == User).FirstOrDefault();
            selectedUser.Score = 0;
            db.Users.Update(selectedUser);
            db.SaveChanges();
            Featuers opject = new Featuers(User);
            this.Close();
            opject.Show();
        }
    }


}
