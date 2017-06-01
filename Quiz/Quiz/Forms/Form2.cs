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
        private List<Answer> answers;
        //-----DEBUG-----
        private List<CheckBox> checkBoxes;
        //Variable that checks to see how many answers were chosen that were correct, that the user chose.
        private int correctAnswers;
        //THIS one decides how many answers will be correct out of the few.
        int setCorrectAnswers;

        public QuestionForm()
        {
            //Initialize the variables
            answers = new List<Answer>();
            checkBoxes = new List<CheckBox>();
            //Adding values to them.
            for (int i = 0; i < 4; i++)
            {
                answers.Add(new Answer());
                checkBoxes.Add(new CheckBox());
            }

            //-----DEBUG TESTING-----
            question.questiontext = "HOW CANCEROUS AM I?";

            

            answers[0].answertext = "ULTRA";
            answers[0].isanswer = true;

            answers[1].answertext = "Not at all! D:";
            answers[1].isanswer = false;

            answers[2].answertext = "Just. kys yourself.";
            answers[2].isanswer = true;

            answers[3].answertext = "BELIEVE IN YOURSELF";
            answers[3].isanswer = false;
            //-----DEBUG TESTING-----

            setQuestion(question);

            //Loops through and ensures that the program knows how many correct answers there are.
            foreach (Answer answer in answers)
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

            //Put each of the question checkboxes into an array to loop through when the answer button is clicked.
            checkBoxes[0] = questionBox1;
            checkBoxes[1] = questionBox2;
            checkBoxes[2] = questionBox3;
            checkBoxes[3] = questionBox4;

            //The answers (sets the text for each of the answers.
            for (int i = 0; i < 4; i++)
            {
                checkBoxes[i].Text = answers[i].answertext;
            }
            
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
