using iTextSharp.text;
using iTextSharp.text.pdf;
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
        private string scoreTxt;

        public ScoreForm(int numCorrect)
        {
            InitializeComponent();
            quiz = GlobalVariables.currentquiz;
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
            CreatePdf();
        }

        public void CreatePdf()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = sfd.OpenFile();

                using (Document document = new Document())
                {
                    int count = 1;
                    PdfWriter.GetInstance(document, stream);
                    document.Open();
                    document.Add(new Paragraph(quiz.name));
                    document.Add(new Paragraph(quiz.subject));
                    document.Add(new Paragraph(scoreTxt));

                    foreach (Question q in quiz.questions)
                    {
                        document.Add(new Paragraph("\n"));
                        document.Add(new Paragraph(count + ":" + q.questiontext));
                        if (q.wasAnsweredCorrectly)
                        {
                            document.Add(new Paragraph("Correct"));
                        }
                        else
                        {
                            document.Add(new Paragraph("Incorrect"));
                            foreach (Answer a in q.answers)
                            {
                                if (a.isanswer)
                                {
                                    document.Add(new Paragraph("The correct answer is " + a.answertext));
                                }
                            }
                        }

                        count++;
                    }
                }
            }
        }
    }
    
}
