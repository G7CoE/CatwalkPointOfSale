using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace MyControls
{

    /// <summary>
    /// Extended Textbox Control used to display Currency
    /// </summary>
    [System.ComponentModel.DefaultBindingProperty("Value")]
    public partial class  CurrencyBox : StrBox
    {
        // member variable used to keep dollar value
        private Decimal _value = 0;

        public string _formatString = "C2";

        // constructor
        public CurrencyBox()
        {
            InitializeComponent();
            this.TextAlign = HorizontalAlignment.Right;
        }



        // default OnPaint
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);
        }


        /// <summary>
        /// Keypress handler used to restrict user input
        /// to numbers and control characters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrencyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers, decimals and control characters
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && this.Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && this.Text.Length < 1)
            {
                e.Handled = true;
            }
        }



        /// <summary>
        /// Update display to show decimal as currency
        /// whenver it is validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrencyBox_Validated(object sender, EventArgs e)
        {
            try
            {
                // format the value as currency
                Decimal dTmp = Convert.ToDecimal(this.Text);
                this.Text = dTmp.ToString(FormatString);
            }
            catch { }
        }



        /// <summary>
        /// Revert back to the display of numbers only
        /// whenever the user clicks in the box for
        /// editing purposes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrencyBox_Click(object sender, EventArgs e)
        {
            this.Text = _value.ToString();

            if (this.Text == "0")
                this.Clear();

            this.SelectionStart = this.Text.Length;
        }

        /// <summary>
        /// Update the dollar value each time the value is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrencyBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.Text.Length == 0)
                    _value = 0;

                _value = Convert.ToDecimal(this.Text);
            }
            catch { }
        }




        /// <summary>
        /// property to maintain value of control
        /// </summary>
        [Bindable (true)]  // เติมบรรทัดนี้ เพื่อ Binding DesignTime
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
                this.Text = value.ToString(FormatString);
            }
        }

        public string FormatString
        {
            get
            {
                return _formatString;
            }
            set
            {
                _formatString = value;
            }
        }
    }
}
