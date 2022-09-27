using System;
using Spin.Base.Company.Entity;

namespace MedicalClinic.Domain.Website.Entities.Information
{
    public class ClinicalInvoiceInformation: CompanyInformation
    {
        public ClinicalInvoiceInformation()
        {
            this.Name = "Medical Microservice";
            this.Version = "0.0.1-alpha";
            this.TypeVersion = "Alpha";
        }
    }
}
