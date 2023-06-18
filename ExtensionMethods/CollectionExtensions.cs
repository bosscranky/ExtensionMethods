using System;
using System.Collections;


namespace ExtensionMethods
{
    /// <summary>
    /// holds collection extension methods
    /// </summary>
    public static class CollectionExtensions
    {

        /// <summary>
        /// determines if instance has entries, true if so, false otherwise, including a null parameter
        /// </summary>
        /// <param name="candidate">instance to evaluate</param>
        /// <returns>true if instance is valid and has at least one record, false in all other conditions</returns>
        /// <remarks>this solution does not require linq and will not generate a NPE if the instance is unitialized</remarks>
        public static bool HasEntries(this ICollection candidate)
        {
            return candidate != null && candidate.Count > 0;
        }

    }
}
