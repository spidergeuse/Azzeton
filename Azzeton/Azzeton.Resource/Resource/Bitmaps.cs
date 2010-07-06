using System;
using System.IO;
using System.Drawing;
using System.Collections;

using Azzeton.Shared;

namespace Azzeton.Resources 
{
   public class Bitmaps : System.IDisposable,IBitmaps
   {
      #region -- private fields --
      private ArrayList    _bitmaps    = new ArrayList();
      #endregion

      #region -- constructors --
      internal Bitmaps(System.Reflection.Assembly target) {
         foreach(string resource in target.GetManifestResourceNames()) {
            string ext = Path.GetExtension(resource).ToLower(System.Globalization.CultureInfo.InvariantCulture);;

            if (ext == ".bmp" ||
                  ext == ".png" ||
                  ext == ".gif" ||
                  ext == ".jpg" ||
                  ext == ".ico" ||
                  ext == ".jpeg") 
               _bitmaps.Add(new BitmapEx(resource, (Bitmap)Bitmap.FromStream(target.GetManifestResourceStream(resource))));
         }
      }
      #endregion

      #region -- properties --
      public Bitmap this[string name] 
      {
         get {
            foreach (BitmapEx b in _bitmaps)
               if (b.Name == name.ToLower(System.Globalization.CultureInfo.InvariantCulture))   // Search case-insensitive
                  return b.Bitmap;

            return null;
         }
      }
       public Bitmap this[string name, Size size]
       {
           get { return new Bitmap(this[name], size); }
       }
       public Bitmap this[string name, int width, int height]
       {
           get { return new Bitmap(this[name], new Size(width,height)); }
       }
      #endregion

      #region -- idisposable members --
      public void Dispose() {
         foreach(BitmapEx bmx in _bitmaps)
            bmx.Dispose();

         GC.SuppressFinalize(this);
      }
      #endregion

      private class BitmapEx : System.IDisposable 
      {
         #region -- private fields --
         private  string      _name    = string.Empty;
         private  Bitmap      _bitmap  = null;
         #endregion

         #region -- constructors --
         public BitmapEx(string name, Bitmap bitmap) {
            string[] tokens = name.Split('.');

            // Pluck the simple name of the resource out of
            // the fully qualified string.  tokens[tokens.Length - 1]
            // is the file extension, also not needed.
            _name = tokens[tokens.Length - 2].ToLower(System.Globalization.CultureInfo.InvariantCulture);;
            _bitmap = bitmap;
         }
         #endregion

         #region -- properties --
         public string Name {
            get {return _name;}
         }

         public Bitmap Bitmap {
            get {return _bitmap;}
         }
         #endregion

         #region -- idisposable members --
         public void Dispose() {
            _bitmap.Dispose();
            _bitmap = null;
         }
         #endregion
      }
	}
}