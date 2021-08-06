using CODU.ai.interview.solution.Models;
using geektrust_family_demo.Models.Processors.Interface;
using geektrust_family_demo.ProcessedModel;
using System.Collections.Generic;

namespace geektrust_family_demo.Models.Processors
{
    public class PaymentProcessor : IModelProcessor<ProcessedPayment, PAYMENT>
    {
        public List<ProcessedPayment> GetprocessedModel(List<PAYMENT> model)
        {
            var ProcessedPayments = new List<ProcessedPayment>();

            foreach (var payment in model)
            {
                ProcessedPayments.Add(new ProcessedPayment
                {
                    BANK_NAME = payment.BANK_NAME,
                    BORROWER_NAME = payment.BORROWER_NAME,
                    LUMP_SUM_AMOUNT = payment.LUMP_SUM_AMOUNT,
                    EMI_NO = payment.EMI_NO
                });
            }

            return ProcessedPayments;
        }
    }
}
