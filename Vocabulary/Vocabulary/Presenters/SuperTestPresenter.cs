using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Vocabulary.DomainModel;
using Vocabulary.MVP;
using Vocabulary.Views;

namespace Vocabulary.Presenters
{
    public class SuperTestPresenter : BasePresenter<ISuperTestView>
    {
        private IMyVocabularyDomainModel Model { get; set; }
        readonly Random rand = new Random();
        private List<Word> words;
        private int count;
        private int rightAnswers;

        public SuperTestPresenter(IMyVocabularyDomainModel domainModel, ISuperTestView superTestView)
        {
            // save references on model and view
            Model = domainModel;
            View = superTestView;
            // subscribe to the events of view
            View.ChooseNeededWords += GetWords;
            View.StartTest += OnStartTest;
            View.Answer += OnAnswer;
            View.Next += OnNext;
            View.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            View.ComboBoxWords.Items.Add("All words");
            View.ComboBoxWords.Items.Add("Except verbs");
            View.ComboBoxWords.Items.Add("Only verbs");
            View.ComboBoxWords.Items.Add("Only phrasal verbs");
            View.ComboBoxWords.Items.Add("Only verb \"Get\"");
            View.ComboBoxWords.Items.Add("Only verb \"Look\"");
            View.ComboBoxWords.Items.Add("Only verb \"Be\"");
            View.ComboBoxWords.Items.Add("Only verb \"Keep\"");
            View.ComboBoxWords.Items.Add("Only verb \"Put\"");
            View.ComboBoxWords.Items.Add("Only verb \"Turn\"");
            View.ComboBoxWords.Items.Add("Only verb \"Go\"");
            View.ComboBoxWords.Items.Add("Only verb \"Make\"");
            View.ComboBoxWords.Items.Add("Only verb \"Take\"");
            View.ComboBoxWords.Items.Add("Only verb \"Run\"");
            View.ComboBoxWords.Items.Add("Only verb \"Throw\"");
            View.ComboBoxWords.Items.Add("Only verb \"Break\"");
            View.ComboBoxWords.Items.Add("Only verb \"Come\"");
            View.ComboBoxWords.Items.Add("Only verb \"Pull\"");
            View.ComboBoxWords.Items.Add("Only verb \"Hang\"");
            View.ComboBoxWords.Items.Add("Only preposition \"In\"");
            View.ComboBoxWords.SelectedIndex = 0;
        }

