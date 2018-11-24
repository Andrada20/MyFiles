using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAS.Models
{
    public class Account
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string OnlinePassword { get; set; }
        protected string Type { get; set; }
        public int ID_Quiz { get; set; }

    }
    public class HtmlHelper { }
}
