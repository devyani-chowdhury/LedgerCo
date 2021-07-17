using CODU.ai.interview.solution.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CODU.ai.interview.solution.Helpers
{
    public class ProgramHelper
    {

        List<LOAN> loansRecords = new List<LOAN>();
        List<PAYMENT> paymentRecords = new List<PAYMENT>();
        List<BALANCE> balanceRecords = new List<BALANCE>();


        public void OutputManager()
        {
            if (balanceRecords.Count != 0)
            {
                foreach (var record in balanceRecords)
                {
                    decimal amtPaid; int remainingEMIs;
                    if (loansRecords.Any(x => x.BORROWER_NAME == record.BORROWER_NAME && x.BANK_NAME == record.BANK_NAME))
                    {
                        LOAN loanAccount = loansRecords.Where(x => x.BORROWER_NAME == record.BORROWER_NAME && x.BANK_NAME == record.BANK_NAME).FirstOrDefault();
                        amtPaid = (record.EMI_NO * loanAccount.EMI_AMOUNT);
                        if (paymentRecords.Any(x => x.BORROWER_NAME == record.BORROWER_NAME
                                                    && x.BANK_NAME == record.BANK_NAME
                                                    && x.EMI_NO <= record.EMI_NO))
                        {
                            List<PAYMENT> paymentRecordsForAcc = paymentRecords.Where(x => x.BORROWER_NAME == record.BORROWER_NAME
                                                                                           && x.BANK_NAME == record.BANK_NAME).ToList();

                            paymentRecordsForAcc.ForEach(x => { amtPaid += x.LUMP_SUM_AMOUNT; });
                        }
                        remainingEMIs = (loanAccount.Amount - amtPaid) < loanAccount.EMI_AMOUNT ? 1 :
                                            (Int32)(Math.Ceiling((loanAccount.Amount - amtPaid) / loanAccount.EMI_AMOUNT));
                        Console.WriteLine(record.BANK_NAME + " " + record.BORROWER_NAME + " " + amtPaid + " " + remainingEMIs);
                    }
                    else
                    {
                        Console.WriteLine($"There are no loan records for Borrower -{record.BORROWER_NAME}  from Bank - {record.BANK_NAME}.");
                    }
                }
            }
        }

        public void PopulateObjects(string line)
        {
            string[] details = line.Split(' ');
            string type = details[0].ToUpper();
            if (type == "LOAN")
            {
                loansRecords.Add(new LOAN(details[1], details[2], Decimal.Parse(details[3]),
                                            Decimal.Parse(details[4]), Decimal.Parse(details[5])));
            }
            else if (type == "PAYMENT")
            {
                paymentRecords.Add(new PAYMENT(details[1], details[2], Decimal.Parse(details[3]), Int32.Parse(details[4])));
            }
            else if (type == "BALANCE")
            {
                balanceRecords.Add(new BALANCE(details[1], details[2], Int32.Parse(details[3])));
            }
            else
            {
                Console.WriteLine($"{type} command doesn't exist");
            }
        }
    }
}
