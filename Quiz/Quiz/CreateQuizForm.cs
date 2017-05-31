using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz {
    public partial class CreateQuizForm : Form {
        public CreateQuizForm() {
            InitializeComponent();
        }

        private void CreateQuizButton_Click(object sender, EventArgs e) {
            //Stuff.AddQuiz(QuizNameTB.Text);
            QuizObject temp = new QuizObject { ID = int.Parse(QuizIDTextBox.Text), name = QuizNameTB.Text, subject = QuizSubjectTB.Text};
            QuizFile file = new QuizFile { main = temp };
            file.CreateFile();
        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}