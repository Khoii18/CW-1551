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
    public partial class editmultiplechoice : Form
    {
        List<Question> question_bank = new List<Question>();
        int questionIndex;
        public editmultiplechoice(List<Question> question_bank, int index)
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
            rt_mcquestion.Clear();
            if (question_bank[questionIndex] is MultipleChoiceQuestion multiplechoice)
            {
                rt_mcquestion.Text += multiplechoice.QuestionText;
                tb_choice1.Text = multiplechoice.Choices[0];
                tb_choice2.Text = multiplechoice.Choices[1];
                tb_choice3.Text = multiplechoice.Choices[2];
                tb_choice4.Text = multiplechoice.Choices[3];

                tb_correctanswer.Text += multiplechoice.CorrectAnswer + 1;
            }
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                string questionText = rt_mcquestion.Text.Trim();
                if (string.IsNullOrWhiteSpace(questionText))
                {
                    MessageBox.Show("Question cannot be empty.");
                    return;
                }

                string[] choices = new string[4];
                choices[0] = tb_choice1.Text.Trim();
                choices[1] = tb_choice2.Text.Trim();
                choices[2] = tb_choice3.Text.Trim();
                choices[3] = tb_choice4.Text.Trim();

                if (choices.Any(string.IsNullOrWhiteSpace))
                {
                    MessageBox.Show("All choices must be provided and cannot be empty.");
                    return;
                }

                int correctAnswer = Convert.ToInt32(tb_correctanswer.Text.Trim());
                if (correctAnswer < 1 || correctAnswer > 4)
                {
                    MessageBox.Show("Correct Answer must be a number between 1 and 4.");
                    return;
                }

                correctAnswer -= 1;

                if (question_bank[questionIndex] is MultipleChoiceQuestion multipleChoiceQuestion)
                {
                    multipleChoiceQuestion.QuestionText = questionText;
                    multipleChoiceQuestion.Choices = choices;
                    multipleChoiceQuestion.CorrectAnswer = correctAnswer;

                    MessageBox.Show("Question has been updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The selected question is not a multiple-choice question.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

    }
}
