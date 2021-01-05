using System;
using System.Collections.Generic;

namespace FianlGUI.Models
{
    public partial class Tyler
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Weekday { get; set; }
        public int? Yardlength { get; set; }
        public int? Yardwidth { get; set; }
    }
}
