namespace Azzeton.Components
{
    public partial  class Mover
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
            this._btn_move_all_left = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._btn_move_selected_left = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._btn_move_all_right = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._btn_move_selected_right = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // _btn_move_all_left
            // 
            this._btn_move_all_left.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_move_all_left.Dock = System.Windows.Forms.DockStyle.Top;
            this._btn_move_all_left.Location = new System.Drawing.Point(0, 78);
            this._btn_move_all_left.Name = "_btn_move_all_left";
            this._btn_move_all_left.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_move_all_left.Size = new System.Drawing.Size(33, 26);
            this._btn_move_all_left.TabIndex = 42;
            this._btn_move_all_left.Text = "<<";
            this._btn_move_all_left.Values.ExtraText = "";
            this._btn_move_all_left.Values.Image = null;
            this._btn_move_all_left.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_move_all_left.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_move_all_left.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_move_all_left.Values.Text = "<<";
            this._btn_move_all_left.Click += new System.EventHandler(this._btn_move_all_left_Click);
            // 
            // _btn_move_selected_left
            // 
            this._btn_move_selected_left.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_move_selected_left.Dock = System.Windows.Forms.DockStyle.Top;
            this._btn_move_selected_left.Location = new System.Drawing.Point(0, 52);
            this._btn_move_selected_left.Name = "_btn_move_selected_left";
            this._btn_move_selected_left.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_move_selected_left.Size = new System.Drawing.Size(33, 26);
            this._btn_move_selected_left.TabIndex = 41;
            this._btn_move_selected_left.Text = "<";
            this._btn_move_selected_left.Values.ExtraText = "";
            this._btn_move_selected_left.Values.Image = null;
            this._btn_move_selected_left.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_move_selected_left.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_move_selected_left.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_move_selected_left.Values.Text = "<";
            this._btn_move_selected_left.Click += new System.EventHandler(this._btn_move_selected_left_Click);
            // 
            // _btn_move_all_right
            // 
            this._btn_move_all_right.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_move_all_right.Dock = System.Windows.Forms.DockStyle.Top;
            this._btn_move_all_right.Location = new System.Drawing.Point(0, 26);
            this._btn_move_all_right.Name = "_btn_move_all_right";
            this._btn_move_all_right.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_move_all_right.Size = new System.Drawing.Size(33, 26);
            this._btn_move_all_right.TabIndex = 40;
            this._btn_move_all_right.Text = ">>";
            this._btn_move_all_right.Values.ExtraText = "";
            this._btn_move_all_right.Values.Image = null;
            this._btn_move_all_right.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_move_all_right.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_move_all_right.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_move_all_right.Values.Text = ">>";
            this._btn_move_all_right.Click += new System.EventHandler(this._btn_move_all_right_Click);
            // 
            // _btn_move_selected_right
            // 
            this._btn_move_selected_right.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_move_selected_right.Dock = System.Windows.Forms.DockStyle.Top;
            this._btn_move_selected_right.Location = new System.Drawing.Point(0, 0);
            this._btn_move_selected_right.Name = "_btn_move_selected_right";
            this._btn_move_selected_right.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_move_selected_right.Size = new System.Drawing.Size(33, 26);
            this._btn_move_selected_right.TabIndex = 39;
            this._btn_move_selected_right.Text = ">";
            this._btn_move_selected_right.Values.ExtraText = "";
            this._btn_move_selected_right.Values.Image = null;
            this._btn_move_selected_right.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_move_selected_right.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_move_selected_right.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_move_selected_right.Values.Text = ">";
            this._btn_move_selected_right.Click += new System.EventHandler(this._btn_move_selected_right_Click);
            // 
            // Mover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this._btn_move_all_left);
            this.Controls.Add(this._btn_move_selected_left);
            this.Controls.Add(this._btn_move_all_right);
            this.Controls.Add(this._btn_move_selected_right);
            this.Name = "Mover";
            this.Size = new System.Drawing.Size(33, 111);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_move_all_left;
        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_move_selected_left;
        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_move_all_right;
        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_move_selected_right;
    }
}
