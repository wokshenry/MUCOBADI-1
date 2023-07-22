using System;
using System.Collections.Generic;

#nullable disable

namespace MUCOBADI.Models
{
    public partial class AExpensePayment
    {
        public AExpensePayment()
        {
            Hvat = new HashSet<Hvat>();
        }

        public int ExpensePaymentId { get; set; }
        public string ExpensePaymentDescription { get; set; }
        public double? ExpensePaymentScore { get; set; }

        public virtual ICollection<Hvat> Hvat { get; set; }
    }
}
