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
        Question q;
        //-----DEBUG-----
        Question question = new Question();
        //-----DEBUG-----
        CheckBox[] checkBoxes;
        //Variable that checks to see how many answers were chosen that were correct, that the user chose.
        private int correctAnswers;
        //THIS one decides how many answers will be correct out of the few.
        int setCorrectAnswers;

        public QuestionForm()
        {
            //-----DEBUG TESTING-----
            question.questiontext = "HOW CANCEROUS AM I?";

            Answer[] answers = question.answers.ToArray();

            answers[0] = new Answer();
            answers[0].answertext = "ULTRA";
            answers[0].isanswer = true;

            //question.answers.ElementAt(1).answertext = "Not at all! D:";
            //question.answers.ElementAt(1).isanswer = false;

            //question.answers.ElementAt(2).answertext = "Just. kys yourself.";
            //question.answers.ElementAt(2).isanswer = true;

            //question.answers.ElementAt(3).answertext = "BELIEVE IN YOURSELF";
            //question.answers.ElementAt(3).isanswer = false;
            //-----DEBUG TESTING-----

            setQuestion(question);

            //Loops through and ensures that the program knows how many correct answers there are.
            foreach (Answer answer in q.answers)
            {
                if (answer.isanswer)
                {
                    setCorrectAnswers += 1;
                }
            }

            InitializeComponent();
        }

        void setQuestion(Question question)
        {
            q = question;
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
            
            //The question
            questionLabel.Text = q.questiontext;

            //The answers
            questionBox1.Text = q.answers.ElementAt(0).answertext;
            questionBox2.Text = q.answers.ElementAt(1).answertext;
            questionBox3.Text = q.answers.ElementAt(2).answertext;
            questionBox4.Text = q.answers.ElementAt(3).answertext;
            //Put each of the question checkboxes into an array to loop through whn the answer button is clicked.
            checkBoxes[0] = questionBox1;
            checkBoxes[1] = questionBox2;
            checkBoxes[2] = questionBox3;
            checkBoxes[3] = questionBox4;
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            //Loop through each of the questions, and check to see if the correct answers were chosen.
            for(int i = 0; i < 4; i++)
            {
                //Check what the user selected against what is actually correct
                if(checkBoxes[i].Checked && q.answers.ElementAt(i).isanswer)
                {
                    correctAnswers += 1;
                }
            }
            //Set the question to have been correctly answered, if the user answered correctly.
            if(correctAnswers == setCorrectAnswers)
            {
                q.wasAnsweredCorrectly = true;
            } else {
                q.wasAnsweredCorrectly = false;
            }
        }
    }
}
