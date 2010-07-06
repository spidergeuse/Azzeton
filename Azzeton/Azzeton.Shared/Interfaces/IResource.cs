using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Drawing;
using System.IO;

namespace Azzeton.Shared
{
    public interface IResourceManager
    {
        IBitmaps Bitmaps { get; }
        IIcons Icons { get; }
        ISounds Sounds { get; }
        IXStream XStream { get; }
    }
    public interface IBitmaps
    {
        Bitmap this[string name] { get; }
        Bitmap this[string name, Size size] { get; }
        Bitmap this[string name, int width, int height] { get; }
    }
    public interface IXStream
    {
        Stream this[string name, string ext] { get; }
    }
    public interface IIcons
    {
        Icon this[string name] { get; }
        Icon this[string name, Size size] { get; }
    }
    public interface ISounds
    {
        ISound this[string name] { get; }
    }
    public interface ISound
    {
        string Name { get; }
        void Play();
    }
    public interface IResource
    {
        bool Exist(Collection<string> resource_names);
    }
}
