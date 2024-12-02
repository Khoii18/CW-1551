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
                if (question_bank[i] is OpenEndedQuestion oeq)
                {
                    rt_question.Text += $"Question {i + 1}: {oeq.QuestionText}\n";
                    rt_answer.Text += $"  Possible Correct Answers:\n";

                    for (int j = 0; j < oeq.CorrectAnswers.Length; j++)
                    {
                        rt_answer.Text += $"    - {oeq.CorrectAnswers[j]}\n";
                    }

                    rt_question.Text += "\n";
                }
            }
        }
        private void bt_update_Click(object sender, EventArgs e)
        {
            string[] correctAnswers = rt_answer.Lines;
            string question = rt_question.Text.Trim();

            if (string.IsNullOrWhiteSpace(rt_question.Text))
            {
                MessageBox.Show("Question cannot be empty.");
                return;
            }
            if (string.IsNullOrWhiteSpace(rt_answer.Text))
            {
                MessageBox.Show("Correct Answer cannot be empty.");
                return;
            }

            MessageBox.Show("A new question was updated to question bank");
        }
    }
}
