using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Azzeton.Shared;
using ComponentFactory.Krypton.Toolkit;

namespace Azzeton.Components
{
    //[Designer(typeof(MoverDesigner))]
    public partial class Mover : UserControl
    {
        public Mover()
        {
            InitializeComponent();
        }
        private KryptonListBox _left_list;
        private KryptonListBox _right_list;
        [Browsable(true)]
        public KryptonListBox LeftList
        {
            get { return _left_list; }
            set { _left_list = value; }
        }
        [Browsable(true)]
        public KryptonListBox RightList
        {
            get { return _right_list; }
            set { _right_list = value; }
        }

        private void _btn_move_selected_right_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList _remove = new System.Collections.ArrayList();
            try
            {
                for (int i = 0; i < _left_list.Items.Count; i++)
                {
                    if (_left_list.SelectedItems.Contains(_left_list.Items[i]))
                    {
                        _right_list.Items.Add(_left_list.Items[i]);
                        _remove.Add(_left_list.Items[i]);
                    }
                }
                for (int i = 0; i < _remove.Count; i++)
                    _left_list.Items.Remove(_remove[i]);
            }
            catch (Exception ex){FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now);}
        }
        private void _btn_move_all_right_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object item in _left_list.Items)
                    _right_list.Items.Add(item);
                _left_list.Items.Clear();
            }
            catch (Exception ex){FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now);}
        }
        private void _btn_move_selected_left_Click(object sender, EventArgs e)
        {
            System.Collections.ArrayList _remove = new System.Collections.ArrayList();
            try
            {
                for (int i = 0; i < _right_list.Items.Count; i++)
                {
                    if (_right_list.SelectedItems.Contains(_right_list.Items[i]))
                    {
                        _left_list.Items.Add(_right_list.Items[i]);
                        _remove.Add(_right_list.Items[i]);
                    }
                }
                for (int i = 0; i < _remove.Count; i++)
                    _right_list.Items.Remove(_remove[i]);
            }
            catch (Exception ex){FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now);}
        }
        private void _btn_move_all_left_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object item in _right_list.Items)
                    _left_list.Items.Add(item);
                _right_list.Items.Clear();
            }
            catch (Exception ex){FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now);}
        }
        public void MoveAllLeft()
        {
            _btn_move_all_left.PerformClick();
        }
        public void MoveAllRight()
        {
            _btn_move_all_right.PerformClick();
        }
    }
}
