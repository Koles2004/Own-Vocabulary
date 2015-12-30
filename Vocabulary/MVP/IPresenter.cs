namespace Vocabulary.MVP
{
    public interface IPresenter<T> where T : IView
    {
        T View { get; set; }
    }
}