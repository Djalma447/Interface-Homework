using System;
using Course.Entities;

namespace Course.Services
{
    class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessInstallments(Contract contract, int months)
        {
            double quota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double interest = _paymentService.MonthlyInterest(quota, i);
                double fee = _paymentService.PaymentFee(interest);
                contract.AddInstallment(new Installment(date, fee));
            }
        }
    }
}
