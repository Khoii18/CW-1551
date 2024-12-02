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
    public partial class multiplechoice : Form
    {
        List<Question> question_bank = new List<Question>();
        public multiplechoice(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void multiplechoice_Load(object sender, EventArgs e)
        {

        }

        private void bt_addquestion_Click(object sender, EventArgs e)
        {
            try
            {
                string question = rt_mcquestion.Text.Trim();

                if (string.IsNullOrWhiteSpace(rt_mcquestion.Text))
                {
                    MessageBox.Show("Question cannot be empty.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(tb_correctanswer.Text))
                {
                    MessageBox.Show("Correct Answer cannot be empty.");
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

                int correctAnswer = Convert.ToInt32(tb_correctanswer.Text) - 1;

                question_bank.Add(new MultipleChoiceQuestion(question, choices, correctAnswer));

                MessageBox.Show("A new question was added to question bank");

            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }
        }
    }
}
