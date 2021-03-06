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
            checkBoxes = new List<CheckBox>();
            q = new List<Question>();

            for (int i = 0; i < 4; i++)
            {
                checkBoxes.Add(new CheckBox());
            }
            InitializeComponent();
        }

        private void CreateQuizWindow(QuizObject quiz) {
            this.Hide();
            CreateQuizForm form = new CreateQuizForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
        

        //Set the Labels and QuestionBoxes set to the question put into the load function.
        private void QuestionForm_Load(object sender, EventArgs e) {
            try {
                realCorrectAnswers = 0;
                QuizFile qf = new QuizFile();
                GlobalVariables.currentquiz = qf.OpenFile();
                main = GlobalVariables.currentquiz;

                this.Text = "Question: 1"; //Display which question the user is on

                foreach (Question question in GlobalVariables.currentquiz.questions)
                {
                    q.Add(question);
                }

                //Loops through and ensures that the program knows how many correct answers there are.
                foreach (Answer answer in q[currentQuestionNumber].answers)
                {
                    if (answer.isanswer)
                    {
                        setCorrectAnswers += 1;
                    }
                }

                //The question
                questionBox.Text = q[0].questiontext; ;

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
            catch (Exception)
            {
                MessageBox.Show("File invalid or no file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                //Form1 form = new Form1();
                //form.Show();
            }

        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            realCorrectAnswers = 0;
            //-----These next lines make sure that the program counts the final question.-----
            for (int i = 0; i < 4; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    q[q.Count - 1].checkBoxSelected = i;
                    q[q.Count - 1].questionAnswered = true;
                }
            }
            //----------------------------------------------------------------------------------
            //Loop through each of the questions, and check to see if the correct answers were chosen.
            foreach (Question que in q)
            {
                int correctAnswerIndex = que.answers.Count + 5;

                for(int i = 0; i < 4; i++)
                {
                    if (que.answers[i].isanswer)
                        correctAnswerIndex = i;
                }

                if ((que.checkBoxSelected == correctAnswerIndex) && que.questionAnswered)
                {
                    realCorrectAnswers++;
                    que.wasAnsweredCorrectly = true;
                }
            }
            if (currentQuestionNumber + 1 == main.numofquestions)
            {
                Forms.ScoreForm score = new Forms.ScoreForm(realCorrectAnswers);
                score.FormClosed += (s, args) => this.Close();
                score.Show();
            }
            else
            {
                currentQuestionNumber++;
                question = q[currentQuestionNumber];
            }

        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            try {
                for (int i = 0; i < 4; i++)
                {
                    if (checkBoxes[i].Checked)
                    {
                        q[currentQuestionNumber].checkBoxSelected = i;
                        q[currentQuestionNumber].questionAnswered = true;
                    }
                }

                //Set which question to be loaded
                currentQuestionNumber--;
                question = q[currentQuestionNumber];

                this.Text = "Question: " + (currentQuestionNumber + 1); //Display which question the user is on

                //The question
                questionBox.Text = question.questiontext;

                for (int i = 0; i < 4; i++)
                {

                    checkBoxes[i].Text = q[currentQuestionNumber].answers[i].answertext;

                    if (q[currentQuestionNumber].questionAnswered && q[currentQuestionNumber].checkBoxSelected == i)
                    {
                        checkBoxes[i].Checked = true;
                    }
                    else
                    {
                        checkBoxes[i].Checked = false;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot go lower than question 1");
                //Set which question to be loaded
                currentQuestionNumber = 0; //Ensure that the program never tries to load lower than the count number.
                question = q[currentQuestionNumber];

                //The question
                questionBox.Text = question.questiontext;

                for (int i = 0; i < 4; i++)
                {
                    checkBoxes[i].Text = q[currentQuestionNumber].answers[i].answertext;
                }
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    if (checkBoxes[i].Checked)
                    {
                        q[currentQuestionNumber].checkBoxSelected = i;
                        q[currentQuestionNumber].questionAnswered = true;
                    }
                }
                //Set which question to be loaded
                currentQuestionNumber++;
                question = q[currentQuestionNumber];

                if (currentQuestionNumber+1 == main.numofquestions)
                {
                    answerButton.Enabled = true;
                }

                this.Text = "Question: " + (currentQuestionNumber + 1); //Display which question the user is on

                //The question
                questionBox.Text = question.questiontext;

                for (int i = 0; i < 4; i++)
                {
                    checkBoxes[i].Text = q[currentQuestionNumber].answers[i].answertext;

                    if (q[currentQuestionNumber].questionAnswered && q[currentQuestionNumber].checkBoxSelected == i)
                    {
                        checkBoxes[i].Checked = true;
                    }
                    else
                    {
                        checkBoxes[i].Checked = false;
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Cannot go higher than the final question");
                //Set which question to be loaded
                currentQuestionNumber = q.Count - 1; //Ensure that the program never tries to load higher than the count number.
                question = q[currentQuestionNumber];

                //The question
                questionBox.Text = question.questiontext;

                for (int i = 0; i < 4; i++)
                {
                    checkBoxes[i].Text = q[currentQuestionNumber].answers[i].answertext;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void questionBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}