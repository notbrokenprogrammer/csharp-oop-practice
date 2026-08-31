class Catalog<T> where T : ILibraryItem, new()
{
    private List<T> items = new();

    public int Count => items.Count;


    public void Add(T item)
    {
        items.Add(item);
    }

    public void CreateEmpty()
    {
        T item = new();
        items.Add(item);
    }

    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine($"Год: {item.GetYear()} информация: {item.GetInfo()}");
        }
    }
    public List<U> FindOlderThan<U>(int years) where U : T
    {
        List<U> ls = new();
        foreach (var item in items)
        {
            if (item is U u && item.GetYear() > years)
            {
                ls.Add(u);
            }
        }
        return ls;
    }

}