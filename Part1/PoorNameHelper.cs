using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWorkshop.Part1
{
    public class PoorNameHelper
    {
        public int GetCustomerId(string name) {
            return 1;
        }
    }

    public class Order {
        public int Number { get; set; }
        public int Total { get; set; }
    }

    public static class DbContext {

        public static class Customers {
            public static IList<Customer> Find() {
                return new List<Customer>();
            }
        }
    }

    public class Customer {
        public int CustomerId { get; set; }
        public bool IsGold { get; set; }
    }
}
