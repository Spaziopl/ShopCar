namespace CarSeller.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        //public int? OwnerId { get; set; }
        //public Owner Owner { get; set; }
    }
}
