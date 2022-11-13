using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[Controller]")]
public class RentalsController : Controller
{
    IRentalService _rentalService;

    public RentalsController(IRentalService rentalService)
    {
        _rentalService = rentalService;
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _rentalService.GetAll();
        if (result.State == true)
        {
            return Ok(result);
        }
        return BadRequest(result); 
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _rentalService.GetById(id);
        if (result.State == true)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("add")]
    public IActionResult Add(Rental rental)
    {
        var result = _rentalService.Add(rental);
        if (result.State == true)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}

