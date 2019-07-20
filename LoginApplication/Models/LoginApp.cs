namespace LoginApplication.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LoginApp : DbContext
    {
        public LoginApp()
            : base("name=LoginApp")
        {
        }

        public virtual DbSet<login> logins { get; set; }
        public virtual DbSet<student> students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<student>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
