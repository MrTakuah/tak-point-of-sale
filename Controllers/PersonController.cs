

using Microsoft.AspNetCore.Mvc;

namespace tak_point_of_sale.Controllers;

[ApiController]
[Route("[controller]")]

public class PersonController : ControllerBase
{
    DataContextDapper _dapper;
    public PersonController(IConfiguration config)
    {
        _dapper = new DataContextDapper(config);
    }
    [HttpGet("GetOrders")]
    public IEnumerable<Person> GetOrders()
    {
        string sql = @"
        SELECT [PersonID],
            [Name],
            [Email],
            [SMS]
            FROM [takpos].[dbo].[Persons]";
        IEnumerable<Person> persons = _dapper.LoadData<Person>(sql);
        return persons;
    }
    // [HttpPost("CreatePerson")]
    // public IActionResult CreatePerson;
}