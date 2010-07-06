using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using Azzeton.Shared;
using Azzeton.Shared.Security;
using Azzeton.Core.Entity;
using System.Globalization;

namespace Azzeton.Core.Entity
{
    public class CoreGlobals
    {
        /*valid interface names*/
        internal const string ValidModuleInterface      = "DMS.Shared.IPlugin";
        internal const string ValidHostInterface        = "DMS.Shared.IDataHost";


       /*Currentdatahost_manager for desired purpose*/
        public static IDataHost         CurrentHost;
        public static IDataHost         CurrentBackupHost;
        public static IDataHost         CurrentImportHost;
        public static IDataHost         CurrentMigrateHost;

        private static Assembly         CurrentResourceAssembly;
        public static IResourceManager  CurrentResourceManager;
        public static IUser             CurrentUser;
        public static string            CurrentWinUser;
        public static string            CurrentWorkstation;
        public static string            CurrentDomain;
        private static Hashtable        CurrentUsersRights;

        /// <summary>
        /// Collection of system modules/plugins
        /// </summary>
        public static Collection<IModule> Modules;
        /// <summary>
        /// Default authentication
        /// </summary>
        public static AccessCredentials Custom_Authentication
        {
            get;
            set;
        }
        /// <summary>
        /// Default authentication
        /// </summary>
        internal static AccessCredentials DefaultAccessCredentials
        {
            get
            {
                AccessCredentials _ha = new Azzeton.Shared.AccessCredentials();
                _ha.Database = "azzeton";
                _ha.Host = "localhost";
                _ha.Username    = "azzeton";
                _ha.Password = "punana";
                return _ha;
            }
        }

        /// <summary>
        /// Load plugins/modules
        /// </summary>
        private static void LoadModules()
        {
            SendStatus("Loading Modules");
            PluginManager _plugin_manager = new PluginManager();
            /*fetch all valid plugins from that path*/
            Collection<object> objects = _plugin_manager.GetPlugins(ValidModuleInterface, null);
            foreach (object module in objects)
            {
                IModule _plugin = (IModule)module;
                if (_plugin.PluginInformation.PassKey == SuperCryptor.Encrypt("azzeton", "punana"))
                {
                    /*add to collection*/
                    if (!Modules.Contains((IModule)module))
                    {
                        Modules.Add((IModule)module);
                        SendStatus(string.Format("Loading {0}", ((IModule)module).PluginInformation.Name));
                    }
                }
            }       
        }
        /// <summary>
        /// Load/Setup the current/default connection object
        /// </summary>
        private static void LoadCurrentConnection()
        {
            /*use default connection settings if custom setting is empty*/
            AccessCredentials _auth = (Custom_Authentication == null) ? DefaultAccessCredentials : Custom_Authentication;
            IModule _module = CurrentHost as IModule;
            CurrentHost = LoadDataHost("", _module.PluginInformation.UniqueId, _auth);
        }
        /// <summary>
        /// Sets up the paths to application related folders
        /// </summary>
        /// <param name="path">Root path / data folder path</param>
        public static void SetupPaths(string path)
        {
            AppBackupPath = Path.Combine(path, "Backups");
            AppCandidateBackupPath = Path.Combine(path, "Backups");
        }

        /// <summary>
        /// Load all data host managers
        /// </summary>
        /// <param name="hostpath">path of the host application / StartupPath</param>
        /// <returns>Collection of DataHost manager object</returns>
        public static Collection<IDataHost> LoadAllDataHost(string hostpath)
        {
            /*set the path to Module files, relative the the hostpath/StartupPath*/
            AppModulePath = Path.Combine(hostpath, "Modules");
            Collection<IDataHost> _plugins = new Collection<IDataHost>();
            /*fetch all valid plugins from that path*/
            Collection<object> objects = new ModuleManager().GetModules(ValidHostInterface, null);
            foreach (object obj in objects)
            {
                /*check if is valid host manager plugin*/
                IDataHost _host = obj as IDataHost;
                if (_host != null)
                {
                    IModule _plugin = _host as IModule;
                    if (_plugin.ModuleInformation.PassKey == SuperCryptor.Encrypt("azzeton", "punana"))
                    {
                        /*add to collection*/
                        if (!_plugins.Contains(_host))
                            _plugins.Add(_host);
                    }
                }
            }
            return _plugins;
        }
        /// <summary>
        /// Load a data host manager
        /// </summary>
        /// <param name="hostpath">path of the host application / StartupPath</param>
        /// <param name="uniqueid">unique id of the host manager /plugin</param>
        /// <returns>DataHost manager object or null</returns>
        public static IDataHost LoadDataHost(string hostpath, string uniqueid)
        {
            return LoadDataHost(hostpath, uniqueid, null);
        }
        /// <summary>
        /// Load a data host manager
        /// </summary>
        /// <param name="hostpath">path of the host application / StartupPath</param>
        /// <param name="uniqueid">unique id of the host manager /plugin</param>
        /// <param name="authentication">authentication to be used to access the host / null</param>
        /// <returns>DataHost manager object or null</returns>
        public static IDataHost LoadDataHost(string hostpath, string uniqueid, AccessCredentials authentication)
        {
            /*set the path to Module files, relative the the hostpath/StartupPath*/
            AppModulePath = Path.Combine(hostpath, "Modules");
            /*fetch all valid plugins from that path*/
            Collection<object> objects = new ModuleManager().GetModules(ValidHostInterface, ((authentication == null) ? null : new object[] { authentication }));
            /*search through list a select one with mataching uniqueid*/
            foreach (object plugin in objects)
            {
                IDataHost _host = plugin as IDataHost;
                IModule _plugin = plugin as IModule;
                if (_plugin.PluginInformation.PassKey == SuperCryptor.Encrypt("azzeton", "punana"))
                {
                    /*set host path of plugin*/
                    if (_plugin.PluginInformation.UniqueId == uniqueid)
                        return _host;
                }
            }
            /*no match found*/
            return null;
        }
        /// <summary>
        /// Send process status information to listening handlers
        /// </summary>
        /// <param name="status">status to send</param>
        private static void SendStatus(string status)
        {
            if (StatusChanged != null)
                StatusChanged(null, new StatusEventArgs(0, status, null));
        }
    }
}
