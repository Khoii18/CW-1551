using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzgame
{
    public partial class editopenend : Form
    {
        List<Question> question_bank = new List<Question>();
        public int questionIndex;
        public editopenend(List<Question> question_bank, int index)
        {
            InitializeComponent();
            this.question_bank = question_bank;
            this.questionIndex = index;
            if (index >= 0 && index < question_bank.Count)
            {
                var selectedQuestion = question_bank[index];
            }
            else
            {
                MessageBox.Show("Invalid question index.");
            }
            display();
        }
        private void display()
        {
            rt_question.Clear();
            for (int i = 0; i < question_bank.Count; i++)
            {
                if (question_bank[i] is OpenEndedQuestion openend)
                {
                    rt_question.Text += $"{openend.QuestionText}";

                    for (int j = 0; j < openend.CorrectAnswers.Length; j++)
                    {
                        rt_answer.Text += $"{openend.CorrectAnswers[j]}\n";
                    }

                    rt_question.Text += "\n";
                }
            }
        }
        private void bt_update_Click(object sender, EventArgs e)
        {
            string[] correctAnswers = rt_answer.Lines
                .Where(line => !string.IsNullOrWhiteSpace(line)) // Lọc bỏ các dòng rỗng
                .ToArray();
            string question = rt_question.Text.Trim();

            if (string.IsNullOrWhiteSpace(question))
            {
                MessageBox.Show("Question cannot be empty.");
                return;
            }
            if (correctAnswers.Length == 0)
            {
                MessageBox.Show("Correct Answers cannot be empty.");
                return;
            }

            if (questionIndex >= 0 && questionIndex < question_bank.Count)
            {
                if (question_bank[questionIndex] is OpenEndedQuestion openend)
                {
                    openend.QuestionText = question;
                    openend.CorrectAnswers = correctAnswers;

                    MessageBox.Show("The question has been updated successfully.");
                }
                else
                {
                    MessageBox.Show("The selected question is not an OpenEndedQuestion.");
                }
            }
            else
            {
                MessageBox.Show("Invalid question index.");
            }
            this.Close();
        }

    }
}
