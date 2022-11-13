using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class CarsController : Controller
{
	ICarService _carService;
	public CarsController(ICarService carService)
	{
		_carService= carService;
	}
	[HttpGet("getall")]
	public IActionResult GetAll()
	{
		var result = _carService.GetAll();
		if (result.State == true)
		{
			return Ok(result);
		}
		return BadRequest(result);
	}

	[HttpGet("getbyid")]
	public IActionResult GetById(int id)
	{
		var result = _carService.GetById(id);
		if (result.State == true)
		{
			return Ok(result);
		}
		return BadRequest(result);
	}

	[HttpPost("add")]
	public IActionResult Add(Car car)
	{
		var result = _carService.Add(car);
		if (result.State == true)
		{
			return Ok(result);
		}
		return BadRequest(result);
	}
}

