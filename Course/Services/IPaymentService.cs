namespace Course.Services
{
    interface IPaymentService
    {
        double MonthlyInterest(double value, int months);
        double PaymentFee(double interest);
    }
}
