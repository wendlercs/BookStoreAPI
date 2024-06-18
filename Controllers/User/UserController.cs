using BookStoreAPI.Communication.Requests.User;
using BookStoreAPI.Entities.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers.User;

public class UserController : BookStoreApiBaseController
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(RequestCreateUserJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetUserByID([FromRoute] int id)
    {
        var response = new UserEntitie
        {
            Id = id,
            Name = "Wendler",
            Email = "wendler@hotmail.com",
            Address = "Rua Tiradentes, 370, Centro, Montes Claros, MG", 
            Password = "Password",
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(RequestCreateUserJson), StatusCodes.Status204NoContent)]
    public IActionResult CreateUser([FromBody] RequestCreateUserJson user)
    {
        var response = new UserEntitie
        {
            Name = user.Name,
            Email = user.Email,
            Address = user.Address,
            Password = user.Password
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateUser([FromRoute] int id,[FromBody] RequestUpdateUserJson user)
    {
        var userJson = new RequestUpdateUserJson
        {
            Name = user.Name,
            Email = user.Email,
            Address = user.Address,
        };

        return NoContent();
    }

    [HttpPut]
    [Route("updatepassword/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult UpdateUserPassword([FromRoute] int id, [FromBody] RequestUpdatePasswordUserJson password)
    {
        var userJson = new RequestUpdatePasswordUserJson
        {
            CurrentPassword = password.CurrentPassword,
            NewPassword = password.NewPassword,
        };

        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult DeleteUser([FromRoute] int id)
    {
        return NoContent();
    }
}
