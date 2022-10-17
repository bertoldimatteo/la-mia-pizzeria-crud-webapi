using la_mia_pizzeria_crud_mvc.Data;
using la_mia_pizzeria_crud_mvc.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_crud_mvc.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        PizzaContext context;
        public PizzaController()
        {
            context = new PizzaContext();
        }

        [HttpGet]
        public IActionResult Get(string? name)
        {
            IQueryable<Pizza> pizzas;

            if(name != null)
            {
                pizzas = context.Pizzas.Where(pizza => pizza.Name.ToLower().Contains(name.ToLower()));

            }else
            {
                pizzas = context.Pizzas;
            }

            return Ok(pizzas.ToList<Pizza>());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pizza pizza = context.Pizzas.Where(pizza => pizza.PizzaID == id).FirstOrDefault();

            return Ok(pizza);
        }
    }
}
