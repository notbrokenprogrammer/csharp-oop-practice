static class CatalogUtils
{
    public static void PrintInfo<T>(T item) where T : ILibraryItem
    {
        Console.WriteLine($"Тип объекта: {typeof(T).Name}, инфа: {item.GetInfo()}");
    }
}