using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Quizzgame
{
    public partial class edittruefalse : Form
    {
        private List<Question> question_bank;
        private int questionIndex;

        public edittruefalse(List<Question> question_bank, int index)
        {
            InitializeComponent();

            this.question_bank = question_bank;
            this.questionIndex = index;

            if (questionIndex >= 0 && questionIndex < question_bank.Count && question_bank[questionIndex] is TrueFalseQuestion trueFalseQuestion)
            {
                rt_truefalseqs.Text = trueFalseQuestion.QuestionText;
                cb_truefalse.SelectedItem = trueFalseQuestion.IsTrue;
            }
            else
            {
                MessageBox.Show("Invalid question index or question type.");
                Close();
            }
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string updatedQuestion = rt_truefalseqs.Text.Trim();
            string selectedAnswer = cb_truefalse.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(updatedQuestion))
            {
                MessageBox.Show("The question text cannot be empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(selectedAnswer))
            {
                MessageBox.Show("Please select 'True' or 'False' as the answer.");
                return;
            }

            if (question_bank[questionIndex] is TrueFalseQuestion trueFalseQuestion)
            {
                trueFalseQuestion.QuestionText = updatedQuestion;
                trueFalseQuestion.IsTrue = selectedAnswer;

                MessageBox.Show("The question has been updated successfully.");
            }
            else
            {
                MessageBox.Show("The selected question is not of type True/False.");
            }
            this.Close();
        }
    }
}
