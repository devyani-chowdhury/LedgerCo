using CODU.ai.interview.solution.Models;
using geektrust_family_demo.Models.Processors.Interface;
using geektrust_family_demo.ProcessedModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace geektrust_family_demo.Models.Processors
{
    public class BalanceProcessor : IModelProcessor<ProcessedBalance, BALANCE>
    {
        public readonly List<ProcessedLoan> ProcessedLoans;
        public BalanceProcessor(List<ProcessedLoan> processedLoans)
        {
            ProcessedLoans = processedLoans;
        }
        public List<ProcessedBalance> GetprocessedModel(List<BALANCE> model)
        {
            List<ProcessedBalance> processedBalances = new List<ProcessedBalance>();

            foreach (var balance in model)
            {
                decimal amountPaid = 0;
                if (this.ProcessedLoans != null)
                {
                    var correspondingLoan = this.ProcessedLoans.Where(loan => loan.BANK_NAME == balance.BANK_NAME
                                                                    && loan.BORROWER_NAME == balance.BORROWER_NAME
                                                                    && loan.NO_OF_EMIS >= balance.EMI_NO).FirstOrDefault();

                    amountPaid += correspondingLoan != null ? (correspondingLoan.EMI_AMOUNT * balance.EMI_NO)
                                                            + (correspondingLoan.Payments.Select(p =>
                                                            {
                                                                decimal pamt = 0;
                                                                pamt += p.EMI_NO <= balance.EMI_NO ? p.LUMP_SUM_AMOUNT : 0;
                                                                return pamt;
                                                            }).Sum())
                                                            : 0;
                    int noOfEmisLeft = (int)Math.Ceiling((correspondingLoan.Amount - amountPaid) / correspondingLoan.EMI_AMOUNT);
                    processedBalances.Add(new ProcessedBalance
                    {
                        BANK_NAME = balance.BANK_NAME,
                        BORROWER_NAME = balance.BORROWER_NAME,
                        AMOUNT_PAID = amountPaid,
                        NO_OF_EMIS_LEFT = noOfEmisLeft
                    });
                }

            }

            return processedBalances;
        }
    }
}
