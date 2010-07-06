using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Azzeton.Shared
{
    /// <summary>
    /// Represenst the description plugins/modules
    /// </summary>
    public struct ModuleInformation
    {
        /// <summary>
        /// Author of plugin/module
        /// </summary>
        public string Author;
        /// <summary>
        /// Name of plugin/module
        /// </summary>
        public string Name;
        /// <summary>
        /// Version of plugin/module
        /// </summary>
        public Version Version;
        /// <summary>
        /// Description of plugin/module
        /// </summary>
        public string Description;
        /// <summary>
        /// URL to resources of plugin/module
        /// </summary>
        public string Link;
        /// <summary>
        /// Type of plugin/module
        /// </summary>
        public ModuleType Type;
        /// <summary>
        /// Image/Icon of plugin/module
        /// </summary>
        public Icon Image;
        /// <summary>
        /// Specifies if plugin/module has user interface
        /// </summary>
        public bool HasUI;
        /// <summary>
        /// Text on host money if plugin/module has a user interface
        /// </summary>
        public string MenuText;
        /// <summary>
        /// Pass key to check validity of plugin/module
        /// </summary>
        public string PassKey;
        /// <summary>
        /// Represent Unique Identity of every module/plugin
        /// </summary>
        public string UniqueId;
        /// <summary>
        /// Common id of group of plugins
        /// </summary>
        public string GroupId;
    }
}
