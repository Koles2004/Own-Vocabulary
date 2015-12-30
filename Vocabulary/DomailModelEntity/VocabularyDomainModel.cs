using Vocabulary.DomainModel;

namespace Vocabulary.DomailModelEntity
{
    public class VocabularyDomainModel : IMyVocabularyDomainModel
    {
        private readonly IDatabase db;
        private readonly IRepository<Word> wordRepository;

        public VocabularyDomainModel()
        {
            db = new Database();
            wordRepository = new WordRepository(db);
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IRepository<Word> WordRepository { get { return wordRepository; } }
    }
}