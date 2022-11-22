using MailBoxServices.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBoxServices.DataAccess
{
   public class MailBoxDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-H45A4ON; Database=MailBoxDb;uid=sefa;password=sefa");
        }
        public DbSet<MAIL_BOX> MailBox { get; set; }
    }
}
