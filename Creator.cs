using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Quizzgame
{
    public partial class Creator : Form
    {
        public List<Question> question_bank = new List<Question>();
        public Creator()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string questionType = cb_type.Text;

            if (questionType == "multiplechoice")
            {
                multiplechoice form_multiplechoice = new multiplechoice(question_bank);
                form_multiplechoice.ShowDialog();
            }
            else if (questionType == "openend")
            {
                openend form_openend = new openend(question_bank);
                form_openend.ShowDialog();
            }
            else if (questionType == "truefalse")
            {
                truefalse form_truefalse = new truefalse(question_bank);
                form_truefalse.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chose Type Of Question You Want To Add");
            }
        }

        private void bt_displayall_Click(object sender, EventArgs e)
        {
            rt_displayall.Clear();
            for (int i = 0; i < question_bank.Count; i++)
            {

                if (question_bank[i] is MultipleChoiceQuestion multiplechoice)
                {
                    rt_displayall.Text += $"Question {i + 1}: {multiplechoice.QuestionText}\n";

                    for (int k = 0; k < multiplechoice.Choices.Length; k++)
                    {
                        rt_displayall.Text += $"  Choice {k + 1}: {multiplechoice.Choices[k]}\n";
                    }

                    rt_displayall.Text += $"  Correct Choice: {multiplechoice.CorrectAnswer + 1}\n\n";
                }
                else if (question_bank[i] is OpenEndedQuestion openend)
                {
                    rt_displayall.Text += $"Question {i + 1}: {openend.QuestionText}\n";
                    rt_displayall.Text += $"  The Correct Answers is...:\n";

                    for (int j = 0; j < openend.CorrectAnswers.Length; j++)
                    {
                        rt_displayall.Text += $"    - {openend.CorrectAnswers[j]}\n";
                    }

                    rt_displayall.Text += "\n";
                }
                else if (question_bank[i] is TrueFalseQuestion truefalse)
                {
                    rt_displayall.Text += $"Question {i + 1}: {truefalse.QuestionText}\n";

                    string correctAnswer = truefalse.IsTrue;
                    rt_displayall.Text += $"  Correct Answer: {correctAnswer}\n\n";

                }
            }
        }
        private void bt_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(tb_index.Text) - 1;

                if (question_bank.Count == 0)
                {
                    MessageBox.Show("No questions available to delete.");
                    return;
                }

                if (index < 0 && index > question_bank.Count)
                {
                    MessageBox.Show("Invalid question number.");
                    return;
                }

                question_bank.RemoveAt(index);
                MessageBox.Show("Deleted successful");
            }
            catch
            {
                MessageBox.Show("Something Wrong");
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            string questionType = cb_type.Text;
            int index = Convert.ToInt32(tb_index.Text)-1;

            if (questionType == "multiplechoice")
            {
                editmultiplechoice form_editmultiplechoice = new editmultiplechoice(question_bank, index);
                form_editmultiplechoice.ShowDialog();
            }
            else if (questionType == "openend")
            {
                editopenend form_editopenend = new editopenend(question_bank, index);
                form_editopenend.ShowDialog();
            }
            else if (questionType == "truefalse")
            {
                edittruefalse form_edittruefalse = new edittruefalse(question_bank, index);
                form_edittruefalse.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chose Type Of Question You Want To Edit");
            }
        }
    }
}
