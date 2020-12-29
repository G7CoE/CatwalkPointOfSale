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
    public partial class DateBox : DateTimePicker
    {
		/*private DateTimePickerFormat oldFormat = DateTimePickerFormat.Long;
		private string oldCustomFormat = null;
		private bool bIsNull = false;*/

		public DateBox()
		{
			// initial ให้เป็นค่าที่ใช้ก่อน
			this.CustomFormat = "dd MMM yy";
			this.Format = DateTimePickerFormat.Custom;
		}
	}
}
