using System;
using System.Collections.Generic;

namespace SPS.Data.Models
{
    public partial class TblCategoryDetail
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public bool? CategoryStatus { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? SubscriberId { get; set; }
    }
}
