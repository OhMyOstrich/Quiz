using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class QuestionForm : Form
    {
        public QuestionForm()
        {
            InitializeComponent();
        }

        private void questionBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void questionBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Set the Labels and QuestionBoxes set to the question put into the load function.
        private void QuestionForm_Load(object sender, EventArgs e)
        {
            Question q = new Question();
            //The question
            questionLabel.Text = q.questiontext;
            //The answers
            questionBox1.Text = q.answers.ElementAt(0).answertext;
            questionBox2.Text = q.answers.ElementAt(1).answertext;
            questionBox3.Text = q.answers.ElementAt(2).answertext;
            questionBox4.Text = q.answers.ElementAt(3).answertext;
        }
    }
}
