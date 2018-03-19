namespace UkrainianLiteraure
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BaseModel : DbContext
    {
        public BaseModel()
            : base("name=BaseModel1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Hero> Heroes { get; set; }
        public virtual DbSet<Periphras> Periphrases { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithOptional(e => e.Author)
                .HasForeignKey(e => e.BookAuthor_Id);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Periphrases)
                .WithOptional(e => e.Author)
                .HasForeignKey(e => e.PeriphraseOwner_Id);

            modelBuilder.Entity<Book>()
                .HasMany(e => e.Heroes)
                .WithOptional(e => e.Book)
                .HasForeignKey(e => e.HerosBook_Id);

            modelBuilder.Entity<Question>()
                .HasMany(e => e.Answers)
                .WithOptional(e => e.Question)
                .HasForeignKey(e => e.Question_Id);

            modelBuilder.Entity<Test>()
                .HasMany(e => e.Questions)
                .WithOptional(e => e.Test)
                .HasForeignKey(e => e.Test_Id);
        }
    }
}
