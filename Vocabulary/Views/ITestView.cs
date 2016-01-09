using System;
using System.Windows.Forms;
using Vocabulary.MVP;

namespace Vocabulary.Views
{
    public interface ITestView : IView
    {
        RadioButton RadioButtonOnlyVerbs { get; }
        RadioButton RadioButtonOnlyPhrasalVerbs { get; }
        RadioButton RadioButtonExceptVerbs { get; }
        RadioButton RadioButtonOnlyVerbGet { get; }
        RadioButton RadioButtonOnlyVerbKeep { get; }
        RadioButton RadioButtonOnlyVerbLook { get; }
        RadioButton RadioButtonOnlyVerbBe { get; }
        RadioButton RadioButtonOnlyVerbPut { get; }
        RadioButton RadioButtonOnlyVerbTurn { get; }
        RadioButton RadioButtonOnlyVerbGo { get; }
        RadioButton RadioButtonOnlyVerbMake { get; }
        RadioButton RadioButtonOnlyVerbTake { get; }
        string EnglishWordForTest { get; set; }
        string TranslationIntoRussian { get; set; }
        string RussianhWordForTest { get; set; }
        string TranslationIntoEnglish { get; set; }

        event EventHandler Loaded;
        event EventHandler ChooseEnglishWord;
        event EventHandler ShowRussianWord;
        event EventHandler ChooseRussianWord;
        event EventHandler ShowEnglishWord;
        event EventHandler ChooseNeededWords;
    }
}