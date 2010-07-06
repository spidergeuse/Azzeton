using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Util
{
    public class TXT
    {
        public static void WriteTXT(DataTable table, int column, string location)
        {
            using (StreamWriter _writer = new StreamWriter(location, false))
            {
                foreach (DataRow row in table.Rows)
                    _writer.WriteLine(row[column].ToString());
                _writer.Close();
            }
        }
        public static void WriteTXT(ListView listview, int column, string location)
        {
            using (StreamWriter _writer = new StreamWriter(location, false))
            {
                foreach (ListViewItem item in listview.Items)
                    _writer.WriteLine(item.SubItems[column].Text);
                _writer.Close();
            }
        }
        public static void WriteTXT(IList<string> strings, string location)
        {
            using (StreamWriter _writer = new StreamWriter(location, false))
            {
                foreach (string _string in strings)
                    _writer.WriteLine(_string);
                _writer.Close();
            }
        }
     }
}
