using System.ComponentModel.DataAnnotations;

namespace CarSeller.Models
{
    public class Car
    {
        public int Id { get; set; }
        public CarBrand Brand { get; set; }
        public int Year { get; set; }

        [DisplayFormat(DataFormatString = "{0:F0}", ApplyFormatInEditMode = true)]
        public decimal Price { get; set; }

        public int? OwnerId { get; set; }
        public Owner? Owner { get; set; }

    }
}
