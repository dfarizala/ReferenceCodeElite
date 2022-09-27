using MedicalClinic.Domain.Interfaces.Base;
using MedicalClinic.Domain.Pharmacy.Entities;

namespace MedicalClinic.Domain.Pharmacy.Interfaces.Persistence
{
   public interface IBatchContext : IBaseCommonBL<BatchItem, int>
    {
    }
}
