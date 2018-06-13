namespace NormasLTI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SubjectModel : DbContext
    {
        public SubjectModel()
            : base("name=SubjectModel")
        {
        }

        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>()
                .Property(e => e.SubjectName)
                .IsFixedLength();

            modelBuilder.Entity<Subject>()
                .Property(e => e.SubjectCode)
                .IsFixedLength();
        }
    }
}
