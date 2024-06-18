namespace BookStoreAPI.Entities.Book;

public class BookEntitie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public double Price { get; set; }
    public int StockQtd { get; set; }
}
