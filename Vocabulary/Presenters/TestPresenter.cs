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

            for (int i = 0; i <= index; i++)
            {
                id = words[i].Id;
            }

            View.EnglishWordForTest = words.Find(w => w.Id == id).EnglishWord;

            View.TranslationIntoRussian = "";
        }

        private void OnShowRussianWord(object sender, EventArgs e)
        {
            var str = View.EnglishWordForTest;

            View.TranslationIntoRussian = words.Find(w => w.EnglishWord == str).Translation;
        }

        private void OnChooseRussianWord(object sender, EventArgs e)
        {
            var index = rand.Next(0, words.Count);
            long id = 0;

            for (int i = 0; i <= index; i++)
            {
                id = words[i].Id;
            }

            View.RussianhWordForTest = words.Find(w => w.Id == id).Translation;

            View.TranslationIntoEnglish = "";
        }

        private void OnShowEnglishWord(object sender, EventArgs e)
        {
            var str = View.RussianhWordForTest;

            View.TranslationIntoEnglish = words.Find(w => w.Translation == str).EnglishWord;
        }

        private void GetWords(object sender, EventArgs e)
        {
            var wordsfromDB = Model.WordRepository.GetAll().ToList();
            var flag = true;

            if (View.RadioButtonOnlyVerbs.Checked)
            {
                words = wordsfromDB.Where(w => w.EnglishWord.StartsWith("To ")).ToList();
                flag = false;
            }

            if (View.RadioButtonExceptVerbs.Checked)
            {
                words = wordsfromDB.Where(w => !w.EnglishWord.StartsWith("To ")).ToList();
                flag = false;
            }

            if (View.RadioButtonOnlyPhrasalVerbs.Checked)
            {
                words = wordsfromDB.Where(w => w.EnglishWord.Split().Length > 2).ToList()
                    .Where(w => w.EnglishWord.StartsWith("To ")).ToList();
                flag = false;
            }

            if (flag)
                words = wordsfromDB;

            // When the radiobutton is changed, all textboxes are cleared
            View.EnglishWordForTest = "";
            View.TranslationIntoRussian = "";
            View.RussianhWordForTest = "";
            View.TranslationIntoEnglish = "";
        }
    }
}