﻿namespace AutomaticContracts.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
