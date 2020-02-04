using Microsoft.EntityFrameworkCore;
using PartyInvitationsPortal.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyPortalInvitations.DataAccess
{

    public class AppDbcontext : DbContext
    {

        //public AppDbcontext(DbContextOptions<AppDbcontext> options)
        //    : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8DOFC5M;Database=PartInvitationsDB;Trusted_Connection=true");

        }

        public DbSet<RegisterUser> registerUser { get; set; }
    }
}
