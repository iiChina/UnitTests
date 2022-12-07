namespace Store.Domain.Entities
{
    public class Product
    {
        public Product(string title, decimal price, bool active)
        {
            Title = title;
            Price = price;
            Active = active;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool Active { get; set; }

        public void ChangeInfo(string title, decimal price, bool active)
        {
            Title = title;
            Price = price;
            Active = active;

        }
    }
}