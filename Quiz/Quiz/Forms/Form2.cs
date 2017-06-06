﻿using System;
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
        public QuizObject main;

        public QuestionForm()
        {
            //Initialize the variables
            answers = new List<Answer>();
            checkBoxes = new List<CheckBox>();
            q = new List<Question>();

            for (int i = 0; i < 4; i++)
            {
                checkBoxes.Add(new CheckBox());
            }
            InitializeComponent();
        }

        private void CreateQuizWindow(QuizObject quiz)
        {
            Quiz form = new Quiz();
            form.Show();
        }

        //Don't worry about this boiii
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

            QuizFile qf = new QuizFile();
            Stuff.currentquiz = qf.OpenFile();

            foreach(Question question in Stuff.currentquiz.questions)
            {
                q.Add(question);
            }

            //Loops through and ensures that the program knows how many correct answers there are.
            foreach (Answer answer in answers)
            {
                if (answer.isanswer)
                {
                    setCorrectAnswers += 1;
                }
            }

            //The question
            questionLabel.Text = q[0].questiontext;

            //Put each of the question checkboxes into an array to loop through when the answer button is clicked.
            checkBoxes[0] = questionBox1;
            checkBoxes[1] = questionBox2;
            checkBoxes[2] = questionBox3;
            checkBoxes[3] = questionBox4;

            //The answers (sets the text for each of the answers.
            for (int i = 0; i < 4; i++)
            {
                checkBoxes[i].Text = q[currentQuestionNumber].answers[i].answertext;
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
                checkBoxes[i].Text = q[currentQuestionNumber].answers[i].answertext;
            }

            //Loop through each of the questions, and check to see if the correct answers were chosen.
            for (int i = 0; i < 4; i++)
            {
                //Check what the user selected against what is actually correct
                if(checkBoxes[i].Checked && q[currentQuestionNumber].answers[i].isanswer)
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
