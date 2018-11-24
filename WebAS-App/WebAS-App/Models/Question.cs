using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAS.Models
{
    public class Question
{
        public int ID_Question { get; set; }
        public string QuestionDescription { get; set; }
        public string Category { get; set; }
        public string Difficulty { get; set; }
        public string Answer { get; set; }
    }
}
