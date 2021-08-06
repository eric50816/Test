using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_test.Models
{
    public class OperaContext : DbContext
    {
        public DbSet<Opera> Operas { get; set; }
    }
}