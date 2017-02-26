namespace Vocabulary.DomainModel
{
    public class Word
    {
        public long Id { get; set; }
        public string EnglishWord { get; set; }
        public string Translation { get; set; }
        public bool? Known { get; set; }
    }
}