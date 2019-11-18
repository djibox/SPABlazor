using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp5.Models
{
    public class BudgetItem
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public decimal Remaining { get; set; }
    }
}
