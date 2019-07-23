using System;
namespace WorkshopNTL.Controllers
{
    public class Product
    {
        public Product() { }
        public Product(int v1, string v2, double v3)
        {
            this.Id = v1;
            this.Name = v2;
            this.Price = v3;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
