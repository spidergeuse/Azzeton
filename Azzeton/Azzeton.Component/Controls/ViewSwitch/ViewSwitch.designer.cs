namespace Azzeton.Components
{
    partial class ViewSwitch
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._btn_switch = new ComponentFactory.Krypton.Toolkit.KryptonDropButton();
            this._ctm_switch = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this._mnu_items_1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this._mnu_detail = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this._mnu_separator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this._mnu_icon = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this._mnu_seperator2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this._mnu_group = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this._mnu_items_2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.SuspendLayout();
            // 
            // _btn_switch
            // 
            this._btn_switch.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_switch.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btn_switch.KryptonContextMenu = this._ctm_switch;
            this._btn_switch.Location = new System.Drawing.Point(0, 0);
            this._btn_switch.Name = "_btn_switch";
            this._btn_switch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_switch.Size = new System.Drawing.Size(50, 25);
            this._btn_switch.TabIndex = 0;
            this._btn_switch.Text = "View";
            this._btn_switch.Values.ExtraText = "";
            this._btn_switch.Values.Image = null;
            this._btn_switch.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_switch.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_switch.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_switch.Values.Text = "View";
            // 
            // _ctm_switch
            // 
            this._ctm_switch.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading1,
            this._mnu_items_1});
            this._ctm_switch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._ctm_switch.Tag = null;
            this._ctm_switch.Opening += new System.ComponentModel.CancelEventHandler(this._ctm_switch_Opening);
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            this.kryptonContextMenuHeading1.ImageTransparentColor = System.Drawing.Color.Empty;
            this.kryptonContextMenuHeading1.Text = "View";
            // 
            // _mnu_items_1
            // 
            this._mnu_items_1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this._mnu_detail,
            this._mnu_separator1,
            this._mnu_icon,
            this._mnu_seperator2,
            this._mnu_group});
            // 
            // _mnu_detail
            // 
            this._mnu_detail.ImageTransparentColor = System.Drawing.Color.Empty;
            this._mnu_detail.Text = "Detail";
            // 
            // _mnu_icon
            // 
            this._mnu_icon.ImageTransparentColor = System.Drawing.Color.Empty;
            this._mnu_icon.Text = "Icon";
            // 
            // _mnu_group
            // 
            this._mnu_group.ImageTransparentColor = System.Drawing.Color.Empty;
            this._mnu_group.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading2,
            this._mnu_items_2});
            this._mnu_group.Text = "Group";
            // 
            // kryptonContextMenuHeading2
            // 
            this.kryptonContextMenuHeading2.ExtraText = "";
            this.kryptonContextMenuHeading2.ImageTransparentColor = System.Drawing.Color.Empty;
            this.kryptonContextMenuHeading2.Text = "Group By";
            // 
            // ViewSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._btn_switch);
            this.Name = "ViewSwitch";
            this.Size = new System.Drawing.Size(50, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDropButton _btn_switch;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu _ctm_switch;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems _mnu_items_1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem _mnu_detail;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator _mnu_separator1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem _mnu_icon;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator _mnu_seperator2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem _mnu_group;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems _mnu_items_2;
    }
}
