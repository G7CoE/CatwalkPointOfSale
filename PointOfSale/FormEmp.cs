using PointOfSale.DbClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class FormEmp : Form
    {
        Emp emp1 = new Emp();
        DataTable dtEmp = new DataTable();
        BindingSource BsEmpType = new BindingSource();
        EditState formState = EditState.Viewing;
        public FormEmp()
        {
            InitializeComponent();
        }

        private void FormEmp_Load(object sender, EventArgs e)
        {
            selectEmpsMyCombo.SelectedIndex = 0; // Load Current Emps
            BsEmpType.DataSource = Helper.LoadSql("SELECT * FROM EmpType Order By ID");
            empTypeIDMyCombo.DataSource = BsEmpType;
            empTypeIDMyCombo.DisplayMember = "name";
            empTypeIDMyCombo.ValueMember = "id";
        }

        private void selectEmpsMyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("selectEmpsMyCombo_SelectedIndexChanged  : " + selectEmpsMyCombo.SelectedIndex.ToString() + " " + selectEmpsMyCombo.Text);
            switch (selectEmpsMyCombo.SelectedIndex)
            {
                case 0: // current Emp
                    dtEmp = emp1.Select("WHERE isQuitted != 1");
                    break;
                case 1: // quitted Emp
                    dtEmp = emp1.Select("WHERE isQuitted = 1");
                    break;
                case 2:
                    dtEmp = emp1.Select();
                    break;
            }
            bsEmp.DataSource = dtEmp;
        }

        private void empListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (empListBox.SelectedIndex == -1)
                return;
            int rowIndex = empListBox.SelectedIndex;
            DataRow dr = dtEmp.Rows[rowIndex];
            inbID.Text = dr["id"].ToString();
            txtName.Text = dr["name"].ToString();
            txtFullName.Text = dr["fullName"].ToString();
            txtTel.Text = dr["tel"].ToString();
            txtEmail.Text = dr["email"].ToString();
            decSalary.Value = Helper.DecimalParse(dr["salary"].ToString());
            ndecBundle.Value = Helper.NDecimalParse(dr["bundle"].ToString());
            chkisQuitted.Checked = Helper.BoolParse(dr["isQuitted"].ToString());
            dateStartDate.Value = Helper.DateParse(dr["startDate"].ToString());
            ndateQuitDate.Value = Helper.NDateParse(dr["quitDate"].ToString());
            empTypeIDMyCombo.SelectedValue = Helper.NIntParse(dr["empTypeID"].ToString());
        }

        private void setFromState ()
        {
            bool isview = (formState == EditState.Viewing);
            txtName.ReadOnly = isview;
            txtFullName.ReadOnly = isview;
            txtTel.ReadOnly = isview;
            txtEmail.ReadOnly = isview;
            decSalary.ReadOnly = isview;
            ndecBundle.ReadOnly = isview;
            chkisQuitted.Enabled = !isview;
            dateStartDate.Enabled = !isview;
            ndateQuitDate.Enabled = !isview;
            empTypeIDMyCombo.Enabled = !isview;

            btnAdd.Visible = isview;
            btnEdit.Visible = isview;
            btnDelete.Visible = isview;
            btnOK.Visible = !isview;
            btnCancel.Visible = !isview;
            // not move while add or update
            selectEmpsMyCombo.Enabled = isview;
            empListBox.Enabled = isview;
            switch (formState)
            {
                case EditState.Adding:
                    inbID.Visible = false;
                    chkisQuitted.Visible = false;
                    ndateQuitDate.Visible = false;
                    break;
                case EditState.Editing:
                default: // Edit or View
                    inbID.Visible = true;
                    chkisQuitted.Visible = true;
                    ndateQuitDate.Visible = chkisQuitted.Checked;
                    break;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Default Value
            inbID.Text = "";
            txtName.Text = "";
            txtFullName.Text = "";
            txtTel.Text = "";
            txtEmail.Text = "";
            decSalary.Value = 0;
            ndateQuitDate.Value = null;
            chkisQuitted.Checked = false;
            dateStartDate.Value = DateTime.Today.AddDays(1);
            ndateQuitDate.Value = null;
            empTypeIDMyCombo.SelectedValue = 2;
            formState = EditState.Adding;
            setFromState();
            txtName.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formState = EditState.Editing;
            setFromState();
            txtFullName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // check Error
            if (dateStartDate.Value > DateTime.Today)
            {
                MessageBox.Show("ระบุวันเริ่มงานด้วย", "เริ่มงาน?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dateStartDate.Focus();
                return;
            }
            if (chkisQuitted.Checked && ndateQuitDate.Value == null)
            {
                MessageBox.Show("ระบุวันออกจากงานด้วย", "ออกจากงาน?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ndateQuitDate.Focus();
                return;
            }
            if (empTypeIDMyCombo.SelectedIndex == -1)
            {
                MessageBox.Show("เลือกตำแหน่งด้วย", "ตำแหน่ง?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                empTypeIDMyCombo.Focus();
                return;
            }
            // copy UIData to emp1
            emp1.name = txtName.Text;
            emp1.fullName = txtFullName.Text;
            emp1.tel = txtTel.Text;
            emp1.email = txtEmail.Text;
            emp1.salary = decSalary.Value;
            emp1.bundle = ndecBundle.Value;
            emp1.startDate = dateStartDate.Value;
            emp1.isQuitted = chkisQuitted.Checked ? 1 : 0;
            /*if (!chkisQuitted.Checked)
               emp1.quitDate = null;
            else
                emp1.quitDate = ndateQuitDate.Value;*/
            emp1.quitDate = ndateQuitDate.Value;
            emp1.empTypeID = (int) empTypeIDMyCombo.SelectedValue;
            if (formState == EditState.Adding)
            {
                emp1.id = emp1.Insert(emp1);
                // Update DataTable ในตัวอย่าง ใช้ refresh
            }
            else
            {
                // ถ้า update ให้ค่า id
                emp1.id = int.Parse(inbID.Text);
                emp1.Update(emp1);
                // Update DataTable ในตัวอย่าง ใช้ refresh
            }
            // refresh Data
            selectEmpsMyCombo_SelectedIndexChanged(sender, e);
            empListBox_SelectedValueChanged(sender, e);

            formState = EditState.Viewing;
            setFromState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // refresh เฉพาะ ข้อมูลที่แสดงผลบน Detail
            empListBox_SelectedValueChanged(sender, e);
            formState = EditState.Viewing;
            setFromState();
        }

        private void chkisQuitted_CheckedChanged(object sender, EventArgs e)
        {
            ndateQuitDate.Visible = chkisQuitted.Checked;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการจะลบข้อมูล ใช่หรือไม่", "ลบ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                emp1.Delete(int.Parse( inbID.Text));
            }
            selectEmpsMyCombo_SelectedIndexChanged(sender, e);
            empListBox_SelectedValueChanged(sender, e);

        }
    }
}
