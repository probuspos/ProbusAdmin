using System;
using System.Collections.Generic;

namespace SPS.Data.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public int SubscriberMasterId { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

       public virtual SubscriberDetail SubscriberMaster { get; set; } = null!;
       public virtual ICollection<Product> Products { get; set; }
    }
}
