using System;
using System.Windows.Forms;
using Vocabulary.MVP;

namespace Vocabulary.Views
{
    public interface IMainView : IView
    {
        ListView ListView { get; }
        TextBox TextBoxEnglishWord { get; }

        string EnglishWord { get; set; }
        string Translation { get; set; }

        event EventHandler Loaded;
        event EventHandler Add;
        event EventHandler Edit;
        event EventHandler Delete;
        event EventHandler Translate;
        event EventHandler OpenTestForm;
        event EventHandler OpenSuperTestForm;
        event EventHandler AddWordTo;
        event EventHandler OpenTestWithKnownWordsForm;
    }
}