using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIApp.Data
{
    public class TypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public IncomeOrExpenditureEnum? IncomeOrExpenditureEnum { get; set; }
    }
}
