using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    internal class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public int YearProdcution { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
