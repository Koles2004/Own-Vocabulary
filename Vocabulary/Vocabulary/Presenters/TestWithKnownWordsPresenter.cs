﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vocabulary.DomainModel;
using Vocabulary.MVP;
using Vocabulary.Views;

namespace Vocabulary.Presenters
{
    public class TestWithKnownWordsPresenter : BasePresenter<ITestWithKnownWordsView>
    {
        private IMyVocabularyDomainModel Model { get; set; }
        readonly Random rand = new Random();
        private List<Word> words;
        
        public TestWithKnownWordsPresenter(IMyVocabularyDomainModel domainModel, ITestWithKnownWordsView testWithKnownWordsView)
        {
            // save references on model and view
            Model = domainModel;
            View = testWithKnownWordsView;
            // subscribe to the events of view
            View.Loaded += OnLoaded;
            View.ChooseEnglishWord += OnChooseEnglishWord;
            View.ShowRussianWord += OnShowRussianWord;            
            View.ChooseNeededWords += GetWords;
            View.CorrectAnswer += MakeWordKnown;
        }

        private void MakeWordKnown(object sender, EventArgs e)
        {
            var wordsfromDB = Model.WordRepository.GetAll().ToList();
            Word word = wordsfromDB.Find(w => w.EnglishWord == View.EnglishWordForTest);

            try
            {
                word.Known = true;
                Model.WordRepository.Update(word);

                View.ButtonCorrect.Enabled = false;
                View.ButtonWrong.Enabled = false;

                words = words.Where(w => w.Known != true).ToList();

                View.CountOfUnknownWords = words.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show("There is an error by making a word known.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            try
            {
                words = Model.WordRepository.GetAll().Where(w => w.Known != true).ToList();

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

                View.CountOfUnknownWords = words.Count.ToString();
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
            var englishWord = words.Find(w => w.Id == id).EnglishWord;

            // count the quantity of commas and plus 1 to get the result of translations
            var translation = words.Find(w => w.EnglishWord == englishWord).Translation;
            var count = 0;
            count = translation.Count(f => f == ',') + 1;
            View.CountOfTranslations = count.ToString();

            View.EnglishWordForTest = englishWord;
            View.TranslationIntoRussian = "";

            if (View.ButtonCorrect.Enabled)
                View.ButtonCorrect.Enabled = false;   
        }

        private void OnShowRussianWord(object sender, EventArgs e)
        {
            var str = View.EnglishWordForTest;

            if (str != "")
            {
                View.TranslationIntoRussian = words.Find(w => w.EnglishWord == str).Translation;
                View.ButtonCorrect.Enabled = true;
                View.ButtonWrong.Enabled = true;
            }
            else
                MessageBox.Show("There is no English word", "Error");
        }        

        private void GetWords(object sender, EventArgs e)
        {
            var wordsfromDB = Model.WordRepository.GetAll().Where(w => w.Known != true).ToList();

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
                case "Only verb \"Run\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To run ")).ToList();
                    break;
                case "Only verb \"Throw\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To throw ")).ToList();
                    break;
                case "Only verb \"Break\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To break ")).ToList();
                    break;
                case "Only verb \"Come\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To come ")).ToList();
                    break;
                case "Only verb \"Pull\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To pull ")).ToList();
                    break;
                case "Only verb \"Hang\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To hang ")).ToList();
                    break;
                case "Only preposition \"In\"":
                    words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("In ")).ToList();
                    break;
                default:
                    words = wordsfromDB;
                    break;
            }

            // When the ComboBoxItem is changed, all textboxes are cleared
            View.EnglishWordForTest = "";
            View.TranslationIntoRussian = "";            
        }
    }
}