namespace NormasLTI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StudentModel : DbContext
    {
        public StudentModel()
            : base("name=StudentModel")
        {
        }

        public virtual DbSet<HistoryStudent> HistoryStudents { get; set; }
        public virtual DbSet<HistoryTeacher> HistoryTeachers { get; set; }
        public virtual DbSet<NormasRegla> NormasReglas { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Trimestre> Trimestres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoryStudent>()
                .Property(e => e.LoginName)
                .IsFixedLength();

            modelBuilder.Entity<HistoryStudent>()
                .Property(e => e.DisplayName)
                .IsFixedLength();

            modelBuilder.Entity<HistoryStudent>()
                .Property(e => e.Domain)
                .IsFixedLength();

            modelBuilder.Entity<HistoryStudent>()
                .Property(e => e.ComputerName)
                .IsFixedLength();

            modelBuilder.Entity<HistoryStudent>()
                .Property(e => e.SubjectName)
                .IsFixedLength();

            modelBuilder.Entity<HistoryStudent>()
                .Property(e => e.SubjectSection)
                .IsFixedLength();

            modelBuilder.Entity<HistoryTeacher>()
                .Property(e => e.LoginName)
                .IsFixedLength();

            modelBuilder.Entity<HistoryTeacher>()
                .Property(e => e.DisplayName)
                .IsFixedLength();

            modelBuilder.Entity<HistoryTeacher>()
                .Property(e => e.Domain)
                .IsFixedLength();

            modelBuilder.Entity<HistoryTeacher>()
                .Property(e => e.ComputerName)
                .IsFixedLength();

            modelBuilder.Entity<NormasRegla>()
                .Property(e => e.NormaContent)
                .IsFixedLength();

            modelBuilder.Entity<NormasRegla>()
                .Property(e => e.CreatedBy)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.DisplayName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.LoginName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.Domain)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.ComputerName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.SubjectName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.SubjectSection)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.LoginName)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.DisplayName)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Domain)
                .IsFixedLength();

            modelBuilder.Entity<Teacher>()
                .Property(e => e.ComputerName)
                .IsFixedLength();

            modelBuilder.Entity<Trimestre>()
                .Property(e => e.Name)
                .IsFixedLength();
        }
    }
}
