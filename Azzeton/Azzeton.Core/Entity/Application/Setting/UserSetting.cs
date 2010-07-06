using System;
using System.Data;
using System.Collections.ObjectModel;
using System.Globalization;

using Azzeton.Shared;


namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represents a user's setting
    /// </summary>
    [Serializable()]
    public class UserSetting : Setting
	{ 
        /// <summary>
        /// Initialize UserSetting
        /// </summary>
		public UserSetting()
		{
		}
        /// <summary>
        /// Initialize UserSetting
        /// </summary>
        /// <param name="userid">Id of user</param>
        /// <param name="setting">Name of setting</param>
        /// <param name="value">Value of the setting</param>
		public UserSetting(int userid,string setting, object value):this()
		{
			this.UserID = userid;
			this.Setting = setting;
            this.Value = value;
		}
        /// <summary>
        /// Id of user
        /// </summary>
        public int UserID { get; set; }
     
	}
}