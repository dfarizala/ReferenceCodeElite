using System;
using MedicalClinic.Domain.Pharmacy.Entities;
using MedicalClinic.Domain.Pharmacy.Interfaces.Persistence;
using Spin.Modules.API.Base;

namespace MedicalClinic.Persistence.Pharmacy.Persistence
{
    public class BatchContext : BaseBL<BatchItem>, IBatchContext
    {
        public BatchContext()
            : base("Pharmacy")
        {
        }
    }
}
