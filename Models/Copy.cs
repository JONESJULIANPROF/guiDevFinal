using System;
using System.Collections.Generic;

namespace FianlGUI.Models
{
    public partial class Copy
    {
        public string BookCode { get; set; }
        public decimal BranchNum { get; set; }
        public decimal CopyNum { get; set; }
        public string Quality { get; set; }
        public decimal? Price { get; set; }
    }
}
