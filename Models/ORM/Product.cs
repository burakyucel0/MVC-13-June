namespace MVCdbConnect.Models.ORM
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitInStock { get; set; }

        public int UnitOnOrder { get; set; }

        public int CategoryId { get; set; }

        public decimal Discounted { get; set; }


    }
}
