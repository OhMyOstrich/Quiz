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

        private void FinishButton_Click(object sender, EventArgs e) {
            //Stuff.AddQuiz(QuizNameTB.Text);

            if (QuizSubjectTB.Text.Trim() == "" || QuizNameTB.Text.Trim() == "") {
                MessageBox.Show("Quiz Subject and Quiz Name cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QuizObject temp = new QuizObject {name = QuizNameTB.Text, subject = QuizSubjectTB.Text,
                numofquestions = QuestionsListBox.Items.Count, questions = new List<Question>()};

            foreach(Question x in QuestionsListBox.Items) {
                temp.questions.Add(x);
            }

            QuizFile file = new QuizFile(temp);
            file.CreateFile();
            MessageBox.Show("Quiz successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e) {
            if (QuestionsListBox.Items.Count == 0 || QuestionsListBox.Items.Count > 1) {
                MessageBox.Show("There are " + QuestionsListBox.Items.Count + " questions in this quiz", "Question Counted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("There is " + QuestionsListBox.Items.Count + " question in this quiz", "Question Counted",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void AddButton_Click(object sender, EventArgs e) {
            if (richTextBox1.Text.Trim() == "") {
                MessageBox.Show("Question Text cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<Answer> temp = new List<Answer>();
            temp.Add(new Answer { answertext = Answer1Box.Text, isanswer = Answer1Check.Checked });
            temp.Add(new Answer { answertext = Answer2Box.Text, isanswer = Answer2Check.Checked });
            temp.Add(new Answer { answertext = Answer3Box.Text, isanswer = Answer3Check.Checked });
            temp.Add(new Answer { answertext = Answer4Box.Text, isanswer = Answer4Check.Checked });
            QuestionsListBox.Items.Add(new Question { questiontext = richTextBox1.Text, answers = temp});
            ClearCheckBoxes();
            ClearTextBoxes();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            QuestionsListBox.Items.Remove(QuestionsListBox.SelectedItem);
        }

        private void ClearTextBoxes() {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is RichTextBox)
                        (control as RichTextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void ClearCheckBoxes() {
            Action<Control.ControlCollection> func = null;

            func = (controls) => {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Answer2Check_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}