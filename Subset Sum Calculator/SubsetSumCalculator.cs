using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subset_Sum_Calculator
{
    public class SubsetSumCalculator
    {
        public decimal Sum { get; protected set; }
        public decimal[] Values { get; protected set; }

        public SubsetSumCalculator(decimal sum, decimal[] values)
        {
            this.Sum = sum;
            this.Values = values;
        }

    }
}
