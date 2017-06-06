using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz {
    class TakeQuiz {
        public QuizObject main;
        public TakeQuiz(QuizObject quiz) {
            main = quiz;
            CreateQuizWindow(main);
        }

        private void CreateQuizWindow(QuizObject quiz) {
            Quiz form = new Quiz();
            form.Show();
        }
    }
}