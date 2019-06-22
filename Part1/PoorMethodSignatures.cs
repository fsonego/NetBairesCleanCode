using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCodeWorkshop.Part1
{
    public class PoorMethodSignatures
    {
        public void Execute() {

            var customerService = new CustomerService();

            var goldCustomers = customerService.GetCustomers(true);
            var customers = customerService.GetCustomers(false);
        }
    }

    public class CustomerService {

        public IList<Customer> GetCustomers(bool IsGold) {
                        
            if (IsGold)
            {
                var customers = DbContext.Customers.Find().Where(p => p.IsGold == true).ToList();
                return customers;
            }
            else {
                var customers = DbContext.Customers.Find().ToList();
                return customers;
            }
        }
    }
}
