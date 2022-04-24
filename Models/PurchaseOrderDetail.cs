using System;
using System.Collections.Generic;

namespace AdventureWorks.Models
{
    public partial class PurchaseOrderDetail
    {
        public int PurchaseOrderId { get; set; }
        public short LineNumber { get; set; }
        public int? ProductId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? OrderQty { get; set; }
        public double? ReceivedQty { get; set; }
        public double? RejectedQty { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
