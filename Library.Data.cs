partial class Library
{
    private List<LibraryItem> _items = new();

    public void Add(LibraryItem item)
    {
        _items.Add(item);
    }

    public void PrintAll()
    {
        foreach (LibraryItem item in _items)
        {
            Console.WriteLine(item.GetInfo());
        }  
    }
// Book(string title, string author, int year, int pageCount) : base(title, year)
    public void AddFromConsole()
    {
        try
        {
            string? title = ReadNonEmpty("Введите название: ");
            string? author = ReadNonEmpty("Введите автора: ");
            int year = int.Parse(ReadNonEmpty("Введите год: "));
            int pageCount = int.Parse(ReadNonEmpty("Введите количество страниц: "));
            Book book = new(title, author, year, pageCount);

        }
        catch (InvalidBookDataException e) when (e.Message == "Строковое значение не может быть пустым.")
        {
            Console.WriteLine(e.Message);
        }
        catch (InvalidBookDataException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Попытка записи книги прошла успешно.");
        }
    }


    public string ReadNonEmpty(string vvod)
    {
        Console.WriteLine(vvod);

        string? value = Console.ReadLine();
        return !string.IsNullOrWhiteSpace(value) ? value : throw new InvalidBookDataException("Строковое значение не может быть пустым.");

    }
}