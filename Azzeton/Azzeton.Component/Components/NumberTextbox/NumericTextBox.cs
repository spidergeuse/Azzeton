using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Azzeton.Components
{
    /// <summary>
    /// Restricts the entry of characters to digits (including hex), the negative sign,
    /// the decimal point, and editing keystrokes (backspace).
    /// </summary>
    [ToolboxItem(true), Browsable(true)]
    public class NumericTextBox : KryptonMaskedTextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            
            NumberFormatInfo numberFormatInfo = CultureInfo.CurrentCulture.NumberFormat;
            string decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            string groupSeparator = numberFormatInfo.NumberGroupSeparator;
            string negativeSign = numberFormatInfo.NegativeSign;

            string keyInput = e.KeyChar.ToString();

            if (Char.IsDigit(e.KeyChar))
            {
                // Digits are OK
            }
            else if (keyInput.Equals(decimalSeparator) || keyInput.Equals(groupSeparator) || keyInput.Equals(negativeSign))
            {
                // Decimal separator is OK
                if (!AllowDecimals)
                    e.Handled = true;
            }
            else if (e.KeyChar == '\b')
            {
                // Backspace key is OK
            }
            else if ((ModifierKeys & (Keys.Control | Keys.Alt)) != 0)
            {
                // Let the edit control handle control and alt key combinations
                e.Handled = true;
            }
            else if (this.AllowSpace && e.KeyChar == ' ')
            {

            }
            else
            {
                // Consume this invalid key and beep
                e.Handled = true;
                //    MessageBeep();
            }
        }
        public int IntValue
        {
            get
            {
                return Int32.Parse(this.Text);
            }
        }
        public decimal DecimalValue
        {
            get
            {
                return Decimal.Parse(this.Text);
            }
        }
        public bool AllowSpace
        {
            get;
            set; }
        public bool AllowDecimals
        { get; set; }
        public MaskedTextBox MaskTextBox
        { get; set; }
    }
}
