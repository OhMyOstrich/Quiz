using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.Forms
{
    public partial class ScoreForm : Form
    {
        private QuizObject quiz;

        public ScoreForm()
        {
            InitializeComponent();
            quiz = Stuff.currentquiz;
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            //ScoreLabel.Text = quiz.

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
