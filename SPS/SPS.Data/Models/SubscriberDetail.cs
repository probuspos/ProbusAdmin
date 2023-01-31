using System;
using System.Collections.Generic;

namespace SPS.Data.Models
{
    public partial class SubscriberDetail
    {
        public SubscriberDetail()
        {
            Categories = new HashSet<Category>();
            Products = new HashSet<Product>();
        }

        public int SubscriberMasterId { get; set; }
        public string? SubscriberName { get; set; }
        public string? City { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
