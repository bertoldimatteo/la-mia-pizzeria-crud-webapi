namespace la_mia_pizzeria_crud_mvc.Models
{
    public interface PizzaRepository
    {
        public List<Pizza> GetList();
        public List<Pizza> GetListByFilter(string search);
        public Pizza GetById(int id);
        public void Create(Pizza pizza);
        public void Update(Pizza pizza);
        public void Delete(Pizza pizza);
    }
}
