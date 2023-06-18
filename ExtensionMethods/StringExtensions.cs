using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    /// <summary>
    /// contains string extension methods
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// determines if instance represents a true value, else assume false
        /// </summary>
        /// <param name="parameter">parameter to check</param>
        /// <returns>true if contents represent a true value, false otherwise</returns>
        /// <remarks>null safe, will remove leading and trailing spaces before evaluating
        /// This is predicated on the stance that anything that does not commonly represent a "true value" is considered false.
        /// That is, it will not explicitly check for values the represent false.  Perhaps you need an IsFalse for that...
        /// </remarks>
        public static bool IsTrue(this string parameter)
        {
            bool result = false;

            if (!string.IsNullOrEmpty(parameter))
            {
                string temp = parameter.Trim();

                // todo: evaluate your most common use case: do you specify true or t or yes more often?  The one that is the most common
                // should be moved in your implemenation to be the first checked, if performance is an issue.
                result = temp.Equals("true", StringComparison.OrdinalIgnoreCase) || temp.Equals("t", StringComparison.OrdinalIgnoreCase) ||
                    temp.Equals("1", StringComparison.OrdinalIgnoreCase) || temp.Equals("y", StringComparison.OrdinalIgnoreCase) ||
                    temp.Equals("yes", StringComparison.OrdinalIgnoreCase);
            }

            return result;
        }
    }
}
