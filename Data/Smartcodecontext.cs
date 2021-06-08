using Microsoft.EntityFrameworkCore;
using Smartcode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smartcode.Data
{
    public class Smartcodecontext : DbContext
    {
        public  Smartcodecontext(DbContextOptions options):base(options){}

        public DbSet<YourMessage> yourMessage { get; set; }
    }
}
