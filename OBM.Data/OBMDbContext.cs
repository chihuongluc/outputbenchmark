namespace OBM.Data
{
    using OBM.Data.Models;
    using System.Data.Entity;

    public partial class OBMDbContext : DbContext
    {
        public OBMDbContext(): base("name=OBMDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ChineseScore> ChineseScores { get; set; }
        public virtual DbSet<FinalTest> FinalTests { get; set; }
        public virtual DbSet<ITScore> ITScores { get; set; }
        public virtual DbSet<JoinFinalTest> JoinFinalTests { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<ToeicScore> ToeicScores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<FinalTest>()
                .HasMany(e => e.JoinFinalTests)
                .WithRequired(e => e.FinalTest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinalTest>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.FinalTest)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JoinFinalTest>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Accounts)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.Room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule>()
                .Property(e => e.TestDate)
                .IsUnicode(false);

            modelBuilder.Entity<Score>()
                .HasOptional(e => e.ChineseScore)
                .WithRequired(e => e.Score);

            modelBuilder.Entity<Score>()
                .HasOptional(e => e.ITScore)
                .WithRequired(e => e.Score);

            modelBuilder.Entity<Score>()
                .HasOptional(e => e.ToeicScore)
                .WithRequired(e => e.Score);

            modelBuilder.Entity<Student>()
                .Property(e => e.Birthday)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Course)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Mobile)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.JoinFinalTests)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.JoinFinalTests)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subject>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.Subject)
                .WillCascadeOnDelete(false);
        }
    }
}