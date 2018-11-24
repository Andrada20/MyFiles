using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAS.Models
{
    public class ProblemContext :DbContext
    {

    }
    public virtual DbSet<Account> Accounts { get; set; }

}
