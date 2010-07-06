using System;
using System.Data;
using System.Collections.ObjectModel;
using System.Globalization;

using Azzeton.Shared;

namespace Azzeton.Core.Entity
{
    /// <summary>
    /// Represents a system setting
    /// </summary>
    [Serializable()]
    public class SystemSetting
	{ 
        /// <summary>
        /// Initialize SystemSetting
        /// </summary>
		public SystemSetting()
		{
		}
        /// <summary>
        /// Initialize SystemSetting
        /// </summary>
        /// <param name="setting">Name of setting</param>
        /// <param name="value">Value of the setting</param>
        public SystemSetting(string setting, object value)
		{
			this.Setting = setting;
			this.Value = value;
		}
    }
}