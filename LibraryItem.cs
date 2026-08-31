abstract class LibraryItem
{
    private static int _totalItems = 0;

    public static int TotalItems => _totalItems;

    public const int MinYear = 1450;

    public string Title { get; init; }

    private int _year;

    public int Year
    {
        get => _year;
        set
        {
            if (value >= MinYear && value <= DateTime.Now.Year)
            {
                _year = value;
            }
        }
    }

    public int AgeInYears => DateTime.Now.Year - Year;

    public string ShortDescription => $"{Title} ({Year})";

    public virtual string Description => $"Описание объекта: название: {Title}, год издания: {Year}";

    public LibraryItem(string title, int year)
    {
        Title = title;
        Year = year;
        _totalItems++;
    }

    public abstract string GetCardInfo();

    public virtual string GetInfo()
    {
        return $"Название: {Title}, год: {Year}";
    }
}