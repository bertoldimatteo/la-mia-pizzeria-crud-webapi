using la_mia_pizzeria_crud_mvc.Data;

namespace la_mia_pizzeria_crud_mvc.Models
{
    public class InMemoryPizza : PizzaRepository
    {
        private static List<Pizza> Pizzas = new List<Pizza>();

        public void Create(Pizza pizza)
        {
            pizza.PizzaID = Pizzas.Count;

            InMemoryPizza.Pizzas.Add(pizza);
        }

        public void Delete(Pizza pizza)
        {
            int DeletePizza = -1;

            for(int i = 0; i < InMemoryPizza.Pizzas.Count; i++)
            {
                Pizza checkPizza = InMemoryPizza.Pizzas[i];

                if(checkPizza.PizzaID == pizza.PizzaID)
                {
                    DeletePizza = i;
                }
            }

            if(DeletePizza != -1)
            {
                InMemoryPizza.Pizzas.RemoveAt(DeletePizza);
            }
        }

        public Pizza GetById(int id)
        {
            Pizza findPizza = null;

            for(int i = 0; i < InMemoryPizza.Pizzas.Count; i++)
            {
                Pizza pizzaCheck = InMemoryPizza.Pizzas[i];

                if(pizzaCheck.PizzaID == id)
                {
                    findPizza = pizzaCheck;
                }
            }

            return findPizza;
        }

        public List<Pizza> GetList()
        {
            return InMemoryPizza.Pizzas;
        }

        public List<Pizza> GetListByFilter(string search)
        {
            List<Pizza> pizzas = InMemoryPizza.Pizzas;

            if(search != null)
            {
                pizzas = pizzas.Where(pizza => pizza.Name.ToLower().Contains(search.ToLower())).ToList();
            }

            return pizzas.ToList();
        }

        public void Update(Pizza pizza)
        {
            int count = -1;

            for(int i = 0; i < InMemoryPizza.Pizzas.Count; i++)
            {
                Pizza pizzaCheck = InMemoryPizza.Pizzas[i];

                if(pizzaCheck.PizzaID == pizza.PizzaID)
                {
                    count = i;
                }
            }

            if (count != -1)
            {
            InMemoryPizza.Pizzas[count] = pizza;
            }
        }
    }
}
