using System;
using System.Collections.Generic;
using System.Text;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represent an audit object
    /// </summary>
    public abstract class Audit 
    {
        /// <summary>
        /// Id of audit entry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Action
        /// </summary>
        public string Action { get; set; }
        /// <summary>
        /// Description of action
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Time stamp
        /// </summary>
        public DateTime Stamp { get; set; }
        /// <summary>
        /// Status of action
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// Workstation name
        /// </summary>
        public string Workstation { get; set; }
        /// <summary>
        /// Logged in user (windows)
        /// </summary>
        public string WinUser { get; set; }
        /// <summary>
        /// Domain name
        /// </summary>
        public string Domain { get; set; }
    }
}
