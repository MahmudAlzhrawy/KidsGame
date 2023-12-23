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
            Scorelbl.Text = $"Score:{this.Score}";

            // يتم تحميل السؤال الحالي من نتائج الاستعلام
            var Question = userQuestions.Skip(i).FirstOrDefault();

            if (Question != null)
            {
                string displayText = $"{i + 1}-{Question.QuestionText}\n";

                TextLable.Text = displayText;


                List<string> answers = new List<string>
                    {
                        Question.Option2,
                        Question.Option3,
                        Question.Answer,
                        Question.Option4
                    };

                answers = answers.OrderBy(x => Guid.NewGuid()).ToList();
                button1.Text = answers[0];
                button2.Text = answers[1];
                button3.Text = answers[2];
                button4.Text = answers[3];
            }

        }

        private void Mathmatic_questions_Load(object sender, EventArgs e)
        {
            LoadQuestion();


        }


        private void Questions_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // فحص النتائج المرتبطة بالمستخدم
        }



        private void button6_Click(object sender, EventArgs e)
        {/*
            Soft soft = new Soft(User);
            soft.ShowDialog();
            this.Hide();*/
        }

        private void Questions_list_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void To_qustion_2_Click(object sender, EventArgs e)
        {
            /*Question_2 q2 = new Question_2(User, this.Score);
            this.Hide();
            q2.ShowDialog();*/
        }

        private void button1_Click(object sender, EventArgs e)
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

            // استدعاء الإجابة للسؤال الحالي
            string correctAnswer = Question.Answer;

            // مقارنة القيمة المختارة مع الإجابة الصحيحة
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
        private void button3_Click(object sender, EventArgs e)
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

            // استدعاء الإجابة للسؤال الحالي
            string correctAnswer = Question.Answer;

            // مقارنة القيمة المختارة مع الإجابة الصحيحة
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

        private void button4_Click(object sender, EventArgs e)
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

            // استدعاء الإجابة للسؤال الحالي
            string correctAnswer = Question.Answer;

            // مقارنة القيمة المختارة مع الإجابة الصحيحة
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

        private void button2_Click(object sender, EventArgs e)
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

            // استدعاء الإجابة للسؤال الحالي
            string correctAnswer = Question.Answer;

            // مقارنة القيمة المختارة مع الإجابة الصحيحة
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
        private void Scorelbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
