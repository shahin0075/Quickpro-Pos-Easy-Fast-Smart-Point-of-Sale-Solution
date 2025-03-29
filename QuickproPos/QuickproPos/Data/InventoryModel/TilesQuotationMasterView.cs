﻿namespace QuickproPos.Data.InventoryModel
{
    public class TilesQuotationMasterView
    {
        public int TileQuotationid { get; set; }
        public int LedgerId { get; set; }
        public int VoucherTypeId { get; set; }
        public string VoucherTypeName { get; set; }
        public string UserId { get; set; }
        public string LedgerName { get; set; }
        public string QuotationNo { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalSqft { get; set; } = 0;
        public decimal TotalBox { get; set; } = 0;
        public decimal DiscountAmount { get; set; } = 0;
        public decimal TotalAmount { get; set; } = 0;
        public decimal AdvanceAmount { get; set; } = 0;
        public decimal PendingAmount { get; set; }
        public decimal GrandTotal { get; set; } = 0;
        public string Narration { get; set; }
    }
}
