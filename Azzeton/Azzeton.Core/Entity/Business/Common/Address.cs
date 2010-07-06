using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Address
    /// </summary>
    public class Address : Contact
    {
        /// <summary>
        /// First line of address
        /// </summary>
        public string AddressLine1 { get; set; }
        /// <summary>
        /// Second line of address
        /// </summary>
        public string AddressLine2 { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Town
        /// </summary>
        public string Town { get; set; }
        /// <summary>
        /// Post Code / Zip Code / Blank or N/A for places that do not use it
        /// </summary>
        public string Code { get; set; }
    }

    public class AddressManager 
    {
    }
}
