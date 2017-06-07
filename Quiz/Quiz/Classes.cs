using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Quiz {

    public class QuizObject {
        public int ID { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public int numofquestions { get; set; }
        public virtual List<Question> questions { get; set; }

        public override string ToString() {
            string obj = name + " " + subject + " ";
            string qs = "";

            foreach(Question q in questions) {
                qs = qs + q;
            }
            
            return obj + qs;
        }


    }

    public class Question {
        public bool wasAnsweredCorrectly { get; set; }
        public string questiontext { get; set; }
        public List<Answer> answers { get; set; }
        public int checkBoxSelected { get; set; }
        public bool questionAnswered { get; set; }

        public override string ToString() {
            //string ans = "";
            //foreach(Answer a in answers) {
            //    ans = ans + a + " " + ": " + a.isanswer;
            //}
            return questiontext;// + " " + ans;
        }
    }

    public class Answer {
        public string answertext { get; set; }
        public bool isanswer { get; set; }

        public override string ToString() {
            return answertext;
        }
    }
}
