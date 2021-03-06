﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vocabulary.MVP;
using Vocabulary.Views;
using Vocabulary.DomainModel;

namespace Vocabulary.Presenters
{
    public class MainPresenter : BasePresenter<IMainView>
    {
        private IMyVocabularyDomainModel Model { get; set; }
        
        public MainPresenter(IMyVocabularyDomainModel domainModel, IMainView mainView)
        {
            // save references on model and view
            Model = domainModel;
            View = mainView;
            // subscribe to the events of view
            View.Loaded += OnLoaded;
            View.Add += OnAdd;
            View.Edit += OnEdit;
            View.Delete += OnDelete;
            View.Translate += OnTranslate;
            View.OpenTestForm += OnOpenTestForm;
            View.OpenSuperTestForm += OnOpenSuperTestForm;
            View.AddWordTo += AddWordTo;
            View.OpenTestWithKnownWordsForm += OnOpenTestWithKnownWordsForm;
        }        

        private void UpdateView()
        {
            try
            {
                IEnumerable<Word> words = Model.WordRepository.GetAll();

                View.ListView.Items.Clear();

                foreach (var word in words)
                {
                    ListViewItem item = View.ListView.Items.Add(new ListViewItem());
                    item.Text = word.EnglishWord;
                    item.SubItems.Add(word.Translation);

                    item.Tag = word;
                }

                View.ListView.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show("There is an error by getting words.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void OnAdd(object sender, EventArgs e)
        {
            IEnumerable<Word> words = Model.WordRepository.GetAll();
            int count = Model.WordRepository.GetAll().ToList().Count;

            var wordPresenter = new WordPresenter(Model, new WordForm());
            wordPresenter.View.EnglishWord = View.EnglishWord;
            
            if (((Form)wordPresenter.View).ShowDialog() == DialogResult.OK)
            {
                if (words.Any(w => w.EnglishWord.ToUpper() == wordPresenter.View.EnglishWord.ToUpper()))
                {
                    MessageBox.Show("Such word is already in the vocabulary.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Model.WordRepository.Add(new Word()
                    {
                        Id = 0,
                        EnglishWord = wordPresenter.View.EnglishWord,
                        Translation = wordPresenter.View.Translation,
                        Known = false                  
                    });

                    count++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                    MessageBox.Show("There is an error by adding new word.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (count == 6000)
                    MessageBox.Show("There are 6000 words in a dictionary");

                UpdateView();
            }
        }

        private void OnEdit(object sender, EventArgs e)
        {
            // Check whether there is at least one selected item in the list
            if (View.ListView.SelectedItems.Count == 0)
                return;

            // If there are several selected items, take the first
            var selectedIndex = View.ListView.SelectedIndices[0];
            Word word = (Word)View.ListView.Items[selectedIndex].Tag;

            var wordPresenter = new WordPresenter(Model, new WordForm());
            
            wordPresenter.View.EnglishWord = word.EnglishWord;
            wordPresenter.View.Translation = word.Translation;

            IEnumerable<Word> words = Model.WordRepository.GetAll();

            if (((Form)wordPresenter.View).ShowDialog() == DialogResult.OK)
            {
                if (words.Any(w => w.EnglishWord.ToUpper() == wordPresenter.View.EnglishWord.ToUpper() &&
                    wordPresenter.View.EnglishWord.ToUpper() != word.EnglishWord.ToUpper()))
                {
                    MessageBox.Show("Such word is already in the vocabulary.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    word.EnglishWord = wordPresenter.View.EnglishWord;
                    word.Translation = wordPresenter.View.Translation;
                    word.Known = false;
                    
                    Model.WordRepository.Update(word);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message);
                    MessageBox.Show(" There is an error by editing a word.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UpdateView();
            }
        }

        private void OnDelete(object sender, EventArgs e)
        {
            // selected items collection in the view words list
            ListView.SelectedIndexCollection selectedIndices = View.ListView.SelectedIndices;

            if (selectedIndices.Count == 0 || MessageBox.Show("Are you sure you want to remove these words?",
                "Words Removing", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                return;

            try
            {
                // Run through the selected items list from bottom till top and remove them from the model and the view
                for (var i = selectedIndices.Count - 1; i >= 0; i--)
                {
                    Model.WordRepository.Delete(((Word)View.ListView.Items[selectedIndices[i]].Tag).Id);
                    View.ListView.Items.RemoveAt(selectedIndices[i]);
                }

                View.ListView.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show("There is an error by removing words.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnTranslate(object sender, EventArgs e)
        {
            if (View.EnglishWord.Length == 0)
                return;

            try
            {
                var wordsForSearch = Model.WordRepository.GetAll().ToList();

                foreach (var wordForSearch in wordsForSearch.Where(wordForSearch => View.EnglishWord.ToLower() == wordForSearch.EnglishWord.ToLower()))
                {
                    View.Translation = wordForSearch.Translation;
                    SelectListViewItem(wordForSearch.EnglishWord);
                    return;
                }

                var result = MessageBox.Show("This word is not in a vocabulary. You can add it", "No word", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                    OnAdd(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show("There is an error by getting a word.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SelectListViewItem(string str)
        {
            if (View.ListView.SelectedIndices.Count != 0)
                View.ListView.SelectedIndices.Clear();

            ListView.ListViewItemCollection toFindColection = View.ListView.Items;

            for (var i = 0; i < toFindColection.Count; i++)
            {
                if (toFindColection[i].Text != str)
                    continue;

                View.ListView.Select();
                toFindColection[i].Selected = true;
                View.ListView.EnsureVisible(i);
                break;
            }
        }

        private void OnOpenTestForm(object sender, EventArgs e)
        {
            MessageBox.Show("Test");

            var testPresenter = new TestPresenter(Model, new TestForm());

            ((Form)(testPresenter.View)).ShowDialog();
        }

        private void OnOpenSuperTestForm(object sender, EventArgs e)
        {
            var superTestPresenter = new SuperTestPresenter(Model, new SuperTestForm());

            ((Form)(superTestPresenter.View)).ShowDialog();
        }

        private void AddWordTo(object sender, EventArgs e)
        {
            View.EnglishWord = "To ";
            View.TextBoxEnglishWord.Select(View.TextBoxEnglishWord.TextLength, 0);
            View.TextBoxEnglishWord.Focus();
        }

        private void OnOpenTestWithKnownWordsForm(object sender, EventArgs e)
        {
            var testWithKnownWordsPresenter = new TestWithKnownWordsPresenter(Model, new TestFormWithKnownWords());

            ((Form)(testWithKnownWordsPresenter.View)).ShowDialog();
        }
    }
}