
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AdministratorUser, AdministratorRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BRLRPQO\\SQLEXPRESS; database=DBWebARC; integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<HeadSlider> HeadSliders { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Reference> References { get; set; }

        public DbSet<OurService> ourServices { get; set; }

        public DbSet<Message> messages { get; set; }

        public DbSet<FAQ> FAQs { get; set; }

        public DbSet<PrivacyPolicy> PrivacyPolicies { get; set; }

        public DbSet<Settings> settings { get; set; }

        public DbSet<SocialLinks> socialLinks { get; set; }

        public DbSet<Team> teams { get; set; }

        public DbSet<RandomInfo> RandomInfos { get; set; }
    }
}
