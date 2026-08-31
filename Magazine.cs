class Magazine : LibraryItem, ILibraryItem
{
    public Magazine() : base("Без названия", 1450)
    {
        IssueNumber = 1;
        Publisher = "Неизвестен";
    }
    public int GetYear()
    {
        return Year;
    }
    public int IssueNumber { get; set; }
    public string Publisher { get; set; }

    public Magazine(string title, int year, int issueNumber, string publisher) 
        : base(title, year)
    {
        IssueNumber = issueNumber;
        Publisher = publisher;
    }
    
    public ItemStatus Status = ItemStatus.Available;

    public string ToCsv() => $"[ЖУРНАЛ];{Title};{Publisher};{Year};{IssueNumber}";
    public string ToJson() =>  $"{{\"type\": \"ЖУРНАЛ\", \"title\": \"{Title}\", \"publisher\": \"{Publisher}\", \"year\": {Year}, \"issueNumber\": {IssueNumber}}}";


    public override string GetInfo()
    {
        return $"Журнал: {Title}, год: {Year}, номер издания: {IssueNumber}, издатель: {Publisher}";
    }

    public override string GetCardInfo()
    {
        return $"[ЖУРНАЛ] {Title}. - {Year}. - №{IssueNumber}, изд-во: {Publisher}";
    }

    public override string Description => $"Журнал «{Title}», №{IssueNumber}, издатель: {Publisher}";

    public bool ContainsKeyword(string keyword) => this.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) || this.IssueNumber.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase);
}