using System;
using System.IO;
using System.Drawing;
using System.Reflection;
using System.Collections;

using Azzeton.Shared;

namespace Azzeton.Resources 
{
   public class Icons : System.IDisposable, IIcons
   {
      #region -- private fields --
      private  ArrayList      _icons   = new ArrayList();
      #endregion

      #region -- constructors --
      internal Icons(Assembly target) {
         foreach(string resource in target.GetManifestResourceNames())
            if (Path.GetExtension(resource).ToLower(System.Globalization.CultureInfo.InvariantCulture) == ".ico")
               _icons.Add(new IconEx(resource, new Icon(target.GetManifestResourceStream(resource))));
      }
      #endregion

      #region -- properties --
      public Icon this[string name] 
      {
         get 
         {
            foreach(IconEx ie in _icons)
               if (ie.Name == name.ToLower(System.Globalization.CultureInfo.InvariantCulture))   // Search case-insensitive
                  return ie.Icon;
            return null;
         }
      }
      public Icon this[string name, Size size]
      {
         
          get{ return new Icon(this[name],size);}
      }
      #endregion

      #region -- idisposable members --
      public void Dispose() {
         foreach(IconEx ie in _icons)
            ie.Dispose();

         GC.SuppressFinalize(this);
      }
      #endregion

      private class IconEx : System.IDisposable 
      {
         #region -- private fields --
         private  string      _name    = string.Empty;
         private  Icon        _icon    = null;
         #endregion

         #region -- constructors --
         public IconEx(string name, Icon icon) {
            string[] tokens = name.Split('.');

            // Pluck the simple name of the resource out of
            // the fully qualified string.  tokens[tokens.Length - 1]
            // is the file extension, also not needed.
            _name = tokens[tokens.Length - 2].ToLower(System.Globalization.CultureInfo.InvariantCulture);;
            _icon = icon;
         }
         #endregion

         #region -- properties --
         public string Name {
            get {return _name;}
         }

         public Icon Icon {
            get {return _icon;}
         }
         #endregion

         #region -- idisposable members --
         public void Dispose() {
            _icon.Dispose();
         }
         #endregion
      }
    }
}

