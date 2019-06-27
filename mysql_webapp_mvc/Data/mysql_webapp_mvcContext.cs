using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace mysql_webapp_mvc.Models
{
    public class mysql_webapp_mvcContext : DbContext
    {
        public mysql_webapp_mvcContext (DbContextOptions<mysql_webapp_mvcContext> options)
            : base(options)
        {
        }

        public DbSet<mysql_webapp_mvc.Models.city> city { get; set; }
    }
}
