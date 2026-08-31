static class LibraryItemExtensions
{
    public static bool IsNew(this LibraryItem item, int years = 5)
    {
        return item.AgeInYears <= years;
    }

    public static string ToCsvLine(this LibraryItem item)
    {
        string type = item is Book ? "Книга" : item is Magazine ? "Журнал" : "Элемент";
        string extra = item switch
        {
            Book b => $"{b.Author};{b.PageCount};{b.Genre} ", 
            Magazine m => $"{m.Publisher};{m.IssueNumber};",
            _ => ";;"
        };
        return $"{type};{item.Title};{item.Year};{extra}";
    }

    public static void PrintCard(this LibraryItem item)
    {
        Console.WriteLine("┌" + new string('─', 48) + "┐");
        Console.WriteLine($"│ {item.GetCardInfo(),-47}│");
        string status = item.IsNew() ? "НОВИНКА" : $"Возраст: {item.AgeInYears} лет";
        Console.WriteLine($"│ {status,-47}│");
        Console.WriteLine("└" + new string('─', 48) + "┘");
    }



}