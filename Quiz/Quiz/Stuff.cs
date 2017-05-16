using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz {
    class Stuff {
        static QuizDatabase db = new QuizDatabase();
        static QuizObject currentquiz;
        public static void AddQuiz(string n, ICollection<Question> q) {
            Stuff.db.Quizzes.Add(new QuizObject{ name = n, questions = q });
            Stuff.db = null;
            Stuff.db = new QuizDatabase()
        }
    }
}