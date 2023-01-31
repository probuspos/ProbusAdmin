using System;
using System.Collections.Generic;

namespace SPS.Data.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int SubscriberMasterId { get; set; }
        public int CategoryId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual SubscriberDetail SubscriberMaster { get; set; } = null!;
    }
}
