using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Collections;
using System.Collections.ObjectModel;
using Azzeton.Shared;
namespace Azzeton.Components
{
    public partial class ViewSwitch : UserControl
    {
        private ListView _listview;
        private SwitchView _view = SwitchView.Detail;
        private bool _has_setup  = false;

        public enum SwitchView
        {
            Detail,
            Icon
        }
        public ListView ListView
        {
            get { return _listview; }
            set 
            { 
                _listview = value;
                this._view = _listview.View == View.Details ? SwitchView.Detail : SwitchView.Icon;
            }
        }
        public SwitchView ShowView
        {
            get {return _view; }
            set 
            {
                _view = value;
                switch (_view)
                {
                    case Azzeton.Components.ViewSwitch.SwitchView.Icon:
                        _mnu_icon_Click(null, null);
                        break;
                    case Azzeton.Components.ViewSwitch.SwitchView.Detail:
                        _mnu_detail_Click(null, null);
                        break;
                }
            }
        }
        public ViewSwitch()
        {
            InitializeComponent();
            _mnu_detail.Click += new EventHandler(_mnu_detail_Click);
            _mnu_icon.Click += new EventHandler(_mnu_icon_Click);
            _mnu_group.Click += new EventHandler(_mnu_group_Click);
        }

        private void _mnu_group_Click(object sender, EventArgs e)
        {
            //_mnu_group.Checked = !_mnu_group.Checked;
        }
        private void _mnu_icon_Click(object sender, EventArgs e)
        {
            Reset();
            _mnu_icon.Checked = true;
            _view = Azzeton.Components.ViewSwitch.SwitchView.Icon;
            _listview.View = View.LargeIcon;
        }
        private void _mnu_detail_Click(object sender, EventArgs e)
        {
            Reset();
            _mnu_detail.Checked = true;
            _view = Azzeton.Components.ViewSwitch.SwitchView.Detail;
            _listview.View = View.Details;
        }
        private void _ctm_switch_Opening(object sender, CancelEventArgs e)
        {
            SetupGroupByMenus();
        }
        
        private void Reset()
        {
            _mnu_icon.Checked = false;
            _mnu_detail.Checked = false;
        }
        private void ResetGroupBy()
        {
            _listview.Groups.Clear();
            foreach (KryptonContextMenuItemBase item in _mnu_items_2.Items)
            {
                try
                {
                    KryptonContextMenuItem _item = item as KryptonContextMenuItem;
                    if(_item!=null)
                        _item.Checked = false;
                }
                catch (Exception ex) { FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now); }
            }
        }
        private void SetupGroupByMenus()
        {
            if (!_has_setup)
            {
                for (int i = 0; i < _listview.Columns.Count; i++)
                    _mnu_items_2.Items.Add(new KryptonContextMenuItem(_listview.Columns[i].Text, GroupBy));
                _mnu_items_2.Items.Add(new KryptonContextMenuSeparator());
                KryptonContextMenuItem _dont = new KryptonContextMenuItem("Dont Group",GroupBy);
                _dont.Tag = "oliversaysdontgroup";
                _dont.Checked = true;
                _mnu_items_2.Items.Add(_dont);
                _has_setup = true;
            }
        }

        private void GroupBy(object sender, EventArgs e)
        {
            try
            {
                ResetGroupBy();
                KryptonContextMenuItem _item = (KryptonContextMenuItem)sender;
                _item.Checked = true;
                if (_item.Tag != null)
                {
                    if (_item.Tag.ToString() == "oliversaysdontgroup")
                    {

                        //for (int k = 0; k < _listview.Items.Count; k++)
                        //{
                        //    _listview.Items[k].Group = null;
                        //}
                        return;
                    }
                }

                int _col_index = 0;
                for (int i = 0; i < _listview.Columns.Count; i++)
                {
                    if (_listview.Columns[i].Text.ToLower(System.Globalization.CultureInfo.InvariantCulture) == _item.Text.ToLower(System.Globalization.CultureInfo.InvariantCulture))
                    {
                        _col_index = i;
                        Hashtable _hash = new Hashtable();
                        for (int j = 0; j < _listview.Items.Count; j++)
                            if (!_hash.Contains(_listview.Items[j].SubItems[i].Text))
                                _hash.Add(_listview.Items[j].SubItems[i].Text, _listview.Items[j].SubItems[_col_index].Text);

                        foreach (Object value in _hash.Values)
                            _listview.Groups.Add(value.ToString(), value.ToString());

                        break;
                    }
                }
                for (int k = 0; k < _listview.Items.Count; k++)
                {
                    _listview.Items[k].Group = _listview.Groups[_listview.Items[k].SubItems[_col_index].Text];
                }
            }
            catch
            { 
                /*error - reset and check "Dont Group"*/
                ResetGroupBy();
                KryptonContextMenuItem _mnu = _mnu_items_2.Items[_mnu_items_2.Items.Count - 1] as KryptonContextMenuItem;
                _mnu.Checked = true;
            }
        }

    }
}
