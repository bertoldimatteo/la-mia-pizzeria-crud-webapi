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
