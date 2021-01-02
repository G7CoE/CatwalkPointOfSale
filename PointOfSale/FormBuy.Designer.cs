
namespace PointOfSale
{
    partial class FormBuy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label22;
            System.Windows.Forms.Label label26;
            System.Windows.Forms.Label label25;
            System.Windows.Forms.Label label27;
            System.Windows.Forms.Label modelInfoEmpIDLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label checkEmpIDLabel;
            System.Windows.Forms.Label barcodeEmpIDLabel;
            System.Windows.Forms.Label discountLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label28;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label lblUpdated;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label billDateLabel;
            System.Windows.Forms.Label branchIDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuy));
            this.leftPanel = new MyControls.MyPanel();
            this.myPanel2 = new MyControls.MyPanel();
            this.dgvBuyView = new MyControls.MyGridView();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeSetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyInEmpNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyBillIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeSetIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyInEmpIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyInDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBuy = new System.Windows.Forms.BindingSource(this.components);
            this.okBillPanel = new MyControls.MyPanel();
            this.btnBillCancel = new System.Windows.Forms.Button();
            this.btnBillOK = new System.Windows.Forms.Button();
            this.modelPanel = new MyControls.MyPanel();
            this.inbModelUnits = new MyControls.IntegerBox();
            this.cmbModelSizeSet = new MyControls.ComboList();
            this.inbModelSets = new MyControls.IntegerBox();
            this.cmbBrand = new MyControls.ComboList();
            this.bsBrandView = new System.Windows.Forms.BindingSource(this.components);
            this.dcbModelCost = new MyControls.CurrencyBox();
            this.dcbModelPrice = new MyControls.CurrencyBox();
            this.cmbModel = new MyControls.ComboText();
            this.bsModel = new System.Windows.Forms.BindingSource(this.components);
            this.panProduct0 = new MyControls.MyPanel();
            this.txtRemark0 = new MyControls.StrBox();
            this.cmbColor0 = new MyControls.ComboList();
            this.cmbSizeSet0 = new MyControls.ComboList();
            this.dcbCost0 = new MyControls.CurrencyBox();
            this.inbSets0 = new MyControls.IntegerBox();
            this.inbUnits0 = new MyControls.IntegerBox();
            this.dcbAmount0 = new MyControls.CurrencyBox();
            this.panSize0 = new MyControls.MyPanel();
            this.cmbSize05 = new MyControls.ComboList();
            this.cmbSize00 = new MyControls.ComboList();
            this.inbUnitSize05 = new MyControls.IntegerBox();
            this.inbUnitSize02 = new MyControls.IntegerBox();
            this.inbUnitSize04 = new MyControls.IntegerBox();
            this.inbUnitSize03 = new MyControls.IntegerBox();
            this.inbUnitSize00 = new MyControls.IntegerBox();
            this.cmbSize04 = new MyControls.ComboList();
            this.inbUnitSize01 = new MyControls.IntegerBox();
            this.cmbSize01 = new MyControls.ComboList();
            this.cmbSize03 = new MyControls.ComboList();
            this.cmbSize02 = new MyControls.ComboList();
            this.panProduct1 = new MyControls.MyPanel();
            this.txtRemark1 = new MyControls.StrBox();
            this.cmbSizeSet1 = new MyControls.ComboList();
            this.dcbCost1 = new MyControls.CurrencyBox();
            this.inbSets1 = new MyControls.IntegerBox();
            this.cmbColor1 = new MyControls.ComboList();
            this.dcbAmount1 = new MyControls.CurrencyBox();
            this.inbUnits1 = new MyControls.IntegerBox();
            this.panSize1 = new MyControls.MyPanel();
            this.cmbSize15 = new MyControls.ComboList();
            this.cmbSize10 = new MyControls.ComboList();
            this.cmbSize11 = new MyControls.ComboList();
            this.inbUnitSize11 = new MyControls.IntegerBox();
            this.cmbSize13 = new MyControls.ComboList();
            this.inbUnitSize15 = new MyControls.IntegerBox();
            this.cmbSize14 = new MyControls.ComboList();
            this.inbUnitSize12 = new MyControls.IntegerBox();
            this.inbUnitSize14 = new MyControls.IntegerBox();
            this.inbUnitSize13 = new MyControls.IntegerBox();
            this.inbUnitSize10 = new MyControls.IntegerBox();
            this.cmbSize12 = new MyControls.ComboList();
            this.panProduct2 = new MyControls.MyPanel();
            this.txtRemark2 = new MyControls.StrBox();
            this.inbUnits2 = new MyControls.IntegerBox();
            this.dcbCost2 = new MyControls.CurrencyBox();
            this.dcbAmount2 = new MyControls.CurrencyBox();
            this.cmbSizeSet2 = new MyControls.ComboList();
            this.cmbColor2 = new MyControls.ComboList();
            this.inbSets2 = new MyControls.IntegerBox();
            this.panSize2 = new MyControls.MyPanel();
            this.cmbSize25 = new MyControls.ComboList();
            this.cmbSize20 = new MyControls.ComboList();
            this.inbUnitSize25 = new MyControls.IntegerBox();
            this.inbUnitSize21 = new MyControls.IntegerBox();
            this.inbUnitSize24 = new MyControls.IntegerBox();
            this.inbUnitSize22 = new MyControls.IntegerBox();
            this.inbUnitSize20 = new MyControls.IntegerBox();
            this.inbUnitSize23 = new MyControls.IntegerBox();
            this.cmbSize22 = new MyControls.ComboList();
            this.cmbSize24 = new MyControls.ComboList();
            this.cmbSize21 = new MyControls.ComboList();
            this.cmbSize23 = new MyControls.ComboList();
            this.panProduct3 = new MyControls.MyPanel();
            this.txtRemark3 = new MyControls.StrBox();
            this.dcbCost3 = new MyControls.CurrencyBox();
            this.cmbSizeSet3 = new MyControls.ComboList();
            this.cmbColor3 = new MyControls.ComboList();
            this.inbSets3 = new MyControls.IntegerBox();
            this.inbUnits3 = new MyControls.IntegerBox();
            this.dcbAmount3 = new MyControls.CurrencyBox();
            this.panSize3 = new MyControls.MyPanel();
            this.inbUnitSize35 = new MyControls.IntegerBox();
            this.cmbSize35 = new MyControls.ComboList();
            this.inbUnitSize31 = new MyControls.IntegerBox();
            this.inbUnitSize34 = new MyControls.IntegerBox();
            this.cmbSize30 = new MyControls.ComboList();
            this.inbUnitSize30 = new MyControls.IntegerBox();
            this.inbUnitSize32 = new MyControls.IntegerBox();
            this.cmbSize32 = new MyControls.ComboList();
            this.inbUnitSize33 = new MyControls.IntegerBox();
            this.cmbSize34 = new MyControls.ComboList();
            this.cmbSize33 = new MyControls.ComboList();
            this.cmbSize31 = new MyControls.ComboList();
            this.panFootItem = new MyControls.MyPanel();
            this.currencyBox3 = new MyControls.CurrencyBox();
            this.btnOKItem = new System.Windows.Forms.Button();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.BottomPanel = new MyControls.MyPanel();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.dcbBilltotal = new MyControls.CurrencyBox();
            this.cmbCheckEmpEdit = new MyControls.ComboList();
            this.bsBuyBill = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.dcbBillAmount = new MyControls.CurrencyBox();
            this.dcbDiscount = new MyControls.CurrencyBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.cmbCheckEmpView = new MyControls.ComboList();
            this.cmbModelInfoEmpEdit = new MyControls.ComboList();
            this.cmbModelInfoEmpView = new MyControls.ComboList();
            this.cmbBarcodeEmp2Edit = new MyControls.ComboList();
            this.cmbBarcodeEmp2View = new MyControls.ComboList();
            this.cmbBarcodeEmpEdit = new MyControls.ComboList();
            this.cmbBarcodeEmpView = new MyControls.ComboList();
            this.headPanel = new MyControls.MyPanel();
            this.buyBillnav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.billInfoPanel = new MyControls.MyPanel();
            this.cmbKeyInEmp = new MyControls.ComboList();
            this.txtKeyInDateTime = new MyControls.StrBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.txtkeyInEmpName = new MyControls.StrBox();
            this.txtUpdated = new MyControls.StrBox();
            this.inbID = new MyControls.StrBox();
            this.txtDeviceName = new MyControls.StrBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtpBillDate = new MyControls.DateBox();
            this.txtBillRemark = new MyControls.StrBox();
            this.cmbSupplier = new MyControls.ComboList();
            this.cmbBranch = new MyControls.ComboList();
            this.button1 = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            label26 = new System.Windows.Forms.Label();
            label25 = new System.Windows.Forms.Label();
            label27 = new System.Windows.Forms.Label();
            modelInfoEmpIDLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            checkEmpIDLabel = new System.Windows.Forms.Label();
            barcodeEmpIDLabel = new System.Windows.Forms.Label();
            discountLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            lblUpdated = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            billDateLabel = new System.Windows.Forms.Label();
            branchIDLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.myPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuy)).BeginInit();
            this.okBillPanel.SuspendLayout();
            this.modelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBrandView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModel)).BeginInit();
            this.panProduct0.SuspendLayout();
            this.panSize0.SuspendLayout();
            this.panProduct1.SuspendLayout();
            this.panSize1.SuspendLayout();
            this.panProduct2.SuspendLayout();
            this.panSize2.SuspendLayout();
            this.panProduct3.SuspendLayout();
            this.panSize3.SuspendLayout();
            this.panFootItem.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuyBill)).BeginInit();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyBillnav)).BeginInit();
            this.buyBillnav.SuspendLayout();
            this.billInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(1, 7);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 16);
            label4.TabIndex = 10;
            label4.Text = "ยี่ห้อ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(753, 7);
            label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(49, 16);
            label19.TabIndex = 96;
            label19.Text = "ราคาขาย";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(580, 7);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 16);
            label3.TabIndex = 9;
            label3.Text = "หมายเหตุ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(69, 7);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 16);
            label5.TabIndex = 11;
            label5.Text = "รุ่น (Model)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(340, 5);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(25, 16);
            label10.TabIndex = 16;
            label10.Text = "เซ็ต";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(199, 7);
            label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(54, 16);
            label18.TabIndex = 94;
            label18.Text = "size-set";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(526, 7);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(24, 16);
            label11.TabIndex = 70;
            label11.Text = "เงิน";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(447, 7);
            label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(37, 16);
            label8.TabIndex = 14;
            label8.Text = "ต้นทุน";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(386, 5);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(39, 16);
            label12.TabIndex = 72;
            label12.Text = "จำนวน";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(160, 9);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(32, 16);
            label15.TabIndex = 78;
            label15.Text = "size";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(153, 42);
            label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(39, 16);
            label16.TabIndex = 90;
            label16.Text = "จำนวน";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(153, 42);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(39, 16);
            label9.TabIndex = 90;
            label9.Text = "จำนวน";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(160, 8);
            label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(32, 16);
            label20.TabIndex = 78;
            label20.Text = "size";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(160, 8);
            label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(32, 16);
            label23.TabIndex = 78;
            label23.Text = "size";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(153, 42);
            label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(39, 16);
            label22.TabIndex = 90;
            label22.Text = "จำนวน";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new System.Drawing.Point(160, 10);
            label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new System.Drawing.Size(32, 16);
            label26.TabIndex = 78;
            label26.Text = "size";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new System.Drawing.Point(153, 40);
            label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label25.Name = "label25";
            label25.Size = new System.Drawing.Size(39, 16);
            label25.TabIndex = 90;
            label25.Text = "จำนวน";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new System.Drawing.Point(436, 16);
            label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label27.Name = "label27";
            label27.Size = new System.Drawing.Size(60, 16);
            label27.TabIndex = 103;
            label27.Text = "รวมเป็นเงิน";
            // 
            // modelInfoEmpIDLabel
            // 
            modelInfoEmpIDLabel.AutoSize = true;
            modelInfoEmpIDLabel.Location = new System.Drawing.Point(767, 17);
            modelInfoEmpIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            modelInfoEmpIDLabel.Name = "modelInfoEmpIDLabel";
            modelInfoEmpIDLabel.Size = new System.Drawing.Size(60, 16);
            modelInfoEmpIDLabel.TabIndex = 17;
            modelInfoEmpIDLabel.Text = "ข้อมูลสินค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(409, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(43, 16);
            label2.TabIndex = 33;
            label2.Text = "รวมบิล:";
            // 
            // checkEmpIDLabel
            // 
            checkEmpIDLabel.AutoSize = true;
            checkEmpIDLabel.Location = new System.Drawing.Point(580, 17);
            checkEmpIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            checkEmpIDLabel.Name = "checkEmpIDLabel";
            checkEmpIDLabel.Size = new System.Drawing.Size(59, 16);
            checkEmpIDLabel.TabIndex = 11;
            checkEmpIDLabel.Text = "เช็คของเข้า";
            // 
            // barcodeEmpIDLabel
            // 
            barcodeEmpIDLabel.AutoSize = true;
            barcodeEmpIDLabel.Location = new System.Drawing.Point(671, 17);
            barcodeEmpIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            barcodeEmpIDLabel.Name = "barcodeEmpIDLabel";
            barcodeEmpIDLabel.Size = new System.Drawing.Size(48, 16);
            barcodeEmpIDLabel.TabIndex = 5;
            barcodeEmpIDLabel.Text = "บาร์โค้ด:";
            // 
            // discountLabel1
            // 
            discountLabel1.AutoSize = true;
            discountLabel1.Location = new System.Drawing.Point(409, 36);
            discountLabel1.Name = "discountLabel1";
            discountLabel1.Size = new System.Drawing.Size(44, 16);
            discountLabel1.TabIndex = 20;
            discountLabel1.Text = "ส่วนลด:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(409, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 16);
            label1.TabIndex = 31;
            label1.Text = "จำนวนเงิน:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(6, 67);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(36, 16);
            label28.TabIndex = 104;
            label28.Text = "เครื่อง";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(20, 37);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(21, 16);
            label24.TabIndex = 103;
            label24.Text = "คีย์";
            // 
            // lblUpdated
            // 
            lblUpdated.AutoSize = true;
            lblUpdated.Location = new System.Drawing.Point(229, 36);
            lblUpdated.Name = "lblUpdated";
            lblUpdated.Size = new System.Drawing.Size(42, 16);
            lblUpdated.TabIndex = 100;
            lblUpdated.Text = "เพิ่มเมื่อ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(229, 69);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(73, 16);
            label21.TabIndex = 101;
            label21.Text = "แก้ไขล่าสุดเมื่อ";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(214, 56);
            supplierIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(75, 16);
            supplierIDLabel.TabIndex = 19;
            supplierIDLabel.Text = "supplier ID:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(15, 107);
            remarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(55, 16);
            remarkLabel.TabIndex = 1;
            remarkLabel.Text = "หมายเหตุ:";
            // 
            // billDateLabel
            // 
            billDateLabel.AutoSize = true;
            billDateLabel.Location = new System.Drawing.Point(381, 58);
            billDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            billDateLabel.Name = "billDateLabel";
            billDateLabel.Size = new System.Drawing.Size(60, 16);
            billDateLabel.TabIndex = 9;
            billDateLabel.Text = "bill Date:";
            // 
            // branchIDLabel
            // 
            branchIDLabel.AutoSize = true;
            branchIDLabel.Location = new System.Drawing.Point(15, 59);
            branchIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            branchIDLabel.Name = "branchIDLabel";
            branchIDLabel.Size = new System.Drawing.Size(47, 16);
            branchIDLabel.TabIndex = 3;
            branchIDLabel.Text = "ของลงที่";
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.myPanel2);
            this.leftPanel.Controls.Add(this.okBillPanel);
            this.leftPanel.Controls.Add(this.modelPanel);
            this.leftPanel.Controls.Add(this.panProduct0);
            this.leftPanel.Controls.Add(this.panSize0);
            this.leftPanel.Controls.Add(this.panProduct1);
            this.leftPanel.Controls.Add(this.panSize1);
            this.leftPanel.Controls.Add(this.panProduct2);
            this.leftPanel.Controls.Add(this.panSize2);
            this.leftPanel.Controls.Add(this.panProduct3);
            this.leftPanel.Controls.Add(this.panSize3);
            this.leftPanel.Controls.Add(this.panFootItem);
            this.leftPanel.Controls.Add(this.BottomPanel);
            this.leftPanel.Controls.Add(this.headPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanel.Size = new System.Drawing.Size(852, 1061);
            this.leftPanel.TabIndex = 23;
            // 
            // myPanel2
            // 
            this.myPanel2.Controls.Add(this.dgvBuyView);
            this.myPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myPanel2.Location = new System.Drawing.Point(10, 195);
            this.myPanel2.Name = "myPanel2";
            this.myPanel2.Size = new System.Drawing.Size(832, 260);
            this.myPanel2.TabIndex = 22;
            // 
            // dgvBuyView
            // 
            this.dgvBuyView.AllowUserToAddRows = false;
            this.dgvBuyView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            this.dgvBuyView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuyView.AutoGenerateColumns = false;
            this.dgvBuyView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvBuyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandNameDataGridViewTextBoxColumn,
            this.modelCodeDataGridViewTextBoxColumn,
            this.colorNameDataGridViewTextBoxColumn,
            this.sizeSetNameDataGridViewTextBoxColumn,
            this.deviceNameDataGridViewTextBoxColumn,
            this.keyInEmpNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.buyBillIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.setsDataGridViewTextBoxColumn,
            this.sizeSetIDDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
            this.deviceIDDataGridViewTextBoxColumn,
            this.keyInEmpIDDataGridViewTextBoxColumn,
            this.keyInDateTimeDataGridViewTextBoxColumn,
            this.updatedDataGridViewTextBoxColumn,
            this.updateByDataGridViewTextBoxColumn});
            this.dgvBuyView.DataSource = this.bsBuy;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBuyView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBuyView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBuyView.Location = new System.Drawing.Point(0, 0);
            this.dgvBuyView.Name = "dgvBuyView";
            this.dgvBuyView.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Bisque;
            this.dgvBuyView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBuyView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuyView.Size = new System.Drawing.Size(832, 260);
            this.dgvBuyView.TabIndex = 0;
            this.dgvBuyView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuyView_CellContentClick);
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "brandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "brandName";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelCodeDataGridViewTextBoxColumn
            // 
            this.modelCodeDataGridViewTextBoxColumn.DataPropertyName = "modelCode";
            this.modelCodeDataGridViewTextBoxColumn.HeaderText = "modelCode";
            this.modelCodeDataGridViewTextBoxColumn.Name = "modelCodeDataGridViewTextBoxColumn";
            this.modelCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorNameDataGridViewTextBoxColumn
            // 
            this.colorNameDataGridViewTextBoxColumn.DataPropertyName = "colorName";
            this.colorNameDataGridViewTextBoxColumn.HeaderText = "colorName";
            this.colorNameDataGridViewTextBoxColumn.Name = "colorNameDataGridViewTextBoxColumn";
            this.colorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeSetNameDataGridViewTextBoxColumn
            // 
            this.sizeSetNameDataGridViewTextBoxColumn.DataPropertyName = "sizeSetName";
            this.sizeSetNameDataGridViewTextBoxColumn.HeaderText = "sizeSetName";
            this.sizeSetNameDataGridViewTextBoxColumn.Name = "sizeSetNameDataGridViewTextBoxColumn";
            this.sizeSetNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceNameDataGridViewTextBoxColumn
            // 
            this.deviceNameDataGridViewTextBoxColumn.DataPropertyName = "deviceName";
            this.deviceNameDataGridViewTextBoxColumn.HeaderText = "deviceName";
            this.deviceNameDataGridViewTextBoxColumn.Name = "deviceNameDataGridViewTextBoxColumn";
            this.deviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyInEmpNameDataGridViewTextBoxColumn
            // 
            this.keyInEmpNameDataGridViewTextBoxColumn.DataPropertyName = "keyInEmpName";
            this.keyInEmpNameDataGridViewTextBoxColumn.HeaderText = "keyInEmpName";
            this.keyInEmpNameDataGridViewTextBoxColumn.Name = "keyInEmpNameDataGridViewTextBoxColumn";
            this.keyInEmpNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buyBillIDDataGridViewTextBoxColumn
            // 
            this.buyBillIDDataGridViewTextBoxColumn.DataPropertyName = "buyBillID";
            this.buyBillIDDataGridViewTextBoxColumn.HeaderText = "buyBillID";
            this.buyBillIDDataGridViewTextBoxColumn.Name = "buyBillIDDataGridViewTextBoxColumn";
            this.buyBillIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // setsDataGridViewTextBoxColumn
            // 
            this.setsDataGridViewTextBoxColumn.DataPropertyName = "sets";
            this.setsDataGridViewTextBoxColumn.HeaderText = "sets";
            this.setsDataGridViewTextBoxColumn.Name = "setsDataGridViewTextBoxColumn";
            this.setsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeSetIDDataGridViewTextBoxColumn
            // 
            this.sizeSetIDDataGridViewTextBoxColumn.DataPropertyName = "sizeSetID";
            this.sizeSetIDDataGridViewTextBoxColumn.HeaderText = "sizeSetID";
            this.sizeSetIDDataGridViewTextBoxColumn.Name = "sizeSetIDDataGridViewTextBoxColumn";
            this.sizeSetIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "remark";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deviceIDDataGridViewTextBoxColumn
            // 
            this.deviceIDDataGridViewTextBoxColumn.DataPropertyName = "deviceID";
            this.deviceIDDataGridViewTextBoxColumn.HeaderText = "deviceID";
            this.deviceIDDataGridViewTextBoxColumn.Name = "deviceIDDataGridViewTextBoxColumn";
            this.deviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyInEmpIDDataGridViewTextBoxColumn
            // 
            this.keyInEmpIDDataGridViewTextBoxColumn.DataPropertyName = "keyInEmpID";
            this.keyInEmpIDDataGridViewTextBoxColumn.HeaderText = "keyInEmpID";
            this.keyInEmpIDDataGridViewTextBoxColumn.Name = "keyInEmpIDDataGridViewTextBoxColumn";
            this.keyInEmpIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyInDateTimeDataGridViewTextBoxColumn
            // 
            this.keyInDateTimeDataGridViewTextBoxColumn.DataPropertyName = "keyInDateTime";
            this.keyInDateTimeDataGridViewTextBoxColumn.HeaderText = "keyInDateTime";
            this.keyInDateTimeDataGridViewTextBoxColumn.Name = "keyInDateTimeDataGridViewTextBoxColumn";
            this.keyInDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedDataGridViewTextBoxColumn
            // 
            this.updatedDataGridViewTextBoxColumn.DataPropertyName = "updated";
            this.updatedDataGridViewTextBoxColumn.HeaderText = "updated";
            this.updatedDataGridViewTextBoxColumn.Name = "updatedDataGridViewTextBoxColumn";
            this.updatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateByDataGridViewTextBoxColumn
            // 
            this.updateByDataGridViewTextBoxColumn.DataPropertyName = "updateBy";
            this.updateByDataGridViewTextBoxColumn.HeaderText = "updateBy";
            this.updateByDataGridViewTextBoxColumn.Name = "updateByDataGridViewTextBoxColumn";
            this.updateByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBuy
            // 
            this.bsBuy.DataSource = typeof(PointOfSale.DbClass.BuyView);
            // 
            // okBillPanel
            // 
            this.okBillPanel.Controls.Add(this.btnBillCancel);
            this.okBillPanel.Controls.Add(this.btnBillOK);
            this.okBillPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.okBillPanel.Location = new System.Drawing.Point(10, 151);
            this.okBillPanel.Name = "okBillPanel";
            this.okBillPanel.Padding = new System.Windows.Forms.Padding(5);
            this.okBillPanel.Size = new System.Drawing.Size(832, 44);
            this.okBillPanel.TabIndex = 1;
            this.okBillPanel.Visible = false;
            // 
            // btnBillCancel
            // 
            this.btnBillCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnBillCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBillCancel.ForeColor = System.Drawing.Color.White;
            this.btnBillCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnBillCancel.Image")));
            this.btnBillCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillCancel.Location = new System.Drawing.Point(364, 0);
            this.btnBillCancel.Name = "btnBillCancel";
            this.btnBillCancel.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.btnBillCancel.Size = new System.Drawing.Size(120, 42);
            this.btnBillCancel.TabIndex = 63;
            this.btnBillCancel.Text = "CANCEL";
            this.btnBillCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBillCancel.UseVisualStyleBackColor = false;
            this.btnBillCancel.Click += new System.EventHandler(this.btnBillCancel_Click);
            // 
            // btnBillOK
            // 
            this.btnBillOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBillOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBillOK.ForeColor = System.Drawing.Color.White;
            this.btnBillOK.Image = ((System.Drawing.Image)(resources.GetObject("btnBillOK.Image")));
            this.btnBillOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillOK.Location = new System.Drawing.Point(217, 0);
            this.btnBillOK.Name = "btnBillOK";
            this.btnBillOK.Padding = new System.Windows.Forms.Padding(8, 8, 25, 8);
            this.btnBillOK.Size = new System.Drawing.Size(120, 43);
            this.btnBillOK.TabIndex = 62;
            this.btnBillOK.Text = "OK";
            this.btnBillOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBillOK.UseVisualStyleBackColor = false;
            this.btnBillOK.Click += new System.EventHandler(this.btnBillOK_Click);
            // 
            // modelPanel
            // 
            this.modelPanel.Controls.Add(label4);
            this.modelPanel.Controls.Add(label19);
            this.modelPanel.Controls.Add(label3);
            this.modelPanel.Controls.Add(this.inbModelUnits);
            this.modelPanel.Controls.Add(label5);
            this.modelPanel.Controls.Add(label10);
            this.modelPanel.Controls.Add(this.cmbModelSizeSet);
            this.modelPanel.Controls.Add(this.inbModelSets);
            this.modelPanel.Controls.Add(label18);
            this.modelPanel.Controls.Add(label11);
            this.modelPanel.Controls.Add(this.cmbBrand);
            this.modelPanel.Controls.Add(this.dcbModelCost);
            this.modelPanel.Controls.Add(label8);
            this.modelPanel.Controls.Add(label12);
            this.modelPanel.Controls.Add(this.dcbModelPrice);
            this.modelPanel.Controls.Add(this.cmbModel);
            this.modelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.modelPanel.Location = new System.Drawing.Point(10, 455);
            this.modelPanel.Name = "modelPanel";
            this.modelPanel.Size = new System.Drawing.Size(832, 53);
            this.modelPanel.TabIndex = 21;
            this.modelPanel.Visible = false;
            // 
            // inbModelUnits
            // 
            this.inbModelUnits.Cue = null;
            this.inbModelUnits.Location = new System.Drawing.Point(382, 26);
            this.inbModelUnits.Name = "inbModelUnits";
            this.inbModelUnits.ReadOnly = true;
            this.inbModelUnits.Size = new System.Drawing.Size(46, 22);
            this.inbModelUnits.TabIndex = 99;
            this.inbModelUnits.Text = "1";
            this.inbModelUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbModelUnits.Value = 0;
            // 
            // cmbModelSizeSet
            // 
            this.cmbModelSizeSet.Cue = null;
            this.cmbModelSizeSet.DisplayMember = "name";
            this.cmbModelSizeSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelSizeSet.FormattingEnabled = true;
            this.cmbModelSizeSet.Location = new System.Drawing.Point(202, 26);
            this.cmbModelSizeSet.Name = "cmbModelSizeSet";
            this.cmbModelSizeSet.Size = new System.Drawing.Size(120, 24);
            this.cmbModelSizeSet.TabIndex = 93;
            this.cmbModelSizeSet.ValueMember = "id";
            this.cmbModelSizeSet.SelectedValueChanged += new System.EventHandler(this.cmbModelSizeSet_SelectedValueChanged);
            // 
            // inbModelSets
            // 
            this.inbModelSets.Cue = null;
            this.inbModelSets.Location = new System.Drawing.Point(332, 26);
            this.inbModelSets.Name = "inbModelSets";
            this.inbModelSets.ReadOnly = true;
            this.inbModelSets.Size = new System.Drawing.Size(40, 22);
            this.inbModelSets.TabIndex = 98;
            this.inbModelSets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbModelSets.Value = 0;
            // 
            // cmbBrand
            // 
            this.cmbBrand.Cue = null;
            this.cmbBrand.DataSource = this.bsBrandView;
            this.cmbBrand.DisplayMember = "name";
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(0, 26);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(62, 24);
            this.cmbBrand.TabIndex = 1;
            this.cmbBrand.ValueMember = "id";
            this.cmbBrand.SelectedIndexChanged += new System.EventHandler(this.ProductPanel_Leave);
            this.cmbBrand.SelectedValueChanged += new System.EventHandler(this.cmbBrand_SelectedValueChanged);
            // 
            // bsBrandView
            // 
            this.bsBrandView.DataSource = typeof(PointOfSale.DbClass.BrandView);
            // 
            // dcbModelCost
            // 
            this.dcbModelCost.Cue = null;
            this.dcbModelCost.FormatString = "C2";
            this.dcbModelCost.Location = new System.Drawing.Point(438, 26);
            this.dcbModelCost.Name = "dcbModelCost";
            this.dcbModelCost.Size = new System.Drawing.Size(55, 22);
            this.dcbModelCost.TabIndex = 97;
            this.dcbModelCost.Text = "฿0.00";
            this.dcbModelCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbModelCost.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.dcbModelCost.TextChanged += new System.EventHandler(this.dcbModelCost_TextChanged);
            // 
            // dcbModelPrice
            // 
            this.dcbModelPrice.Cue = null;
            this.dcbModelPrice.FormatString = "C2";
            this.dcbModelPrice.Location = new System.Drawing.Point(756, 26);
            this.dcbModelPrice.Name = "dcbModelPrice";
            this.dcbModelPrice.Size = new System.Drawing.Size(76, 22);
            this.dcbModelPrice.TabIndex = 95;
            this.dcbModelPrice.Text = "฿0.00";
            this.dcbModelPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbModelPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbModel
            // 
            this.cmbModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbModel.Cue = null;
            this.cmbModel.DataSource = this.bsModel;
            this.cmbModel.DisplayMember = "name";
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.isAlwaysDropperDown = false;
            this.cmbModel.Location = new System.Drawing.Point(72, 26);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(120, 24);
            this.cmbModel.TabIndex = 2;
            this.cmbModel.ValueMember = "id";
            this.cmbModel.TextChanged += new System.EventHandler(this.cmbModel_TextChanged);
            this.cmbModel.Click += new System.EventHandler(this.cmbModel_Click);
            this.cmbModel.Enter += new System.EventHandler(this.cmbModel_Enter);
            this.cmbModel.Leave += new System.EventHandler(this.cmbModel_Leave);
            // 
            // bsModel
            // 
            this.bsModel.DataMember = "modelCodes";
            this.bsModel.DataSource = this.bsBrandView;
            // 
            // panProduct0
            // 
            this.panProduct0.Controls.Add(this.txtRemark0);
            this.panProduct0.Controls.Add(this.cmbColor0);
            this.panProduct0.Controls.Add(this.cmbSizeSet0);
            this.panProduct0.Controls.Add(this.dcbCost0);
            this.panProduct0.Controls.Add(this.inbSets0);
            this.panProduct0.Controls.Add(this.inbUnits0);
            this.panProduct0.Controls.Add(this.dcbAmount0);
            this.panProduct0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panProduct0.Location = new System.Drawing.Point(10, 508);
            this.panProduct0.Name = "panProduct0";
            this.panProduct0.Size = new System.Drawing.Size(832, 32);
            this.panProduct0.TabIndex = 20;
            this.panProduct0.Visible = false;
            this.panProduct0.Enter += new System.EventHandler(this.ProductPanel_Enter);
            this.panProduct0.Leave += new System.EventHandler(this.ProductPanel_Leave);
            // 
            // txtRemark0
            // 
            this.txtRemark0.Cue = null;
            this.txtRemark0.Location = new System.Drawing.Point(583, 6);
            this.txtRemark0.Name = "txtRemark0";
            this.txtRemark0.Size = new System.Drawing.Size(249, 22);
            this.txtRemark0.TabIndex = 8;
            // 
            // cmbColor0
            // 
            this.cmbColor0.Cue = null;
            this.cmbColor0.DisplayMember = "name";
            this.cmbColor0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor0.FormattingEnabled = true;
            this.cmbColor0.Location = new System.Drawing.Point(132, 5);
            this.cmbColor0.Name = "cmbColor0";
            this.cmbColor0.Size = new System.Drawing.Size(60, 24);
            this.cmbColor0.TabIndex = 5;
            this.cmbColor0.ValueMember = "id";
            this.cmbColor0.Leave += new System.EventHandler(this.cmbColor_Leave);
            // 
            // cmbSizeSet0
            // 
            this.cmbSizeSet0.Cue = null;
            this.cmbSizeSet0.DisplayMember = "name";
            this.cmbSizeSet0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeSet0.FormattingEnabled = true;
            this.cmbSizeSet0.Location = new System.Drawing.Point(202, 6);
            this.cmbSizeSet0.Name = "cmbSizeSet0";
            this.cmbSizeSet0.Size = new System.Drawing.Size(120, 24);
            this.cmbSizeSet0.TabIndex = 3;
            this.cmbSizeSet0.ValueMember = "id";
            this.cmbSizeSet0.SelectedIndexChanged += new System.EventHandler(this.cmbSizeSet_SelectedIndexChanged);
            this.cmbSizeSet0.SelectedValueChanged += new System.EventHandler(this.cmbSizeSet_SelectedValueChanged);
            // 
            // dcbCost0
            // 
            this.dcbCost0.Cue = null;
            this.dcbCost0.FormatString = "C2";
            this.dcbCost0.Location = new System.Drawing.Point(438, 6);
            this.dcbCost0.Name = "dcbCost0";
            this.dcbCost0.Size = new System.Drawing.Size(55, 22);
            this.dcbCost0.TabIndex = 6;
            this.dcbCost0.Text = "฿0.00";
            this.dcbCost0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbCost0.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // inbSets0
            // 
            this.inbSets0.Cue = null;
            this.inbSets0.Location = new System.Drawing.Point(332, 6);
            this.inbSets0.Name = "inbSets0";
            this.inbSets0.Size = new System.Drawing.Size(40, 22);
            this.inbSets0.TabIndex = 4;
            this.inbSets0.Text = "1";
            this.inbSets0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbSets0.Value = 0;
            this.inbSets0.TextChanged += new System.EventHandler(this.inbSets_TextChanged);
            // 
            // inbUnits0
            // 
            this.inbUnits0.Cue = null;
            this.inbUnits0.Location = new System.Drawing.Point(382, 6);
            this.inbUnits0.Name = "inbUnits0";
            this.inbUnits0.ReadOnly = true;
            this.inbUnits0.Size = new System.Drawing.Size(46, 22);
            this.inbUnits0.TabIndex = 92;
            this.inbUnits0.Text = "1";
            this.inbUnits0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnits0.Value = 0;
            // 
            // dcbAmount0
            // 
            this.dcbAmount0.Cue = null;
            this.dcbAmount0.FormatString = "C2";
            this.dcbAmount0.Location = new System.Drawing.Point(503, 6);
            this.dcbAmount0.Name = "dcbAmount0";
            this.dcbAmount0.ReadOnly = true;
            this.dcbAmount0.Size = new System.Drawing.Size(70, 22);
            this.dcbAmount0.TabIndex = 69;
            this.dcbAmount0.Text = "฿0.00";
            this.dcbAmount0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbAmount0.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // panSize0
            // 
            this.panSize0.Controls.Add(this.cmbSize05);
            this.panSize0.Controls.Add(this.cmbSize00);
            this.panSize0.Controls.Add(this.inbUnitSize05);
            this.panSize0.Controls.Add(this.inbUnitSize02);
            this.panSize0.Controls.Add(this.inbUnitSize04);
            this.panSize0.Controls.Add(this.inbUnitSize03);
            this.panSize0.Controls.Add(this.inbUnitSize00);
            this.panSize0.Controls.Add(this.cmbSize04);
            this.panSize0.Controls.Add(this.inbUnitSize01);
            this.panSize0.Controls.Add(this.cmbSize01);
            this.panSize0.Controls.Add(label15);
            this.panSize0.Controls.Add(this.cmbSize03);
            this.panSize0.Controls.Add(this.cmbSize02);
            this.panSize0.Controls.Add(label16);
            this.panSize0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panSize0.Location = new System.Drawing.Point(10, 540);
            this.panSize0.Name = "panSize0";
            this.panSize0.Size = new System.Drawing.Size(832, 66);
            this.panSize0.TabIndex = 19;
            this.panSize0.Visible = false;
            // 
            // cmbSize05
            // 
            this.cmbSize05.Cue = null;
            this.cmbSize05.DisplayMember = "id";
            this.cmbSize05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize05.Enabled = false;
            this.cmbSize05.FormattingEnabled = true;
            this.cmbSize05.Location = new System.Drawing.Point(452, 6);
            this.cmbSize05.Name = "cmbSize05";
            this.cmbSize05.Size = new System.Drawing.Size(40, 24);
            this.cmbSize05.TabIndex = 100;
            this.cmbSize05.ValueMember = "id";
            // 
            // cmbSize00
            // 
            this.cmbSize00.Cue = null;
            this.cmbSize00.DisplayMember = "id";
            this.cmbSize00.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize00.Enabled = false;
            this.cmbSize00.FormattingEnabled = true;
            this.cmbSize00.Location = new System.Drawing.Point(202, 6);
            this.cmbSize00.Name = "cmbSize00";
            this.cmbSize00.Size = new System.Drawing.Size(40, 24);
            this.cmbSize00.TabIndex = 101;
            this.cmbSize00.ValueMember = "id";
            // 
            // inbUnitSize05
            // 
            this.inbUnitSize05.Cue = null;
            this.inbUnitSize05.Location = new System.Drawing.Point(452, 39);
            this.inbUnitSize05.Name = "inbUnitSize05";
            this.inbUnitSize05.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize05.TabIndex = 95;
            this.inbUnitSize05.Text = "1";
            this.inbUnitSize05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize05.Value = 0;
            // 
            // inbUnitSize02
            // 
            this.inbUnitSize02.Cue = null;
            this.inbUnitSize02.Location = new System.Drawing.Point(302, 39);
            this.inbUnitSize02.Name = "inbUnitSize02";
            this.inbUnitSize02.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize02.TabIndex = 85;
            this.inbUnitSize02.Text = "1";
            this.inbUnitSize02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize02.Value = 0;
            // 
            // inbUnitSize04
            // 
            this.inbUnitSize04.Cue = null;
            this.inbUnitSize04.Location = new System.Drawing.Point(402, 39);
            this.inbUnitSize04.Name = "inbUnitSize04";
            this.inbUnitSize04.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize04.TabIndex = 94;
            this.inbUnitSize04.Text = "1";
            this.inbUnitSize04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize04.Value = 0;
            // 
            // inbUnitSize03
            // 
            this.inbUnitSize03.Cue = null;
            this.inbUnitSize03.Location = new System.Drawing.Point(352, 39);
            this.inbUnitSize03.Name = "inbUnitSize03";
            this.inbUnitSize03.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize03.TabIndex = 86;
            this.inbUnitSize03.Text = "1";
            this.inbUnitSize03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize03.Value = 0;
            // 
            // inbUnitSize00
            // 
            this.inbUnitSize00.Cue = null;
            this.inbUnitSize00.Location = new System.Drawing.Point(202, 39);
            this.inbUnitSize00.Name = "inbUnitSize00";
            this.inbUnitSize00.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize00.TabIndex = 96;
            this.inbUnitSize00.Text = "1";
            this.inbUnitSize00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize00.Value = 0;
            // 
            // cmbSize04
            // 
            this.cmbSize04.Cue = null;
            this.cmbSize04.DisplayMember = "id";
            this.cmbSize04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize04.Enabled = false;
            this.cmbSize04.FormattingEnabled = true;
            this.cmbSize04.Location = new System.Drawing.Point(402, 6);
            this.cmbSize04.Name = "cmbSize04";
            this.cmbSize04.Size = new System.Drawing.Size(40, 24);
            this.cmbSize04.TabIndex = 99;
            this.cmbSize04.ValueMember = "id";
            // 
            // inbUnitSize01
            // 
            this.inbUnitSize01.Cue = null;
            this.inbUnitSize01.Location = new System.Drawing.Point(252, 39);
            this.inbUnitSize01.Name = "inbUnitSize01";
            this.inbUnitSize01.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize01.TabIndex = 84;
            this.inbUnitSize01.Text = "1";
            this.inbUnitSize01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize01.Value = 0;
            // 
            // cmbSize01
            // 
            this.cmbSize01.Cue = null;
            this.cmbSize01.DisplayMember = "id";
            this.cmbSize01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize01.FormattingEnabled = true;
            this.cmbSize01.Location = new System.Drawing.Point(252, 6);
            this.cmbSize01.Name = "cmbSize01";
            this.cmbSize01.Size = new System.Drawing.Size(40, 24);
            this.cmbSize01.TabIndex = 77;
            this.cmbSize01.ValueMember = "id";
            // 
            // cmbSize03
            // 
            this.cmbSize03.Cue = null;
            this.cmbSize03.DisplayMember = "id";
            this.cmbSize03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize03.Enabled = false;
            this.cmbSize03.FormattingEnabled = true;
            this.cmbSize03.Location = new System.Drawing.Point(352, 6);
            this.cmbSize03.Name = "cmbSize03";
            this.cmbSize03.Size = new System.Drawing.Size(40, 24);
            this.cmbSize03.TabIndex = 98;
            this.cmbSize03.ValueMember = "id";
            // 
            // cmbSize02
            // 
            this.cmbSize02.Cue = null;
            this.cmbSize02.DisplayMember = "id";
            this.cmbSize02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize02.Enabled = false;
            this.cmbSize02.FormattingEnabled = true;
            this.cmbSize02.Location = new System.Drawing.Point(302, 6);
            this.cmbSize02.Name = "cmbSize02";
            this.cmbSize02.Size = new System.Drawing.Size(40, 24);
            this.cmbSize02.TabIndex = 97;
            this.cmbSize02.ValueMember = "id";
            // 
            // panProduct1
            // 
            this.panProduct1.Controls.Add(this.txtRemark1);
            this.panProduct1.Controls.Add(this.cmbSizeSet1);
            this.panProduct1.Controls.Add(this.dcbCost1);
            this.panProduct1.Controls.Add(this.inbSets1);
            this.panProduct1.Controls.Add(this.cmbColor1);
            this.panProduct1.Controls.Add(this.dcbAmount1);
            this.panProduct1.Controls.Add(this.inbUnits1);
            this.panProduct1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panProduct1.Location = new System.Drawing.Point(10, 606);
            this.panProduct1.Name = "panProduct1";
            this.panProduct1.Size = new System.Drawing.Size(832, 32);
            this.panProduct1.TabIndex = 18;
            this.panProduct1.Visible = false;
            this.panProduct1.Enter += new System.EventHandler(this.ProductPanel_Enter);
            this.panProduct1.Leave += new System.EventHandler(this.ProductPanel_Leave);
            // 
            // txtRemark1
            // 
            this.txtRemark1.Cue = null;
            this.txtRemark1.Location = new System.Drawing.Point(583, 5);
            this.txtRemark1.Name = "txtRemark1";
            this.txtRemark1.Size = new System.Drawing.Size(249, 22);
            this.txtRemark1.TabIndex = 8;
            // 
            // cmbSizeSet1
            // 
            this.cmbSizeSet1.Cue = null;
            this.cmbSizeSet1.DisplayMember = "name";
            this.cmbSizeSet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeSet1.FormattingEnabled = true;
            this.cmbSizeSet1.Location = new System.Drawing.Point(202, 5);
            this.cmbSizeSet1.Name = "cmbSizeSet1";
            this.cmbSizeSet1.Size = new System.Drawing.Size(120, 24);
            this.cmbSizeSet1.TabIndex = 3;
            this.cmbSizeSet1.ValueMember = "id";
            this.cmbSizeSet1.SelectedValueChanged += new System.EventHandler(this.cmbSizeSet_SelectedValueChanged);
            // 
            // dcbCost1
            // 
            this.dcbCost1.Cue = null;
            this.dcbCost1.FormatString = "C2";
            this.dcbCost1.Location = new System.Drawing.Point(438, 5);
            this.dcbCost1.Name = "dcbCost1";
            this.dcbCost1.Size = new System.Drawing.Size(55, 22);
            this.dcbCost1.TabIndex = 6;
            this.dcbCost1.Text = "฿0.00";
            this.dcbCost1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbCost1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // inbSets1
            // 
            this.inbSets1.Cue = null;
            this.inbSets1.Location = new System.Drawing.Point(332, 5);
            this.inbSets1.Name = "inbSets1";
            this.inbSets1.Size = new System.Drawing.Size(40, 22);
            this.inbSets1.TabIndex = 4;
            this.inbSets1.Text = "1";
            this.inbSets1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbSets1.Value = 0;
            // 
            // cmbColor1
            // 
            this.cmbColor1.Cue = null;
            this.cmbColor1.DisplayMember = "name";
            this.cmbColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor1.FormattingEnabled = true;
            this.cmbColor1.Location = new System.Drawing.Point(132, 5);
            this.cmbColor1.Name = "cmbColor1";
            this.cmbColor1.Size = new System.Drawing.Size(60, 24);
            this.cmbColor1.TabIndex = 5;
            this.cmbColor1.ValueMember = "id";
            // 
            // dcbAmount1
            // 
            this.dcbAmount1.Cue = null;
            this.dcbAmount1.FormatString = "C2";
            this.dcbAmount1.Location = new System.Drawing.Point(503, 5);
            this.dcbAmount1.Name = "dcbAmount1";
            this.dcbAmount1.ReadOnly = true;
            this.dcbAmount1.Size = new System.Drawing.Size(70, 22);
            this.dcbAmount1.TabIndex = 69;
            this.dcbAmount1.Text = "฿0.00";
            this.dcbAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbAmount1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // inbUnits1
            // 
            this.inbUnits1.Cue = null;
            this.inbUnits1.Location = new System.Drawing.Point(382, 5);
            this.inbUnits1.Name = "inbUnits1";
            this.inbUnits1.ReadOnly = true;
            this.inbUnits1.Size = new System.Drawing.Size(46, 22);
            this.inbUnits1.TabIndex = 92;
            this.inbUnits1.Text = "1";
            this.inbUnits1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnits1.Value = 0;
            // 
            // panSize1
            // 
            this.panSize1.Controls.Add(label9);
            this.panSize1.Controls.Add(this.cmbSize15);
            this.panSize1.Controls.Add(this.cmbSize10);
            this.panSize1.Controls.Add(this.cmbSize11);
            this.panSize1.Controls.Add(this.inbUnitSize11);
            this.panSize1.Controls.Add(this.cmbSize13);
            this.panSize1.Controls.Add(this.inbUnitSize15);
            this.panSize1.Controls.Add(this.cmbSize14);
            this.panSize1.Controls.Add(this.inbUnitSize12);
            this.panSize1.Controls.Add(this.inbUnitSize14);
            this.panSize1.Controls.Add(this.inbUnitSize13);
            this.panSize1.Controls.Add(this.inbUnitSize10);
            this.panSize1.Controls.Add(this.cmbSize12);
            this.panSize1.Controls.Add(label20);
            this.panSize1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panSize1.Location = new System.Drawing.Point(10, 638);
            this.panSize1.Name = "panSize1";
            this.panSize1.Size = new System.Drawing.Size(832, 66);
            this.panSize1.TabIndex = 17;
            this.panSize1.Visible = false;
            // 
            // cmbSize15
            // 
            this.cmbSize15.Cue = null;
            this.cmbSize15.DisplayMember = "id";
            this.cmbSize15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize15.Enabled = false;
            this.cmbSize15.FormattingEnabled = true;
            this.cmbSize15.Location = new System.Drawing.Point(452, 5);
            this.cmbSize15.Name = "cmbSize15";
            this.cmbSize15.Size = new System.Drawing.Size(40, 24);
            this.cmbSize15.TabIndex = 100;
            this.cmbSize15.ValueMember = "id";
            // 
            // cmbSize10
            // 
            this.cmbSize10.Cue = null;
            this.cmbSize10.DisplayMember = "id";
            this.cmbSize10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize10.Enabled = false;
            this.cmbSize10.FormattingEnabled = true;
            this.cmbSize10.Location = new System.Drawing.Point(202, 5);
            this.cmbSize10.Name = "cmbSize10";
            this.cmbSize10.Size = new System.Drawing.Size(40, 24);
            this.cmbSize10.TabIndex = 101;
            this.cmbSize10.ValueMember = "id";
            // 
            // cmbSize11
            // 
            this.cmbSize11.Cue = null;
            this.cmbSize11.DisplayMember = "id";
            this.cmbSize11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize11.FormattingEnabled = true;
            this.cmbSize11.Location = new System.Drawing.Point(252, 5);
            this.cmbSize11.Name = "cmbSize11";
            this.cmbSize11.Size = new System.Drawing.Size(40, 24);
            this.cmbSize11.TabIndex = 77;
            this.cmbSize11.ValueMember = "id";
            // 
            // inbUnitSize11
            // 
            this.inbUnitSize11.Cue = null;
            this.inbUnitSize11.Location = new System.Drawing.Point(252, 39);
            this.inbUnitSize11.Name = "inbUnitSize11";
            this.inbUnitSize11.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize11.TabIndex = 84;
            this.inbUnitSize11.Text = "1";
            this.inbUnitSize11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize11.Value = 0;
            // 
            // cmbSize13
            // 
            this.cmbSize13.Cue = null;
            this.cmbSize13.DisplayMember = "id";
            this.cmbSize13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize13.Enabled = false;
            this.cmbSize13.FormattingEnabled = true;
            this.cmbSize13.Location = new System.Drawing.Point(352, 5);
            this.cmbSize13.Name = "cmbSize13";
            this.cmbSize13.Size = new System.Drawing.Size(40, 24);
            this.cmbSize13.TabIndex = 98;
            this.cmbSize13.ValueMember = "id";
            // 
            // inbUnitSize15
            // 
            this.inbUnitSize15.Cue = null;
            this.inbUnitSize15.Location = new System.Drawing.Point(452, 39);
            this.inbUnitSize15.Name = "inbUnitSize15";
            this.inbUnitSize15.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize15.TabIndex = 95;
            this.inbUnitSize15.Text = "1";
            this.inbUnitSize15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize15.Value = 0;
            // 
            // cmbSize14
            // 
            this.cmbSize14.Cue = null;
            this.cmbSize14.DisplayMember = "id";
            this.cmbSize14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize14.Enabled = false;
            this.cmbSize14.FormattingEnabled = true;
            this.cmbSize14.Location = new System.Drawing.Point(402, 5);
            this.cmbSize14.Name = "cmbSize14";
            this.cmbSize14.Size = new System.Drawing.Size(40, 24);
            this.cmbSize14.TabIndex = 99;
            this.cmbSize14.ValueMember = "id";
            // 
            // inbUnitSize12
            // 
            this.inbUnitSize12.Cue = null;
            this.inbUnitSize12.Location = new System.Drawing.Point(302, 39);
            this.inbUnitSize12.Name = "inbUnitSize12";
            this.inbUnitSize12.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize12.TabIndex = 85;
            this.inbUnitSize12.Text = "1";
            this.inbUnitSize12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize12.Value = 0;
            // 
            // inbUnitSize14
            // 
            this.inbUnitSize14.Cue = null;
            this.inbUnitSize14.Location = new System.Drawing.Point(402, 39);
            this.inbUnitSize14.Name = "inbUnitSize14";
            this.inbUnitSize14.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize14.TabIndex = 94;
            this.inbUnitSize14.Text = "1";
            this.inbUnitSize14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize14.Value = 0;
            // 
            // inbUnitSize13
            // 
            this.inbUnitSize13.Cue = null;
            this.inbUnitSize13.Location = new System.Drawing.Point(352, 39);
            this.inbUnitSize13.Name = "inbUnitSize13";
            this.inbUnitSize13.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize13.TabIndex = 86;
            this.inbUnitSize13.Text = "1";
            this.inbUnitSize13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize13.Value = 0;
            // 
            // inbUnitSize10
            // 
            this.inbUnitSize10.Cue = null;
            this.inbUnitSize10.Location = new System.Drawing.Point(202, 39);
            this.inbUnitSize10.Name = "inbUnitSize10";
            this.inbUnitSize10.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize10.TabIndex = 96;
            this.inbUnitSize10.Text = "1";
            this.inbUnitSize10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize10.Value = 0;
            // 
            // cmbSize12
            // 
            this.cmbSize12.Cue = null;
            this.cmbSize12.DisplayMember = "id";
            this.cmbSize12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize12.Enabled = false;
            this.cmbSize12.FormattingEnabled = true;
            this.cmbSize12.Location = new System.Drawing.Point(302, 5);
            this.cmbSize12.Name = "cmbSize12";
            this.cmbSize12.Size = new System.Drawing.Size(40, 24);
            this.cmbSize12.TabIndex = 97;
            this.cmbSize12.ValueMember = "id";
            // 
            // panProduct2
            // 
            this.panProduct2.Controls.Add(this.txtRemark2);
            this.panProduct2.Controls.Add(this.inbUnits2);
            this.panProduct2.Controls.Add(this.dcbCost2);
            this.panProduct2.Controls.Add(this.dcbAmount2);
            this.panProduct2.Controls.Add(this.cmbSizeSet2);
            this.panProduct2.Controls.Add(this.cmbColor2);
            this.panProduct2.Controls.Add(this.inbSets2);
            this.panProduct2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panProduct2.Location = new System.Drawing.Point(10, 704);
            this.panProduct2.Name = "panProduct2";
            this.panProduct2.Size = new System.Drawing.Size(832, 32);
            this.panProduct2.TabIndex = 16;
            this.panProduct2.Visible = false;
            this.panProduct2.Enter += new System.EventHandler(this.ProductPanel_Enter);
            this.panProduct2.Leave += new System.EventHandler(this.ProductPanel_Leave);
            // 
            // txtRemark2
            // 
            this.txtRemark2.Cue = null;
            this.txtRemark2.Location = new System.Drawing.Point(583, 5);
            this.txtRemark2.Name = "txtRemark2";
            this.txtRemark2.Size = new System.Drawing.Size(249, 22);
            this.txtRemark2.TabIndex = 8;
            // 
            // inbUnits2
            // 
            this.inbUnits2.Cue = null;
            this.inbUnits2.Location = new System.Drawing.Point(382, 5);
            this.inbUnits2.Name = "inbUnits2";
            this.inbUnits2.ReadOnly = true;
            this.inbUnits2.Size = new System.Drawing.Size(46, 22);
            this.inbUnits2.TabIndex = 92;
            this.inbUnits2.Text = "1";
            this.inbUnits2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnits2.Value = 0;
            // 
            // dcbCost2
            // 
            this.dcbCost2.Cue = null;
            this.dcbCost2.FormatString = "C2";
            this.dcbCost2.Location = new System.Drawing.Point(438, 5);
            this.dcbCost2.Name = "dcbCost2";
            this.dcbCost2.Size = new System.Drawing.Size(55, 22);
            this.dcbCost2.TabIndex = 6;
            this.dcbCost2.Text = "฿0.00";
            this.dcbCost2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbCost2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dcbAmount2
            // 
            this.dcbAmount2.Cue = null;
            this.dcbAmount2.FormatString = "C2";
            this.dcbAmount2.Location = new System.Drawing.Point(503, 5);
            this.dcbAmount2.Name = "dcbAmount2";
            this.dcbAmount2.ReadOnly = true;
            this.dcbAmount2.Size = new System.Drawing.Size(70, 22);
            this.dcbAmount2.TabIndex = 69;
            this.dcbAmount2.Text = "฿0.00";
            this.dcbAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbAmount2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbSizeSet2
            // 
            this.cmbSizeSet2.Cue = null;
            this.cmbSizeSet2.DisplayMember = "name";
            this.cmbSizeSet2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeSet2.FormattingEnabled = true;
            this.cmbSizeSet2.Location = new System.Drawing.Point(202, 5);
            this.cmbSizeSet2.Name = "cmbSizeSet2";
            this.cmbSizeSet2.Size = new System.Drawing.Size(120, 24);
            this.cmbSizeSet2.TabIndex = 3;
            this.cmbSizeSet2.ValueMember = "id";
            this.cmbSizeSet2.SelectedValueChanged += new System.EventHandler(this.cmbSizeSet_SelectedValueChanged);
            // 
            // cmbColor2
            // 
            this.cmbColor2.Cue = null;
            this.cmbColor2.DisplayMember = "name";
            this.cmbColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor2.FormattingEnabled = true;
            this.cmbColor2.Location = new System.Drawing.Point(132, 5);
            this.cmbColor2.Name = "cmbColor2";
            this.cmbColor2.Size = new System.Drawing.Size(60, 24);
            this.cmbColor2.TabIndex = 5;
            this.cmbColor2.ValueMember = "id";
            // 
            // inbSets2
            // 
            this.inbSets2.Cue = null;
            this.inbSets2.Location = new System.Drawing.Point(332, 5);
            this.inbSets2.Name = "inbSets2";
            this.inbSets2.Size = new System.Drawing.Size(40, 22);
            this.inbSets2.TabIndex = 4;
            this.inbSets2.Text = "1";
            this.inbSets2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbSets2.Value = 0;
            // 
            // panSize2
            // 
            this.panSize2.Controls.Add(this.cmbSize25);
            this.panSize2.Controls.Add(label23);
            this.panSize2.Controls.Add(this.cmbSize20);
            this.panSize2.Controls.Add(this.inbUnitSize25);
            this.panSize2.Controls.Add(this.inbUnitSize21);
            this.panSize2.Controls.Add(this.inbUnitSize24);
            this.panSize2.Controls.Add(this.inbUnitSize22);
            this.panSize2.Controls.Add(this.inbUnitSize20);
            this.panSize2.Controls.Add(this.inbUnitSize23);
            this.panSize2.Controls.Add(this.cmbSize22);
            this.panSize2.Controls.Add(this.cmbSize24);
            this.panSize2.Controls.Add(label22);
            this.panSize2.Controls.Add(this.cmbSize21);
            this.panSize2.Controls.Add(this.cmbSize23);
            this.panSize2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panSize2.Location = new System.Drawing.Point(10, 736);
            this.panSize2.Name = "panSize2";
            this.panSize2.Size = new System.Drawing.Size(832, 66);
            this.panSize2.TabIndex = 15;
            this.panSize2.Visible = false;
            // 
            // cmbSize25
            // 
            this.cmbSize25.Cue = null;
            this.cmbSize25.DisplayMember = "id";
            this.cmbSize25.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize25.Enabled = false;
            this.cmbSize25.FormattingEnabled = true;
            this.cmbSize25.Location = new System.Drawing.Point(452, 5);
            this.cmbSize25.Name = "cmbSize25";
            this.cmbSize25.Size = new System.Drawing.Size(40, 24);
            this.cmbSize25.TabIndex = 100;
            this.cmbSize25.ValueMember = "id";
            // 
            // cmbSize20
            // 
            this.cmbSize20.Cue = null;
            this.cmbSize20.DisplayMember = "id";
            this.cmbSize20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize20.Enabled = false;
            this.cmbSize20.FormattingEnabled = true;
            this.cmbSize20.Location = new System.Drawing.Point(202, 5);
            this.cmbSize20.Name = "cmbSize20";
            this.cmbSize20.Size = new System.Drawing.Size(40, 24);
            this.cmbSize20.TabIndex = 101;
            this.cmbSize20.ValueMember = "id";
            // 
            // inbUnitSize25
            // 
            this.inbUnitSize25.Cue = null;
            this.inbUnitSize25.Location = new System.Drawing.Point(452, 39);
            this.inbUnitSize25.Name = "inbUnitSize25";
            this.inbUnitSize25.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize25.TabIndex = 95;
            this.inbUnitSize25.Text = "1";
            this.inbUnitSize25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize25.Value = 0;
            // 
            // inbUnitSize21
            // 
            this.inbUnitSize21.Cue = null;
            this.inbUnitSize21.Location = new System.Drawing.Point(252, 39);
            this.inbUnitSize21.Name = "inbUnitSize21";
            this.inbUnitSize21.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize21.TabIndex = 84;
            this.inbUnitSize21.Text = "1";
            this.inbUnitSize21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize21.Value = 0;
            // 
            // inbUnitSize24
            // 
            this.inbUnitSize24.Cue = null;
            this.inbUnitSize24.Location = new System.Drawing.Point(402, 39);
            this.inbUnitSize24.Name = "inbUnitSize24";
            this.inbUnitSize24.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize24.TabIndex = 94;
            this.inbUnitSize24.Text = "1";
            this.inbUnitSize24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize24.Value = 0;
            // 
            // inbUnitSize22
            // 
            this.inbUnitSize22.Cue = null;
            this.inbUnitSize22.Location = new System.Drawing.Point(302, 39);
            this.inbUnitSize22.Name = "inbUnitSize22";
            this.inbUnitSize22.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize22.TabIndex = 85;
            this.inbUnitSize22.Text = "1";
            this.inbUnitSize22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize22.Value = 0;
            // 
            // inbUnitSize20
            // 
            this.inbUnitSize20.Cue = null;
            this.inbUnitSize20.Location = new System.Drawing.Point(202, 39);
            this.inbUnitSize20.Name = "inbUnitSize20";
            this.inbUnitSize20.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize20.TabIndex = 96;
            this.inbUnitSize20.Text = "1";
            this.inbUnitSize20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize20.Value = 0;
            // 
            // inbUnitSize23
            // 
            this.inbUnitSize23.Cue = null;
            this.inbUnitSize23.Location = new System.Drawing.Point(352, 39);
            this.inbUnitSize23.Name = "inbUnitSize23";
            this.inbUnitSize23.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize23.TabIndex = 86;
            this.inbUnitSize23.Text = "1";
            this.inbUnitSize23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize23.Value = 0;
            // 
            // cmbSize22
            // 
            this.cmbSize22.Cue = null;
            this.cmbSize22.DisplayMember = "id";
            this.cmbSize22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize22.Enabled = false;
            this.cmbSize22.FormattingEnabled = true;
            this.cmbSize22.Location = new System.Drawing.Point(302, 5);
            this.cmbSize22.Name = "cmbSize22";
            this.cmbSize22.Size = new System.Drawing.Size(40, 24);
            this.cmbSize22.TabIndex = 97;
            this.cmbSize22.ValueMember = "id";
            // 
            // cmbSize24
            // 
            this.cmbSize24.Cue = null;
            this.cmbSize24.DisplayMember = "id";
            this.cmbSize24.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize24.Enabled = false;
            this.cmbSize24.FormattingEnabled = true;
            this.cmbSize24.Location = new System.Drawing.Point(402, 5);
            this.cmbSize24.Name = "cmbSize24";
            this.cmbSize24.Size = new System.Drawing.Size(40, 24);
            this.cmbSize24.TabIndex = 99;
            this.cmbSize24.ValueMember = "id";
            // 
            // cmbSize21
            // 
            this.cmbSize21.Cue = null;
            this.cmbSize21.DisplayMember = "id";
            this.cmbSize21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize21.FormattingEnabled = true;
            this.cmbSize21.Location = new System.Drawing.Point(252, 5);
            this.cmbSize21.Name = "cmbSize21";
            this.cmbSize21.Size = new System.Drawing.Size(40, 24);
            this.cmbSize21.TabIndex = 77;
            this.cmbSize21.ValueMember = "id";
            // 
            // cmbSize23
            // 
            this.cmbSize23.Cue = null;
            this.cmbSize23.DisplayMember = "id";
            this.cmbSize23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize23.Enabled = false;
            this.cmbSize23.FormattingEnabled = true;
            this.cmbSize23.Location = new System.Drawing.Point(352, 5);
            this.cmbSize23.Name = "cmbSize23";
            this.cmbSize23.Size = new System.Drawing.Size(40, 24);
            this.cmbSize23.TabIndex = 98;
            this.cmbSize23.ValueMember = "id";
            // 
            // panProduct3
            // 
            this.panProduct3.Controls.Add(this.txtRemark3);
            this.panProduct3.Controls.Add(this.dcbCost3);
            this.panProduct3.Controls.Add(this.cmbSizeSet3);
            this.panProduct3.Controls.Add(this.cmbColor3);
            this.panProduct3.Controls.Add(this.inbSets3);
            this.panProduct3.Controls.Add(this.inbUnits3);
            this.panProduct3.Controls.Add(this.dcbAmount3);
            this.panProduct3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panProduct3.Location = new System.Drawing.Point(10, 802);
            this.panProduct3.Name = "panProduct3";
            this.panProduct3.Size = new System.Drawing.Size(832, 32);
            this.panProduct3.TabIndex = 14;
            this.panProduct3.Visible = false;
            this.panProduct3.Enter += new System.EventHandler(this.ProductPanel_Enter);
            this.panProduct3.Leave += new System.EventHandler(this.ProductPanel_Leave);
            // 
            // txtRemark3
            // 
            this.txtRemark3.Cue = null;
            this.txtRemark3.Location = new System.Drawing.Point(583, 5);
            this.txtRemark3.Name = "txtRemark3";
            this.txtRemark3.Size = new System.Drawing.Size(249, 22);
            this.txtRemark3.TabIndex = 8;
            // 
            // dcbCost3
            // 
            this.dcbCost3.Cue = null;
            this.dcbCost3.FormatString = "C2";
            this.dcbCost3.Location = new System.Drawing.Point(438, 5);
            this.dcbCost3.Name = "dcbCost3";
            this.dcbCost3.Size = new System.Drawing.Size(55, 22);
            this.dcbCost3.TabIndex = 6;
            this.dcbCost3.Text = "฿0.00";
            this.dcbCost3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbCost3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbSizeSet3
            // 
            this.cmbSizeSet3.Cue = null;
            this.cmbSizeSet3.DisplayMember = "name";
            this.cmbSizeSet3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeSet3.FormattingEnabled = true;
            this.cmbSizeSet3.Location = new System.Drawing.Point(202, 5);
            this.cmbSizeSet3.Name = "cmbSizeSet3";
            this.cmbSizeSet3.Size = new System.Drawing.Size(120, 24);
            this.cmbSizeSet3.TabIndex = 3;
            this.cmbSizeSet3.ValueMember = "id";
            this.cmbSizeSet3.SelectedValueChanged += new System.EventHandler(this.cmbSizeSet_SelectedValueChanged);
            // 
            // cmbColor3
            // 
            this.cmbColor3.Cue = null;
            this.cmbColor3.DisplayMember = "name";
            this.cmbColor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor3.FormattingEnabled = true;
            this.cmbColor3.Location = new System.Drawing.Point(132, 5);
            this.cmbColor3.Name = "cmbColor3";
            this.cmbColor3.Size = new System.Drawing.Size(60, 24);
            this.cmbColor3.TabIndex = 5;
            this.cmbColor3.ValueMember = "id";
            // 
            // inbSets3
            // 
            this.inbSets3.Cue = null;
            this.inbSets3.Location = new System.Drawing.Point(332, 5);
            this.inbSets3.Name = "inbSets3";
            this.inbSets3.Size = new System.Drawing.Size(40, 22);
            this.inbSets3.TabIndex = 4;
            this.inbSets3.Text = "1";
            this.inbSets3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbSets3.Value = 0;
            // 
            // inbUnits3
            // 
            this.inbUnits3.Cue = null;
            this.inbUnits3.Location = new System.Drawing.Point(382, 5);
            this.inbUnits3.Name = "inbUnits3";
            this.inbUnits3.ReadOnly = true;
            this.inbUnits3.Size = new System.Drawing.Size(46, 22);
            this.inbUnits3.TabIndex = 92;
            this.inbUnits3.Text = "1";
            this.inbUnits3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnits3.Value = 0;
            // 
            // dcbAmount3
            // 
            this.dcbAmount3.Cue = null;
            this.dcbAmount3.FormatString = "C2";
            this.dcbAmount3.Location = new System.Drawing.Point(503, 5);
            this.dcbAmount3.Name = "dcbAmount3";
            this.dcbAmount3.ReadOnly = true;
            this.dcbAmount3.Size = new System.Drawing.Size(70, 22);
            this.dcbAmount3.TabIndex = 69;
            this.dcbAmount3.Text = "฿0.00";
            this.dcbAmount3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbAmount3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // panSize3
            // 
            this.panSize3.Controls.Add(this.inbUnitSize35);
            this.panSize3.Controls.Add(this.cmbSize35);
            this.panSize3.Controls.Add(this.inbUnitSize31);
            this.panSize3.Controls.Add(this.inbUnitSize34);
            this.panSize3.Controls.Add(this.cmbSize30);
            this.panSize3.Controls.Add(this.inbUnitSize30);
            this.panSize3.Controls.Add(this.inbUnitSize32);
            this.panSize3.Controls.Add(label26);
            this.panSize3.Controls.Add(this.cmbSize32);
            this.panSize3.Controls.Add(this.inbUnitSize33);
            this.panSize3.Controls.Add(label25);
            this.panSize3.Controls.Add(this.cmbSize34);
            this.panSize3.Controls.Add(this.cmbSize33);
            this.panSize3.Controls.Add(this.cmbSize31);
            this.panSize3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panSize3.Location = new System.Drawing.Point(10, 834);
            this.panSize3.Name = "panSize3";
            this.panSize3.Size = new System.Drawing.Size(832, 66);
            this.panSize3.TabIndex = 13;
            this.panSize3.Visible = false;
            // 
            // inbUnitSize35
            // 
            this.inbUnitSize35.Cue = null;
            this.inbUnitSize35.Location = new System.Drawing.Point(452, 39);
            this.inbUnitSize35.Name = "inbUnitSize35";
            this.inbUnitSize35.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize35.TabIndex = 95;
            this.inbUnitSize35.Text = "1";
            this.inbUnitSize35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize35.Value = 0;
            // 
            // cmbSize35
            // 
            this.cmbSize35.Cue = null;
            this.cmbSize35.DisplayMember = "id";
            this.cmbSize35.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize35.Enabled = false;
            this.cmbSize35.FormattingEnabled = true;
            this.cmbSize35.Location = new System.Drawing.Point(452, 5);
            this.cmbSize35.Name = "cmbSize35";
            this.cmbSize35.Size = new System.Drawing.Size(40, 24);
            this.cmbSize35.TabIndex = 100;
            this.cmbSize35.ValueMember = "id";
            // 
            // inbUnitSize31
            // 
            this.inbUnitSize31.Cue = null;
            this.inbUnitSize31.Location = new System.Drawing.Point(252, 39);
            this.inbUnitSize31.Name = "inbUnitSize31";
            this.inbUnitSize31.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize31.TabIndex = 84;
            this.inbUnitSize31.Text = "1";
            this.inbUnitSize31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize31.Value = 0;
            // 
            // inbUnitSize34
            // 
            this.inbUnitSize34.Cue = null;
            this.inbUnitSize34.Location = new System.Drawing.Point(402, 39);
            this.inbUnitSize34.Name = "inbUnitSize34";
            this.inbUnitSize34.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize34.TabIndex = 94;
            this.inbUnitSize34.Text = "1";
            this.inbUnitSize34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize34.Value = 0;
            // 
            // cmbSize30
            // 
            this.cmbSize30.Cue = null;
            this.cmbSize30.DisplayMember = "id";
            this.cmbSize30.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize30.Enabled = false;
            this.cmbSize30.FormattingEnabled = true;
            this.cmbSize30.Location = new System.Drawing.Point(202, 5);
            this.cmbSize30.Name = "cmbSize30";
            this.cmbSize30.Size = new System.Drawing.Size(40, 24);
            this.cmbSize30.TabIndex = 101;
            this.cmbSize30.ValueMember = "id";
            // 
            // inbUnitSize30
            // 
            this.inbUnitSize30.Cue = null;
            this.inbUnitSize30.Location = new System.Drawing.Point(202, 39);
            this.inbUnitSize30.Name = "inbUnitSize30";
            this.inbUnitSize30.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize30.TabIndex = 96;
            this.inbUnitSize30.Text = "1";
            this.inbUnitSize30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize30.Value = 0;
            // 
            // inbUnitSize32
            // 
            this.inbUnitSize32.Cue = null;
            this.inbUnitSize32.Location = new System.Drawing.Point(302, 39);
            this.inbUnitSize32.Name = "inbUnitSize32";
            this.inbUnitSize32.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize32.TabIndex = 85;
            this.inbUnitSize32.Text = "1";
            this.inbUnitSize32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize32.Value = 0;
            // 
            // cmbSize32
            // 
            this.cmbSize32.Cue = null;
            this.cmbSize32.DisplayMember = "id";
            this.cmbSize32.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize32.Enabled = false;
            this.cmbSize32.FormattingEnabled = true;
            this.cmbSize32.Location = new System.Drawing.Point(302, 5);
            this.cmbSize32.Name = "cmbSize32";
            this.cmbSize32.Size = new System.Drawing.Size(40, 24);
            this.cmbSize32.TabIndex = 97;
            this.cmbSize32.ValueMember = "id";
            // 
            // inbUnitSize33
            // 
            this.inbUnitSize33.Cue = null;
            this.inbUnitSize33.Location = new System.Drawing.Point(352, 39);
            this.inbUnitSize33.Name = "inbUnitSize33";
            this.inbUnitSize33.Size = new System.Drawing.Size(40, 22);
            this.inbUnitSize33.TabIndex = 86;
            this.inbUnitSize33.Text = "1";
            this.inbUnitSize33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inbUnitSize33.Value = 0;
            // 
            // cmbSize34
            // 
            this.cmbSize34.Cue = null;
            this.cmbSize34.DisplayMember = "id";
            this.cmbSize34.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize34.Enabled = false;
            this.cmbSize34.FormattingEnabled = true;
            this.cmbSize34.Location = new System.Drawing.Point(402, 5);
            this.cmbSize34.Name = "cmbSize34";
            this.cmbSize34.Size = new System.Drawing.Size(40, 24);
            this.cmbSize34.TabIndex = 99;
            this.cmbSize34.ValueMember = "id";
            // 
            // cmbSize33
            // 
            this.cmbSize33.Cue = null;
            this.cmbSize33.DisplayMember = "id";
            this.cmbSize33.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize33.Enabled = false;
            this.cmbSize33.FormattingEnabled = true;
            this.cmbSize33.Location = new System.Drawing.Point(352, 5);
            this.cmbSize33.Name = "cmbSize33";
            this.cmbSize33.Size = new System.Drawing.Size(40, 24);
            this.cmbSize33.TabIndex = 98;
            this.cmbSize33.ValueMember = "id";
            // 
            // cmbSize31
            // 
            this.cmbSize31.Cue = null;
            this.cmbSize31.DisplayMember = "id";
            this.cmbSize31.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize31.FormattingEnabled = true;
            this.cmbSize31.Location = new System.Drawing.Point(252, 5);
            this.cmbSize31.Name = "cmbSize31";
            this.cmbSize31.Size = new System.Drawing.Size(40, 24);
            this.cmbSize31.TabIndex = 77;
            this.cmbSize31.ValueMember = "id";
            // 
            // panFootItem
            // 
            this.panFootItem.Controls.Add(this.currencyBox3);
            this.panFootItem.Controls.Add(label27);
            this.panFootItem.Controls.Add(this.btnOKItem);
            this.panFootItem.Controls.Add(this.btnCancelItem);
            this.panFootItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFootItem.Location = new System.Drawing.Point(10, 900);
            this.panFootItem.Name = "panFootItem";
            this.panFootItem.Size = new System.Drawing.Size(832, 52);
            this.panFootItem.TabIndex = 12;
            this.panFootItem.Visible = false;
            // 
            // currencyBox3
            // 
            this.currencyBox3.Cue = null;
            this.currencyBox3.FormatString = "C2";
            this.currencyBox3.Location = new System.Drawing.Point(503, 13);
            this.currencyBox3.Name = "currencyBox3";
            this.currencyBox3.ReadOnly = true;
            this.currencyBox3.Size = new System.Drawing.Size(70, 22);
            this.currencyBox3.TabIndex = 70;
            this.currencyBox3.Text = "฿0.00";
            this.currencyBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.currencyBox3.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // btnOKItem
            // 
            this.btnOKItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOKItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOKItem.ForeColor = System.Drawing.Color.White;
            this.btnOKItem.Image = ((System.Drawing.Image)(resources.GetObject("btnOKItem.Image")));
            this.btnOKItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOKItem.Location = new System.Drawing.Point(583, 3);
            this.btnOKItem.Name = "btnOKItem";
            this.btnOKItem.Padding = new System.Windows.Forms.Padding(8, 8, 25, 8);
            this.btnOKItem.Size = new System.Drawing.Size(120, 43);
            this.btnOKItem.TabIndex = 64;
            this.btnOKItem.Text = "OK";
            this.btnOKItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOKItem.UseVisualStyleBackColor = false;
            this.btnOKItem.Click += new System.EventHandler(this.btnOKItem_Click);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancelItem.ForeColor = System.Drawing.Color.White;
            this.btnCancelItem.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelItem.Image")));
            this.btnCancelItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelItem.Location = new System.Drawing.Point(712, 4);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Padding = new System.Windows.Forms.Padding(8, 8, 0, 8);
            this.btnCancelItem.Size = new System.Drawing.Size(120, 42);
            this.btnCancelItem.TabIndex = 65;
            this.btnCancelItem.Text = "CANCEL";
            this.btnCancelItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.btnEditItem);
            this.BottomPanel.Controls.Add(modelInfoEmpIDLabel);
            this.BottomPanel.Controls.Add(this.dcbBilltotal);
            this.BottomPanel.Controls.Add(this.cmbCheckEmpEdit);
            this.BottomPanel.Controls.Add(label2);
            this.BottomPanel.Controls.Add(checkEmpIDLabel);
            this.BottomPanel.Controls.Add(this.btnDeleteItem);
            this.BottomPanel.Controls.Add(barcodeEmpIDLabel);
            this.BottomPanel.Controls.Add(this.dcbBillAmount);
            this.BottomPanel.Controls.Add(this.dcbDiscount);
            this.BottomPanel.Controls.Add(this.btnAddNewItem);
            this.BottomPanel.Controls.Add(discountLabel1);
            this.BottomPanel.Controls.Add(label1);
            this.BottomPanel.Controls.Add(this.cmbCheckEmpView);
            this.BottomPanel.Controls.Add(this.cmbModelInfoEmpEdit);
            this.BottomPanel.Controls.Add(this.cmbModelInfoEmpView);
            this.BottomPanel.Controls.Add(this.cmbBarcodeEmp2Edit);
            this.BottomPanel.Controls.Add(this.cmbBarcodeEmp2View);
            this.BottomPanel.Controls.Add(this.cmbBarcodeEmpEdit);
            this.BottomPanel.Controls.Add(this.cmbBarcodeEmpView);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(10, 952);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(832, 99);
            this.BottomPanel.TabIndex = 11;
            // 
            // btnEditItem
            // 
            this.btnEditItem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEditItem.ForeColor = System.Drawing.Color.White;
            this.btnEditItem.Image = global::PointOfSale.Properties.Resources.EditItem;
            this.btnEditItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditItem.Location = new System.Drawing.Point(141, 5);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Padding = new System.Windows.Forms.Padding(8);
            this.btnEditItem.Size = new System.Drawing.Size(95, 43);
            this.btnEditItem.TabIndex = 95;
            this.btnEditItem.Text = "แก้";
            this.btnEditItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditItem.UseVisualStyleBackColor = false;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // dcbBilltotal
            // 
            this.dcbBilltotal.Cue = null;
            this.dcbBilltotal.FormatString = "C0";
            this.dcbBilltotal.Location = new System.Drawing.Point(473, 69);
            this.dcbBilltotal.Name = "dcbBilltotal";
            this.dcbBilltotal.ReadOnly = true;
            this.dcbBilltotal.Size = new System.Drawing.Size(100, 22);
            this.dcbBilltotal.TabIndex = 34;
            this.dcbBilltotal.Text = "฿0";
            this.dcbBilltotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbBilltotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cmbCheckEmpEdit
            // 
            this.cmbCheckEmpEdit.Cue = null;
            this.cmbCheckEmpEdit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBuyBill, "checkEmpID", true));
            this.cmbCheckEmpEdit.DisplayMember = "name";
            this.cmbCheckEmpEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckEmpEdit.FormattingEnabled = true;
            this.cmbCheckEmpEdit.Location = new System.Drawing.Point(583, 69);
            this.cmbCheckEmpEdit.Name = "cmbCheckEmpEdit";
            this.cmbCheckEmpEdit.Size = new System.Drawing.Size(65, 24);
            this.cmbCheckEmpEdit.TabIndex = 27;
            this.cmbCheckEmpEdit.ValueMember = "id";
            this.cmbCheckEmpEdit.Visible = false;
            // 
            // bsBuyBill
            // 
            this.bsBuyBill.AllowNew = true;
            this.bsBuyBill.DataSource = typeof(PointOfSale.DbClass.BuyBillView);
            this.bsBuyBill.PositionChanged += new System.EventHandler(this.bsBuyBill_PositionChanged);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.White;
            this.btnDeleteItem.Image = global::PointOfSale.Properties.Resources.Trash;
            this.btnDeleteItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteItem.Location = new System.Drawing.Point(258, 5);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Padding = new System.Windows.Forms.Padding(8);
            this.btnDeleteItem.Size = new System.Drawing.Size(95, 42);
            this.btnDeleteItem.TabIndex = 93;
            this.btnDeleteItem.Text = "ลบ";
            this.btnDeleteItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // dcbBillAmount
            // 
            this.dcbBillAmount.Cue = null;
            this.dcbBillAmount.FormatString = "C0";
            this.dcbBillAmount.Location = new System.Drawing.Point(473, 5);
            this.dcbBillAmount.Name = "dcbBillAmount";
            this.dcbBillAmount.ReadOnly = true;
            this.dcbBillAmount.Size = new System.Drawing.Size(100, 22);
            this.dcbBillAmount.TabIndex = 32;
            this.dcbBillAmount.Text = "฿0";
            this.dcbBillAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbBillAmount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dcbDiscount
            // 
            this.dcbDiscount.Cue = null;
            this.dcbDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBuyBill, "discount", true));
            this.dcbDiscount.FormatString = "C0";
            this.dcbDiscount.Location = new System.Drawing.Point(473, 37);
            this.dcbDiscount.Name = "dcbDiscount";
            this.dcbDiscount.ReadOnly = true;
            this.dcbDiscount.Size = new System.Drawing.Size(100, 22);
            this.dcbDiscount.TabIndex = 21;
            this.dcbDiscount.Text = "฿0";
            this.dcbDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dcbDiscount.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddNewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.btnAddNewItem.Image = global::PointOfSale.Properties.Resources.AddItem;
            this.btnAddNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewItem.Location = new System.Drawing.Point(13, 5);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Padding = new System.Windows.Forms.Padding(8);
            this.btnAddNewItem.Size = new System.Drawing.Size(95, 43);
            this.btnAddNewItem.TabIndex = 94;
            this.btnAddNewItem.Text = "เพิ่ม";
            this.btnAddNewItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewItem.UseVisualStyleBackColor = false;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // cmbCheckEmpView
            // 
            this.cmbCheckEmpView.Cue = null;
            this.cmbCheckEmpView.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "checkEmpName", true));
            this.cmbCheckEmpView.DisplayMember = "id";
            this.cmbCheckEmpView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckEmpView.Enabled = false;
            this.cmbCheckEmpView.FormattingEnabled = true;
            this.cmbCheckEmpView.Location = new System.Drawing.Point(583, 39);
            this.cmbCheckEmpView.Name = "cmbCheckEmpView";
            this.cmbCheckEmpView.Size = new System.Drawing.Size(65, 24);
            this.cmbCheckEmpView.TabIndex = 23;
            this.cmbCheckEmpView.ValueMember = "id";
            // 
            // cmbModelInfoEmpEdit
            // 
            this.cmbModelInfoEmpEdit.Cue = null;
            this.cmbModelInfoEmpEdit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBuyBill, "modelInfoEmpID", true));
            this.cmbModelInfoEmpEdit.DisplayMember = "name";
            this.cmbModelInfoEmpEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelInfoEmpEdit.FormattingEnabled = true;
            this.cmbModelInfoEmpEdit.Location = new System.Drawing.Point(767, 69);
            this.cmbModelInfoEmpEdit.Name = "cmbModelInfoEmpEdit";
            this.cmbModelInfoEmpEdit.Size = new System.Drawing.Size(65, 24);
            this.cmbModelInfoEmpEdit.TabIndex = 30;
            this.cmbModelInfoEmpEdit.ValueMember = "id";
            this.cmbModelInfoEmpEdit.Visible = false;
            // 
            // cmbModelInfoEmpView
            // 
            this.cmbModelInfoEmpView.Cue = null;
            this.cmbModelInfoEmpView.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "modelInfoEmpName", true));
            this.cmbModelInfoEmpView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModelInfoEmpView.Enabled = false;
            this.cmbModelInfoEmpView.FormattingEnabled = true;
            this.cmbModelInfoEmpView.Location = new System.Drawing.Point(767, 37);
            this.cmbModelInfoEmpView.Name = "cmbModelInfoEmpView";
            this.cmbModelInfoEmpView.Size = new System.Drawing.Size(65, 24);
            this.cmbModelInfoEmpView.TabIndex = 26;
            // 
            // cmbBarcodeEmp2Edit
            // 
            this.cmbBarcodeEmp2Edit.Cue = null;
            this.cmbBarcodeEmp2Edit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBuyBill, "barcodeEmpID2", true));
            this.cmbBarcodeEmp2Edit.DisplayMember = "name";
            this.cmbBarcodeEmp2Edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarcodeEmp2Edit.FormattingEnabled = true;
            this.cmbBarcodeEmp2Edit.Location = new System.Drawing.Point(674, 69);
            this.cmbBarcodeEmp2Edit.Name = "cmbBarcodeEmp2Edit";
            this.cmbBarcodeEmp2Edit.Size = new System.Drawing.Size(65, 24);
            this.cmbBarcodeEmp2Edit.TabIndex = 29;
            this.cmbBarcodeEmp2Edit.ValueMember = "id";
            this.cmbBarcodeEmp2Edit.Visible = false;
            // 
            // cmbBarcodeEmp2View
            // 
            this.cmbBarcodeEmp2View.Cue = null;
            this.cmbBarcodeEmp2View.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "barcodeEmpName2", true));
            this.cmbBarcodeEmp2View.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarcodeEmp2View.Enabled = false;
            this.cmbBarcodeEmp2View.FormattingEnabled = true;
            this.cmbBarcodeEmp2View.Location = new System.Drawing.Point(674, 69);
            this.cmbBarcodeEmp2View.Name = "cmbBarcodeEmp2View";
            this.cmbBarcodeEmp2View.Size = new System.Drawing.Size(65, 24);
            this.cmbBarcodeEmp2View.TabIndex = 25;
            // 
            // cmbBarcodeEmpEdit
            // 
            this.cmbBarcodeEmpEdit.Cue = null;
            this.cmbBarcodeEmpEdit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBuyBill, "barcodeEmpID", true));
            this.cmbBarcodeEmpEdit.DisplayMember = "name";
            this.cmbBarcodeEmpEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarcodeEmpEdit.FormattingEnabled = true;
            this.cmbBarcodeEmpEdit.Location = new System.Drawing.Point(674, 37);
            this.cmbBarcodeEmpEdit.Name = "cmbBarcodeEmpEdit";
            this.cmbBarcodeEmpEdit.Size = new System.Drawing.Size(65, 24);
            this.cmbBarcodeEmpEdit.TabIndex = 28;
            this.cmbBarcodeEmpEdit.ValueMember = "id";
            this.cmbBarcodeEmpEdit.Visible = false;
            // 
            // cmbBarcodeEmpView
            // 
            this.cmbBarcodeEmpView.Cue = null;
            this.cmbBarcodeEmpView.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "barcodeEmpName", true));
            this.cmbBarcodeEmpView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarcodeEmpView.Enabled = false;
            this.cmbBarcodeEmpView.FormattingEnabled = true;
            this.cmbBarcodeEmpView.Location = new System.Drawing.Point(674, 37);
            this.cmbBarcodeEmpView.Name = "cmbBarcodeEmpView";
            this.cmbBarcodeEmpView.Size = new System.Drawing.Size(65, 24);
            this.cmbBarcodeEmpView.TabIndex = 24;
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.buyBillnav);
            this.headPanel.Controls.Add(this.billInfoPanel);
            this.headPanel.Controls.Add(this.btnAdd);
            this.headPanel.Controls.Add(this.btnDelete);
            this.headPanel.Controls.Add(this.btnEdit);
            this.headPanel.Controls.Add(this.dtpBillDate);
            this.headPanel.Controls.Add(supplierIDLabel);
            this.headPanel.Controls.Add(this.txtBillRemark);
            this.headPanel.Controls.Add(this.cmbSupplier);
            this.headPanel.Controls.Add(remarkLabel);
            this.headPanel.Controls.Add(this.cmbBranch);
            this.headPanel.Controls.Add(billDateLabel);
            this.headPanel.Controls.Add(branchIDLabel);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headPanel.Location = new System.Drawing.Point(10, 10);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(832, 141);
            this.headPanel.TabIndex = 0;
            // 
            // buyBillnav
            // 
            this.buyBillnav.AddNewItem = null;
            this.buyBillnav.BindingSource = this.bsBuyBill;
            this.buyBillnav.CountItem = this.bindingNavigatorCountItem;
            this.buyBillnav.DeleteItem = null;
            this.buyBillnav.Dock = System.Windows.Forms.DockStyle.None;
            this.buyBillnav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.buyBillnav.Location = new System.Drawing.Point(608, 10);
            this.buyBillnav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.buyBillnav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.buyBillnav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.buyBillnav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.buyBillnav.Name = "buyBillnav";
            this.buyBillnav.PositionItem = this.bindingNavigatorPositionItem;
            this.buyBillnav.Size = new System.Drawing.Size(224, 25);
            this.buyBillnav.TabIndex = 0;
            this.buyBillnav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // billInfoPanel
            // 
            this.billInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billInfoPanel.Controls.Add(this.cmbKeyInEmp);
            this.billInfoPanel.Controls.Add(this.txtKeyInDateTime);
            this.billInfoPanel.Controls.Add(this.idLabel);
            this.billInfoPanel.Controls.Add(label28);
            this.billInfoPanel.Controls.Add(this.txtkeyInEmpName);
            this.billInfoPanel.Controls.Add(this.txtUpdated);
            this.billInfoPanel.Controls.Add(label24);
            this.billInfoPanel.Controls.Add(lblUpdated);
            this.billInfoPanel.Controls.Add(this.inbID);
            this.billInfoPanel.Controls.Add(this.txtDeviceName);
            this.billInfoPanel.Controls.Add(label21);
            this.billInfoPanel.Location = new System.Drawing.Point(519, 42);
            this.billInfoPanel.Name = "billInfoPanel";
            this.billInfoPanel.Padding = new System.Windows.Forms.Padding(5);
            this.billInfoPanel.Size = new System.Drawing.Size(313, 96);
            this.billInfoPanel.TabIndex = 66;
            // 
            // cmbKeyInEmp
            // 
            this.cmbKeyInEmp.Cue = null;
            this.cmbKeyInEmp.DisplayMember = "name";
            this.cmbKeyInEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeyInEmp.FormattingEnabled = true;
            this.cmbKeyInEmp.Location = new System.Drawing.Point(49, 5);
            this.cmbKeyInEmp.Name = "cmbKeyInEmp";
            this.cmbKeyInEmp.Size = new System.Drawing.Size(65, 24);
            this.cmbKeyInEmp.TabIndex = 105;
            this.cmbKeyInEmp.ValueMember = "id";
            this.cmbKeyInEmp.Visible = false;
            // 
            // txtKeyInDateTime
            // 
            this.txtKeyInDateTime.Cue = null;
            this.txtKeyInDateTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "keyInDateTime", true));
            this.txtKeyInDateTime.Location = new System.Drawing.Point(104, 34);
            this.txtKeyInDateTime.Name = "txtKeyInDateTime";
            this.txtKeyInDateTime.ReadOnly = true;
            this.txtKeyInDateTime.Size = new System.Drawing.Size(119, 22);
            this.txtKeyInDateTime.TabIndex = 99;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(229, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(19, 16);
            this.idLabel.TabIndex = 65;
            this.idLabel.Text = "id";
            // 
            // txtkeyInEmpName
            // 
            this.txtkeyInEmpName.Cue = null;
            this.txtkeyInEmpName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "keyInEmpName", true));
            this.txtkeyInEmpName.Location = new System.Drawing.Point(49, 33);
            this.txtkeyInEmpName.Name = "txtkeyInEmpName";
            this.txtkeyInEmpName.ReadOnly = true;
            this.txtkeyInEmpName.Size = new System.Drawing.Size(49, 22);
            this.txtkeyInEmpName.TabIndex = 97;
            // 
            // txtUpdated
            // 
            this.txtUpdated.Cue = null;
            this.txtUpdated.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "updated", true));
            this.txtUpdated.Location = new System.Drawing.Point(104, 63);
            this.txtUpdated.Name = "txtUpdated";
            this.txtUpdated.ReadOnly = true;
            this.txtUpdated.Size = new System.Drawing.Size(119, 22);
            this.txtUpdated.TabIndex = 98;
            // 
            // inbID
            // 
            this.inbID.Cue = null;
            this.inbID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "id", true));
            this.inbID.Location = new System.Drawing.Point(151, 6);
            this.inbID.Name = "inbID";
            this.inbID.ReadOnly = true;
            this.inbID.Size = new System.Drawing.Size(72, 22);
            this.inbID.TabIndex = 60;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Cue = null;
            this.txtDeviceName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "deviceName", true));
            this.txtDeviceName.Location = new System.Drawing.Point(49, 63);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(49, 22);
            this.txtDeviceName.TabIndex = 102;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PointOfSale.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(15, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(8);
            this.btnAdd.Size = new System.Drawing.Size(98, 45);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "NEW";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PointOfSale.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(260, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(8);
            this.btnDelete.Size = new System.Drawing.Size(98, 45);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "DEL";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(143, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(8);
            this.btnEdit.Size = new System.Drawing.Size(98, 45);
            this.btnEdit.TabIndex = 57;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CustomFormat = "dd MMM yy";
            this.dtpBillDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBuyBill, "billDate", true));
            this.dtpBillDate.Enabled = false;
            this.dtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBillDate.Location = new System.Drawing.Point(384, 73);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(100, 22);
            this.dtpBillDate.TabIndex = 61;
            // 
            // txtBillRemark
            // 
            this.txtBillRemark.Cue = null;
            this.txtBillRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "remark", true));
            this.txtBillRemark.Location = new System.Drawing.Point(78, 107);
            this.txtBillRemark.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillRemark.Name = "txtBillRemark";
            this.txtBillRemark.ReadOnly = true;
            this.txtBillRemark.Size = new System.Drawing.Size(406, 22);
            this.txtBillRemark.TabIndex = 2;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.CausesValidation = false;
            this.cmbSupplier.Cue = null;
            this.cmbSupplier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBuyBill, "supplierID", true));
            this.cmbSupplier.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsBuyBill, "supplierID", true));
            this.cmbSupplier.DisplayMember = "name";
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Enabled = false;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(217, 73);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(160, 24);
            this.cmbSupplier.TabIndex = 20;
            this.cmbSupplier.ValueMember = "id";
            // 
            // cmbBranch
            // 
            this.cmbBranch.Cue = null;
            this.cmbBranch.DisplayMember = "name";
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.Enabled = false;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(18, 75);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(95, 24);
            this.cmbBranch.TabIndex = 4;
            this.cmbBranch.ValueMember = "id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(941, 898);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 1061);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBuy";
            this.Text = "FormBuy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBuy_Load);
            this.leftPanel.ResumeLayout(false);
            this.myPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuy)).EndInit();
            this.okBillPanel.ResumeLayout(false);
            this.modelPanel.ResumeLayout(false);
            this.modelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBrandView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModel)).EndInit();
            this.panProduct0.ResumeLayout(false);
            this.panProduct0.PerformLayout();
            this.panSize0.ResumeLayout(false);
            this.panSize0.PerformLayout();
            this.panProduct1.ResumeLayout(false);
            this.panProduct1.PerformLayout();
            this.panSize1.ResumeLayout(false);
            this.panSize1.PerformLayout();
            this.panProduct2.ResumeLayout(false);
            this.panProduct2.PerformLayout();
            this.panSize2.ResumeLayout(false);
            this.panSize2.PerformLayout();
            this.panProduct3.ResumeLayout(false);
            this.panProduct3.PerformLayout();
            this.panSize3.ResumeLayout(false);
            this.panSize3.PerformLayout();
            this.panFootItem.ResumeLayout(false);
            this.panFootItem.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBuyBill)).EndInit();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyBillnav)).EndInit();
            this.buyBillnav.ResumeLayout(false);
            this.buyBillnav.PerformLayout();
            this.billInfoPanel.ResumeLayout(false);
            this.billInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsBuyBill;
        private MyControls.MyPanel leftPanel;
        private MyControls.MyPanel myPanel2;
        private MyControls.MyGridView dgvBuyView;
        private MyControls.MyPanel okBillPanel;
        private System.Windows.Forms.Button btnBillCancel;
        private System.Windows.Forms.Button btnBillOK;
        private MyControls.MyPanel modelPanel;
        private MyControls.IntegerBox inbModelUnits;
        private MyControls.ComboList cmbModelSizeSet;
        private MyControls.IntegerBox inbModelSets;
        private MyControls.ComboList cmbBrand;
        private MyControls.CurrencyBox dcbModelCost;
        private MyControls.CurrencyBox dcbModelPrice;
        private MyControls.ComboText cmbModel;
        private MyControls.MyPanel panProduct0;
        private MyControls.StrBox txtRemark0;
        private MyControls.ComboList cmbColor0;
        private MyControls.ComboList cmbSizeSet0;
        private MyControls.CurrencyBox dcbCost0;
        private MyControls.IntegerBox inbSets0;
        private MyControls.IntegerBox inbUnits0;
        private MyControls.CurrencyBox dcbAmount0;
        private MyControls.MyPanel panSize0;
        private MyControls.ComboList cmbSize05;
        private MyControls.ComboList cmbSize00;
        private MyControls.IntegerBox inbUnitSize05;
        private MyControls.IntegerBox inbUnitSize02;
        private MyControls.IntegerBox inbUnitSize04;
        private MyControls.IntegerBox inbUnitSize03;
        private MyControls.IntegerBox inbUnitSize00;
        private MyControls.ComboList cmbSize04;
        private MyControls.IntegerBox inbUnitSize01;
        private MyControls.ComboList cmbSize01;
        private MyControls.ComboList cmbSize03;
        private MyControls.ComboList cmbSize02;
        private MyControls.MyPanel panProduct1;
        private MyControls.StrBox txtRemark1;
        private MyControls.ComboList cmbSizeSet1;
        private MyControls.CurrencyBox dcbCost1;
        private MyControls.IntegerBox inbSets1;
        private MyControls.ComboList cmbColor1;
        private MyControls.CurrencyBox dcbAmount1;
        private MyControls.IntegerBox inbUnits1;
        private MyControls.MyPanel panSize1;
        private MyControls.ComboList cmbSize15;
        private MyControls.ComboList cmbSize10;
        private MyControls.ComboList cmbSize11;
        private MyControls.IntegerBox inbUnitSize11;
        private MyControls.ComboList cmbSize13;
        private MyControls.IntegerBox inbUnitSize15;
        private MyControls.ComboList cmbSize14;
        private MyControls.IntegerBox inbUnitSize12;
        private MyControls.IntegerBox inbUnitSize14;
        private MyControls.IntegerBox inbUnitSize13;
        private MyControls.IntegerBox inbUnitSize10;
        private MyControls.ComboList cmbSize12;
        private MyControls.MyPanel panProduct2;
        private MyControls.StrBox txtRemark2;
        private MyControls.IntegerBox inbUnits2;
        private MyControls.CurrencyBox dcbCost2;
        private MyControls.CurrencyBox dcbAmount2;
        private MyControls.ComboList cmbSizeSet2;
        private MyControls.ComboList cmbColor2;
        private MyControls.IntegerBox inbSets2;
        private MyControls.MyPanel panSize2;
        private MyControls.ComboList cmbSize25;
        private MyControls.ComboList cmbSize20;
        private MyControls.IntegerBox inbUnitSize25;
        private MyControls.IntegerBox inbUnitSize21;
        private MyControls.IntegerBox inbUnitSize24;
        private MyControls.IntegerBox inbUnitSize22;
        private MyControls.IntegerBox inbUnitSize20;
        private MyControls.IntegerBox inbUnitSize23;
        private MyControls.ComboList cmbSize22;
        private MyControls.ComboList cmbSize24;
        private MyControls.ComboList cmbSize21;
        private MyControls.ComboList cmbSize23;
        private MyControls.MyPanel panProduct3;
        private MyControls.StrBox txtRemark3;
        private MyControls.CurrencyBox dcbCost3;
        private MyControls.ComboList cmbSizeSet3;
        private MyControls.ComboList cmbColor3;
        private MyControls.IntegerBox inbSets3;
        private MyControls.IntegerBox inbUnits3;
        private MyControls.CurrencyBox dcbAmount3;
        private MyControls.MyPanel panSize3;
        private MyControls.IntegerBox inbUnitSize35;
        private MyControls.ComboList cmbSize35;
        private MyControls.IntegerBox inbUnitSize31;
        private MyControls.IntegerBox inbUnitSize34;
        private MyControls.ComboList cmbSize30;
        private MyControls.IntegerBox inbUnitSize30;
        private MyControls.IntegerBox inbUnitSize32;
        private MyControls.ComboList cmbSize32;
        private MyControls.IntegerBox inbUnitSize33;
        private MyControls.ComboList cmbSize34;
        private MyControls.ComboList cmbSize33;
        private MyControls.ComboList cmbSize31;
        private MyControls.MyPanel panFootItem;
        private MyControls.CurrencyBox currencyBox3;
        private System.Windows.Forms.Button btnOKItem;
        private System.Windows.Forms.Button btnCancelItem;
        private MyControls.MyPanel BottomPanel;
        private System.Windows.Forms.Button btnEditItem;
        private MyControls.CurrencyBox dcbBilltotal;
        private MyControls.ComboList cmbCheckEmpEdit;
        private System.Windows.Forms.Button btnDeleteItem;
        private MyControls.CurrencyBox dcbBillAmount;
        private MyControls.CurrencyBox dcbDiscount;
        private System.Windows.Forms.Button btnAddNewItem;
        private MyControls.ComboList cmbCheckEmpView;
        private MyControls.ComboList cmbModelInfoEmpEdit;
        private MyControls.ComboList cmbBarcodeEmpView;
        private MyControls.ComboList cmbBarcodeEmp2Edit;
        private MyControls.ComboList cmbBarcodeEmp2View;
        private MyControls.ComboList cmbBarcodeEmpEdit;
        private MyControls.ComboList cmbModelInfoEmpView;
        private MyControls.MyPanel headPanel;
        private System.Windows.Forms.BindingNavigator buyBillnav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private MyControls.MyPanel billInfoPanel;
        private MyControls.StrBox txtKeyInDateTime;
        private System.Windows.Forms.Label idLabel;
        private MyControls.StrBox txtkeyInEmpName;
        private MyControls.StrBox txtUpdated;
        private MyControls.StrBox inbID;
        private MyControls.StrBox txtDeviceName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private MyControls.DateBox dtpBillDate;
        private MyControls.StrBox txtBillRemark;
        private MyControls.ComboList cmbSupplier;
        private MyControls.ComboList cmbBranch;
        private MyControls.ComboList cmbKeyInEmp;
        private System.Windows.Forms.BindingSource bsBuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeSetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyInEmpNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyBillIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn setsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeSetIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyInEmpIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyInDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateByDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bsBrandView;
        private System.Windows.Forms.BindingSource bsModel;
    }
}