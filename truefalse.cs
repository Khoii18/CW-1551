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
    public partial class truefalse : Form
    {
        List<Question> question_bank = new List<Question>();
        public truefalse(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }
        private void bt_addquestion_Click(object sender, EventArgs e)
        {
            string Question = rt_truefalseqs.Text;
            string istrue = cb_truefalse.Text;

            if (string.IsNullOrEmpty(Question))
            {
                MessageBox.Show("Please enter the question text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(istrue))
            {
                MessageBox.Show("Please select the correct answer (True or False).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            question_bank.Add(new TrueFalseQuestion(Question, istrue));

            MessageBox.Show("The question has been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            rt_truefalseqs.Clear();

            this.Close();
        }
    }
}
