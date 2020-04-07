namespace Course.Services
{
    class PaypalPaymentService : IPaymentService
    {
        public double MonthlyInterest(double value, int months)
        {
            return value + (value * 0.01) * months;
        }

        public double PaymentFee(double interest)
        {
            return interest + (interest * 0.02);
        }
    }
}
