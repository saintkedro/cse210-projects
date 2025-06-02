public class Reference
{
    public string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return _endVerse.HasValue ? $"{_book} {_chapter}:{_startVerse}-{_endVerse}" : $"{_book} {_chapter}:{_startVerse}";
    }

    public string GetBook() => _book;
    public int GetChapter() => _chapter;
    public int GetStartVerse() => _startVerse;
    public int? GetEndVerse() => _endVerse;

    public void SetBook(string book) => _book = book;
    public void SetChapter(int chapter) => _chapter = chapter;
    public void SetStartVerse(int verse) => _startVerse = verse;
    public void SetEndVerse(int? endVerse) => _endVerse = endVerse;
}