using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.DbClass;

namespace PointOfSale
{
    public partial class FormBuy : Form
    {
        DataTable dtSuppleir, dtBranch;
        DataTable dtBuyBills;
        DataTable dtLogInEmp = MyGlobals.dtLogInEmp;
        DataTable  dtCurrentEmp = MyGlobals.dtCurrentEmp;
        BindingSource bsSupplier = new BindingSource();
        BindingSource bsBranch = new BindingSource();
        BindingSource bsCheckEmp = new BindingSource();
        BindingSource bsBarcodeEmp = new BindingSource();
        BindingSource bsBarcodeEmp2 = new BindingSource();
        BindingSource bsModelInfoEmp = new BindingSource();
        BindingSource bsKeyInEmp = new BindingSource();

        BuyBillView buyBillview1 = new BuyBillView();
        string strBuyBillCriteria = "WHERE BuyBill.id > 4700 ORDER BY BuyBill.id"; // เปลี่ยนเป็น โหลด 4 เดือนย้อนหลัง
        EditState billState = EditState.Viewing;
        DataRowView drvNew;
        private void SetFormState(EditState setState)
        {
            bool isAllowEdit = (setState != EditState.Viewing);
            cmbBranch.Enabled = isAllowEdit;
            cmbSupplier.Enabled = isAllowEdit;
            dtpBillDate.Enabled = isAllowEdit;
            txtBillRemark.ReadOnly = !isAllowEdit;
            dcbDiscount.ReadOnly = !isAllowEdit;
            cmbKeyInEmp.Visible = isAllowEdit;
            txtkeyInEmpName.Visible = !isAllowEdit;
            txtUpdated.Visible = !isAllowEdit;

            cmbCheckEmpView.Visible = !isAllowEdit;
            cmbCheckEmpEdit.Visible = isAllowEdit;
            cmbBarcodeEmpView.Visible = !isAllowEdit;
            cmbBarcodeEmpEdit.Visible = isAllowEdit;
            cmbBarcodeEmp2View.Visible = !isAllowEdit;
            cmbBarcodeEmp2Edit.Visible = isAllowEdit;
            cmbModelInfoEmpView.Visible = !isAllowEdit;
            cmbModelInfoEmpEdit.Visible = isAllowEdit;

            btnAdd.Visible = !isAllowEdit;
            btnEdit.Visible = !isAllowEdit;
            btnDelete.Visible = !isAllowEdit;
            okBillPanel.Visible = isAllowEdit;
            dgvBuyView.Visible = (setState != EditState.Adding);
            billState = setState;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetFormState(EditState.Adding);
            drvNew = (DataRowView)bsBuyBill.AddNew();
            dtpBillDate.Value = DateTime.Today.AddDays(1);
            if (bsKeyInEmp.Count == 1) // ถ้า login คนเดียว ใส่ให้ ถ้าหลายคนให้เลือก
                cmbKeyInEmp.SelectedIndex = 0;
            else
                cmbKeyInEmp.SelectedIndex = -1;
            
            dcbDiscount.Value = 0;
            dcbBillAmount.Value = 0; // ไม่มีผลอะไร ไม่ได้ bind ไว้
            dcbBilltotal.Value = 0; // ไม่มีผลอะไร ไม่ได้ bind ไว้
            cmbSupplier.Focus();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // create backup data

            // txtDeviceName.Text = "";
            SetFormState(EditState.Editing);
            cmbSupplier.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        SqlParameter[] getValueFromControls()
        {
            SqlParameter[] parameters = {
                new SqlParameter("@branchID", cmbBranch.SelectedValue),
                new SqlParameter("@supplierID", cmbSupplier.SelectedValue),
                new SqlParameter("@billDate", dtpBillDate.Value),
                new SqlParameter("@checkEmpID", cmbCheckEmpEdit.SelectedValue),
                new SqlParameter("@barcodeEmpID", cmbBarcodeEmpEdit.SelectedValue ?? DBNull.Value),
                new SqlParameter("@barcodeEmpID2", cmbBarcodeEmp2Edit.SelectedValue ?? DBNull.Value),
                new SqlParameter("@modelInfoEmpID", cmbModelInfoEmpEdit.SelectedValue ?? DBNull.Value),
                new SqlParameter("@remark", txtBillRemark.Text),
                new SqlParameter("@discount", dcbDiscount.Value),
                new SqlParameter("@deviceID", SettingClass.deviceID),
                new SqlParameter("@keyInEmpID", cmbKeyInEmp.SelectedValue), 
                new SqlParameter("@updateBy", "")
            };
            return parameters;
        }
        private int InsertBill()
        {
            string command = "INSERT BuyBill (branchID, supplierID, billDate, checkEmpID, barcodeEmpID, barcodeEmpID2, modelInfoEmpID, remark, discount, deviceID, keyInEmpID, keyInDateTime, updated, updateBy)" +
                "OUTPUT Inserted.id VALUES (@branchID, @supplierID, @billDate, @checkEmpID, @barcodeEmpID, @barcodeEmpID2, @modelInfoEmpID, @remark, @discount, @deviceID, @keyInEmpID, CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, @updateBy)";
            return (int)Helper.ExecuteScalar(command, System.Data.CommandType.Text, getValueFromControls());
        }

        private int UpdateBill()
        {
            string command = "UPDATE BuyBill SET branchID=@branchID, supplierID=@supplierID, billDate=@billDate, checkEmpID=@checkEmpID, barcodeEmpID=@barcodeEmpID, barcodeEmpID2=@barcodeEmpID2, modelInfoEmpID=@modelInfoEmpID, remark=@remark, discount=@discount, deviceID=@deviceID, keyInEmpID=@keyInEmpID, updated=CURRENT_TIMESTAMP, updateBy=@updateBy WHERE id = @id";
            SqlParameter[] temp = getValueFromControls();
            Array.Resize(ref temp, temp.Length + 1);
            temp[temp.Length - 1] = new SqlParameter("@id", int.Parse(inbID.Text));
            return (int)Helper.ExecuteNonQuery(command, System.Data.CommandType.Text, temp);
        }
        private void btnBillOK_Click(object sender, EventArgs e)
        {
            #region checkError // Check User Error
            if (cmbSupplier.SelectedIndex == -1)
            {
                MessageBox.Show("เลือกร้านค้าส่งด้วย", "ร้านค้าส่ง?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbSupplier.Focus();
                return;
            }
            if (dtpBillDate.Value > DateTime.Today)
            {
                MessageBox.Show("ระบุวันที่บิลด้วย", "วันที่บิล", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpBillDate.Focus();
                return;
            }
            // keyIn EmpID
            if (cmbKeyInEmp.SelectedIndex == -1)
            {
                MessageBox.Show("เลือกคนคีย์ด้วย", "ใครคีย์?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbKeyInEmp.Focus();
                return;
            }
            if (cmbCheckEmpEdit.SelectedIndex == -1)
            {
                MessageBox.Show("เลือกพนักงาน ที่เช็คสินค้าด้วย", "ใครเช็คของ?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbKeyInEmp.Focus();
                return;
            }
            #endregion
            // เอา DataRow จาก current ของ bindingSource
            int thisID = 0;
            // Update Database ก่อน
            DataTable dtNewBill;
            if (billState == EditState.Adding) // Adding
            {
                thisID = InsertBill();
                dtNewBill = SelectBill("WHERE BuyBill.id = " + thisID.ToString());
                dtBuyBills.ImportRow(dtNewBill.Rows[0]);            // update DataTable ให้ตรงกับที่ select มา  
            }
            else // Editing
            {
                UpdateBill();
                thisID = int.Parse(inbID.Text);
                DataRow newRow = (SelectBill("WHERE BuyBill.id = " + thisID.ToString())).Rows[0];
                // Copy ค่า ที่ไม่ได้ Bind เอาไว้
                DataRow thisRow = dtBuyBills.Rows[bsBuyBill.Position];
                thisRow["checkEmpID"] = newRow["checkEmpID"];
                thisRow["checkEmpName"] = newRow["checkEmpName"];
                thisRow["barcodeEmpID"] = newRow["barcodeEmpID"];
                thisRow["barcodeEmpName"] = newRow["barcodeEmpName"];
                thisRow["barcodeEmpID2"] = newRow["barcodeEmpID2"];
                thisRow["barcodeEmpName2"] = newRow["barcodeEmpName2"];
                thisRow["modelInfoEmpID"] = newRow["modelInfoEmpID"];
                thisRow["modelInfoEmpName"] = newRow["modelInfoEmpName"];
                thisRow["deviceID"] = newRow["deviceID"];
                thisRow["deviceName"] = newRow["deviceName"];
                thisRow["keyInEmpID"] = newRow["keyInEmpID"];
                thisRow["keyInEmpName"] = newRow["keyInEmpName"];
                thisRow["keyInDateTime"] = newRow["keyInDateTime"];
                thisRow["updated"] = newRow["updated"];
                thisRow["updateBy"] = newRow["updateBy"];
                // refresh binding control
                bsBuyBill.ResetBindings(false);
            }

            SetFormState(EditState.Viewing);
        }

        private void btnBillCancel_Click(object sender, EventArgs e)
        {
            // Copy Data From Backup Avoid refresh

            bsBuyBill.CancelEdit();
            SetFormState(EditState.Viewing);
        }

        public FormBuy()
        {
            InitializeComponent();
        }
        private DataTable SelectBill(string criteria)
        {
            return (Helper.LoadSql("SELECT        dbo.BuyBill.id, dbo.BuyBill.branchID, dbo.BuyBill.supplierID, dbo.BuyBill.billDate, dbo.BuyBill.transportExpenseID, " +
                "dbo.BuyBill.checkEmpID, dbo.BuyBill.barcodeEmpID, dbo.BuyBill.barcodeEmpID2, dbo.BuyBill.modelInfoEmpID, dbo.BuyBill.remark, dbo.BuyBill.discount, dbo.BuyBill.payID, dbo.BuyBill.deviceID, " +
                "dbo.BuyBill.keyInEmpID, dbo.BuyBill.keyInDateTime, dbo.BuyBill.updated, dbo.BuyBill.updateBy, " +
                "CheckEmp.name AS checkEmpName, BarCodeEmp.name AS barcodeEmpName, BarcodeEmp2.name AS barcodeEmpName2, ModelInfoEmp.name AS modelInfoEmpName, KeyInEmp.name AS keyInEmpName, dbo.Device.name AS deviceName" +
                ", amount = 0, total = 0 " +
                "FROM	dbo.BuyBill LEFT OUTER JOIN " +
                "dbo.Device ON dbo.BuyBill.deviceID = dbo.Device.id LEFT OUTER JOIN " +
                "dbo.Emp AS CheckEmp ON dbo.BuyBill.checkEmpID = CheckEmp.id LEFT OUTER JOIN " +
                "dbo.Emp AS BarCodeEmp ON dbo.BuyBill.barcodeEmpID = BarCodeEmp.id LEFT OUTER JOIN " +
                "dbo.Emp AS BarcodeEmp2 ON dbo.BuyBill.barcodeEmpID2 = BarcodeEmp2.id LEFT OUTER JOIN " +
                "dbo.Emp AS ModelInfoEmp ON dbo.BuyBill.modelInfoEmpID = ModelInfoEmp.id LEFT OUTER JOIN " +
                "dbo.Emp AS KeyInEmp ON dbo.BuyBill.keyInEmpID = KeyInEmp.id " + criteria ));
        }
        private void FormBuy_Load(object sender, EventArgs e)
        {

            dtSuppleir = Helper.LoadSql("SELECT id, name From Supplier WHERE isQuitted != 1"); // Load Supplier Lookup
            dtBranch = Helper.LoadSql("SELECT id, name FROM Branch WHERE branchTypeID = 1"); // Load Branch Lookup
            dtCurrentEmp = Helper.LoadSql("SELECT id, name FROM Emp WHERE isQuitted = 0"); // Load current Emp
            bsSupplier.DataSource = dtSuppleir;
            cmbSupplier.DataSource = bsSupplier;
            bsBranch.DataSource = dtBranch;
            cmbBranch.DataSource = dtBranch;
            bsCheckEmp.DataSource = dtCurrentEmp;
            bsBarcodeEmp.DataSource = dtCurrentEmp;
            bsBarcodeEmp2.DataSource = dtCurrentEmp;
            bsModelInfoEmp.DataSource = dtCurrentEmp;

            cmbCheckEmpEdit.DataSource = bsCheckEmp;
            cmbBarcodeEmpEdit.DataSource = bsBarcodeEmp;
            cmbBarcodeEmp2Edit.DataSource = bsBarcodeEmp2;
            cmbModelInfoEmpEdit.DataSource = bsModelInfoEmp;
            
            bsKeyInEmp.DataSource = dtLogInEmp;
            cmbKeyInEmp.DataSource = bsKeyInEmp;
            // ** หมายเหตุ DisplayMember = "name" ValueMember = "id" เซ็ตไว้ใน property ขี้เกียจพิมพ์
            // โหลด BuyBill
            dtBuyBills = SelectBill(strBuyBillCriteria);
            bsBuyBill.DataSource = dtBuyBills;
            bsBuyBill.MoveLast();



        }
    }
}
