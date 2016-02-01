using System;
using System.Windows.Forms;

namespace Vocabulary.Views
{
    public partial class SuperTestForm : Form, ISuperTestView
    {
        public SuperTestForm()
        {
            InitializeComponent();
        }

        public NumericUpDown Numeric { get { return numericUpDown1; } }
        public Button ButtonStart { get { return buttonStart; } }
        public Button ButtonAnswer { get { return buttonAnswer; } }
        public Button ButtonNext { get { return buttonNext; } }
        public ComboBox ComboBoxWords { get { return comboBoxWords; } }
        public RadioButton RadioButtonVariant1 { get { return radioButtonVariant1; } }
        public RadioButton RadioButtonVariant2 { get { return radioButtonVariant2; } }
        public RadioButton RadioButtonVariant3 { get { return radioButtonVariant3; } }
        public int ValueNumeric { get { return (int)numericUpDown1.Value; } }

        public string EnglishWordForTest
        {
            get { return textBoxFromEnglish.Text.Trim(); }
            set { textBoxFromEnglish.Text = value; }
        }

        public event EventHandler Loaded;

        private void LoadedHandler(object sender, EventArgs e)
        {
            if (Loaded != null)
                Loaded(this, EventArgs.Empty);
        }

        public event EventHandler StartTest;

        private void StartTestHandler(object sender, EventArgs e)
        {
            if (StartTest != null)
                StartTest(this, EventArgs.Empty);
        }

        public event EventHandler Answer;

        private void AnswerHandler(object sender, EventArgs e)
        {
            if (Answer != null)
                Answer(this, EventArgs.Empty);
        }

        public event EventHandler Next;

        private void NextHandler(object sender, EventArgs e)
        {
            if (Next != null)
                Next(this, EventArgs.Empty);
        }

        public event EventHandler ChooseNeededWords;

        private void ChooseNeededWordsHandler(object sender, EventArgs e)
        {
            if (ChooseNeededWords != null)
                ChooseNeededWords(this, EventArgs.Empty);
        }

        private void radioButtonVariant1_CheckedChanged(object sender, EventArgs e)
        {
            buttonAnswer.Enabled = RadioButtonVariant1.Checked || RadioButtonVariant2.Checked ||
                                   RadioButtonVariant3.Checked;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}