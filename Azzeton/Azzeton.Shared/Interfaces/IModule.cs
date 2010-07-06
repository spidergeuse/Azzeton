using System;
using System.Text;
using System.Drawing;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;
using System.Windows.Forms;

namespace Azzeton.Shared
{

    /// <summary>
    /// Should be implemented by all classes that
    /// wish to act as modules/plugins in Azzeton.
    /// To have a user interface IPluginWithUI should also be implemented
    /// </summary>
    public interface IModule
    {
        /// <summary>
        /// Represents complete information of plugin/module
        /// </summary>
        ModuleInformation PluginInformation { get;}
        /// <summary>
        /// Creates an instance of the current object
        /// </summary>
        /// <returns>Current object</returns>
        object CreateInstance();
        /// <summary>
        /// Creates an instance of the current object with parameters
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns></returns>
        object CreateInstance(params object[] parameters);
       
    }
}
