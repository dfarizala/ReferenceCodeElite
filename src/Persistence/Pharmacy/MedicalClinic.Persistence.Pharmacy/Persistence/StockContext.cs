using System;
using MedicalClinic.Domain.Pharmacy.Entities;
using MedicalClinic.Domain.Pharmacy.Interfaces.Persistence;
using Spin.Modules.API.Base;

namespace MedicalClinic.Persistence.Pharmacy.Persistence
{
    public class StockContext : BaseBL<StockItem>, IStockContext
    {
        public StockContext()
            :base("Pharmacy")
        {
        }
    }
}
