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

        public List<string> GetMatches()
        {
            var matches = new List<string>();

            var allSubsets = findAllSubsets(this.Values);

            var allSubsetsWithSum = findAllSubsetsWithSum(allSubsets, this.Sum);

            matches = convertSubsetsWithSumToStrings(allSubsetsWithSum);

            return matches;
        }

        private List<string> convertSubsetsWithSumToStrings(List<decimal[]> allSubsetsWithSum)
        {
            var stringSubsets = new List<string>();

            foreach (var subset in allSubsetsWithSum)
            {
                stringSubsets.Add(String.Join(", ", subset));
            }

            return stringSubsets;
        }

        private List<decimal[]> findAllSubsets(decimal[] set)
        {
            var subsets = new List<decimal[]>();

            for (int i = 1; i < set.Length; i++)
            {
                var singleEntry = new decimal[1];
                singleEntry[0] = set[i - 1];
                subsets.Add(singleEntry);

                var newSubsets = new List<decimal[]>();

                for (int j = 0; j < subsets.Count; j++)
                {
                    var newSubset = new List<decimal>();
                    newSubset.AddRange(subsets[j]);
                    newSubset.Add(set[i]);

                    newSubsets.Add(newSubset.ToArray());
                }

                subsets.AddRange(newSubsets);
            }

            var lastEntry = new decimal[1];
            lastEntry[0] = set[set.Length - 1];
            subsets.Add(lastEntry);

            return subsets;
        }

        private List<decimal[]> findAllSubsetsWithSum(List<decimal[]> allSubsets, decimal sum)
        {
            var subsetsWithSum = new List<decimal[]>();

            foreach (var subset in allSubsets)
            {
                if (subset.Sum() == sum)
                {
                    subsetsWithSum.Add(subset);
                }
            }

            return subsetsWithSum;
        }
    }
}
