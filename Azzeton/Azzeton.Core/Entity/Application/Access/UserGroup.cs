using System;
using System.Data;
using System.Collections.ObjectModel;

using Azzeton.Shared;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represent UserGroup
    /// A grou that a user belongs to
    /// </summary>
    [Serializable()]
    public class UserGroup : IUserGroup
    {
        /// <summary>
        /// Initialize user group
        /// </summary>
        public UserGroup()
        {
        }
        /// <summary>
        /// Initialize user group
        /// </summary>
        /// <param name="userid">Id of user</param>
        /// <param name="groupid">Id of group</param>
        public UserGroup(int userid, int groupid)
        {
            this.UserID = userid;
            this.GroupID = groupid;
        }
        /// <summary>
        /// Id of user
        /// </summary>
        public int UserID { get; set; }
        /// <summary>
        /// Id of group
        /// </summary>
        public int GroupID { get; set; }
    }
    public class UserGroupManager 
    {
    }
}