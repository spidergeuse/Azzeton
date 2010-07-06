using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
namespace Util
{
    /// <summary>
    /// CSV Utitlity
    /// </summary>
    public class CSV
    {
        /// <summary>
        /// Writes the content of a table as CSV
        /// </summary>
        /// <param name="table">Source table</param>
        /// <param name="location">destination filename</param>
        public static void WriteCSV(DataTable table, string location)
        {
            using (StreamWriter _writer = new StreamWriter(location, false))
            {
                string _comma = "";
                foreach (DataRow row in table.Rows)
                {
                    StringBuilder _builder = new StringBuilder();
                    foreach (DataColumn col in table.Columns)
                    {

                        _builder.Append(_comma);
                        _builder.Append(row[col]);
                        _comma = ",";
                    }
                    _writer.WriteLine(_builder.ToString());
                    _comma = "";
                }
                _writer.Close();
            }
        }
        /// <summary>
        /// Writes the contents of a listview as CSV
        /// </summary>
        /// <param name="listview">source listview</param>
        /// <param name="location">destination filename</param>
        public static void WriteCSV(ListView listview, string location)
        {
            using (StreamWriter _writer = new StreamWriter(location, false))
            {
                string _comma = "";
                foreach (ListViewItem item in listview.Items)
                {
                    StringBuilder _builder = new StringBuilder();
                    foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                    {

                        _builder.Append(_comma);
                        _builder.Append(subitem.Text);
                        _comma = ",";
                    }
                    _writer.WriteLine(_builder.ToString());
                    _comma = "";
                }
                _writer.Close();
            }
        }
        /// <summary>
        /// Writes the contents of a collection as CSV
        /// </summary>
        /// <param name="strings">Collection of string collections</param>
        /// <param name="location">destination filename</param>
        public static void WriteCSV(ICollection<ICollection<string>> strings, string location)
        {
            using (StreamWriter _writer = new StreamWriter(location, false))
            {
                string _comma = "";
                foreach (List<string> coll in strings)
                {
                    StringBuilder _builder = new StringBuilder();
                    foreach (string item in coll)
                    {

                        _builder.Append(_comma);
                        _builder.Append(item);
                        _comma = ",";
                    }
                    _writer.WriteLine(_builder.ToString());
                    _comma = "";
                }
                _writer.Close();
            }
        }
        /// <summary>
        /// Writes the contents of a collection as CSV
        /// </summary>
        /// <param name="strings">Collection of strings</param>
        /// <param name="location">destination filename</param>
        public static void WriteCSV(ICollection<string> strings, string location)
        {
            ICollection<ICollection<string>> _strings =(ICollection<ICollection<string>>) new List<List<string>>();
            _strings.Add(strings);
            WriteCSV(_strings,location);
        }
    }
}
