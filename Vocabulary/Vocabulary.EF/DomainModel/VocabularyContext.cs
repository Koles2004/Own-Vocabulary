using Vocabulary.DomainModel;
using System.Data.Entity;

namespace Vocabulary.EF.DomainModel
{
    public class VocabularyContext : DbContext
    {
        public VocabularyContext() : base("Vocabulary") { }

        public DbSet<Word> Words { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>().Property(w => w.EnglishWord).HasMaxLength(100);
            modelBuilder.Entity<Word>().Property(w => w.EnglishWord).IsRequired();
            modelBuilder.Entity<Word>().Property(w => w.Translation).HasMaxLength(100);
            modelBuilder.Entity<Word>().Property(w => w.Translation).IsRequired();
            modelBuilder.Entity<Word>().Property(w => w.Known).IsRequired();            

            base.OnModelCreating(modelBuilder);
        }
    }
}