using System.Collections.Generic;

namespace Vocabulary.DomainModel
{
    public class WordRepository : IRepository<Word>
    {
        private readonly IDatabase db;

        public WordRepository(IDatabase database)
        {
            db = database;
        }

        public IEnumerable<Word> GetAll()
        {
            return db.GetAllWords();
        }

        public long Add(Word word)
        {
            return db.InsertWord(word);
        }

        public void Update(Word word)
        {
            db.UpdateWord(word);
        }

        public void Delete(long id)
        {
            db.DeleteWord(id);
        }
    }
}