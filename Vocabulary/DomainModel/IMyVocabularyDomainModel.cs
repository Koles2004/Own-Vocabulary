using System;

namespace Vocabulary.DomainModel
{
    public interface IMyVocabularyDomainModel : IDisposable
    {
        IRepository<Word> WordRepository { get; }
    }
}