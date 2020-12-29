using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyControls
{
    public partial class NDateBox : DateTimePicker
    {
		private string _customFormat = "dd MMM yyyy";
		//private bool bIsNull = false;

		private DateTime? _value;
		public NDateBox() : base()
		{
			this.Format = DateTimePickerFormat.Custom;
		}

        public new string CustomFormat
		{
			get
			{
				return _customFormat;
			}
			set
			{
				base.CustomFormat = value;
				_customFormat = value;
			}
		}
        public new DateTime? Value
		{
			get
			{
				if (_value is null)
					return null;
				else
					return _value;
			}
			set
			{
				if (value == null) // ค่าที่จะเซ็ตเป็น null
                {
					base.CustomFormat = " ";
					_value = null;
                }
				else
                {
					base.Value = DateTime.Parse(value.ToString());
					base.CustomFormat = this.CustomFormat;
					_value = value;
				}
			}
		}

		protected override void OnCloseUp(EventArgs eventargs)
		{
			if (Control.MouseButtons == MouseButtons.None)
			{
				CustomFormat = "dd MMM yyyy";
				_value = base.Value;
			}
			base.OnCloseUp(eventargs);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);

			if (e.KeyCode == Keys.Delete)
				this.Value = null;
		}
	}
}
