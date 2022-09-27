using System;
using Spin.Base.Company.Entity;

namespace MedicalClinic.Domain.Pharmacy.Entities.Information
{
    public class ClinicalPharmacyInformation: CompanyInformation
    {
        public ClinicalPharmacyInformation()
        {
            this.Name = "Medical Microservice";
            this.Version = "0.0.1-alpha";
            this.TypeVersion = "Alpha";
        }
    }
}
