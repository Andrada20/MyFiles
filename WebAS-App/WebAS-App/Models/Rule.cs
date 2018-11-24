using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAS.Models
{
    public class Rule
    {
        public int ID_Question { get; set; }
        public string Category { get; set; }
        public string Difficulty { get; set; }
        public int ID_Quiz { get; set; }
}
}
