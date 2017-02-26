using System;
using Vocabulary.DomainModel;
using Vocabulary.MVP;
using Vocabulary.Views;
using System.Windows.Forms;

namespace Vocabulary.Presenters
{
    public class WordPresenter : BasePresenter<IWordView>
    {
        private IMyVocabularyDomainModel Model { get; set; }
        
        public WordPresenter(IMyVocabularyDomainModel domainModel, IWordView wordView)
        {
            // save references on model and view
            Model = domainModel;
            View = wordView;
            // subscribe to the events of view
            View.Loaded += OnLoaded;            
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
                MessageBox.Show("There is an error by getting words.", "Something is wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}