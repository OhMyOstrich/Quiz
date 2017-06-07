using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz {
    static class Stuff {

        public static QuizDatabase db = new QuizDatabase();
        public static QuizObject currentquiz;
        public static string pass;

        public static void AddQuiz(string n, List<Question> q) {
            Stuff.db.Quizzes.Add(new QuizObject { name = n, questions = q });
            Stuff.db.SaveChanges();
            Stuff.db = null;
            Stuff.db = new QuizDatabase();
        }

        public static void AddQuiz(string n) {
            Stuff.db.Quizzes.Add(new QuizObject { name = n });
            Stuff.db.SaveChanges();
            Stuff.db = null;
            Stuff.db = new QuizDatabase();
        }

    }
}