using Microsoft.AspNetCore.Mvc;

namespace _02_person.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
 
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Sum(string firstNumber, string secondNumber)
    {
        return BadRequest("Invalid input");
    }
}
