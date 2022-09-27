using MedicalClinic.Domain.Interfaces.Base;
using MedicalClinic.Domain.Pharmacy.Entities;

namespace MedicalClinic.Domain.Pharmacy.Interfaces.Persistence
{   
    public interface IStorageContext : IBaseCommonBL<StorageItem, int>
    {
    }
}
