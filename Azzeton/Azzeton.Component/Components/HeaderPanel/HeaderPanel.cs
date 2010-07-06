using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Azzeton.Shared;

namespace Azzeton.Components
{
    public partial class HeaderPanel : System.Windows.Forms.ContainerControl
    {
        #region -- Declarations --
        /*image*/
        private Icon _icon = null;

        /*text*/
        private string _title               = "Title";
        private string _subtitle            = "Sub Title";

        /*font*/
        private Font _titlefont             = new Font("Tahoma", 16, FontStyle.Regular, GraphicsUnit.Point);
        private Font _subtitlefont          = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);

        /*color*/
        private Color _colorone             = Color.FromArgb(107, 128, 186);
        private Color _colortwo             = Color.FromArgb(174, 187, 222);
        private Color _colorthree           = Color.FromArgb(131, 154, 209);
        private Color _colorfour            = Color.FromArgb(229, 234, 246);
        private LinearGradientMode _mode    = LinearGradientMode.Horizontal;

        private Color _colortop             = Color.FromArgb(1, 52, 205);
        private Color _colorbottom          = Color.FromArgb(50, 101, 254);
        private Color _colorleftright       = Color.FromArgb(116, 161, 255);
        private Color _colormiddle          = Color.FromArgb(210, 224, 255);

        private Style _style                = Style.Simple;
        private Theme _theme                = Theme.Green;
        /*style*/
        public enum Style
        {
            Simple,
            Elegant
        }
        public enum Theme
        {
            Green,
            Grey,
            Brown
        }

        #endregion

        #region -- Designer --
        public HeaderPanel()
        {
            ProductSettings.Initialize();
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.ContainerControl, true);
            SetStyle(ControlStyles.Selectable, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            this.ForeColor = Color.White;
            this.BackColor = Color.Green;

            this.Resize += new EventHandler(HeaderPanel_Resize);
        }
        public HeaderPanel(IContainer container)
        {
            ProductSettings.Initialize();
            container.Add(this);
            InitializeComponent();
            this.Resize += new EventHandler(HeaderPanel_Resize);

        }
        #endregion

        #region -- Properties --
        [Category("Custom"),Bindable(true),DefaultValue(typeof(Icon),"")]
        public Icon Icon
        {
            get { return _icon; }
            set { _icon = value; this.Invalidate(true); }
        }
        [Category("Custom"),Bindable(true),DefaultValue(typeof(String),"Title")]
        public string Title
        {
            get{return _title;}
            set { _title = value; this.Invalidate(true); }
        }
        [Category("Custom"),Bindable(true),DefaultValue(typeof(String),"Sub Title")]
        public string SubTitle
        {
            get{return _subtitle;}
            set { _subtitle = value; this.Invalidate(true); }
        }
        [Category("Custom"), Bindable(true), DefaultValue(typeof(Color), "0,255,0")]
        public Color GradientColorOne
        {
            get
            {
                if (_mode == LinearGradientMode.Vertical)
                    return _colorthree;
                else
                    return _colorone;
            }
            set
            {
                if (_mode == LinearGradientMode.Vertical)
                    _colorthree = value;
                else
                    _colorone = value;
            }
        }
        [Category("Custom"), Bindable(true), DefaultValue(typeof(Color), "192,255,192")]
        public Color GradientColorTwo
        {
            get
            {
                if (_mode == LinearGradientMode.Vertical)
                    return _colorfour;
                else
                    return _colortwo;
            }
            set
            {
                if (_mode == LinearGradientMode.Vertical)
                    _colorfour = value;
                else
                    _colortwo = value;
            }
        }
        [Category("Custom"), Bindable(true), DefaultValue(typeof(LinearGradientMode), "Horizontal")]
        public LinearGradientMode GradientMode
        {
            get { return _mode; }
            set { _mode = value; }
        }
        [Category("Custom"), Bindable(true), DefaultValue(typeof(HeaderPanel.Style), "0")]
        public Style DisplayStyle
        {
            get { return _style; }
            set { _style = value; }
        }
        [Category("Custom"), Bindable(true), DefaultValue(typeof(HeaderPanel.Style), "0")]
        public Theme DisplayTheme
        { 
            get
            {return this._theme;}
            set
            {
                switch (value)
                {
                    case Theme.Green:
                        this._theme = Theme.Green;
                        break;
                    default:
                        this._theme = Theme.Green;
                        break;
                }
            }
        }
        #endregion

        #region -- Methods --
        private void HeaderPanel_Resize(object sender, EventArgs e)
        {
            this.Invalidate(true);
        }
        #endregion

        #region -- Overrides --
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            try
            {
                /*setup graphics*/
                Graphics _graphics = e.Graphics;
                _graphics.SmoothingMode = SmoothingMode.HighQuality;
                _graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                Rectangle _linear_rectangle_cover = new Rectangle((this.Width / 2) - 2, 58, 4, 5);
                int _xposition = 0;

                /*draw icon*/
                if (_icon != null)
                {
                    _graphics.DrawIcon(_icon, new Rectangle(10, 15, 32, 32));
                    _xposition = 47;
                }

                /*draw titles*/
                _graphics.DrawString(_title, _titlefont, new SolidBrush(this.ForeColor), _xposition, 10);
                _graphics.DrawString(_subtitle, _subtitlefont, new SolidBrush(this.ForeColor), _xposition + 5, _graphics.MeasureString(_title, _titlefont).Height + (_graphics.MeasureString(_subtitle, _subtitlefont).Height / 2));
            }
            catch
            { }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics _graphics = e.Graphics;
            try
            {
                if (_style == HeaderPanel.Style.Elegant)
                {
                    Rectangle _linear_rectangle_one = new Rectangle(0, 58, (this.Width / 2), 5);
                    Rectangle _linear_rectangle_two = new Rectangle((this.Width / 2), 58, (this.Width / 2) + 3, 5);
                    Rectangle _linear_rectangle_both = new Rectangle(0, 58, this.Width, 5);
                    _graphics.FillRectangle(new LinearGradientBrush(e.ClipRectangle, _colortop, _colorbottom, LinearGradientMode.Vertical), e.ClipRectangle);
                    _graphics.FillRectangle(new LinearGradientBrush(_linear_rectangle_one, _colorleftright, _colormiddle, LinearGradientMode.Horizontal), _linear_rectangle_one);
                    _graphics.FillRectangle(new LinearGradientBrush(_linear_rectangle_two, _colormiddle, _colorleftright, LinearGradientMode.Horizontal), _linear_rectangle_two);
                }
                else
                {
                    if (_mode == LinearGradientMode.Vertical)
                    {
                        RectangleF _wrectangle = new RectangleF(0, 0, this.Width, 40);
                        _graphics.FillRectangle(new LinearGradientBrush(_wrectangle, _colorthree, _colorfour, _mode), _wrectangle);
                    }
                    else
                    {
                        RectangleF _hrectangle = new RectangleF(0, 0, this.Width, this.Height - 1);
                        e.Graphics.FillRectangle(new LinearGradientBrush(_hrectangle, _colorone, _colortwo, _mode), _hrectangle);
                    }
                }
            }
            catch (Exception ex) { FileSystemLogger.WriteLog(System.Reflection.MethodBase.GetCurrentMethod(), ex, DateTime.Now); }

        }
        #endregion

    }
}
