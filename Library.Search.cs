partial class Library
{
    public List<LibraryItem> Search(string keyword, SearchOptions option = SearchOptions.All)
    {
        List<LibraryItem> result = new();

        foreach (var item in _items)
        {
            if (item is Book book)
            {
                if (option.HasFlag(SearchOptions.ByTitle) && book.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(book);
                }
                else if (option.HasFlag(SearchOptions.ByAuthor) && book.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(book);
                }
                else if (option.HasFlag(SearchOptions.ByGenre) && book.GenreRu.Contains(keyword, StringComparison.OrdinalIgnoreCase))      
                {
                    result.Add(book);
                }
            }

            if (item is Magazine magazine)
            {
                if (option.HasFlag(SearchOptions.ByTitle) && magazine.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(magazine);
                }
            }
        }
        return result;
    }
    

    public List<LibraryItem> FindByTitle(string keyword)
    {
        List<LibraryItem> result = new();
        foreach (var item in _items)
        {
            if (item.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(item);
            }
        }
        return result;
    }

    public List<Book> FindBooks()
    {
        List<Book> books = new();
        foreach (var item in _items)
        {
            if (item is Book b)
            {
                books.Add(b);
            }
        }
        return books;
    }

    public List<Magazine> FindMagazines()
    {
        List<Magazine> res = new();
        foreach (var item in _items)
        {
            if (item is Magazine m)
            {
                res.Add(m);
            }
        }
        return res;
    }
}