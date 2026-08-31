public enum BookGenre
{
    Unknown,
    Novel,
    SciFi,
    Detective,
    History,
    Science
}

public enum ItemStatus
{
    Available,
    OnLoan,
    Reserved
}

[Flags]
public enum SearchOptions
{
    None = 0,
    ByTitle = 1,
    ByAuthor = 2,
    ByGenre = 4,
    All = ByTitle | ByAuthor | ByGenre
}