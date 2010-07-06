using System;
using System.Data;
using System.Collections.ObjectModel;
using System.Globalization;
using Azzeton.Shared;


namespace Azzeton.Core.Entity
{
    [Serializable()]
    public class SystemAudit : Audit
    {
        public SystemAudit()
        {
            this.WinUser = CoreGlobals.CurrentWinUser;// Environment.UserName;
            this.Domain = CoreGlobals.CurrentDomain;// Environment.UserDomainName;
            this.Workstation = CoreGlobals.CurrentWorkstation;// Environment.MachineName;
        }
        public SystemAudit(int id, string action, string description, string status, DateTime stamp, int sourceid):this()
        {
            this.Id = id;
            this.Action = action;
            this.Description = description;
            this.Status = status;
            this.Stamp = stamp;
            this.SourceId = sourceid;
        }
        public SystemAudit(int id, string action, string description, string status, DateTime stamp, int userid, string winuser, string workstation, string domain):this(id,action,description,status,stamp,userid)
        {
            this.WinUser = winuser;
            this.Domain = domain;
            this.Workstation = workstation;
        }
        /// <summary>
        /// Action taker's id
        /// </summary>
        public int SourceId { get; set; }
    }
    public class SystemAuditManager 
    {
    }
}