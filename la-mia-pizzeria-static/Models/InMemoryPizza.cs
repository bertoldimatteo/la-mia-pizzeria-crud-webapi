using la_mia_pizzeria_crud_mvc.Data;

namespace la_mia_pizzeria_crud_mvc.Models
{
    public class InMemoryPizza : PizzaRepository
    {
        private static List<Pizza> Pizzas = new List<Pizza>();

        public void Create(Pizza pizza, List<string> SelectedIngredient)
        {
            pizza.PizzaID = Pizzas.Count;

            pizza.Categories = new List<Category>();

            InMemoryPizza.Pizzas.Add(pizza);
        }

        public void Create(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public Pizza GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Pizza> GetListByFilter(string search)
        {
            throw new NotImplementedException();
        }

        public void Update(Pizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
