using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ionasc_Robert_Lab6.Models;

namespace Ionasc_Robert_Lab6.Data
{
    public class Ionasc_Robert_Lab6Context : DbContext
    {
        public Ionasc_Robert_Lab6Context (DbContextOptions<Ionasc_Robert_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Ionasc_Robert_Lab6.Models.Book> Book { get; set; }
    }
}
