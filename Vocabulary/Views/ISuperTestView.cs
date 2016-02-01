using System;
using System.Windows.Forms;
using Vocabulary.MVP;

namespace Vocabulary.Views
{
    public interface ISuperTestView : IView
    {
        NumericUpDown Numeric { get; }
        Button ButtonStart { get; }
        Button ButtonAnswer { get; }
        Button ButtonNext { get; }
        ComboBox ComboBoxWords { get; }
        RadioButton RadioButtonVariant1 { get; }
        RadioButton RadioButtonVariant2 { get; }
        RadioButton RadioButtonVariant3 { get; }

        string EnglishWordForTest { get; set; }
        int ValueNumeric { get; }

        event EventHandler Loaded;
        event EventHandler StartTest;
        event EventHandler Answer;
        event EventHandler ChooseNeededWords;
        event EventHandler Next;
    }
}