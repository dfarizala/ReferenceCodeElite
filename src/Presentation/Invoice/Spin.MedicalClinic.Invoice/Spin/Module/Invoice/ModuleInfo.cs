using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Spin.Modules.Entity;

namespace Spin.Modules.Invoice
{
    [Serializable]
    public class Invoice : SpinModuleBase
    {
        public Invoice()
            : base("Invoice")
        {
            
        }
    }
}