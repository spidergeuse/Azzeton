namespace Azzeton.Components
{
    partial class AzzetonMessageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._btn_no = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._btn_yes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._btn_cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._lbl_message = new System.Windows.Forms.Label();
            this._pan_yes_no_cancel = new System.Windows.Forms.Panel();
            this._pan_yes_no = new System.Windows.Forms.Panel();
            this._btn_no_ = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._btn_yes_ = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._pan_ok = new System.Windows.Forms.Panel();
            this._btn_ok = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this._chk_dont_show = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.etchedLine1 = new Azzeton.Components.EtchedLine();
            this.panel2 = new System.Windows.Forms.Panel();
            this._web_browser = new System.Windows.Forms.WebBrowser();
            this._hdp_header = new Azzeton.Components.HeaderPanel(this.components);
            this._pan_yes_no_cancel.SuspendLayout();
            this._pan_yes_no.SuspendLayout();
            this._pan_ok.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btn_no
            // 
            this._btn_no.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_no.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_no.Location = new System.Drawing.Point(174, 7);
            this._btn_no.Name = "_btn_no";
            this._btn_no.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_no.Size = new System.Drawing.Size(90, 29);
            this._btn_no.TabIndex = 1;
            this._btn_no.Text = "No";
            this._btn_no.Values.ExtraText = "";
            this._btn_no.Values.Image = null;
            this._btn_no.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_no.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_no.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_no.Values.Text = "No";
            this._btn_no.Click += new System.EventHandler(this._btn_no_Click);
            // 
            // _btn_yes
            // 
            this._btn_yes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_yes.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_yes.Location = new System.Drawing.Point(78, 7);
            this._btn_yes.Name = "_btn_yes";
            this._btn_yes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_yes.Size = new System.Drawing.Size(90, 29);
            this._btn_yes.TabIndex = 2;
            this._btn_yes.Text = "Yes";
            this._btn_yes.Values.ExtraText = "";
            this._btn_yes.Values.Image = null;
            this._btn_yes.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_yes.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_yes.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_yes.Values.Text = "Yes";
            this._btn_yes.Click += new System.EventHandler(this._btn_yes_Click);
            // 
            // _btn_cancel
            // 
            this._btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_cancel.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_cancel.Location = new System.Drawing.Point(270, 7);
            this._btn_cancel.Name = "_btn_cancel";
            this._btn_cancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_cancel.Size = new System.Drawing.Size(90, 29);
            this._btn_cancel.TabIndex = 3;
            this._btn_cancel.Text = "Cancel";
            this._btn_cancel.Values.ExtraText = "";
            this._btn_cancel.Values.Image = null;
            this._btn_cancel.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_cancel.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_cancel.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_cancel.Values.Text = "Cancel";
            this._btn_cancel.Click += new System.EventHandler(this._btn_cancel_Click);
            // 
            // _lbl_message
            // 
            this._lbl_message.AutoEllipsis = true;
            this._lbl_message.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lbl_message.ForeColor = System.Drawing.Color.Navy;
            this._lbl_message.Location = new System.Drawing.Point(9, 14);
            this._lbl_message.Name = "_lbl_message";
            this._lbl_message.Size = new System.Drawing.Size(359, 127);
            this._lbl_message.TabIndex = 6;
            this._lbl_message.Text = "Message";
            // 
            // _pan_yes_no_cancel
            // 
            this._pan_yes_no_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._pan_yes_no_cancel.Controls.Add(this._btn_cancel);
            this._pan_yes_no_cancel.Controls.Add(this._btn_yes);
            this._pan_yes_no_cancel.Controls.Add(this._btn_no);
            this._pan_yes_no_cancel.Location = new System.Drawing.Point(9, 32);
            this._pan_yes_no_cancel.Name = "_pan_yes_no_cancel";
            this._pan_yes_no_cancel.Size = new System.Drawing.Size(367, 38);
            this._pan_yes_no_cancel.TabIndex = 12;
            // 
            // _pan_yes_no
            // 
            this._pan_yes_no.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._pan_yes_no.Controls.Add(this._btn_no_);
            this._pan_yes_no.Controls.Add(this._btn_yes_);
            this._pan_yes_no.Location = new System.Drawing.Point(9, 32);
            this._pan_yes_no.Name = "_pan_yes_no";
            this._pan_yes_no.Size = new System.Drawing.Size(367, 38);
            this._pan_yes_no.TabIndex = 13;
            // 
            // _btn_no_
            // 
            this._btn_no_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_no_.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_no_.Location = new System.Drawing.Point(270, 7);
            this._btn_no_.Name = "_btn_no_";
            this._btn_no_.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_no_.Size = new System.Drawing.Size(90, 29);
            this._btn_no_.TabIndex = 3;
            this._btn_no_.Text = "No";
            this._btn_no_.Values.ExtraText = "";
            this._btn_no_.Values.Image = null;
            this._btn_no_.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_no_.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_no_.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_no_.Values.Text = "No";
            this._btn_no_.Click += new System.EventHandler(this._btn_no_Click);
            // 
            // _btn_yes_
            // 
            this._btn_yes_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_yes_.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_yes_.Location = new System.Drawing.Point(174, 7);
            this._btn_yes_.Name = "_btn_yes_";
            this._btn_yes_.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_yes_.Size = new System.Drawing.Size(90, 29);
            this._btn_yes_.TabIndex = 1;
            this._btn_yes_.Text = "Yes";
            this._btn_yes_.Values.ExtraText = "";
            this._btn_yes_.Values.Image = null;
            this._btn_yes_.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_yes_.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_yes_.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_yes_.Values.Text = "Yes";
            this._btn_yes_.Click += new System.EventHandler(this._btn_yes_Click);
            // 
            // _pan_ok
            // 
            this._pan_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._pan_ok.Controls.Add(this._btn_ok);
            this._pan_ok.Location = new System.Drawing.Point(9, 32);
            this._pan_ok.Name = "_pan_ok";
            this._pan_ok.Size = new System.Drawing.Size(367, 38);
            this._pan_ok.TabIndex = 14;
            // 
            // _btn_ok
            // 
            this._btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btn_ok.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Standalone;
            this._btn_ok.Location = new System.Drawing.Point(270, 7);
            this._btn_ok.Name = "_btn_ok";
            this._btn_ok.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._btn_ok.Size = new System.Drawing.Size(90, 29);
            this._btn_ok.TabIndex = 3;
            this._btn_ok.Text = "OK";
            this._btn_ok.Values.ExtraText = "";
            this._btn_ok.Values.Image = null;
            this._btn_ok.Values.ImageStates.ImageCheckedNormal = null;
            this._btn_ok.Values.ImageStates.ImageCheckedPressed = null;
            this._btn_ok.Values.ImageStates.ImageCheckedTracking = null;
            this._btn_ok.Values.Text = "OK";
            this._btn_ok.Click += new System.EventHandler(this._btn_ok_Click);
            // 
            // _chk_dont_show
            // 
            this._chk_dont_show.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.NormalControl;
            this._chk_dont_show.Location = new System.Drawing.Point(9, 6);
            this._chk_dont_show.Name = "_chk_dont_show";
            this._chk_dont_show.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this._chk_dont_show.Size = new System.Drawing.Size(192, 20);
            this._chk_dont_show.TabIndex = 15;
            this._chk_dont_show.Text = "Don\'t show this message again";
            this._chk_dont_show.Values.ExtraText = "";
            this._chk_dont_show.Values.Image = null;
            this._chk_dont_show.Values.Text = "Don\'t show this message again";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this._chk_dont_show);
            this.panel1.Controls.Add(this.etchedLine1);
            this.panel1.Controls.Add(this._pan_yes_no_cancel);
            this.panel1.Controls.Add(this._pan_ok);
            this.panel1.Controls.Add(this._pan_yes_no);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 76);
            this.panel1.TabIndex = 16;
            // 
            // etchedLine1
            // 
            this.etchedLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.etchedLine1.Location = new System.Drawing.Point(12, 24);
            this.etchedLine1.Name = "etchedLine1";
            this.etchedLine1.Size = new System.Drawing.Size(356, 10);
            this.etchedLine1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this._web_browser);
            this.panel2.Controls.Add(this._lbl_message);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 144);
            this.panel2.TabIndex = 17;
            // 
            // _web_browser
            // 
            this._web_browser.Location = new System.Drawing.Point(6, 6);
            this._web_browser.MinimumSize = new System.Drawing.Size(20, 20);
            this._web_browser.Name = "_web_browser";
            this._web_browser.ScrollBarsEnabled = false;
            this._web_browser.Size = new System.Drawing.Size(363, 132);
            this._web_browser.TabIndex = 8;
            this._web_browser.Visible = false;
            // 
            // _hdp_header
            // 
            this._hdp_header.BackColor = System.Drawing.Color.Khaki;
            this._hdp_header.DisplayTheme = Azzeton.Components.HeaderPanel.Theme.Green;
            this._hdp_header.Dock = System.Windows.Forms.DockStyle.Top;
            this._hdp_header.ForeColor = System.Drawing.Color.White;
            this._hdp_header.GradientColorOne = System.Drawing.Color.DarkGoldenrod;
            this._hdp_header.GradientColorTwo = System.Drawing.Color.Khaki;
            this._hdp_header.Location = new System.Drawing.Point(0, 0);
            this._hdp_header.Name = "_hdp_header";
            this._hdp_header.Size = new System.Drawing.Size(376, 52);
            this._hdp_header.SubTitle = "Inventory Control System";
            this._hdp_header.TabIndex = 11;
            this._hdp_header.Title = null;
            // 
            // AzzetonMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(376, 272);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._hdp_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 215);
            this.Name = "AzzetonMessageBox";
            this.Opacity = 0.9;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AzzetonMessageBox_Load);
            this._pan_yes_no_cancel.ResumeLayout(false);
            this._pan_yes_no.ResumeLayout(false);
            this._pan_ok.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_no;
        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_yes;
        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_cancel;
        private Azzeton.Components.EtchedLine etchedLine1;
        private System.Windows.Forms.Label _lbl_message;
        private Azzeton.Components.HeaderPanel _hdp_header;
        private System.Windows.Forms.Panel _pan_yes_no_cancel;
        private System.Windows.Forms.Panel _pan_yes_no;
        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_no_;
        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_yes_;
        private System.Windows.Forms.Panel _pan_ok;
        private ComponentFactory.Krypton.Toolkit.KryptonButton _btn_ok;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox _chk_dont_show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.WebBrowser _web_browser;
    }
}