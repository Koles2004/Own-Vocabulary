using System;
using Vocabulary.MVP;

namespace Vocabulary.Views
{
    public interface IWordView : IView
    {
        string EnglishWord { get; set; }
        string Translation { get; set; }
        
        event EventHandler Loaded;        
    }
}