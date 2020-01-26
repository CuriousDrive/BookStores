using System;
using System.Collections.Generic;

namespace BookStoresWebAPI.Models
{
    public partial class Sale
    {
        public int SaleId { get; set; }
        public string StoreId { get; set; }
        public string OrderNum { get; set; }
        public DateTime OrderDate { get; set; }
        public short Quantity { get; set; }
        public string PayTerms { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; }
        public virtual Store Store { get; set; }
    }
}
