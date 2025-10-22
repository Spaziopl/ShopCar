using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebApp.Models
{
    internal class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
