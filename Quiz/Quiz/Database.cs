﻿using System;
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
        public virtual List<Question> questions { get; set; }

       
    }

    class Question {
        [Key]
        public int ID { get; set; }
        public bool wasAnsweredCorrectly { get; set; }
        public string questiontext { get; set; }
        public List<Answer> answers { get; set; }

        public override string ToString() {
            return questiontext;
        }
    }

    class Answer {
        [Key]
        public int ID { get; set; }
        public string answertext { get; set; }
        public bool isanswer { get; set; }
    }
}
