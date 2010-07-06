using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

using Azzeton.Shared;

namespace Azzeton.Core.Entity
{
    public class PluginManager
    {
        private string _search_string= "*.mgp";
        public PluginManager()
        {}
        public object GetPlugin(string valid_plugin_interface, object[] args)
        {
            return GetPlugin(valid_plugin_interface, args, false);
        }
        public object GetPlugin(string valid_plugin_interface, object[] args, bool onlyregistered)
        {
            try
            {
                foreach (string _file in Directory.GetFiles(CoreGlobals.AppPluginPath, _search_string, SearchOption.AllDirectories))
                {
                    try
                    {
                        Assembly _assembly = (Assembly)Assembly.LoadFile(_file);
                        System.Type[] _types = _assembly.GetTypes();
                        foreach (System.Type _type in _types)
                        {
                            if (_type.GetInterface(valid_plugin_interface, true) != null)
                            {
                                try
                                {
                                    object _plugin = (object)_assembly.CreateInstance(_type.FullName, true, BindingFlags.CreateInstance, null, args, null, null);
                                    if (onlyregistered)
                                    {
                                        if (IsRegistered(_plugin))
                                            return _plugin;
                                        else
                                            return null;
                                    }
                                    return _plugin;
                                }
                                catch{}
                            }
                        }
                    }
                    catch{}
                }
            }
            catch{}
            return null;
        }
        public object GetPlugin(string valid_plugin_interface, object[] args, string path)
        {
            try
            {
                Assembly _assembly = (Assembly)Assembly.LoadFile(path);
                System.Type[] _types = _assembly.GetTypes();
                foreach (System.Type _type in _types)
                {
                    if (_type.GetInterface(valid_plugin_interface, true) != null)
                    {
                        try
                        {
                            object _plugin = (object)_assembly.CreateInstance(_type.FullName, true, BindingFlags.CreateInstance, null, args, null, null);
                            return _plugin;
                        }
                        catch { }
                    }
                }
            }
            catch { }
            return null;
        }
        public Collection<object> GetPlugins(string valid_plugin_interface, object[] args)
        {
            return GetPlugins(valid_plugin_interface, args, false);
        }
        public Collection<object> GetPlugins(string valid_plugin_interface, object[] args, bool onlyregistered)
        {
            Collection<object> _plugins = new Collection<object>();
            try
            {
                Assembly _assembly;
                foreach (string _file in Directory.GetFiles(CoreGlobals.AppPluginPath, _search_string, SearchOption.AllDirectories))
                {
                    try
                    {
                        _assembly = (Assembly)Assembly.LoadFile(_file);
                        System.Type[] _types = _assembly.GetTypes();
                        foreach (System.Type _type in _types)
                        {
                            if (_type.GetInterface(valid_plugin_interface, true) != null)
                            {
                                try
                                {
                                    object _plugin = (object)_assembly.CreateInstance(_type.FullName, true, BindingFlags.CreateInstance, null, args, null, null);
                                    if (onlyregistered)
                                    {
                                        if (!IsRegistered(_plugin))
                                            continue;
                                    }
                                    _plugins.Add(_plugin);
                                }
                                catch{}
                            }
                        }
                    }
                    catch{}
                }
            }
            catch (Exception ex){FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now);}  
            return _plugins;
        }
        public Assembly GetAssembly(string valid_assembly_interface)
        {
            try
            {
                foreach (string _file in Directory.GetFiles(CoreGlobals.AppPluginPath, _search_string, SearchOption.AllDirectories))
                {
                    try
                    {
                        Assembly _plugin = (Assembly)Assembly.LoadFile(_file);
                        System.Type[] _types = _plugin.GetTypes();
                        foreach (System.Type _type in _types)
                        {
                            try
                            {
                                if (_type.GetInterface(valid_assembly_interface, true) != null)
                                    return _plugin;
                            }
                            catch{}
                        }
                    }
                    catch{}
                }
            }
            catch{}
            return null;
        }
        public bool IsRegistered(IModule plugin)
        {
            if (plugin != null)
            {
                try
                {
                    IConfiguration _config = null;// new ConfigurationManager().Get(SystemSettingTitle.Module + plugin.PluginInformation.Name);
                    if (_config != null)
                    {
                        string _value = (string)Serializer.Deserialize<string>((byte[])_config.Value);
                        if (_value == plugin.UniqueID)
                            return true;
                    }
                }
                catch { }
            }
            return false;
        }
        public bool IsRegistered(object plugin)
        {
            IModule _plugin = plugin as IModule;
            return IsRegistered(_plugin);
        }
    }
}
