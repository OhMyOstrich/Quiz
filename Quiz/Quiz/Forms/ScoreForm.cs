using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz.Forms
{
    public partial class ScoreForm : Form
    {
        private QuizObject quiz;
        private int numCorrect;
        private string scoreTxt;

        public ScoreForm(int numCorrect)
        {
            InitializeComponent();
            quiz = Stuff.currentquiz;
            scoreTxt = numCorrect + " / " + quiz.numofquestions + "  " + 100*((float)numCorrect / (float)quiz.numofquestions) + "%";
            Console.Write(numCorrect);
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            QuizTitle.Text = quiz.name;
            ScoreLabel.Text = scoreTxt;

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveReport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Filter = "Text files (*.txt)|*.txt";
            saver.FilterIndex = 1;

            if (saver.ShowDialog() == DialogResult.OK)
            {
                Stream FileStream = saver.OpenFile();

                using (StreamWriter writer = new StreamWriter(FileStream))
                {
                    writer.WriteLine(quiz.name);
                    writer.WriteLine(quiz.subject);
                    writer.WriteLine(scoreTxt);

                    foreach(Question q in quiz.questions)
                    {
                        writer.WriteLine();
                        writer.WriteLine(q.questiontext);
                        if (q.wasAnsweredCorrectly)
                        {
                            writer.WriteLine("Correct");
                        }
                        else
                        {
                            writer.WriteLine("Incorrect");
                            foreach(Answer a in q.answers)
                            {
                                if (a.isanswer)
                                {
                                    writer.WriteLine("The correct answer is " + a.answertext);
                                }
                            }
                        }
                    }
                }
            }

            File.SetAttributes(saver.FileName, FileAttributes.ReadOnly);

        }
    }
    
}
