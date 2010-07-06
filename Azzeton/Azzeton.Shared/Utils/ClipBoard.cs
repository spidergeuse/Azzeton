using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace Util
{
    /// <summary>
    /// Clipboard operations helper
    /// </summary>
    public class ClipBoardHelper
    {
        /// <summary>
        /// Retrieves text content in Clipboard
        /// </summary>
        /// <returns></returns>
        public static string GetText()
        {
            IDataObject dataObj = Clipboard.GetDataObject();
            if (!dataObj.GetDataPresent(DataFormats.Text))
                return "";
            return dataObj.GetData(DataFormats.Text).ToString();
        }
        /// <summary>
        /// Copy item in a listview
        /// </summary>
        /// <param name="listview">Source listview</param>
        /// <param name="column">Index of column</param>
        public static void CopyColumText(ListView listview, int column)
        {
            try
            {
                StringBuilder _builder = new StringBuilder();
                foreach (ListViewItem item in listview.Items)
                    _builder.Append(item.SubItems[column].Text + "\n");
                Clipboard.SetText(_builder.ToString(), TextDataFormat.Text);
            }
            catch { }
        }
        /// <summary>
        /// Copies an entire listview as CSV
        /// </summary>
        /// <param name="listview">Source CSV</param>
        public static void CopyListViewAsCSV(ListView listview)
        {
            string _comma = "";
            StringBuilder _builder = new StringBuilder();
            foreach (ListViewItem item in listview.Items)
            {
                foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                {

                    _builder.Append(_comma);
                    _builder.Append(subitem.Text);
                    _comma = ",";
                }
                _comma = "";
                _builder.Append("\n");
            }
            Clipboard.SetText(_builder.ToString(),TextDataFormat.CommaSeparatedValue);
        }
    }   
}
