using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UnitTestExample;

namespace TDDSessionUnitTests
{
    public class Exercise3Should
    {
        private Order order;  

        [SetUp]
        public void SetUp()
        {
        
        }


        [Test]
        public void GetAllValues()
        {
            var order = new Order()
            {
                CustomerName = "Jim",
                OrderNo = 1234,
                OrderTime = DateTime.Now,
                Items = GetItemList(5)
            };

            var expectedOrder = JsonConvert.SerializeObject(order);
            Assert.AreEqual(expectedOrder, order.GetAllAttributes());

        } 

        private List<Item> GetItemList(int numOfItems)
        {
            var itemList = new List<Item>();
            for (int i = 0; i < numOfItems; i++)
            {
                itemList.Add(new Item(){ItemNo = i.ToString(), Price = 1.99m, Quantity = 5});
            }

            return itemList;
        }
    }
}
