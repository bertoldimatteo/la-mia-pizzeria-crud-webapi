namespace la_mia_pizzeria_crud_mvc.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Message()
        {

        }
        public Message(int id, string title, string content, string name, string email)
        {
            Id = id;
            Title = title;
            Content = content;
            Name = name;
            Email = email;
        }
    }
}
