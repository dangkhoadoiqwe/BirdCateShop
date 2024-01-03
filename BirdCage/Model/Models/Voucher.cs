using System;
using System.Collections.Generic;

#nullable disable

namespace Model.Models
{
    public partial class Voucher
    {
        public int VoucherId { get; set; }
        public string VoucherName { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int? Value { get; set; }
        public int VoucherStatus { get; set; }
        public string Code { get; set; }
    }
}
