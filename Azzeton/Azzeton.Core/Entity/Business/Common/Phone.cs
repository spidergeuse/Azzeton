using System;
using System.Collections.ObjectModel;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Phone
    /// </summary>
    public class Phone :Contact
    {
        /// <summary>
        /// Phone Number Type
        /// </summary>
        public enum PhoneType
        {
            Fax,
            Mobile,
            Telephone,
            Pager,
            Unknown
        }
        /// <summary>
        /// Phone Number
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// Number Type
        /// </summary>
        public PhoneType Type { get; set; }
    }
    public class PhoneManager
    {
    }
}
