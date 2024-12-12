using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzgame
{
    public partial class Player : Form
    {
        List<Question> question_bank = new List<Question>();
        public Player(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }
        int grade = 0;
        int indexQuestion = 0;
        Stopwatch stopwatch = new Stopwatch();

        private void bt_start_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            if (question_bank.Count == 0)
            {
                Console.WriteLine("No questions available.");
                return;
            }

            rt_question.Clear();
            rt_question.Text = $"Question 1: {question_bank[0].QuestionText}\n";

            if (question_bank[0] is MultipleChoiceQuestion multiplechoice)
            {
                for (int j = 0; j < multiplechoice.Choices.Length; j++)
                {
                    rt_question.Text += $"  Choice {j + 1}: {multiplechoice.Choices[j]}\n";
                }
                rt_question.Text += "Please Choose 1-4";
            }
            else if (question_bank[0] is OpenEndedQuestion openend)
            {
                rt_question.Text += "\n(Open-ended question, write your answer in Answer Box)\n";
            }
            else if (question_bank[0] is TrueFalseQuestion truefalse)
            {
                rt_question.Text += "\nPlease choose True or False?\n";
            }

        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            try
            {
                if (indexQuestion < question_bank.Count)
                {
                    if (question_bank[indexQuestion] is MultipleChoiceQuestion mcq)
                    {
                        if (Convert.ToInt32(rt_answer.Text) < 0 || Convert.ToInt32(rt_answer.Text) > 4)
                        {
                            MessageBox.Show("Please Choose 1-4");
                            return;
                        }
                        if (Convert.ToInt32(rt_answer.Text) == mcq.CorrectAnswer + 1)
                        {
                            grade++;
                        }
                    }
                    else if (question_bank[indexQuestion] is TrueFalseQuestion tfq)
                    {
                        if (rt_answer.Text.Trim().ToLower() == tfq.IsTrue)
                        {
                            grade++;
                        }
                    }
                    else if (question_bank[indexQuestion] is OpenEndedQuestion oeq)
                    {
                        for (int j = 0; j < oeq.CorrectAnswers.Length; j++)
                        {
                            if (rt_answer.Text == oeq.CorrectAnswers[j])
                            {
                                grade++;
                                break;
                            }
                        }
                    }

                    rt_answer.Clear();

                    indexQuestion++;

                    if (indexQuestion < question_bank.Count)
                    {
                        rt_question.Text = question_bank[indexQuestion].QuestionText;

                        if (question_bank[indexQuestion] is MultipleChoiceQuestion MCQ)
                        {
                            for (int j = 0; j < MCQ.Choices.Length; j++)
                            {
                                rt_question.Text += $"  Choice {j + 1}: {MCQ.Choices[j]}\n";
                            }
                        }
                        else if (question_bank[indexQuestion] is TrueFalseQuestion)
                        {
                            rt_question.Text += "\nPlease enter true or false?\n";
                        }
                        else if (question_bank[indexQuestion] is OpenEndedQuestion)
                        {
                            rt_question.Text += "\n(Open-ended question, write your answer in Answer Box)\n";
                        }
                    }
                    else
                    {
                        stopwatch.Stop();
                        string yourGrade = $"Quizz Complete! Total Grade: {grade}/{question_bank.Count};Total Time spent: {stopwatch.Elapsed.TotalMinutes:F2} minutes.";
                        MessageBox.Show(yourGrade);

                        indexQuestion = 0;
                        grade = 0;
                        rt_question.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
