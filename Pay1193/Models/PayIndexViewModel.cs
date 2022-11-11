﻿using System.ComponentModel.DataAnnotations;

namespace Pay1193.Models
{
    public class PayIndexViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal NiC { get; set; }
        public decimal Tax { get; set; }
        public decimal UnionFee { get; set; }
        public DateTime DatePay { get; set; }
        public decimal NetPayment { get; set; }
    }
}
