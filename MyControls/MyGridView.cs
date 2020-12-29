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
    public partial class MyGridView : DataGridView
    {
        public MyGridView()
        {
            InitializeComponent();
            this.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.CellBorderStyle = DataGridViewCellBorderStyle.None;

            this.DefaultCellStyle.SelectionBackColor = Color.Red;
            this.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            this.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //this.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
