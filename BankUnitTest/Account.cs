
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUnitTest
{
    public class Account
    {

        public string Name { get; set; }
        public int CardID { get; set; }
        public int Balcence { get; set; }
        public int Pin { get; set; }

        public Account(string name, int cardID, int balcence, int pin)
        {
            Name = name;
            CardID = cardID;
            Balcence = balcence;
            Pin = pin;
        }
        public bool ValidateUser(int pin)
        {
            return (pin == this.Pin);
        }

    }
}
