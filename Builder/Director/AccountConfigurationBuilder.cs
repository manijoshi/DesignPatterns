using Builder.Builder;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Director
{
    public class AccountConfigurationBuilder
    {
        public Account BuildLoanAccount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(123456);
            builder.WithLoanAmount(50000);
            builder.AddInterestRate(10.5);
            return builder.GetAccount();
        }
        public Account BuildSavingAccount(IAccountBuilder builder)
        {
            builder.AddAccountNumber(45678);
            builder.WithSavingBalance();
            return builder.GetAccount();
        }
    }
}
