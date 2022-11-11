using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections;
namespace WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    IProductService _productService;
    public ProductsController (IProductService productService)
	{
        _productService = productService;
	}

    [HttpGet]
    public List<Product> Get(){
        var result = _productService.GetAll();
        return result.Data;
    }
}