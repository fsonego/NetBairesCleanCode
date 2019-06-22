    using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWorkshop.Part1
{

    // Refactorizar: La clase es una clase customer, el primer parametro day es dia de generación
    // el sgundo es dia de modificación, el ultmo parametro corresponde al id del cliente.
    public class DtaRcrd102
    {
        private int _customerId;

        private DateTime genymdhms;
        private DateTime modymdhms;
        private string pszqint = "102";

        private int iMaxOrder = 10;
        private IList<string> m_collectionNames = new List<string>();

        private Order TheOrder;
        private List<Order> ListOfOrderForACustomer;

        public string nameofcustomer { get; set; }
        public string GetsuperValue { get; set; }
        public int ChekValidation_InTheDatabaseAndServices(string n) {
            var nn = new PoorNameHelper();
            return nn.GetCustomerId(n);
        }

        public List<Order> getorderbyclienteid(string customerId) {
            return new List<Order>();
        }
    };
}
