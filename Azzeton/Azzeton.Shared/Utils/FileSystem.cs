using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
namespace Azzeton.Shared
{
    public class FileSystemLogger
    {
        private static void CompressPeviousLog(string path)
        {
            try
            {
                string _name = path + "\\" + string.Format(CultureInfo.InvariantCulture, "{0:ddMMyyyy}.log", DateTime.Now.AddDays(-1));
                if (File.Exists(_name))
                {
                    Util.Compressor.Compress(_name, _name + ".zip");
                    File.Delete(_name);
                }
            }
            catch { }
        }
        public static void WriteLog(MethodBase source, Exception ex, DateTime datetime)
        {
            try
            {
                string root_path;
                if(ProductSettings.DataSource!="")
                    root_path = Path.Combine(ProductSettings.DataSource, "Logs");
                else
                    root_path= Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location.Replace(".", "_"));
                string file_path = Path.Combine(root_path, "Logs");
                if (!Directory.Exists(root_path)) Directory.CreateDirectory(root_path);
                CompressPeviousLog(file_path);
                string _name = file_path + "\\" + string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0:ddMMyyyy}.log", DateTime.Now);
                WriteHeader(_name);
                using (StreamWriter _writer = new StreamWriter(_name, true))
                {
                    _writer.WriteLine("| TIME              | {0:HH:mm:ss}", datetime);
                    _writer.WriteLine("| OBJECT SOURCE     | {0}", source.ReflectedType.Name);
                    _writer.WriteLine("| FUNCTION SOURCE   | {0}", source.Name);
                    _writer.WriteLine("| EXCEPTION SOURCE  | {0}", ex.Source);
                    _writer.WriteLine("| EXCEPTION MESSAGE | {0}", ex.Message);
                    _writer.WriteLine("+-------------------+----------------------------------------------------------------------------------------------------------------+");
                    _writer.Close();
                    _writer.Dispose();
                }
            }
            catch { }
        }
        public static string[] GetLogFiles()
        {
            try
            {
                string root_path = System.Reflection.Assembly.GetExecutingAssembly().Location;
                if (Directory.Exists(root_path))
                    return Directory.GetFiles(root_path, "*.log");
            }
            catch { }
            return new string[] { };
        }
        private string ReadFile(string filename)
        {
            StringBuilder builder = new StringBuilder();
            using (StreamReader reader = new StreamReader(filename))
            {
                int i = 1;
                while (reader.Peek() != -1)
                {
                    if (i % 2 == 0)
                        builder.Append(reader.ReadLine());
                }
                reader.Close();
            }
            return builder.ToString();
        }
        private static void WriteHeader(string name)
        {
            try
            {
                if (!File.Exists(name))
                {
                    using (StreamWriter _writer = new StreamWriter(name, true))
                    {
                        _writer.WriteLine("+------------------------------------------------------------------------------------------------------------------------------------+");
                        _writer.WriteLine("|                                               Azzeton ERROR LOG ({0:dd/MM/yyyy})                                                 |", DateTime.Now);
                        _writer.WriteLine("+-------------------+----------------------------------------------------------------------------------------------------------------+");
                        _writer.WriteLine("|   ITEM            | VALUE                                                                                                          |");
                        _writer.WriteLine("+-------------------+----------------------------------------------------------------------------------------------------------------+");
                        _writer.Flush();
                        _writer.Dispose();
                    }
                }
            }
            catch { }
        }
        private static string FitString(string @string, int length)
        {
            try
            {
                string _return = @string;
                if (@string.Length > length)
                    _return = string.Format(System.Globalization.CultureInfo.InvariantCulture,"{0}...", @string.Substring(0, length - 3));
                else if (@string.Length < length)
                    _return = @string.PadRight((length - @string.Length) + (@string.Length <= 10 ? 5 : (@string.Length >= 20 ? 15 : 10)), '\0');
                return _return.PadRight(5, '\0');
            }
            catch { }
            return "";
        }
    }
    public class FileSystem
    {
        public static bool CancelProcess { get; set; }
        public static event EventHandler DirectoryCopyStatusChanged;
        public static string GetTempFilename()
        {
            return Path.GetTempPath() + System.Guid.NewGuid();
        }
        public static string ValidateFolderName(string name)
        {
            char[] _invalids = System.IO.Path.GetInvalidPathChars();
            for (int i = _invalids.GetLowerBound(0); i < _invalids.GetUpperBound(0); i++)
                name = name.Replace(_invalids[i].ToString(), "");
            return name;
        }
        public static string ValidateFileName(string name)
        {
            char[] _invalids = System.IO.Path.GetInvalidFileNameChars();
            for (int i = _invalids.GetLowerBound(0); i < _invalids.GetUpperBound(0); i++)
                name = name.Replace(_invalids[i], Convert.ToChar(""));
            return name;
        }
        public static string CreateFolder(string foldername)
        {
            try
            {
                Directory.CreateDirectory(foldername);
            }
            catch (Exception ex) { FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now); }
            return foldername;
        }
        public static void DeleteFolder(string foldername)
        {
            try { Directory.Delete(foldername, true); }
            catch (Exception ex) { FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now); }
        }
        public static void CopyDirectory(string source, string destination)
        {
            String[] Files;

            if (destination[destination.Length - 1] != Path.DirectorySeparatorChar)
                destination += Path.DirectorySeparatorChar;
            if (!Directory.Exists(destination))
            {
                if (DirectoryCopyStatusChanged != null)
                    DirectoryCopyStatusChanged(0, new StatusEventArgs(0, string.Format(System.Globalization.CultureInfo.InvariantCulture,"Creating Directory {0}", Path.GetFileName(destination)), 0));
                Directory.CreateDirectory(destination);
            }
            Files = Directory.GetFileSystemEntries(source);
            int i = 0;
            foreach (string Element in Files)
            {
                i++;
                if (Directory.Exists(Element))
                    CopyDirectory(Element, destination + Path.GetFileName(Element));
                else
                {
                    File.Copy(Element, destination + Path.GetFileName(Element), true);
                    if (DirectoryCopyStatusChanged != null)
                        DirectoryCopyStatusChanged(i, new StatusEventArgs(0, string.Format(System.Globalization.CultureInfo.InvariantCulture,"Copied {0}", Element), Files.Length));
                }
            }
        }
        public static void DeleteFile(string filename)
        {
            try
            {
                File.Delete(filename);
            }
            catch { }
        }
        public static string GetFilename(Form owner)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "All Files|*.*;";
                //dlg.Filter = "Images|*.jpg;*.png;*.tif;*.tiff;*.bmp;*.emf;*.wmf;*.gif";

                if (dlg.ShowDialog(owner) == DialogResult.OK)
                    return dlg.FileName;
                else
                    return null;
            }
        }
        public static string GetSaveFilename(Form owner)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "TIFF Images|*.tif";
                if (dlg.ShowDialog(owner) == DialogResult.OK)
                    return dlg.FileName;
                else
                    return null;
            }
        }
        public static string GetSaveFilename(Form owner, string filter)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0} Files|*{1}", filter.ToUpperInvariant().Replace(".", ""), filter) ;
                if (dlg.ShowDialog(owner) == DialogResult.OK)
                    return dlg.FileName;
                else
                    return null;
            }
        }
        public static string GetSaveFilename(Form owner,FileSaveFilterType filtertype)
        {
            string _filter = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0} Files |*.{0}",filtertype.ToString());

            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = _filter;
                if (dlg.ShowDialog(owner) == DialogResult.OK)
                    return dlg.FileName;
                else
                    return null;
            }
        }
        public static string GetExtension(string path)
        {
            return System.IO.Path.GetExtension(path);
        }
        public static long GetFolderSize(string path)
        {
            long size = 0;
            DirectoryInfo _directory = new DirectoryInfo(Path.GetDirectoryName(path));
            foreach (FileInfo file in _directory.GetFiles("*.*", SearchOption.AllDirectories))
                size += file.Length;
            return size;
        }
    }
    public class FileSearcher
    {
        public static void ReplaceInFile( string filePath, string searchText, string replaceText )
        {
            StreamReader reader = new StreamReader( filePath );
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace( content, searchText, replaceText );

            StreamWriter writer = new StreamWriter( filePath );
            writer.Write( content );
            writer.Close();
        }
        private static List<string> SearchDirectory(string directory,string searchpattern)
        {
            List<string> _files = new List<string>();
            try
            {
                foreach (string _directory in Directory.GetDirectories(directory))
                {
                    foreach (string file in Directory.GetFiles(_directory, searchpattern, SearchOption.TopDirectoryOnly))
                    {
                        _files.Add(file);
                    }
                    SearchDirectory(_directory, searchpattern);
                }
            }
            catch { }
            return _files;
        }
        public static void Replace(string find, string replace, string directory,string searchpattern)
        {
            foreach (string file in SearchDirectory(directory, searchpattern))
                ReplaceInFile(file, find, replace);
        }
    }
    public enum FileSaveFilterType
    {
        Txt,
        Csv,
        Html,
        Tif,
    }
}
