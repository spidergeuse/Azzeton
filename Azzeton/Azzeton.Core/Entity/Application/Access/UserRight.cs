using System;
using System.Data;
using System.Collections.ObjectModel;

using Azzeton.Shared;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Right of a user
    /// </summary>
    [Serializable()]
    public class UserRight
    {
        /// <summary>
        /// Initalize UserRight
        /// </summary>
        public UserRight()
        {
        }
        /// <summary>
        /// Initalize UserRight
        /// </summary>
        /// <param name="userid">Id of user</param>
        /// <param name="rightcode">Right Code</param>
        /// <param name="sectioncode">Section Code</param>
        public UserRight(int userid, string rightcode)
            : this()
        {
            this.UserID = userid;
            this.RightCode = rightcode;
        }
        /// <summary>
        /// Id of user
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Right Code
        /// </summary>
        public string RightCode { get; set; }
    }
    public class UserRightManager
    {
    }
}