using Quiz.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private void Form1_Load(object sender, EventArgs e) {
            byte[] hash;
            using (SHA512 sha = SHA512.Create()) {
                hash = sha.ComputeHash(Encoding.UTF8.GetBytes("cheneysd"));
            }
            foreach (var y in hash) {
                Stuff.pass += y;
            }
    }

        private void button1_Click(object sender, EventArgs e) {
            this.Hide();
            PasswordForm form = new PasswordForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void TakeQuiz_Click(object sender, EventArgs e) {
            this.Hide();
            //Quiz form = new Quiz();
            //form.FormClosed += (s, args) => this.Close();
            //form.Show();
        }

        

        private void TempQuestionButton_Click(object sender, EventArgs e) {
            this.Hide();
            QuestionForm form = new QuestionForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            //QuizFile open = new QuizFile();
            //QuizObject obj = open.OpenFile();
            //TakeQuiz take = new TakeQuiz(obj);

            
            QuestionForm form = new QuestionForm();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
            this.Hide();

        }
    }
}
