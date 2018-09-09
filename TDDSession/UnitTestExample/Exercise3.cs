using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UnitTestExample
{
    public class Exercise3
    {

    }

    public class Order
    {
        public int OrderNo { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderTime { get; set; }
        public List<Item> Items { get; set; }
        public string GetAllAttributes()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class Item
    {
        public string ItemNo { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

}
