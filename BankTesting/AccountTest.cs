using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BankUnitTest;

namespace BankTest
{
    public class AccountTest
    {
        [Theory]
        [InlineData(1234, 1234, true)]
        [InlineData(1234, 9999, false)]
        [InlineData(1234, 6969, false)]
        public void ValiDateAccount_ShouldReturnBool(int pin, int CardPin, bool expeted)
        {
            Account acc = new Account("Kira", 1, 500, pin);
            bool actuel = acc.ValidateUser(CardPin);
            Assert.Equal(expeted, actuel);
        }

    }
}
