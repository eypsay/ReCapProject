using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public string CompanyName { get; set; }
        public decimal Payment { get; set; }
        public string PaymetType { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
