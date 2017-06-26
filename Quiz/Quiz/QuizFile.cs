using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Quiz {
    public class QuizFile {
        public QuizObject main;

        public QuizFile() {
            this.main = new QuizObject();
        }

        public QuizFile(QuizObject obj) {
            this.main = obj;
        }

        private int colonIndex;
        private string questionTextTemp;
        char colon = new char();

        //Writes new file of the .quiz type
        public void CreateFile() {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Filter = "Quiz files (*.quiz)|*.quiz";
            saver.FilterIndex = 1;

            if (saver.ShowDialog() == DialogResult.OK) {
                Stream FileStream = saver.OpenFile();

                //Writes header to quiz file detailing name and subject
                using (StreamWriter writer = new StreamWriter(FileStream)) {
                    writer.WriteLine("Name: " + main.name);
                    writer.WriteLine("Subject: " + main.subject);

                    //Writes questions entered into create quiz section in order
                    for(int i = 0; i < main.numofquestions; i++) {
                        writer.WriteLine((i + 1).ToString() + ": " + main.questions[i]);
                        foreach(Answer a in main.questions[i].answers)
                        {
                            //Writes answer and if answer is true or false
                            writer.WriteLine(a);
                            if (a.isanswer) {
                                writer.WriteLine("True");
                            }
                            else {
                                writer.WriteLine("False");
                            }
                        }
                    }
                }
            }
        }

        //Reads new file of the .quiz type
        public QuizObject OpenFile() {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Quiz files (*.quiz)|*.quiz";

            if (openFile.ShowDialog() == DialogResult.OK) {
                Stream fileStream = openFile.OpenFile();

                //Reads name, subject, and creates new list of questions
                using (StreamReader reader = new StreamReader(fileStream)) {
                    main.name = reader.ReadLine().Remove(0, 5);
                    main.subject = reader.ReadLine().Remove(0, 9);
                    main.questions = new List<Question>();

                    //Populates list of questions with the text and answers to each question
                    while (reader.Peek() > 0) {
                        Question quest = new Question();
                        questionTextTemp = reader.ReadLine();
                        colonIndex = questionTextTemp.IndexOf(":");
                        quest.questiontext = questionTextTemp.Remove(0, colonIndex + 1);
                        quest.answers = new List<Answer>();
                        for (int i = 0; i < 8; i++) {
                            if (i % 2 > 0) {
                                Answer ans = new Answer();
                                ans.answertext = reader.ReadLine();
                                //Assigns corect answers
                                if (reader.ReadLine().Equals("True")) {
                                    ans.isanswer = true;
                                }
                                quest.answers.Add(ans);
                            }
                        }
                        main.questions.Add(quest);
                        main.numofquestions++;
                    }
                }
            }
            return main;
        }
    }
}
