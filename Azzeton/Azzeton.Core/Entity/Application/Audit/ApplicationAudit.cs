using System;
using System.Data;
using System.Collections.ObjectModel;
using System.Globalization;
using Azzeton.Shared;


namespace Azzeton.Core.Entity
{ 
    /// <summary>
    /// Represents an audit class
    /// </summary>
    [Serializable()]
	public class ApplicationAudit : Audit
	{ 
		public ApplicationAudit()
		{
            this.WinUser = CoreGlobals.CurrentWinUser;// Environment.UserName;
            this.Domain = CoreGlobals.CurrentDomain;// Environment.UserDomainName;
            this.Workstation = CoreGlobals.CurrentWorkstation;// Environment.MachineName;
		}
        public ApplicationAudit(int id, string action, string description, string status, DateTime stamp, int sourceid, int destinationid)
            : this()
        {
            this.Id = id;
            this.Action = action;
            this.Description = description;
            this.Status = status;
            this.Stamp = stamp;
            this.SourceId = sourceid;
            this.DestinationId = destinationid;
        }
        public ApplicationAudit(int id, string action, string description, string status, DateTime stamp, int sourceid, int destinationid, string winuser, string workstation, string domain):this(id,action,description,status,stamp,sourceid,destinationid)
        {
            this.WinUser = winuser;
            this.Domain = domain;
            this.Workstation = workstation;
        }
        /// <summary>
        /// Action taker's id
        /// </summary>
        public int SourceId { get; set; }
        /// <summary>
        /// Action receipient's id
        /// </summary>
        public int DestinationId { get; set; }

    }
    public class ApplicationAuditManager
    {
    }
}