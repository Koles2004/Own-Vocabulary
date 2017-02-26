using System;
using System.Windows.Forms;
using Vocabulary.EF.DomainModel;
using Vocabulary.Presenters;
using Vocabulary.Views;

namespace Vocabulary.EF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (VocabularyDomainModel vocabularyDomainModel = new VocabularyDomainModel())
            {
                var mainPresenter = new MainPresenter(vocabularyDomainModel, new MainForm());
                Application.Run((Form)mainPresenter.View);
            }
        }
    }
}