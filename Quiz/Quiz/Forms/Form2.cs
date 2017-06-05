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
        private List<Question> q;
        int currentQuestionNumber = 0;
        Question question = new Question();
        //--Debug--
        Question question1 = new Question();
        Question question2 = new Question();
        //--Debug--
        private List<Answer> answers;
        private List<CheckBox> checkBoxes;
        //Variable that checks to see how many answers were chosen that were correct, that the user chose.
        private int correctAnswers;
        //THIS one decides how many answers will be correct out of the few.
        int setCorrectAnswers;
        //This one is universal among the questions, and adds one if all correct answers in a question are selected.
        public static int realCorrectAnswers = 0;

        public QuestionForm()
        {
            //Initialize the variables
            answers = new List<Answer>();
            checkBoxes = new List<CheckBox>();
            q = new List<Question>();
            //Adding values to them.
            for (int i = 0; i < 3; i++)
            {
                q.Add(new Question { answers = new List<Answer>()});
            }

            for (int i = 0; i < 4; i++) {
                answers.Add(new Answer());
                checkBoxes.Add(new CheckBox());
            }

            //-----DEBUG TESTING START-----
            question.questiontext = "HOW CANCEROUS AM I?";

            //for (int i = 0; i < 3; i++)
            //{
            //    q[i].answers = new List<Answer>();
                
            //}

            for (int b = 0; b < 3; b++) {
                for (int i = 0; i < 4; i++) {
                    q[b].answers.Add(new Answer());
                }
            }

            q[0].answers[0].answertext = "ULTRA";
            q[0].answers[0].isanswer = true;

            q[0].answers[1].answertext = "Not at all! D:";
            q[0].answers[1].isanswer = false;

            q[0].answers[2].answertext = "Just. kys yourself.";
            q[0].answers[2].isanswer = true;

            q[0].answers[3].answertext = "BELIEVE IN YOURSELF";
            q[0].answers[3].isanswer = false;



            
            //Question 2
            question1.questiontext = "Who do I like?";
            q[0].questiontext = question1.questiontext;

            q[1].answers[0].answertext = "Not going to say";
            q[1].answers[0].isanswer = true;

            q[1].answers[1].answertext = "Haha, still not gonna say";
            q[1].answers[1].isanswer = true;

            q[1].answers[2].answertext = "Nah";
            q[1].answers[2].isanswer = true;

            q[1].answers[3].answertext = "Some person";
            q[1].answers[3].isanswer = false;
            
            q[1] = question1;
            //Question 3
            question2.questiontext = "Which of these are garbage?";

            q[2].answers[0].answertext = "The Album 'One More Light' by Linkin Park";
            q[2].answers[0].isanswer = true;

            q[2].answers[1].answertext = "Twenty One Pilots";
            q[2].answers[1].isanswer = true;

            q[2].answers[2].answertext = "Lord of the Rings";
            q[2].answers[2].isanswer = false;

            q[2].answers[3].answertext = "Unity Game Engine";
            q[2].answers[3].isanswer = false;

            q[2] = question2;
            //-----DEBUG TESTING END-----

            setQuestion(q);

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

        void setQuestion(List<Question> question)
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
            questionLabel.Text = question.questiontext;

            //Put each of the question checkboxes into an array to loop through when the answer button is clicked.
            checkBoxes[0] = questionBox1;
            checkBoxes[1] = questionBox2;
            checkBoxes[2] = questionBox3;
            checkBoxes[3] = questionBox4;

            //The answers (sets the text for each of the answers.
            for (int i = 0; i < 3; i++)
            {
                checkBoxes[i].Text = q[i].answers[i].answertext;
            }
            
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            //Set which question to be loaded
            currentQuestionNumber++;
            question = q[currentQuestionNumber];

            //The question
            questionLabel.Text = question.questiontext;

            for (int i = 0; i < 4; i++)
            {
                checkBoxes[i].Text = question.answers[i].answertext;
            }


            //The answers (sets the text for each of the answers.)
            for (int i = 0; i < 4; i++)
            {
                checkBoxes[i].Text = answers[i].answertext;
            }
            //Loop through each of the questions, and check to see if the correct answers were chosen.
            for (int i = 0; i < 4; i++)
            {
                //Check what the user selected against what is actually correct
                if(checkBoxes[i].Checked && answers[i].isanswer)
                {
                    correctAnswers += 1;
                    if (correctAnswers == setCorrectAnswers)
                    {
                        realCorrectAnswers++;
                        label1.Text = realCorrectAnswers.ToString();
                    }
                }
            }
            //Set the question to have been correctly answered, if the user answered correctly.
            if(correctAnswers == setCorrectAnswers)
            {
                q[currentQuestionNumber].wasAnsweredCorrectly = true;
            } else {
                q[currentQuestionNumber].wasAnsweredCorrectly = false;
            }
        }
    }
}
