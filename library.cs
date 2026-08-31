class Book : LibraryItem, ISearchable, IExportable, ILibraryItem
{
    public override string GetInfo() => $"Информация о книге: название {Title}, год издания {Year}, год {Year}, страниц {PageCount}";

    public int GetYear()
    {
        return Year;
    }
    public const int MaxPageCount = 10000;

    public string Author { get; init; }
    
    private static int _totalCount = 0;
    public static int TotalCount => _totalCount;

    public string ToCsv() => $"[КНИГА];{Title};{Author};{Year};{PageCount};{Genre}";
    public string ToJson() =>  $"{{\"type\": \"КНИГА\", \"title\": \"{Title}\", \"author\": \"{Author}\", \"year\": {Year}, \"pageCount\": {PageCount}, \"genre\": \"{Genre}\"}}";

    public static void PrintStatistics()
    {
        Console.WriteLine($"Общее количество созданых книг: {Book.TotalCount}");
    }
          
    public bool ContainsKeyword(string keyword) => (Title.Contains(keyword, StringComparison.OrdinalIgnoreCase)) || (Author.Contains(keyword, StringComparison.OrdinalIgnoreCase));
    
    public int PageCount { get; set; }

    public BookGenre Genre { get; init; } = BookGenre.Unknown;
    
    public string GenreRu
    {
        get
        {
            return Genre switch
            {
                BookGenre.Unknown => "Неизвестный",
                BookGenre.Novel => "Роман",
                BookGenre.SciFi => "Фантастика / Антиутопия",
                BookGenre.Detective => "Детектив",
                BookGenre.History => "История / Историческая литература",
                BookGenre.Science => "Научная / Популярная литуратура"
            };
        }
    }

    public ItemStatus Status = ItemStatus.Available;

    public int AgeInYears => (DateTime.Now.Year - Year);
    public string ShortDescription => $"название: {Title}, автор: {Author}";
    
    public Book(string title, string author, int year, int pageCount) : base(title, year)
    {

        if (pageCount <= 0)
        {
            throw new InvalidBookDataException("Количество страниц должно быть больше нуля");
        }
        // Title = title;
        Author = author ?? throw new InvalidBookDataException("Автор книги не может быть пустым.");
        // Year = year;
        PageCount = pageCount;
        _totalCount++;
    }

    public Book(string Title, string Author) : this(Title, Author, 2024, 0) {}

    public Book() : this("Неизвестно", "Неизвестен") {}

    ~Book()
    {
        Console.WriteLine($"Финализатор: книга «{Title}» удалена из памяти");
    }

    
    public override string GetCardInfo() => $"[КНИГА] - {Title}, автор - {Author}, {TotalCount} стр. - {Genre}";
    public string GetInfo(bool showPages)
    {
        if (showPages)
        {
            return $"Информация о книге: название {Title}, автор {Author}, год {Year}, страниц {PageCount}, жанр {Genre}";
        }
        else 
        {
            return $"Информация о книге: название {Title}, автор {Author}, год {Year}";
        }
    }

    public bool IsOlderThan(int years = 50) 
    {
        return AgeInYears > years;
    }

    public string GetFormattedInfo(string format = "short")
    {
        string GetShortFormat() => $"Название: {this.Title}, автор: {this.Author}";

        string GetFullFormat() => $"Полная информация о книге: название {this.Title}, автор {this.Author}, год {this.Year}, страниц {this.PageCount}";

        return format switch
        {
            "short" => GetShortFormat(),
            "full" => GetFullFormat(),
            _ => "Неизвестный формат."
        };
    }
}