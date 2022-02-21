namespace AutomaticContracts.Services
{
    interface IOnlinePaymentService
    {
       
        double interest(double amount, int months);

        double PaymentFee(double amount);
    }
}