        private void GetWords(object sender, EventArgs e)
        {
            View.ButtonStart.Enabled = true;

            var wordsfromDB = Model.WordRepository.GetAll().ToList();
            var wordsKnownFalsefromDB = wordsfromDB.Where(w => w.Known != true).ToList();

            switch (View.ComboBoxWords.SelectedItem.ToString())
            {
                case "Except verbs":
                    words = wordsKnownFalsefromDB.Where(w => !w.EnglishWord.StartsWith("To ")).ToList();
                    break;
                case "Only verbs":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To ")).ToList();
                    break;
                case "Only phrasal verbs":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.Split().Length > 2).ToList()
                    .Where(w => w.EnglishWord.StartsWith("To ")).ToList();
                    break;
                case "Only verb \"Get\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To get ")).ToList();
                    break;
                case "Only verb \"Look\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To look ")).ToList();
                    break;
                case "Only verb \"Be\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To be ")).ToList();
                    break;
                case "Only verb \"Keep\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To keep ")).ToList();
                    break;
                case "Only verb \"Put\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To put ")).ToList();
                    break;
                case "Only verb \"Turn\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To turn ")).ToList();
                    break;
                case "Only verb \"Go\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To go ")).ToList();
                    break;
                case "Only verb \"Make\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To make ")).ToList();
                    break;
                case "Only verb \"Take\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To take ")).ToList();
                    break;
                case "Only verb \"Run\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To run ")).ToList();
                    break;
                case "Only verb \"Throw\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To throw ")).ToList();
                    break;
                case "Only verb \"Break\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To break ")).ToList();
                    break;
                case "Only verb \"Come\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To come ")).ToList();
                    break;
                case "Only verb \"Pull\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To pull ")).ToList();
                    break;
                case "Only verb \"Hang\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("To hang ")).ToList();
                    break;
                case "Only preposition \"In\"":
                    words = wordsKnownFalsefromDB.Where(w => w.EnglishWord.StartsWith("In ")).ToList();
                    break;
                default:
                    words = wordsKnownFalsefromDB;
                    break;
            }
        }

        private void Test()
        {
            View.RadioButtonVariant1.Visible = true;
            View.RadioButtonVariant2.Visible = true;
            View.RadioButtonVariant3.Visible = true;

            View.RadioButtonVariant1.Enabled = true;
            View.RadioButtonVariant2.Enabled = true;
            View.RadioButtonVariant3.Enabled = true;

            View.RadioButtonVariant1.Checked = false;
            View.RadioButtonVariant2.Checked = false;
            View.RadioButtonVariant3.Checked = false;

            View.RadioButtonVariant1.BackColor = Color.LightGray;
            View.RadioButtonVariant2.BackColor = Color.LightGray;
            View.RadioButtonVariant3.BackColor = Color.LightGray;

            var index1 = rand.Next(0, words.Count);

            var id1 = words[index1].Id;
            View.EnglishWordForTest = words.Find(w => w.Id == id1).EnglishWord;

            string str1 = words.Find(w => w.Id == id1).Translation;

            var index2 = 0;
            do
            {
                index2 = rand.Next(0, words.Count);
            } while (index2 == index1);

            var id2 = words[index2].Id;
            string str2 = words.Find(w => w.Id == id2).Translation;

            var index3 = 0;
            do
            {
                index3 = rand.Next(0, words.Count);
            } while (index3 == index1 || index3 == index2);

            var id3 = words[index3].Id;
            string str3 = words.Find(w => w.Id == id3).Translation;

            List<string> variants = new List<string> { str1, str2, str3 };

            var indexList = rand.Next(0, variants.Count);
            View.RadioButtonVariant1.Text = variants[indexList];
            variants.RemoveAt(indexList);

            indexList = rand.Next(0, variants.Count);
            View.RadioButtonVariant2.Text = variants[indexList];
            variants.RemoveAt(indexList);

            // now we have only 1 element
            View.RadioButtonVariant3.Text = variants[0];
        }

        private void OnStartTest(object sender, EventArgs e)
        {
            count = 0;
            rightAnswers = 0;

            View.Numeric.Enabled = false;
            View.ButtonStart.Enabled = false;
            View.ComboBoxWords.Enabled = false;

            Test();
        }

        private void OnAnswer(object sender, EventArgs e)
        {
            View.RadioButtonVariant1.Enabled = false;
            View.RadioButtonVariant2.Enabled = false;
            View.RadioButtonVariant3.Enabled = false;

            var id = words.Find(en => en.EnglishWord == View.EnglishWordForTest).Id;
            string translation = words.Find(en => en.Id == id).Translation;

            if (View.RadioButtonVariant1.Text == translation)
                View.RadioButtonVariant1.BackColor = Color.LightGreen;
            else if (View.RadioButtonVariant2.Text == translation)
                View.RadioButtonVariant2.BackColor = Color.LightGreen;
            else if (View.RadioButtonVariant3.Text == translation)
                View.RadioButtonVariant3.BackColor = Color.LightGreen;

            if (View.RadioButtonVariant1.Checked)
            {
                if (View.RadioButtonVariant1.Text == translation)
                    rightAnswers++;
                else
                    View.RadioButtonVariant1.BackColor = Color.Red;
            }
            else if (View.RadioButtonVariant2.Checked)
            {
                if (View.RadioButtonVariant2.Text == translation)
                    rightAnswers++;
                else
                    View.RadioButtonVariant2.BackColor = Color.Red;
            }
            else if (View.RadioButtonVariant3.Checked)
            {
                if (View.RadioButtonVariant3.Text == translation)
                    rightAnswers++;
                else
                    View.RadioButtonVariant3.BackColor = Color.Red;
            }

            View.ButtonAnswer.Enabled = false;
            View.ButtonNext.Enabled = true;
        }

        private void OnNext(object sender, EventArgs e)
        {
            count++;

            if (count == View.ValueNumeric)
            {
                MessageBox.Show("Test is over. You have " + rightAnswers + " right answers", "Finished", MessageBoxButtons.OK);
                View.ButtonStart.Enabled = true;
                View.ComboBoxWords.Enabled = true;
                View.Numeric.Enabled = true;

                View.ButtonAnswer.Enabled = false;
                View.RadioButtonVariant1.Checked = false;
                View.RadioButtonVariant2.Checked = false;
                View.RadioButtonVariant3.Checked = false;
                View.RadioButtonVariant1.Visible = false;
                View.RadioButtonVariant2.Visible = false;
                View.RadioButtonVariant3.Visible = false;
                View.ButtonNext.Enabled = false;
                View.EnglishWordForTest = "";
            }
            else
            {
                View.ButtonNext.Enabled = false;
                Test();
            }
        }
    }
}