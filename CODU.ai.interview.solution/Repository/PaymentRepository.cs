using geektrust_family_demo.ProcessedModel;
using geektrust_family_demo.Repository.Interface;
using System;
using System.Collections.Generic;

namespace geektrust_family_demo.Repository
{
    public class PaymentRepository : IModelRepository<ProcessedPayment>
    {
        public List<ProcessedPayment> paymentRecords = new List<ProcessedPayment>();
        public void AddModel(ProcessedPayment model)
        {
            throw new NotImplementedException();
        }

        public void DeleteModel(ProcessedPayment model)
        {
            throw new NotImplementedException();
        }

        public List<ProcessedPayment> GetAllModels()
        {
            throw new NotImplementedException();
        }

        public ProcessedPayment GetModel(string BANK_NAME, string BORROWER_NAME)
        {
            throw new NotImplementedException();
        }

        public ProcessedPayment UpdateModel(ProcessedPayment model)
        {
            throw new NotImplementedException();
        }
    }
}
