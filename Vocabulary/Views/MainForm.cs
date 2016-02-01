using System;
using System.Windows.Forms;

namespace Vocabulary.Views
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public ListView ListView { get { return listView1; } }

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

        public event EventHandler Add;

        private void AddHandler(object sender, EventArgs e)
        {
            if (Add != null)
                Add(this, EventArgs.Empty);
        }

        public event EventHandler Edit;

        private void EditHandler(object sender, EventArgs e)
        {
            if (Edit != null)
                Edit(this, EventArgs.Empty);
        }

        public event EventHandler Delete;

        private void DeleteHandler(object sender, EventArgs e)
        {
            if (Delete != null)
                Delete(this, EventArgs.Empty);
        }

        public event EventHandler Translate;

        private void TranslateHandler(object sender, EventArgs e)
        {
            if (Translate != null)
                Translate(this, EventArgs.Empty);
        }

        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditHandler(sender, e);
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close?", "Close", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
                Close();
        }

        public event EventHandler OpenTestForm;

        private void OpenTestFormHandler(object sender, EventArgs e)
        {
            if (OpenTestForm != null)
                OpenTestForm(this, EventArgs.Empty);
        }

        public event EventHandler OpenSuperTestForm;

        private void OpenSuperTestFormHandler(object sender, EventArgs e)
        {
            if (OpenSuperTestForm != null)
                OpenSuperTestForm(this, EventArgs.Empty);
        }
    }
}