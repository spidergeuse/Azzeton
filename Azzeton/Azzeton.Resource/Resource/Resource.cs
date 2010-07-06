using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text;

using Azzeton.Shared;

namespace Azzeton.Resources
{
    public class Resource : IResource, IModule
    {       
        public bool Exist(Collection<string> resource_names)
        {
            return true;
        }
        
        #region IPlugin Implementations
         public ModuleInformation PluginInformation
         {
             get
             {
                 ModuleInformation _information = new ModuleInformation();
                 _information.Name = ProductSettings.ProductName + " Resource";
                 _information.Description = "Resouorce Tool";
                 _information.Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
                 _information.Link = ProductSettings.ProductPluginURL;
                 _information.Author = ProductSettings.ProductCompany;
                 _information.Type = ModuleType.Resource;
                 _information.HasUI = false;
                 _information.MenuText = "";
                 _information.PassKey = Azzeton.Shared.Security.SuperCryptor.Encrypt("azzeton", "punana");
                 return _information;
             }
         }
         public string HostStartupPath { private get; set; }
         public string UniqueID { get { return "{21B8A6EA-7C4F-4188-A82E-401F6FF2DA39}"; } }
        #endregion
    }
}
