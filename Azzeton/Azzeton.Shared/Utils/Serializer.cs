using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Azzeton.Shared
{
    public class Serializer
    {
        public  static byte[] Serialize<T>(T obj)
        {
            byte[] _data = null;
            try
            {
                using (MemoryStream _stream = new MemoryStream())
                {
                    BinaryFormatter _binary_formatter = new BinaryFormatter();
                    _binary_formatter.Serialize(_stream, obj);
                    _data = _stream.GetBuffer();
                    _stream.Close();
                }
            }
            catch{ }
            return _data;
        }
        public static T Deserialize<T>(byte[] data)
        {
            T obj = default(T);
            try
            {
                obj = Activator.CreateInstance<T>();
            }
            catch { }
            try
            {
                using (MemoryStream _stream = new MemoryStream(data))
                {
                    BinaryFormatter _binary_formatter = new BinaryFormatter();
                    obj = (T)_binary_formatter.Deserialize(_stream);
                    _stream.Close();
                }
            }
            catch{ }
            return obj;
        }
    }
    public class XMLSerializer
    {
        public static void SaveXML<T>( object @object,string filename)
        {
            using (FileStream _stream = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.Delete))
            {
                using (StreamWriter _writer = new StreamWriter(_stream))
                {
                    T _obj = Activator.CreateInstance<T>();
                    XmlSerializer _serializer = new XmlSerializer(_obj.GetType());
                    _serializer.Serialize(_writer, @object);
                    _writer.Close();
                }
            }
        }
        public static T ReadXML<T>(string filename)
        {
            try
            {
                using (FileStream _stream = new FileStream(filename, FileMode.Open, FileAccess.ReadWrite, FileShare.Delete))
                {
                    using (TextReader _reader = new StreamReader(_stream))
                    {
                        T _obj = Activator.CreateInstance<T>();
                        XmlSerializer _serializer = new XmlSerializer(_obj.GetType());
                        _obj = (T)_serializer.Deserialize(_reader);
                        _reader.Close();
                        return _obj;
                    }
                }
            }
            catch{ }
            return default(T);
        }
    }
}