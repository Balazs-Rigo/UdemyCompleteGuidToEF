using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Contract
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public DateTime CreatedOn { get; set; }

        public string PurchaseResponsible { get; set; }
        public string ContractManager { get; set; }
    }
}
