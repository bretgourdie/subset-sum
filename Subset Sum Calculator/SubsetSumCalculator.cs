using System;
using System.Collections.Generic;
using System.Linq;

namespace Subset_Sum_Calculator
{
    /// <summary>
    /// Handles calculating the subset sum of the supplied set and sum.
    /// </summary>
    public class SubsetSumCalculator
    {
        /// <summary>
        /// The target sum for the subset(s) to reach.
        /// </summary>
        public decimal Sum { get; protected set; }
        /// <summary>
        /// The set to use to find the subset sum(s).
        /// </summary>
        public decimal[] Values { get; protected set; }

        /// <summary>
        /// Initializes a SubsetSumCalculator with the target sum and set of values.
        /// </summary>
        /// <param name="sum">The number to find the summation of subsets of.</param>
        /// <param name="values">The set to find subsets of.</param>
        public SubsetSumCalculator(decimal sum, decimal[] values)
        {
            this.Sum = sum;
            this.Values = values;
        }

        /// <summary>
        /// Calculates a list of subset sums and returns it.
        /// </summary>
        /// <returns>Returns a list of comma-separated strings with subsets equaling the sum.</returns>
        public List<string> GetMatches()
        {
            var matches = new List<string>();

            var allSubsets = findAllSubsets(this.Values);

            var allSubsetsWithSum = findAllSubsetsWithSum(allSubsets, this.Sum);

            matches = convertSubsetsWithSumToStrings(allSubsetsWithSum);

            return matches;
        }

        /// <summary>
        /// Converts a list of decimal arrays to a list of comma-separated strings.
        /// </summary>
        /// <param name="allSubsetsWithSum">All subsets that sum to the target sum.</param>
        /// <returns>Returns a list of comma-separated subset strings.</returns>
        private List<string> convertSubsetsWithSumToStrings(List<decimal[]> allSubsetsWithSum)
        {
            var stringSubsets = new List<string>();

            foreach (var subset in allSubsetsWithSum)
            {
                stringSubsets.Add(String.Join(", ", subset));
            }

            return stringSubsets;
        }

        /// <summary>
        /// Find all subsets for the given decimal array.
        /// </summary>
        /// <param name="set">A decimal array to find subsets of.</param>
        /// <remarks>
        /// I lifted this from StackOverflow and it seems to work. 
        /// I will attempt to understand it in a different branch.
        /// </remarks>
        /// <returns>Returns a list of decimal arrays for each subset of the supplied set.</returns>
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

        /// <summary>
        /// Find the subsets that total to the supplied sum.
        /// </summary>
        /// <param name="allSubsets">A list of all subsets of the target set.</param>
        /// <param name="sum">The target sum.</param>
        /// <returns>Returns the subsets that sum to the target sum.</returns>
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
