using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Order
    {
        public Client client { get; set; }
        public Product product { get; set; }
        public string Count { get; set; }
        public string TotalPrice { get; set; }
    }
}
