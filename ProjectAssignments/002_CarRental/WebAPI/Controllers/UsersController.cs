using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class UsersController : ControllerBase
{
    // public string Get(){
    //     return "Hello World";
    // }

    // public List<User> Get(){
    //     return new List<User>{
    //         new User{Id = 1, FirstName = "Erhan", LastName = "Balkan", Email = "erhan@gmail.com", Password = "111"},
    //         new User{Id = 1, FirstName = "Erhan", LastName = "Balkan", Email = "erhan@gmail.com", Password = "111"},
    //     };
    // }

    IUserService _userService;
    // IoC Container => Inversion of Control 
    public UsersController(IUserService userService)
    {
        _userService = userService;   
    }

    [HttpGet("getall")]
    public IActionResult GetAll(){
        var result = _userService.GetAll();
        if(result.State == true){
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id){
        var result = _userService.GetById(id);
        if (result.State == true)
        {
            return Ok(result);   
        }
        return BadRequest(result);
    }

    [HttpPost("add")]
    public IActionResult Add(User user){
        var result = _userService.Add(user);
        if (result.State == true)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    
    
}