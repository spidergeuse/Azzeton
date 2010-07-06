using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Core.Entity
{
    public class DiscountRule : Discount
    {
        /* I've been thinking about product deals, like buy 1 get 1 free, 3 for 5 pounds but 1 for 2 pounds
         * that kind of thing.
         * 
         * In my mind, i'd create 
         * 1. A Condition class which takes 3 values. ValueA, Operator/Operation, ValueB.
         */

        int ProductId { get; set; }

    }
    public struct Condition
    {
        public object value1 { get; set; }
        public object value2 { get; set; }
    }
    public enum SearchUsing
    {
        AND = 0,
        OR = 1,
        NOTHING = 2
    }
    /// <summary>
    /// Type of comparism to be perform on two values
    /// Useful for SQL query building
    /// </summary>
    public enum ComparismType
    {
        /// <summary>
        /// LIKE anything containing
        /// </summary>
        Like = 0,
        /// <summary>
        /// LIKE anything ending with
        /// </summary>
        LikePre = 1,
        /// <summary>
        /// LIKE anything begining with
        /// </summary>
        LikePost = 2,
        /// <summary>
        /// EQUAL TO
        /// </summary>
        Equal = 3,
        /// <summary>
        /// Greater Than
        /// </summary>
        GreaterThan = 4,
        /// <summary>
        /// Less Than
        /// </summary>
        LessThan = 5,
        /// <summary>
        /// Greater Than or Equal To
        /// </summary>
        GreaterThanOrEqualTo = 6,
        /// <summary>
        /// Less Than or Equal To
        /// </summary>
        LessThanOrEqualTo = 7,
        /// <summary>
        /// Not Equal To
        /// </summary>
        NotEqual = 8
    }
}
