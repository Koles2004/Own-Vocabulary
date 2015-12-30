using System;
using System.Windows.Forms;

namespace Vocabulary.Views
{
    public partial class TestForm : Form, ITestView
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public RadioButton RadioButtonOnlyVerbs { get { return radioButtonOnlyVerbs; } }
        public RadioButton RadioButtonOnlyPhrasalVerbs { get { return radioButtonOnlyPhrasalVerbs; } }
        public RadioButton RadioButtonExceptVerbs { get { return radioButtonExceptVerbs; } }

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

        public string RussianhWordForTest
        {
            get { return textBoxFromRussian.Text.Trim(); }
            set { textBoxFromRussian.Text = value; }
        }

        public string TranslationIntoEnglish
        {
            get { return textBoxToEnglish.Text.Trim(); }
            set { textBoxToEnglish.Text = value; }
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

        public event EventHandler ChooseRussianWord;

        private void ChooseRussianWordHandler(object sender, EventArgs e)
        {
            if (ChooseRussianWord != null)
                ChooseRussianWord(this, EventArgs.Empty);
        }

        public event EventHandler ShowEnglishWord;

        private void ShowEnglishWordHandler(object sender, EventArgs e)
        {
            if (ShowEnglishWord != null)
                ShowEnglishWord(this, EventArgs.Empty);
        }

        public event EventHandler ChooseNeededWords;

        private void ChooseNeededWordsHandler(object sender, EventArgs e)
        {
            if (ChooseNeededWords != null)
                ChooseNeededWords(this, EventArgs.Empty);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}