using System;
using System.IO;
using System.IO.Compression;

namespace Util
{
    /// <summary>
    /// Compression and Decompression
    /// Uses GZip in .Net
    /// </summary>
    public class Compressor
    {
        /// <summary>
        /// Compress a file
        /// </summary>
        /// <param name="source">Source file</param>
        /// <param name="destination">destination filename</param>
        public static void Compress(string source, string destination)
        {
            /*
             * Open destination file stream
             * pass destination file to a GZip stream in Compress mode
             * open soure file
             * read content of source file and save save in GZip stream
             * free resources
             */
            byte[] _buffer;
            int _count = 0;

            try
            {
                using (FileStream _fs_destination = new FileStream(destination, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    using (GZipStream _gzip_stream = new GZipStream(_fs_destination, CompressionMode.Compress, true))
                    {
                        using (FileStream _fs_source = new FileStream(source, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            _buffer = new byte[_fs_source.Length];
                            _count = _fs_source.Read(_buffer, 0, _buffer.Length);
                            _fs_source.Close();
                            _gzip_stream.Write(_buffer, 0, _buffer.Length);
                            _gzip_stream.Close();
                        }
                    }
                   
                }
            }
            catch { }
        }
        /// <summary>
        /// Decompresses a compressed file
        /// </summary>
        /// <param name="source">source file</param>
        /// <param name="destination">destination filename</param>
        public static void Decompress(string source, string destination)
        {
            /*
             * Open source file stream
             * pass source file to a GZip stream in Compress mode
             * create destination file
             * read content of GZip stream and save save in GZip stream
             * free resources
             */
            const int _bufferSize = 4096;
            byte[] _buffer = new byte[_bufferSize];
            int _count = 0;

            try
            {
                using (FileStream _fs_source = new FileStream(source, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (GZipStream _gzip_stream = new GZipStream(_fs_source, CompressionMode.Decompress, true))
                    {
                        using (FileStream _fs_destination = new FileStream(destination, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            while (true)
                            {
                                _count = _gzip_stream.Read(_buffer, 0, _bufferSize);
                                if (_count != 0)
                                    _fs_destination.Write(_buffer, 0, _count);
                                if (_count != _bufferSize)
                                    break;
                            }
                            _fs_source.Close();
                            _gzip_stream.Close();
                        }
                    }
                }

            }
            catch { }
        }
    }
}