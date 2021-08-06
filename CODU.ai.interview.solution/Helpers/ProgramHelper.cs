using CODU.ai.interview.solution.Models;
using geektrust_family_demo.Models.Processors;
using geektrust_family_demo.Repository;
using System;
using System.Linq;

namespace CODU.ai.interview.solution.Helpers
{
    public class ProgramHelper
    {

        public LoanRepository LoanRepoObject;
        public PaymentRepository PaymentRepoObject;
        public BalanceRepository BalanceRepoObject;

        public void ProcessObjects()
        {
            #region LoanProcessing
            LoanProcessor loanProcessor = new LoanProcessor();
            LoanRepoObject = new LoanRepository { loansRecords = loanProcessor.GetprocessedModel(ModelStore.LoanRecords) };
            #endregion

            #region PaymentProcessing
            PaymentProcessor paymentProcessor = new PaymentProcessor();
            PaymentRepoObject = new PaymentRepository { paymentRecords = paymentProcessor.GetprocessedModel(ModelStore.paymentRecords) };
            #endregion

            #region UpdateLoanRecords
            LoanRepoObject.loansRecords.ForEach(record =>
            {
                var payment = PaymentRepoObject.paymentRecords.Where(pr => pr.BANK_NAME == record.BANK_NAME && pr.BORROWER_NAME == record.BORROWER_NAME);
                if (payment.Any())
                {
                    record.Payments.AddRange(payment);
                }
            });
            #endregion

            #region BalanceProcessing
            BalanceProcessor balanceProcessor = new BalanceProcessor(LoanRepoObject.loansRecords);
            BalanceRepoObject = new BalanceRepository { BalanceRecords = balanceProcessor.GetprocessedModel(ModelStore.balanceRecords) };
            #endregion
        }

        public void OutputBalance()
        {
            foreach (var balanceObj in BalanceRepoObject.BalanceRecords)
            {
                Console.WriteLine($"{balanceObj.BANK_NAME} {balanceObj.BORROWER_NAME} {balanceObj.AMOUNT_PAID} {balanceObj.NO_OF_EMIS_LEFT}");
            }
        }

        public void PopulateObjects(string line)
        {
            string[] details = line.Split(' ');
            string type = details[0].ToUpper();
            switch (type)
            {
                case "LOAN":
                    ModelStore.LoanRecords.Add(new LOAN
                    {
                        BANK_NAME = details[1],
                        BORROWER_NAME = details[2],
                        PRINCIPAL = Decimal.Parse(details[3]),
                        RATE_OF_INTEREST = Decimal.Parse(details[5]),
                        NO_OF_YEARS = Int32.Parse(details[4])
                    });
                    return;

                case "PAYMENT":
                    ModelStore.paymentRecords.Add(new PAYMENT
                    {
                        BANK_NAME = details[1],
                        BORROWER_NAME = details[2],
                        LUMP_SUM_AMOUNT = Decimal.Parse(details[3]),
                        EMI_NO = Int32.Parse(details[4])
                    });
                    return;

                case "BALANCE":
                    ModelStore.balanceRecords.Add(new BALANCE
                    {
                        BANK_NAME = details[1],
                        BORROWER_NAME = details[2],
                        EMI_NO = Int32.Parse(details[3])
                    });
                    return;

                default:
                    Console.WriteLine($"{type} command doesn't exist");
                    return;
            }

        }
    }
}
