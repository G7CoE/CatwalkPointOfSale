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
using MyControls;
using PointOfSale.DbClass;

namespace PointOfSale
{
    public partial class FormBuy : Form
    {
        DataSet ds = MyGlobals.ds;
        DataTable dtSuppleir, dtBranch;
        DataTable dtBuyBill;
        DataTable dtBuy;
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

        BindingSource[] BsColors = new BindingSource[4];
        BindingSource BsModelSizeSet = new BindingSource();
        BindingSource[] BsSizeSets = new BindingSource[4];

        ComboList[] cmbColor;
        ComboList[] cmbSizeSet;
        IntegerBox[] inbSets;
        IntegerBox[] inbUnits;
        CurrencyBox[] dcbCost;
        CurrencyBox[] dcbAmount;
        StrBox[] txtRemark;
        Panel[] panProduct;
        Panel[] panSize;

        List<SizeSetView> sizeSetViews = new List<SizeSetView>();
        BindingSource[,] BsSizes = new BindingSource[4, 6];
        ComboList[,] cmbSize;
        IntegerBox[,] inbUnitSize;
        DataRelation brandsmodelsRelation;
        DataRelation sizeSetssizeSetItemsRelation;
        EditState billState = EditState.Viewing;
        EditState itemState = EditState.Viewing;
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
            if (MessageBox.Show ("จะลบบิลใช่มั้ย", "ลบบิล", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {   // ลบ record ใน Database
                string command = "DELETE FROM BuyBill WHERE id = " + ((DataRowView)(bsBuyBill.Current)).Row["id"].ToString();
                Helper.ExecuteNonQuery(command, CommandType.Text);
            }
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
                bsBuyBill.CancelEdit(); // cancel ก่อน เพื่อทำลาย ข้อมูลที่ AddNew เข้ามา แต่ยังไม่เข้าไปที่ DataTable
                dtBuyBill.ImportRow(dtNewBill.Rows[0]);            // importRow จะสร้าง row ใหม่  
                bsBuyBill.MoveLast(); // เลื่อนไป record ที่เพิ่งเพิ่มเข้ามา
            }
            else // Editing
            {
                UpdateBill();
                thisID = int.Parse(inbID.Text);
                // Copy ค่า ที่ไม่ได้ Bind เอาไว้
                dtBuyBill.Columns["id"].ReadOnly = false;
                DataRow thisRow = dtBuyBill.Rows[bsBuyBill.Position];
                DataRow newRow = (SelectBill("WHERE BuyBill.id = " + thisID.ToString())).Rows[0];
                thisRow.ItemArray = newRow.ItemArray.Clone() as object[];

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

        private DataTable SelectItem ()
        {
            return (Helper.LoadSql("SELECT id, buyBillID, productID, brandName, modelCode, colorName, " +
                "sizeSetID, sizeSetName, sets, units, cost,  units * cost AS amount, remark, " +
                "deviceID, deviceName, keyInEmpID, keyInEmpName, keyInDateTime, updated, updateBy " +
                "FROM (SELECT  dbo.Buy.*, dbo.Brand.name AS brandName, dbo.Model.code AS modelCode, dbo.Color.name AS colorName, " +
                "dbo.SizeSet.name AS sizeSetName, dbo.Device.name AS deviceName, dbo.Emp.name AS keyInEmpName, " +
                "(SELECT COUNT(id) FROM dbo.ProductItem WHERE(buyID = dbo.Buy.id)) AS units " +
                "FROM dbo.Color RIGHT OUTER JOIN dbo.Product ON dbo.Color.id = dbo.Product.colorID RIGHT OUTER JOIN dbo.SizeSet RIGHT OUTER JOIN " +
                "dbo.Buy ON dbo.SizeSet.id = dbo.Buy.sizeSetID ON dbo.Product.id = dbo.Buy.productID LEFT OUTER JOIN dbo.Brand RIGHT OUTER JOIN " +
                "dbo.Model ON dbo.Brand.id = dbo.Model.brandID ON dbo.Product.modelID = dbo.Model.id LEFT OUTER JOIN dbo.Emp ON dbo.Buy.keyInEmpID = dbo.Emp.id LEFT OUTER JOIN " +
                "dbo.Device ON dbo.Buy.deviceID = dbo.Device.id WHERE(dbo.Buy.buyBillID = " + ((DataRowView)bsBuyBill.Current).Row["id"].ToString() + ")) AS t1"));
        }
        
        private void updateBillAmount()
        {
            decimal temp =  dtBuy.AsEnumerable().Sum(b => b.Field<decimal>("amount"));
            dcbBillAmount.Value = temp;
            dcbBilltotal.Value = temp - dcbDiscount.Value;
        }

        private void bsBuyBill_PositionChanged(object sender, EventArgs e)
        {
            // Load รายการซื้อ
            if (billState == EditState.Adding)
            {
                // ในขณะที่ Add dt ไม่มีอะไร ซ่อน Grid หรือ clear Grid
                // ((DataRowView)bsBuyBill.Current).Row["id"].ToString();
                return;
            }
            dtBuy = SelectItem();
            bsBuy.DataSource = dtBuy;
            updateBillAmount();
        }

        public FormBuy()
        {
            InitializeComponent();
            panProduct = new Panel[] { panProduct0, panProduct1, panProduct2, panProduct3 };
            panSize = new Panel[] { panSize0, panSize1, panSize2, panSize3 };
            cmbColor = new ComboList[] { cmbColor0, cmbColor1, cmbColor2, cmbColor3 };
            cmbSizeSet = new ComboList[] { cmbSizeSet0, cmbSizeSet1, cmbSizeSet2, cmbSizeSet3 };
            inbSets = new IntegerBox[] { inbSets0, inbSets1, inbSets2, inbSets3 };
            inbUnits = new IntegerBox[] { inbUnits0, inbUnits1, inbUnits2, inbUnits3 };
            dcbCost = new CurrencyBox[] { dcbCost0, dcbCost1, dcbCost2, dcbCost3 };
            dcbAmount = new CurrencyBox[] { dcbAmount0, dcbAmount1, dcbAmount2, dcbAmount3 };
            txtRemark = new StrBox[] { txtRemark0, txtRemark1, txtRemark2, txtRemark3 };
            cmbSize = new ComboList[,] { { cmbSize00, cmbSize01, cmbSize02, cmbSize03, cmbSize04, cmbSize05 },
                                             { cmbSize10, cmbSize11, cmbSize12, cmbSize13, cmbSize14, cmbSize15 },
                                             { cmbSize20, cmbSize21, cmbSize22, cmbSize23, cmbSize24, cmbSize25 },
                                             { cmbSize30, cmbSize31, cmbSize32, cmbSize33, cmbSize34, cmbSize35 } };
            inbUnitSize = new IntegerBox[,] { { inbUnitSize00, inbUnitSize01, inbUnitSize02, inbUnitSize03, inbUnitSize04, inbUnitSize05 },
                                                   { inbUnitSize10, inbUnitSize11, inbUnitSize12, inbUnitSize13, inbUnitSize14, inbUnitSize15 },
                                                   { inbUnitSize20, inbUnitSize21, inbUnitSize22, inbUnitSize23, inbUnitSize24, inbUnitSize25 },
                                                   { inbUnitSize30, inbUnitSize31, inbUnitSize32, inbUnitSize33, inbUnitSize34, inbUnitSize35 } };
        }
        private DataTable SelectBill(string criteria)
        {
            return (Helper.LoadSql("SELECT        dbo.BuyBill.id, dbo.BuyBill.branchID, dbo.BuyBill.supplierID, dbo.BuyBill.billDate, dbo.BuyBill.transportExpenseID, " +
                "dbo.BuyBill.checkEmpID, dbo.BuyBill.barcodeEmpID, dbo.BuyBill.barcodeEmpID2, dbo.BuyBill.modelInfoEmpID, dbo.BuyBill.remark, dbo.BuyBill.discount, dbo.BuyBill.payID, dbo.BuyBill.deviceID, " +
                "dbo.BuyBill.keyInEmpID, dbo.BuyBill.keyInDateTime, dbo.BuyBill.updated, dbo.BuyBill.updateBy, " +
                "CheckEmp.name AS checkEmpName, BarCodeEmp.name AS barcodeEmpName, BarcodeEmp2.name AS barcodeEmpName2, ModelInfoEmp.name AS modelInfoEmpName, KeyInEmp.name AS keyInEmpName, dbo.Device.name AS deviceName " +
                "FROM dbo.BuyBill LEFT OUTER JOIN " +
                "dbo.Device ON dbo.BuyBill.deviceID = dbo.Device.id LEFT OUTER JOIN " +
                "dbo.Emp AS CheckEmp ON dbo.BuyBill.checkEmpID = CheckEmp.id LEFT OUTER JOIN " +
                "dbo.Emp AS BarCodeEmp ON dbo.BuyBill.barcodeEmpID = BarCodeEmp.id LEFT OUTER JOIN " +
                "dbo.Emp AS BarcodeEmp2 ON dbo.BuyBill.barcodeEmpID2 = BarcodeEmp2.id LEFT OUTER JOIN " +
                "dbo.Emp AS ModelInfoEmp ON dbo.BuyBill.modelInfoEmpID = ModelInfoEmp.id LEFT OUTER JOIN " +
                "dbo.Emp AS KeyInEmp ON dbo.BuyBill.keyInEmpID = KeyInEmp.id " + criteria ));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void setItemState (EditState temp)
        {
            bool isAllowEdit = (temp != EditState.Viewing);
            modelPanel.Visible = isAllowEdit;
            panFootItem.Visible = isAllowEdit;

            btnAdd.Visible = !isAllowEdit;
            btnEdit.Visible = !isAllowEdit;
            btnDelete.Visible = !isAllowEdit;
            btnAddNewItem.Visible = !isAllowEdit;
            btnEditItem.Visible = !isAllowEdit;
            btnDeleteItem.Visible = !isAllowEdit;
            itemState = temp;
        }
        private void createBrandModelList()
        {
            List<BrandView> brandViews = new List<BrandView>();
            DataTable dtBrandsSupplierID = Helper.LoadSql("SELECT dbo.Brand.id FROM dbo.Supplier_Brand INNER JOIN " +
                "dbo.Brand ON dbo.Supplier_Brand.brandID = dbo.Brand.id " +
                "WHERE(dbo.Supplier_Brand.supplierID = " + cmbSupplier.SelectedValue + ")"); // SupplierID
            foreach (DataRow brandRow in dtBrandsSupplierID.Rows)
            {

                int brandID = int.Parse(brandRow["id"].ToString());
                DataRow dr1 = (DataRow)(from myRow in ds.Tables["Brand"].AsEnumerable()
                                        where myRow.Field<int>("id") == brandID
                                        select myRow).FirstOrDefault();
                BrandView brandView1 = new BrandView();
                brandView1.id = int.Parse(dr1["id"].ToString());
                brandView1.name = dr1["name"].ToString();
                brandView1.fullName = dr1["fullName"].ToString();
                brandView1.brandProductTypeID = int.Parse(dr1["brandProductTypeID"].ToString());
                brandView1.brandProductTypeName = dr1["brandProductTypeName"].ToString();
                brandView1.defaultSizeSetID = Helper.IntParse(dr1["defaultSizeSetID"].ToString());
                brandView1.sizeSetName = dr1["sizeSetName"].ToString();
                brandView1.isRequiredColor = int.Parse(dr1["isRequiredColor"].ToString());
                brandView1.isRequireSize = int.Parse(dr1["isRequireSize"].ToString());
                brandView1.modelCodes = new List<BaseTable>();
                foreach (DataRow dr2 in dr1.GetChildRows(brandsmodelsRelation))
                {
                    BaseTable model1 = new BaseTable();
                    model1.id = (int)dr2["id"];
                    model1.name = dr2["code"].ToString();
                    brandView1.modelCodes.Add(model1);
                }
                brandViews.Add(brandView1);
            }
            bsBrandView.DataSource = brandViews;
        }
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            createBrandModelList();
            // Set Default value
            cmbModel.SelectedIndex = -1;
            cmbModelSizeSet.SelectedIndex = -1;
            inbModelSets.Text = "";
            inbModelUnits.Text = "";
            dcbModelCost.Value = 0;
            dcbModelPrice.Value = 0;
            for (int i = 0; i < 4; i++)
            {
                cmbColor[i].SelectedIndex = -1;
                cmbSizeSet[i].SelectedIndex = -1;
                inbSets[i].Text = "";
                inbUnits[i].Text = "";
                dcbCost[i].Value = 0;
                dcbAmount[i].Value = 0;
                txtRemark[i].Text = "";
            }
            if (bsBrandView.Count > 1)
            {
                cmbBrand.SelectedIndex = -1;
                cmbBrand.Focus();
            }
            else
            {
                cmbBrand.SelectedIndex = 0;
                cmbModel.Focus();
            }
            setItemState(EditState.Adding);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            setItemState(EditState.Editing);
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnOKItem_Click(object sender, EventArgs e)
        {
            setItemState(EditState.Viewing);
        }

        private void btnCancelItem_Click(object sender, EventArgs e)
        {
            setItemState(EditState.Viewing);
        }

        private bool checkSelectedModel ()
        {
            return (cmbModel.SelectedValue != null && cmbModel.Text.Length != 0);
        }
        private void cmbBrand_SelectedValueChanged(object sender, EventArgs e)
        {
            if (modelPanel.Visible == false)
                return;
            bool isSelectedModel = checkSelectedModel();
            if (isSelectedModel)
            {
                cmbModel.Text = "";
                panProduct[0].Visible = true;
            }
            else
            {
                for (int i=0; i<4; i++)
                {
                    panProduct[i].Visible = false;
                    panSize[i].Visible = false;
                }
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvBuyView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductPanel_Enter(object sender, EventArgs e)
        {
            /*Panel productPanel = (Panel) sender;
            int arrIndex = int.Parse(productPanel.Name.Substring(productPanel.Name.Length - 1));            
            panSize[arrIndex].Visible = true;
            Console.WriteLine("EnterProductPanel sender Name: {0}, {1}", productPanel.Name, arrIndex);
            setchildindex();*/
        }

        private void ProductPanel_Leave(object sender, EventArgs e)
        {
            /*Control leaveSender = (Control)sender;
            // ถ้าอยู่ใน Product Panel จะเป็นเลข
            string temp = leaveSender.Name.Substring(leaveSender.Name.Length - 1);
            int arrIndex = 0;
            if (int.TryParse(temp, out arrIndex))
            {
                arrIndex = int.Parse(leaveSender.Name.Substring(leaveSender.Name.Length - 1));
                panSize[arrIndex].Visible = false;
                setchildindex();
            }*/
        }


        private void setchildindex()
        {
            // SetChildIndex
            leftPanel.Controls.SetChildIndex(modelPanel, 0);
            leftPanel.Controls.SetChildIndex(panProduct0, 1);
            leftPanel.Controls.SetChildIndex(panSize0, 2);
            leftPanel.Controls.SetChildIndex(panProduct1, 3);
            leftPanel.Controls.SetChildIndex(panSize1, 4);
            leftPanel.Controls.SetChildIndex(panProduct2, 5);
            leftPanel.Controls.SetChildIndex(panSize2, 6);
            leftPanel.Controls.SetChildIndex(panProduct3, 7);
            leftPanel.Controls.SetChildIndex(panSize3, 8);
            leftPanel.Controls.SetChildIndex(panFootItem, 9);
        }

        private void cmbModelSizeSet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbModelSizeSet.SelectedValue == null)
                return;
            int selectedValue = (int) cmbModelSizeSet.SelectedValue;

            cmbSizeSet[0].SelectedValue = selectedValue;
            cmbSizeSet[1].SelectedValue = selectedValue;
            cmbSizeSet[2].SelectedValue = selectedValue;
            cmbSizeSet[3].SelectedValue = selectedValue;

        }

        private void dcbModelCost_TextChanged(object sender, EventArgs e)
        {
            dcbCost[0].Text = dcbModelCost.Text;
            dcbCost[1].Text = dcbModelCost.Text;
            dcbCost[2].Text = dcbModelCost.Text;
            dcbCost[3].Text = dcbModelCost.Text;
        }

        private void cmbModel_Click(object sender, EventArgs e)
        {

        }

        private void cmbModel_Enter(object sender, EventArgs e)
        {
            cmbModel.DroppedDown = true;
        }

        private void cmbModel_Leave(object sender, EventArgs e)
        {
            if (checkSelectedModel())
            {   
                // ถ้าระบุ รุ่นแล้ว
                if (cmbModel.SelectedValue != null)
                {
                    // รุ่นเก่า โหลดข้อมุูลเก่า

                }
                else
                {
                    // รุ่นใหม่ รับค่าราคาขาย

                }
                panProduct[0].Visible = true;
                setchildindex();
            }
        }

        private void cmbColor_Leave(object sender, EventArgs e)
        {
            
            Control leaveSender = (Control)sender;
            string temp = leaveSender.Name.Substring(leaveSender.Name.Length - 1);
            int arrIndex = 0;
            if (int.TryParse(temp, out arrIndex))
            {

            }
        }

        private void showSizeUnit (int index, List<SizeSetItemGroupSize> sizeUnits, int sets)
        {
            for (int i = 0; i < sizeUnits.Count; i++)
            {
                cmbSize[index, i].SelectedValue = sizeUnits[i].sizeID;
                inbUnitSize[index, i].Text = (sets * sizeUnits[i].units).ToString();
            }
        }


        private void cmbSizeSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboList thisControl = (ComboList)sender;
            if (thisControl.SelectedValue == null)
                return;
            string temp = thisControl.Name.Substring(thisControl.Name.Length - 1);
            if (int.TryParse(temp, out int index) == false)
                return;
            if (int.TryParse(inbSets[index].Text, out int sets) == false)
                sets = 0;
            showSizeUnit(index, ((SizeSetView)BsSizeSets[index].Current).sizeUnits, sets);
        }
        
        private void cmbSizeSet_SelectedValueChanged(object sender, EventArgs e)
        {
            


        }

        private void cmbModel_TextChanged(object sender, EventArgs e)
        {
            if (cmbModel.Text.Length > 1)
            {
                panProduct0.Visible = true;
                panSize0.Visible = true;
                setchildindex();
            }
        }

        private void inbSets_TextChanged(object sender, EventArgs e)
        {
            TextBox thisTextBox = (TextBox)sender;
            string temp = thisTextBox.Name.Substring(thisTextBox.Name.Length - 1);
            if (int.TryParse(temp, out int index) == false)
                return;
            if (int.TryParse(inbSets[index].Text, out int sets) == false)
                sets = 0;
            showSizeUnit(index, ((SizeSetView)BsSizeSets[index].Current).sizeUnits, sets);
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

            // โหลดข้อมูลที่ต้องการ เพื่อจัดการข้อมูลรายการ
            // color, sizeset + item

            // โหลด Brand ทั้งหมด พร้อมกับ brandModelType
            string command = "SELECT dbo.Brand.id, dbo.Brand.name, dbo.Brand.fullName, dbo.Brand.brandProductTypeID, dbo.BrandProductType.name AS brandProductTypeName, " +
                "dbo.Brand.defaultSizeSetID, dbo.SizeSet.name AS sizeSetName, dbo.BrandProductType.isRequiredColor, dbo.BrandProductType.isRequireSize " +
                "FROM dbo.Brand INNER JOIN " +
                "dbo.BrandProductType ON dbo.Brand.brandProductTypeID = dbo.BrandProductType.id LEFT OUTER JOIN " +
                "dbo.SizeSet ON dbo.Brand.id = dbo.SizeSet.id ORDER BY dbo.Brand.id";
            Helper.fillDataSet("Brand", Helper.ExecuteReader(command, CommandType.Text)); // Load Brand ไว้ใน Dataset
            // โหลด model ทั้งตาราง เพื่อเป็นข้อมูลที่จะเอาไปทำ AutoComplete ที่ cmbModek
            Helper.fillDataSet("Model", Helper.ExecuteReader("SELECT * FROM Model ORDER BY brandID, code", CommandType.Text));
            brandsmodelsRelation = new DataRelation("BrandsModels", ds.Tables["Brand"].Columns["id"], ds.Tables["Model"].Columns["brandID"]);
            ds.Relations.Add(brandsmodelsRelation);

            Helper.fillDataSet("Color", Helper.ExecuteReader("SELECT * FROM Color order by id", CommandType.Text));
            Helper.fillDataSet("SizeSet", Helper.ExecuteReader("SELECT * FROM SizeSet ORDER BY id", CommandType.Text));
            Helper.fillDataSet("SizeSetItemGroupSize", Helper.ExecuteReader("SELECT dbo.SizeSetItem.sizeSetID, dbo.SizeSetItem.sizeID, dbo.Size.name AS sizeName, COUNT(*) AS units " +
                "FROM dbo.SizeSetItem INNER JOIN dbo.Size ON dbo.SizeSetItem.sizeID = dbo.Size.id " +
                "GROUP BY dbo.SizeSetItem.sizeID, dbo.SizeSetItem.sizeSetID, dbo.Size.name ORDER BY dbo.SizeSetItem.sizeSetID, dbo.SizeSetItem.sizeID", CommandType.Text));
            sizeSetssizeSetItemsRelation = new DataRelation("sizeSetssizeSetItems", ds.Tables["SizeSet"].Columns["id"], ds.Tables["SizeSetItemGroupSize"].Columns["sizeSetID"]);
            ds.Relations.Add(sizeSetssizeSetItemsRelation);
            SizeSetView orderSize = new SizeSetView();
            orderSize.id = 0;
            orderSize.name = "สั่งไซส์";
            orderSize.sizeUnits = new List<SizeSetItemGroupSize>();
            sizeSetViews.Add(orderSize);
            foreach (DataRow dr1 in ds.Tables["SizeSet"].Rows)
            {
                SizeSetView sizeSetView1 = new SizeSetView();
                sizeSetView1.id = (int)dr1["id"];
                sizeSetView1.name = dr1["name"].ToString();
                sizeSetView1.sizeUnits = new List<SizeSetItemGroupSize>();
                foreach (DataRow dr2 in dr1.GetChildRows(sizeSetssizeSetItemsRelation))
                {
                    SizeSetItemGroupSize item1 = new SizeSetItemGroupSize();
                    item1.sizeSetID = (int)dr2["sizeSetID"];
                    item1.sizeID = (int)dr2["sizeID"];
                    item1.sizeName = dr2["sizeName"].ToString();
                    item1.units = (int)dr2["units"];
                    sizeSetView1.sizeUnits.Add(item1);
                }
                sizeSetViews.Add(sizeSetView1);
            }
            BsModelSizeSet.DataSource = sizeSetViews;
            cmbModelSizeSet.DataSource = BsModelSizeSet;
            for (int i = 0; i < 4; i++)
            {
                BsSizeSets[i] = new BindingSource();
                BsSizeSets[i].DataSource = sizeSetViews;
                cmbSizeSet[i].DataSource = BsSizeSets[i];
                BsColors[i] = new BindingSource();
                BsColors[i].DataSource = ds.Tables["Color"];
                cmbColor[i].DataSource = BsColors[i];
            }

            Helper.fillDataSet("Size", Helper.ExecuteReader("SELECT * FROM Size order by id", CommandType.Text));
            DataTable dtSize = ds.Tables["Size"];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    BsSizes[i, j] = new BindingSource();
                    BsSizes[i, j].DataSource = dtSize;
                    cmbSize[i, j].DataSource = BsSizes[i, j];
                    cmbSize[i, j].DisplayMember = "name";
                    cmbSize[i, j].ValueMember = "id";
                }
            }
            


            // โหลด BuyBill
            dtBuyBill = SelectBill(strBuyBillCriteria);
            bsBuyBill.DataSource = dtBuyBill;
            bsBuyBill.MoveLast();

            Console.WriteLine("Form Loaded");

        }
    }
}
