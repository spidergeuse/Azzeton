using System;
using System.IO;
using System.Drawing;
using System.Collections;

using Azzeton.Shared;

namespace Azzeton.Resources 
{
   public class XStream : System.IDisposable,IXStream
   {
      #region -- private fields --
      private ArrayList    _xstreams    = new ArrayList();
      #endregion

      #region -- constructors --
      internal XStream(System.Reflection.Assembly target) {
         foreach(string resource in target.GetManifestResourceNames()) 
         {
            string ext = Path.GetExtension(resource).ToLower(System.Globalization.CultureInfo.InvariantCulture);;
            _xstreams.Add(new XStreamEx(resource, (Stream)target.GetManifestResourceStream(resource)));
         }
      }
      #endregion

      #region -- properties --
      public Stream this[string name, string ext] 
      {
         get {
             foreach (XStreamEx b in _xstreams)
                 if (b.Name == name.ToLower(System.Globalization.CultureInfo.InvariantCulture) && b.Ext == ext )   // Search case-insensitive
                     return b.Stream;

            return null;
         }
      }
      #endregion

      #region -- idisposable members --
      public void Dispose() {
         foreach(XStream bmx in _xstreams)
            bmx.Dispose();

         GC.SuppressFinalize(this);
      }
      #endregion

      private class XStreamEx : System.IDisposable 
      {
         #region -- private fields --
         private  string      _name    = string.Empty;
         private  string      _ext     = string.Empty;
         private  Stream      _stream  = null;
         #endregion

         #region -- constructors --
         public XStreamEx(string name, Stream stream) {
            string[] tokens = name.Split('.');

            // Pluck the simple name of the resource out of
            // the fully qualified string.  tokens[tokens.Length - 1]
            // is the file extension, also not needed.
            _name = tokens[tokens.Length - 2].ToLower(System.Globalization.CultureInfo.InvariantCulture);;
            _ext  = tokens[tokens.Length - 1].ToLower(System.Globalization.CultureInfo.InvariantCulture);;
            _stream = stream;
         }
         #endregion

         #region -- properties --
         public string Name {
            get {return _name;}
         }

         public string Ext
         {
             get {return _ext;}
         }
         public Stream Stream {
            get {return _stream;}
         }
         #endregion

         #region -- idisposable members --
         public void Dispose() {
            _stream.Dispose();
            _stream = null;
         }
         #endregion
      }
	}
}