using System;
using Spin.Base.Company.Entity;

namespace MedicalClinic.Domain.Common.Information
{
    public class ClinicalInvoiceInformation: CompanyInformation
    {
        public ClinicalInvoiceInformation()
        {
            this.Name = "Medical Clinic";
            this.Version = "0.0.1-alpha";
            this.TypeVersion = "Alpha";
        }
    }
}
