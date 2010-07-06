using System;
using System.Data;
using System.Collections.ObjectModel;

using Azzeton.Shared;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Right of a group
    /// </summary>
    [Serializable()]
    public class GroupRight 
    {
        /// <summary>
        /// Initalize GroupRight
        /// </summary>
        public GroupRight()
        {
        }
        /// <summary>
        /// Initalize GroupRight
        /// </summary>
        /// <param name="groupid">Id of group</param>
        /// <param name="rightcode">Right Code</param>
        /// <param name="sectioncode">Section Code</param>
        public GroupRight(int groupid, string rightcode):this()
        {
            this.GroupID = groupid;
            this.RightCode = rightcode;
        }
        /// <summary>
        /// Id of group
        /// </summary>
        public int GroupID { get; set; }
        /// <summary>
        /// Right Code
        /// </summary>
        public string RightCode { get; set; }
    }
    public class GroupRightManager 
    {
    }
}