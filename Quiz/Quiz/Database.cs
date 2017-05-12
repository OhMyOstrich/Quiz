using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Quiz {
    class Database : DbContext {
        public DbSet<Quiz> Quizzes { get; set; }
    }

    class Quiz {
        [Key]
        public int ID { get; set; }
        public string name { get; set; }
        public virtual ICollection<Question> questions { get; set; }
    }

    class Question {
        public string questiontext { get; set; }
        public ICollection<Answer> answers { get; set; }
    }

    class Answer {
        public string answertext { get; set; }
        public bool isanswer { get; set; }
    }
}
