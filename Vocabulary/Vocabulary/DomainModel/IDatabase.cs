using System;
using System.Collections.Generic;

namespace Vocabulary.DomainModel
{
    public interface IDatabase : IDisposable
    {
        IEnumerable<Word> GetAllWords();
        
        long InsertWord(Word word);
        void UpdateWord(Word word);
        void DeleteWord(long id);
    }
}