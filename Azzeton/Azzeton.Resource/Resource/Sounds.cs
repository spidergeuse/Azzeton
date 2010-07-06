using System;
using System.IO;
using System.Reflection;
using System.Collections;

using Azzeton.Shared;

namespace Azzeton.Resources 
{
   public class Sounds : System.IDisposable, ISounds
   {
      #region -- private fields --
      private  ArrayList   _sounds     = new ArrayList();
      #endregion

      #region -- constructors --
      internal Sounds(Assembly target) {
         foreach(string resource in target.GetManifestResourceNames()) 
            if (Path.GetExtension(resource).ToLower(System.Globalization.CultureInfo.InvariantCulture) == ".wav") 
               _sounds.Add(new Sound(resource, target.GetManifestResourceStream(resource)));
      }
      #endregion

      #region -- properties --
      public ISound this[string name] {
         get {
            foreach(ISound se in _sounds)
               if (se.Name == name.ToLower(System.Globalization.CultureInfo.InvariantCulture))   // Search case-insensitive
                  return se;

            return null;
         }
      }
      #endregion

      #region -- idisposable members --
      public void Dispose() 
      {
         foreach (Sound se in _sounds)
            se.Dispose();

         GC.SuppressFinalize(this);
      }
      #endregion
   }
   public class Sound : System.IDisposable, ISound 
   {
      [System.Runtime.InteropServices.DllImport("Winmm.dll")]
      private static extern bool PlaySound(byte[] data, IntPtr hMod, UInt32 dwFlags);
      private const UInt32 SND_ASYNC   = 1;
      private const UInt32 SND_MEMORY  = 4;

      #region -- private fields --
      private     string   _name    = string.Empty;
      private     byte[]   _data    = null;
      #endregion

      #region -- constructors --
      internal Sound(string name, System.IO.Stream stream) 
      {
         Int32    length = (Int32)stream.Length;
         string[] tokens = name.Split('.');

         // Pluck the simple name of the resource out of
         // the fully qualified string.  tokens[tokens.Length - 1]
         // is the file extension, also not needed.
         _name = tokens[tokens.Length - 2];

         _data = new byte[length];
         stream.Read(_data, 0, length);
      }
      #endregion

      #region -- properties --
      public string Name 
      {
         get {return _name;}
      }
      #endregion

      #region -- methodes --
      public void Play() 
      {
         PlaySound(_data, IntPtr.Zero, SND_ASYNC | SND_MEMORY);
      }
      #endregion

      #region -- idisposable members --
      public void Dispose() 
      {
         GC.SuppressFinalize(this);
      }
      #endregion
   }
}