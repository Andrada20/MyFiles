using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAS.Models
{
    public class Event
{public  int ID_Event { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public int ID_Quiz { get; set; }
    }
}
