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
        public DbSet<Question> Questions { get; set; }
    }

    public class Quiz {
        [Key]
        public string username { get; set; }
        public ICollection<Question> questions { get; set; }
    }

    public class Question {
        public string test;
    }
}
