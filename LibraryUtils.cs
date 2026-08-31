using System.Text;

static class LibraryUtils
{
    public static readonly DateTime StartupTime = DateTime.Now;
    public const string LibraryName = "Городская библиотека";

    public static void PrintSeparator(char symbol = '─', int length = 40)
    {
        Console.WriteLine(new string(symbol, length));
    }

    public static string FormatBookList(Book[] books)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < books.Length; i++)
        {
            sb.AppendLine($"{i + 1}. название: {books[i].Title}, автор: {books[i].Author}, год: {books[i].Year}");   
        }
        return sb.ToString();
    }

    public static string FindOldest(Book[] books)
    {
       int veryOldBook = DateTime.Now.Year - books[0].Year;
       string nameVeryOldBook = books[0].Title;
       for (int i = 0; i < books.Length; i++)
       {
            int yearbook = DateTime.Now.Year - books[i].Year;
            if (yearbook > veryOldBook)
            {
                veryOldBook = yearbook;
                nameVeryOldBook = books[i].Title;
            }
       }
       return nameVeryOldBook;
    }
}

