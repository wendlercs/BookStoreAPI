using BookStoreAPI.Communication.Requests.Book;
using BookStoreAPI.Entities.Book;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers.Book;

public class BookController : BookStoreApiBaseController
{
    [HttpGet("get-all-books")]
    [ProducesResponseType(typeof(BookEntitie), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetAllBooks()
    {
        var response = new List<BookEntitie>()
        {
            new BookEntitie
            {
                Title = "A Guerra dos Tronos : As Crônicas de Gelo e Fogo, volume 1",
                Author = "George R. R. Martin",
                Genre = "Romance, Literatura fantástica, Alta fantasia, Ficção Política",
                Price = 150.50,
                StockQtd = 120
            },
            new BookEntitie
            {
                Title = "Harry Potter e a Pedra Filosofal",
                Author = "J. K. Rowling",
                Genre = "Romance, Literatura infantil, Literatura fantástica, Alta fantasia",
                Price = 120.50,
                StockQtd = 250
            }
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult CreateBook([FromBody] RequestCreateBookJson book)
    {
        var bookJson = new RequestCreateBookJson
        {
            Title = book.Title,
            Author = book.Author,
            Genre = book.Genre,
            Price = book.Price,
            StockQtd = book.StockQtd
        };

        return NoContent();
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateBook([FromRoute] int id,[FromBody] RequestUpdateBookJson book)
    {
        var bookJson = new RequestUpdateBookJson
        {
            Title = book.Title,
            Author = book.Author,
            Genre = book.Genre,
            Price = book.Price,
            StockQtd = book.StockQtd
        };

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteBook([FromRoute] int id)
    {
        return NoContent();
    }

}
