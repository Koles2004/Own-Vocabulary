using System.Collections.Generic;
using System.Linq;
using Vocabulary.DomainModel;
using System.Data.Entity;

namespace Vocabulary.EF.DomainModel
{
    public class Database : IDatabase
    {
        private readonly VocabularyContext context = new VocabularyContext();

        public void Dispose()
        {
            context.Dispose();
        }

        public IEnumerable<Word> GetAllWords()
        {
            return context.Words.ToList();            
        }

        public long InsertWord(Word word)
        {
            context.Words.Add(word);
            context.SaveChanges();

            return word.Id;
        }

        public void UpdateWord(Word word)
        {
            Word c = context.Words.Find(word.Id);

            if (c != null)
            {
                c.EnglishWord = word.EnglishWord;
                c.Translation = word.Translation;
                
                context.Entry(c).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteWord(long id)
        {
            Word w = context.Words.Find(id);

            if (w != null)
            {
                context.Words.Remove(w);
                context.SaveChanges();
            }
        }
    }
}