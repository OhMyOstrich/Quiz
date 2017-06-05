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
    public partial class Form1 : Form
    {
        //public int test;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e) {
            CreateQuizForm form = new CreateQuizForm();
            form.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TempQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionForm form = new QuestionForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuizFile open = new QuizFile();
            QuizObject obj = open.OpenFile();
            TakeQuiz take = new TakeQuiz(obj);
        }
    }
}
