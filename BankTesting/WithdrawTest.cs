using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BankUnitTest;

namespace BankTest
{
    public class WithdrawTest
    {

        [Theory]
        [InlineData(4200, 6969, true)]
        [InlineData(69, 57, false)]
        [InlineData(9999, 9999, true)]
        public void WithdrawBelowIfAmount(double ammount, double balance, bool expected)
        {
            //Arrange
            Withdraw withdraw = new Withdraw();
            //Act
            bool actual = withdraw.WithdrawMoney(ammount, balance);
            //Assert
            Assert.Equal(expected, actual);
        }


    }
}
