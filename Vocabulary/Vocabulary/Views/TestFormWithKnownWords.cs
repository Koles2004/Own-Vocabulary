using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocabulary.Views
{
    public partial class TestFormWithKnownWords : Form, ITestWithKnownWordsView
    {
        public TestFormWithKnownWords()
        {
            InitializeComponent();
        }

        public ComboBox ComboBoxWords { get { return comboBoxWords; } }
        public Button ButtonCorrect { get { return buttonCorrect; } }
        public Button ButtonWrong { get { return buttonWrong; } }

        public string EnglishWordForTest
        {
            get { return textBoxFromEnglish.Text.Trim(); }
            set { textBoxFromEnglish.Text = value; }
        }

        public string TranslationIntoRussian
        {
            get { return textBoxToRussian.Text.Trim(); }
            set { textBoxToRussian.Text = value; }
        }

        public string CountOfTranslations
        {
            get { return labelCountOfTranslations.Text; }
            set { labelCountOfTranslations.Text = value; }
        }

        public event EventHandler Loaded;

        private void LoadedHandler(object sender, EventArgs e)
        {
            if (Loaded != null)
                Loaded(this, EventArgs.Empty);
        }

        public event EventHandler ChooseEnglishWord;

        private void ChooseEnglishWordHandler(object sender, EventArgs e)
        {
            if (ChooseEnglishWord != null)
                ChooseEnglishWord(this, EventArgs.Empty);
        }

        public event EventHandler ShowRussianWord;

        private void ShowRussianWordHandler(object sender, EventArgs e)
        {
            if (ShowRussianWord != null)
                ShowRussianWord(this, EventArgs.Empty);
        }        

        public event EventHandler ChooseNeededWords;

        private void ChooseNeededWordsHandler(object sender, EventArgs e)
        {
            if (ChooseNeededWords != null)
                ChooseNeededWords(this, EventArgs.Empty);
        }

        public event EventHandler CorrectAnswer;

        private void CorrectAnswerHandler(object sender, EventArgs e)
        {
            if (CorrectAnswer != null)
                CorrectAnswer(this, EventArgs.Empty);
        }

        public event EventHandler WrongAnswer;

        private void WrongAnswerHandler(object sender, EventArgs e)
        {
            if (WrongAnswer != null)
                WrongAnswer(this, EventArgs.Empty);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}