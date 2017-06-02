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


namespace Quiz {
    public class QuizFile {
        public QuizObject main;


        public QuizFile(QuizObject obj) {
            this.main = obj;
        }

        public void CreateFile() {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Filter = "Quiz files (*.quiz)|*.quiz";
            saver.FilterIndex = 1;

            if (saver.ShowDialog() == DialogResult.OK) {
                Stream FileStream = saver.OpenFile();

                using (StreamWriter writer = new StreamWriter(FileStream)) {
                    //writer.WriteLine("ID: " + main.ID);
                    writer.WriteLine("Name: " + main.name);
                    writer.WriteLine("Subject: " + main.subject);

                    for(int i = 0; i < main.numofquestions; i++) {
                        writer.WriteLine((i+1).ToString() + ": " + main.questions[i]);
                    }
                }
            }
        }
    }
}