using System;
using System.Drawing;
using System.Reflection;
using System.Collections.ObjectModel;

using Azzeton.Shared;

namespace Azzeton.Resources {
   public class Plugin : System.IDisposable, IResourceManager, IModule
   {

      #region -- private fields --
      private  Bitmaps     _bitmaps         = null;
      private  Icons       _icons           = null;
      private  Sounds      _sounds          = null;
      private  IXStream    _xstream         = null;
      #endregion

      #region -- constructors --
        public Plugin()
        {
            Assembly _assembly = Assembly.GetExecutingAssembly();
            _bitmaps = new Bitmaps(_assembly);
            _icons = new Icons(_assembly);
            _sounds = new Sounds(_assembly);
        }
        public Plugin(Assembly target) 
        {
         _bitmaps = new Bitmaps(target);
         _icons   = new Icons(target);
         _sounds  = new Sounds(target);
        }
      #endregion

      #region -- properties --
      public IBitmaps Bitmaps 
      {
         get {return _bitmaps;}
      }
      public IIcons Icons 
      {
         get {return _icons;}
      }
      public ISounds Sounds 
      {
         get {return _sounds;}
      }
      public IXStream XStream
      {
          get { return _xstream; }
      }
      #endregion

      #region -- idisposable members --
      public void Dispose() 
      {
         _bitmaps.Dispose();
         _icons.Dispose();
         _sounds.Dispose();

         GC.SuppressFinalize(this);
      }
      #endregion

      #region IPlugin Implementations
       public ModuleInformation PluginInformation
       {
           get
           {
               ModuleInformation _information = new ModuleInformation();
               _information.Name = ProductSettings.ProductName + " Resource Manager";
               _information.Description = "Resource Management Tool";
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
       public string UniqueID { get { return "{BC5CF1A6-F610-44ce-9B43-119B0D943613}"; } }
       #endregion
   }
   
}
