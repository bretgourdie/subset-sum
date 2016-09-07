using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subset_Sum_Calculator
{
    /// <summary>
    /// The state of the input on the form.
    /// </summary>
    public enum InvalidInput
    {
        /// <summary>
        /// Denotes the "sum" field is invalid.
        /// </summary>
        Sum, 
        /// <summary>
        /// Denotes the "values" field is invalid.
        /// </summary>
        Values, 
        /// <summary>
        /// Denotes that no "values" sum together to the "sum" field.
        /// </summary>
        NoResults,
        /// <summary>
        /// Denotes that no inputs are invalid.
        /// </summary>
        None
    }
}
