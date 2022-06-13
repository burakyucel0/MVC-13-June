namespace MVCdbConnect.Models.ORM
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }
        
        public DateTime RequiredDate { get; set; }

        public string CompanyName { get; set; }

        public string Adress { get; set; }

       
    }
}
