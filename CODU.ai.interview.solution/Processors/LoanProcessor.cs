using CODU.ai.interview.solution.Models;
using geektrust_family_demo.Models.Processors.Interface;
using geektrust_family_demo.ProcessedModel;
using System;
using System.Collections.Generic;

namespace geektrust_family_demo.Models.Processors
{

    public class LoanProcessor : IModelProcessor<ProcessedLoan, LOAN>
    {

        public List<ProcessedLoan> GetprocessedModel(List<LOAN> model)
        {
            List<ProcessedLoan> ProcessedLoans = new List<ProcessedLoan>();
            foreach (var loan in model)
            {
                int noOfEmis = loan.NO_OF_YEARS * 12;
                decimal amount = loan.PRINCIPAL + ((loan.PRINCIPAL * loan.NO_OF_YEARS * loan.RATE_OF_INTEREST) / 100);
                int emiAmt = (int)Math.Ceiling(amount / noOfEmis);
                ProcessedLoans.Add(new ProcessedLoan
                {
                    BANK_NAME = loan.BANK_NAME,
                    BORROWER_NAME = loan.BORROWER_NAME,
                    PRINCIPAL = loan.PRINCIPAL,
                    NO_OF_YEARS = loan.NO_OF_YEARS,
                    RATE_OF_INTEREST = loan.RATE_OF_INTEREST,
                    NO_OF_EMIS = noOfEmis,
                    Amount = amount,
                    EMI_AMOUNT = emiAmt
                });
            }
            return ProcessedLoans;
        }

    }
}
