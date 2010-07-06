using System.Collections;
using System.Windows.Forms;
using System;
using System.Globalization;

namespace Azzeton.Shared
{
    /// <summary>
    /// This class is an implementation of the 'IComparer' interface.
    /// </summary>
    public class ListViewColumnSorter : IComparer
    {
        /// <summary>
        /// Specifies the column to be sorted
        /// </summary>
        private int ColumnToSort;
        /// <summary>
        /// Specifies the order in which to sort (i.e. 'Ascending').
        /// </summary>
        private SortOrder OrderOfSort;
        /// <summary>
        /// Case insensitive comparer object
        /// </summary>
        private CaseInsensitiveComparer ObjectCompare;
        /// <summary>
        /// Class constructor.  Initializes various elements
        /// </summary>
        public ListViewColumnSorter()
        {
            // Initialize the column to '0'
            ColumnToSort = 0;

            // Initialize the sort order to 'none'
            OrderOfSort = SortOrder.None;

            // Initialize the CaseInsensitiveComparer object
            ObjectCompare = new CaseInsensitiveComparer();
        }
        /// <summary>
        /// This method is inherited from the IComparer interface.  It compares the two objects passed using a case insensitive comparison.
        /// </summary>
        /// <param name="x">First object to be compared</param>
        /// <param name="y">Second object to be compared</param>
        /// <returns>The result of the comparison. "0" if equal, negative if 'x' is less than 'y' and positive if 'x' is greater than 'y'</returns>
        public int Compare(object x, object y)
        {
            try
            {
                int compareResult;
                ListViewItem listviewX, listviewY;

                // Cast the objects to be compared to ListViewItem objects
                listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;

                 //Compare the two items
                object j = null;
                if (j ==null)
                    compareResult = DateTime.Compare(Convert.ToDateTime(listviewX.SubItems[ColumnToSort].Tag, CultureInfo.CurrentUICulture), Convert.ToDateTime(listviewY.SubItems[ColumnToSort].Tag, CultureInfo.CurrentUICulture));
                else
                    compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
                 //Calculate correct return value based on object comparison
                if (OrderOfSort == SortOrder.Ascending)
                {
                    // Ascending sort is selected, return normal result of compare operation
                    return compareResult;
                }
                else if (OrderOfSort == SortOrder.Descending)
                {
                    // Descending sort is selected, return negative result of compare operation
                    return (-compareResult);
                }
                else
                {
                    // Return '0' to indicate they are equal
                    return 0;
                }
            }
            catch{ }
            return 0;
        }
        /// <summary>
        /// Gets or sets the number of the column to which to apply the sorting operation (Defaults to '0').
        /// </summary>
        public int SortColumn
        {
            set
            {
                ColumnToSort = value;
            }
            get
            {
                return ColumnToSort;
            }
        }
        /// <summary>
        /// Gets or sets the order of sorting to apply (for example, 'Ascending' or 'Descending').
        /// </summary>
        public SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }
        public ListView ListView { get; set; }

    }
    public class ListViewSortManager
    {
        private void _staticlistview_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView _listview = sender as ListView;
            ListViewColumnSorter _sorter = _listview.Tag as ListViewColumnSorter;


            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == _sorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (_sorter.Order == System.Windows.Forms.SortOrder.Ascending)
                    _sorter.Order = System.Windows.Forms.SortOrder.Descending;
                else
                    _sorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                _sorter.SortColumn = e.Column;
                _sorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            _listview.Sort();
            //this.listView1.Sort();
        }
        public void SetupListviewSorter(ListView listview)
        {
            ListViewColumnSorter _sorter = new ListViewColumnSorter();
            listview.ListViewItemSorter = _sorter;
            listview.Tag = _sorter;
            listview.ColumnClick += new ColumnClickEventHandler(_staticlistview_ColumnClick);
        }
    }
}