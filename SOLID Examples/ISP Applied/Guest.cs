namespace SOLID_Examples.ISP_Applied;

public class Guest : ISearchable
{
    public void SearchCatalog(string searchTerm)
    {
        // Implementation to search books.
        Console.WriteLine($"Guest Search Book, Search Catalog: {searchTerm}");
    }
}