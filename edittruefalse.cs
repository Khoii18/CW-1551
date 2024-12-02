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
    public partial class edittruefalse : Form
    {
        List<Question> question_bank = new List<Question>();
        public edittruefalse(List<Question> question_bank)
        {
            InitializeComponent();
            this.question_bank = question_bank;
        }
    }
}
