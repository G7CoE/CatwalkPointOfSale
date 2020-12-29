using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyControls
{
    [System.ComponentModel.DefaultBindingProperty("Value")]
    public partial class IntegerBox : StrBox
    {
        public IntegerBox()
        {
            InitializeComponent();
            this.TextAlign = HorizontalAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            // Ignore all non-control and non-numeric key presses.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            //  to Call the implementation in the base TextBox class,
            // which raises the KeyPress event.
            base.OnKeyPress(e);
        }
        [Bindable(true)]  // เติมบรรทัดนี้ เพื่อ Binding DesignTime
        public int Value { get; set; }
    }
}
