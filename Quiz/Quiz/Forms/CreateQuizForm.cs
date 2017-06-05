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
            QuizObject temp = new QuizObject {name = QuizNameTB.Text, subject = QuizSubjectTB.Text, numofquestions = QuestionsListBox.Items.Count, questions = new List<Question>()};

            foreach(Question x in QuestionsListBox.Items) {
                temp.questions.Add(x);
            }

            //for (int i = 0; i < poop.; i++) {
            //    Question q = new Question { questiontext = QuestionsListBox.Items[0].};
            //    temp.questions.Add(QuestionsListBox.Items[i]);
            //}

            QuizFile file = new QuizFile(temp);
            file.CreateFile();
        }

        private void button3_Click(object sender, EventArgs e) {
            if (QuestionsListBox.Items.Count == 0 || QuestionsListBox.Items.Count > 1) {
                MessageBox.Show("There are " + QuestionsListBox.Items.Count + " questions in this quiz", "Question Counted");
            } else {
                MessageBox.Show("There is " + QuestionsListBox.Items.Count + " question in this quiz", "Question Counted");
            }
            
        }

        private void AddButton_Click(object sender, EventArgs e) {
            List<Answer> temp = new List<Answer>();
            temp.Add(new Answer { answertext = Answer1Box.Text, isanswer = Answer1Check.Checked });
            temp.Add(new Answer { answertext = Answer2Box.Text, isanswer = Answer2Check.Checked });
            temp.Add(new Answer { answertext = Answer3Box.Text, isanswer = Answer3Check.Checked });
            temp.Add(new Answer { answertext = Answer4Box.Text, isanswer = Answer4Check.Checked });

            QuestionsListBox.Items.Add(new Question { questiontext = richTextBox1.Text, answers = temp});
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            QuestionsListBox.Items.Remove(QuestionsListBox.SelectedItem);
        }
    }
}