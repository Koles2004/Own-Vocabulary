using System;
using System.Windows.Forms;

namespace Vocabulary.Views
{
    public partial class WordForm : Form, IWordView
    {
        public WordForm()
        {
            InitializeComponent();
        }

        public string EnglishWord
        {
            get { return textBoxEnglishWord.Text.Trim(); }
            set { textBoxEnglishWord.Text = value; }
        }

        public string Translation
        {
            get { return textBoxTranslation.Text.Trim(); }
            set { textBoxTranslation.Text = value; }
        }

        public event EventHandler Loaded;

        private void LoadedHandler(object sender, EventArgs e)
        {
            if (Loaded != null)
                Loaded(this, EventArgs.Empty);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = EnglishWord.Length > 0 && Translation.Length > 0;
        }
    }
}