using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vocabulary.MVP;

namespace Vocabulary.Views
{
    public interface ITestWithKnownWordsView : IView
    {
        ComboBox ComboBoxWords { get; }
        Button ButtonCorrect { get; }
        Button ButtonWrong { get; }
        string CountOfUnknownWords { get; set; }

        string EnglishWordForTest { get; set; }
        string TranslationIntoRussian { get; set; }
        string CountOfTranslations { get; set; }
        
        event EventHandler Loaded;
        event EventHandler ChooseEnglishWord;
        event EventHandler ShowRussianWord;        
        event EventHandler ChooseNeededWords;
        event EventHandler CorrectAnswer;
        event EventHandler WrongAnswer;
    }
}