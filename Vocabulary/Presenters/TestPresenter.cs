using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vocabulary.DomainModel;
using Vocabulary.MVP;
using Vocabulary.Views;

namespace Vocabulary.Presenters
{
    public class TestPresenter : BasePresenter<ITestView>
    {
        private IMyVocabularyDomainModel Model { get; set; }
        readonly Random rand = new Random();
        private List<Word> words;
        private long identifier;

        public TestPresenter(IMyVocabularyDomainModel domainModel, ITestView testView)
        {
            // save references on model and view
            Model = domainModel;
            View = testView;
            // subscribe to the events of view
            View.Loaded += OnLoaded;
            View.ChooseEnglishWord += OnChooseEnglishWord;
            View.ShowRussianWord += OnShowRussianWord;
            View.ChooseRussianWord += OnChooseRussianWord;
            View.ShowEnglishWord += OnShowEnglishWord;
            View.ChooseNeededWords += GetWords;
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            try
            {
                words = Model.WordRepository.GetAll().ToList();
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
                View.ComboBoxWords.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show("There is an error by getting words.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnChooseEnglishWord(object sender, EventArgs e)
        {
            var index = rand.Next(0, words.Count);
            long id = 0;

            id = words[index].Id;

            View.EnglishWordForTest = words.Find(w => w.Id == id).EnglishWord;

            View.TranslationIntoRussian = "";
        }

        private void OnShowRussianWord(object sender, EventArgs e)
        {
            var str = View.EnglishWordForTest;

            if (str != "")
                View.TranslationIntoRussian = words.Find(w => w.EnglishWord == str).Translation;
            else
                MessageBox.Show("There is no English word", "Error");
        }

        private void OnChooseRussianWord(object sender, EventArgs e)
        {
            var index = rand.Next(0, words.Count);
            long id = 0;

            id = words[index].Id;

            View.RussianhWordForTest = words.Find(w => w.Id == id).Translation;

            View.TranslationIntoEnglish = "";

            identifier = id;
        }

        private void OnShowEnglishWord(object sender, EventArgs e)
        {
            if (View.RussianhWordForTest != "")
                View.TranslationIntoEnglish = words.Find(w => w.Id == identifier).EnglishWord;
            else
                MessageBox.Show("There is no Russian word", "Error");
        }

        private void GetWords(object sender, EventArgs e)
        {
            var wordsfromDB = Model.WordRepository.GetAll().ToList();

            switch (View.ComboBoxWords.SelectedItem.ToString())
            {
                case "Except verbs":
                    words = wordsfromDB.Where(w => !w.EnglishWord.StartsWith("To ")).ToList();
                    break;
                case "Only verbs":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To ")).ToList();
                    break;
                case "Only phrasal verbs":
                    words = wordsfromDB.Where(w => w.EnglishWord.Split().Length > 2).ToList()
                    .Where(w => w.EnglishWord.StartsWith("To ")).ToList();
                    break;
                case "Only verb \"Get\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To get ")).ToList();
                    break;
                case "Only verb \"Look\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To look ")).ToList();
                    break;
                case "Only verb \"Be\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To be ")).ToList();
                    break;
                case "Only verb \"Keep\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To keep ")).ToList();
                    break;
                case "Only verb \"Put\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To put ")).ToList();
                    break;
                case "Only verb \"Turn\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To turn ")).ToList();
                    break;
                case "Only verb \"Go\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To go ")).ToList();
                    break;
                case "Only verb \"Make\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To make ")).ToList();
                    break;
                case "Only verb \"Take\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To take ")).ToList();
                    break;
                default:
                    words = wordsfromDB;
                    break;
            }

            // When the ComboBoxItem is changed, all textboxes are cleared
            View.EnglishWordForTest = "";
            View.TranslationIntoRussian = "";
            View.RussianhWordForTest = "";
            View.TranslationIntoEnglish = "";
        }
    }
}