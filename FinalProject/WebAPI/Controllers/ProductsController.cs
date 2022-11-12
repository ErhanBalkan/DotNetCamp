using System.Net;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Collections;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    IProductService _productService;
    public ProductsController (IProductService productService)
	{
        _productService = productService;
	}

    [HttpGet]
    public string Get(){
        return "Merhaba";
    }
}