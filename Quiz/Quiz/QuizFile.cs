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
    class QuizFile {
        public QuizObject main;

        public void CreateFile() {
            SaveFileDialog saver = new SaveFileDialog();
            saver.Filter = "quiz files (*.quiz)|*.quiz|All files (*.*)|*.*";
            saver.FilterIndex = 1;

            if (saver.ShowDialog() == DialogResult.OK) {
                Stream FileStream = saver.OpenFile();

                using (StreamWriter writer = new StreamWriter(FileStream)) {
                    //writer.WriteLine("ID: " + main.ID);
                    writer.WriteLine("Name: " + main.name);
                    writer.WriteLine("Subject: " + main.subject);
                }
            }
        }
    }
}