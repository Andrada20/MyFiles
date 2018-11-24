using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAS.Models
{
    public class Quiz
{
        public int ID_Quiz { get; set; }
        public int TotalQuestions { get; set; }
        public int ID_Event { get; set; }
        public DateTime MaxTime { get; set; }
        public int Score { get; set; }
    }
}
