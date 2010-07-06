using System;
using System.Collections.Generic;
namespace Azzeton.Shared
{
    /// <summary>
    /// Represents audit item
    /// </summary>
    public interface IAudit
    {
        /// <summary>
        /// Action
        /// </summary>
        string Action { get; set; }
        /// <summary>
        /// Description of item
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// Id of item
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Date Created/Last Modified or Timestamp
        /// </summary>
        DateTime Stamp { get; set; }
        /// <summary>
        /// Status of action
        /// </summary>
        string Status { get; set; }
        /// <summary>
        /// Workstation from which action was taken
        /// </summary>
        string Workstation{ get; set; }  
        /// <summary>
        /// System(Windows) user account from which action was taken
        /// </summary>
        string WinUser{ get; set; }
        /// <summary>
        /// Network domain from which action was taken
        /// </summary>
        string Domain{ get; set; }
    }
}
