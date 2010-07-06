using System;
using System.ComponentModel;
using System.CodeDom;

namespace Azzeton.Shared
{
    public delegate void StatusEventHandler(object sender, StatusEventArgs e);
    public delegate void ActionResultEventHandler(ActionResult results);
    public delegate void NotifySettingUpdateEventHandler(object sender);
    /// <summary>
    /// A generic event handler. Could be use for any instance.
    /// e could take any type of object
    /// </summary>
    /// <param name="sender">source</param>
    /// <param name="e">Generic argument</param>
    public delegate void GenericEventHandler(object sender, GenericEventArgs e);
}
