using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWorkshop.Part2
{
    public class Nested
    {
        private string client;
        private string country;
        private string location;
        private string ListMatchingTheCriteria;
     
        public string CheckMethod() {

            if (client == "Client1")
            {
                if (country == "Country1")
                {
                    if (location == "Location1")
                    {
                        return ListMatchingTheCriteria;
                    }

                    if (location == "Location2")
                    {
                        return ListMatchingTheCriteria;
                    }   
                }

                if (country == "Country2")
                {
                    if (location == "Location1")
                    {
                        return ListMatchingTheCriteria;
                    }
                    if (location == "Location2")
                    {
                        return ListMatchingTheCriteria;
                    }
                }
            }

            if (client == "Client2")
            {
                if (country == "Country1")
                {
                    if (location == "Location1")
                    {
                        return ListMatchingTheCriteria;
                    }
                    if (location == "Location2")
                    {
                        return ListMatchingTheCriteria;
                    }
                   
                }

                if (country == "Country2")
                {
                    if (location == "Location1")
                    {
                        return ListMatchingTheCriteria;
                    }
                    if (location == "Location2")
                    {
                        return ListMatchingTheCriteria;
                    }
                }
            }

            return String.Empty;
        }
    }
}
