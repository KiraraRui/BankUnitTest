using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUnitTest
{
    public class Withdraw
    {

        public bool WithdrawMoney(double ammount, double balance)
        {
            if (ammount <= balance)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

    }
}
