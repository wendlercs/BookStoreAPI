namespace BookStoreAPI.Communication.Requests.Book;

public class RequestUpdateBookJson
{
    public string? Title { get; set; } 
    public string? Author { get; set; }
    public string? Genre { get; set; } 
    public double? Price { get; set; }
    public int? StockQtd { get; set; }
}
