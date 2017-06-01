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
            QuizObject temp = new QuizObject { //ID = int.Parse(QuizIDTextBox.Text),
                name = QuizNameTB.Text, subject = QuizSubjectTB.Text};
            QuizFile file = new QuizFile { main = temp };
            file.CreateFile();
        }

        private void button3_Click(object sender, EventArgs e) {
            MessageBox.Show("There are " + QuestionsListBox.Items.Count + " questions in this quiz", "Question Counted");
        }

        private void AddButton_Click(object sender, EventArgs e) {
            List<Answer> temp = new List<Answer>();
            temp.Add(new Answer { answertext = Answer1Box.Text, isanswer = Answer1Check.Checked });
            temp.Add(new Answer { answertext = Answer2Box.Text, isanswer = Answer2Check.Checked });
            temp.Add(new Answer { answertext = Answer3Box.Text, isanswer = Answer3Check.Checked });
            temp.Add(new Answer { answertext = Answer4Box.Text, isanswer = Answer4Check.Checked });

            QuestionsListBox.Items.Add(new Question { questiontext = richTextBox1.Text, answers = temp});
        }
    }
}