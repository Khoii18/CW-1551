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
    public partial class openend : Form
    {
        List<Question> question_bank = new List<Question>();
        public openend(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }

        private void bt_add_Click(object sender, EventArgs e)
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

            question_bank.Add(new OpenEndedQuestion(question, correctAnswers));
            MessageBox.Show("A new question was added to question bank");
        }
    }
}
