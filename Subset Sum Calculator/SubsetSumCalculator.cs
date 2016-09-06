using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subset_Sum_Calculator
{
    public class SubsetSumCalculator
    {
        public int Sum { get; protected set; }
        public int[] Values { get; protected set; }

        public SubsetSumCalculator(int sum, int[] values)
        {
            this.Sum = sum;
            this.Values = values;
        }

    }
}
