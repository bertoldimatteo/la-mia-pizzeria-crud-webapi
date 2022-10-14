using la_mia_pizzeria_crud_mvc.Data;
using la_mia_pizzeria_crud_mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_crud_mvc.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostContoller : ControllerBase
    {
        PizzaContext context;
        public PostContoller()
        {
            context = new PizzaContext();
        }
        public IActionResult Get()
        {

            List<Pizza> pizzas = context.Pizzas.ToList();

            return Ok(pizzas);
        }
    }
}
