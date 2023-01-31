using System;
using System.Collections.Generic;

namespace SPS.Data.Models
{
    public partial class Userdetail
    {
        public int Userid { get; set; }
        public string? Username { get; set; }
        public string? Address { get; set; }
        public string? Cellnumber { get; set; }
        public string? Emailid { get; set; }
    }
}
