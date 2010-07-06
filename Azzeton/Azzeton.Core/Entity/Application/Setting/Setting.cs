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
    protected abstract class Setting
    {
        /// <summary>
        /// Name of setting
        /// </summary>
        public string Setting { get; set; }
        /// <summary>
        /// Value of setting
        /// </summary>
        public object Value { get; set; }
    }
}