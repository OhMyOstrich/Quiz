using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Quiz {
    class QuizDatabase : DbContext {
        public DbSet<QuizObject> Quizzes { get; set; }

        public QuizDatabase() : base("QuizDatabaseAway") {

        }
    }

    class QuizObject {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public int numofquestions { get; set; }
        public virtual ICollection<Question> questions { get; set; }
    }

    class Question {
        [Key]
        public int ID { get; set; }
        public string questiontext { get; set; }
        public ICollection<Answer> answers { get; set; }
    }

    class Answer {
        [Key]
        public int ID { get; set; }
        public string answertext { get; set; }
        public bool isanswer { get; set; }
    }
}
