
namespace PointOfSale
{
    partial class FormEmp
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label telLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label bundleLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label empTypeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmp));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inbID = new MyControls.IntegerBox();
            this.txtName = new MyControls.StrBox();
            this.txtFullName = new MyControls.StrBox();
            this.txtTel = new MyControls.StrBox();
            this.txtEmail = new MyControls.StrBox();
            this.decSalary = new MyControls.CurrencyBox();
            this.dateStartDate = new MyControls.DateBox();
            this.bsEmp = new System.Windows.Forms.BindingSource(this.components);
            this.empListBox = new System.Windows.Forms.ListBox();
            this.leftMyPanel = new MyControls.MyPanel();
            this.fillmyPanel = new MyControls.MyPanel();
            this.topMyPanel = new MyControls.MyPanel();
            this.selectEmpsMyCombo = new MyControls.MyCombo();
            this.empDataGroupBox = new System.Windows.Forms.GroupBox();
            this.ndateQuitDate = new MyControls.NDateBox();
            this.ndecBundle = new MyControls.NCurrencyBox();
            this.chkisQuitted = new System.Windows.Forms.CheckBox();
            this.empTypeIDMyCombo = new MyControls.MyCombo();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            telLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            bundleLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            empTypeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmp)).BeginInit();
            this.leftMyPanel.SuspendLayout();
            this.fillmyPanel.SuspendLayout();
            this.topMyPanel.SuspendLayout();
            this.empDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(272, 28);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(22, 16);
            idLabel.TabIndex = 63;
            idLabel.Text = "id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(20, 61);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(40, 16);
            nameLabel.TabIndex = 65;
            nameLabel.Text = "ชื่อเล่น:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(165, 61);
            fullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(47, 16);
            fullNameLabel.TabIndex = 67;
            fullNameLabel.Text = "ชื่อ-สกุล:";
            // 
            // telLabel
            // 
            telLabel.AutoSize = true;
            telLabel.Location = new System.Drawing.Point(20, 96);
            telLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telLabel.Name = "telLabel";
            telLabel.Size = new System.Drawing.Size(25, 16);
            telLabel.TabIndex = 69;
            telLabel.Text = "tel:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(165, 96);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 71;
            emailLabel.Text = "email:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(20, 131);
            salaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(50, 16);
            salaryLabel.TabIndex = 73;
            salaryLabel.Text = "เงินเดือน:";
            // 
            // bundleLabel
            // 
            bundleLabel.AutoSize = true;
            bundleLabel.Location = new System.Drawing.Point(223, 131);
            bundleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            bundleLabel.Name = "bundleLabel";
            bundleLabel.Size = new System.Drawing.Size(60, 16);
            bundleLabel.TabIndex = 75;
            bundleLabel.Text = "มัดจำพนง.:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(20, 172);
            startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(45, 16);
            startDateLabel.TabIndex = 79;
            startDateLabel.Text = "เริ่มงาน:";
            // 
            // empTypeIDLabel
            // 
            empTypeIDLabel.AutoSize = true;
            empTypeIDLabel.Location = new System.Drawing.Point(165, 210);
            empTypeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            empTypeIDLabel.Name = "empTypeIDLabel";
            empTypeIDLabel.Size = new System.Drawing.Size(50, 16);
            empTypeIDLabel.TabIndex = 85;
            empTypeIDLabel.Text = "ตำแหน่ง:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(549, 429);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(11, 10, 0, 10);
            this.btnCancel.Size = new System.Drawing.Size(123, 45);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.ForestGreen;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(332, 429);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Padding = new System.Windows.Forms.Padding(11, 10, 33, 10);
            this.btnOK.Size = new System.Drawing.Size(123, 45);
            this.btnOK.TabIndex = 61;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::PointOfSale.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(565, 13);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnDelete.Size = new System.Drawing.Size(109, 45);
            this.btnDelete.TabIndex = 60;
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
            this.btnEdit.Location = new System.Drawing.Point(423, 13);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnEdit.Size = new System.Drawing.Size(109, 45);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::PointOfSale.Properties.Resources.Add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(281, 13);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btnAdd.Size = new System.Drawing.Size(109, 45);
            this.btnAdd.TabIndex = 58;
            this.btnAdd.Text = "NEW";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // inbID
            // 
            this.inbID.Cue = null;
            this.inbID.Location = new System.Drawing.Point(301, 25);
            this.inbID.Margin = new System.Windows.Forms.Padding(4);
            this.inbID.Name = "inbID";
            this.inbID.ReadOnly = true;
            this.inbID.Size = new System.Drawing.Size(109, 22);
            this.inbID.TabIndex = 64;
            this.inbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.Cue = null;
            this.txtName.Location = new System.Drawing.Point(70, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(87, 22);
            this.txtName.TabIndex = 66;
            // 
            // txtFullName
            // 
            this.txtFullName.Cue = null;
            this.txtFullName.Location = new System.Drawing.Point(220, 58);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(190, 22);
            this.txtFullName.TabIndex = 68;
            // 
            // txtTel
            // 
            this.txtTel.Cue = null;
            this.txtTel.Location = new System.Drawing.Point(70, 93);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(87, 22);
            this.txtTel.TabIndex = 70;
            // 
            // txtEmail
            // 
            this.txtEmail.Cue = null;
            this.txtEmail.Location = new System.Drawing.Point(220, 93);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(191, 22);
            this.txtEmail.TabIndex = 72;
            // 
            // decSalary
            // 
            this.decSalary.Cue = null;
            this.decSalary.FormatString = "C2";
            this.decSalary.Location = new System.Drawing.Point(70, 128);
            this.decSalary.Margin = new System.Windows.Forms.Padding(4);
            this.decSalary.Name = "decSalary";
            this.decSalary.ReadOnly = true;
            this.decSalary.Size = new System.Drawing.Size(119, 22);
            this.decSalary.TabIndex = 74;
            this.decSalary.Text = "฿0.00";
            this.decSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.decSalary.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // dateStartDate
            // 
            this.dateStartDate.CustomFormat = "dd MMM yy";
            this.dateStartDate.Enabled = false;
            this.dateStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStartDate.Location = new System.Drawing.Point(70, 167);
            this.dateStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateStartDate.Name = "dateStartDate";
            this.dateStartDate.Size = new System.Drawing.Size(109, 22);
            this.dateStartDate.TabIndex = 80;
            this.dateStartDate.Value = new System.DateTime(2020, 12, 25, 16, 31, 14, 270);
            // 
            // empListBox
            // 
            this.empListBox.DataSource = this.bsEmp;
            this.empListBox.DisplayMember = "name";
            this.empListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empListBox.FormattingEnabled = true;
            this.empListBox.ItemHeight = 16;
            this.empListBox.Location = new System.Drawing.Point(0, 0);
            this.empListBox.Name = "empListBox";
            this.empListBox.Size = new System.Drawing.Size(236, 524);
            this.empListBox.TabIndex = 88;
            this.empListBox.ValueMember = "id";
            this.empListBox.SelectedValueChanged += new System.EventHandler(this.empListBox_SelectedValueChanged);
            // 
            // leftMyPanel
            // 
            this.leftMyPanel.Controls.Add(this.fillmyPanel);
            this.leftMyPanel.Controls.Add(this.topMyPanel);
            this.leftMyPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftMyPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMyPanel.Name = "leftMyPanel";
            this.leftMyPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftMyPanel.Size = new System.Drawing.Size(256, 579);
            this.leftMyPanel.TabIndex = 89;
            // 
            // fillmyPanel
            // 
            this.fillmyPanel.Controls.Add(this.empListBox);
            this.fillmyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillmyPanel.Location = new System.Drawing.Point(10, 45);
            this.fillmyPanel.Name = "fillmyPanel";
            this.fillmyPanel.Size = new System.Drawing.Size(236, 524);
            this.fillmyPanel.TabIndex = 89;
            // 
            // topMyPanel
            // 
            this.topMyPanel.Controls.Add(this.selectEmpsMyCombo);
            this.topMyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMyPanel.Location = new System.Drawing.Point(10, 10);
            this.topMyPanel.Name = "topMyPanel";
            this.topMyPanel.Size = new System.Drawing.Size(236, 35);
            this.topMyPanel.TabIndex = 0;
            // 
            // selectEmpsMyCombo
            // 
            this.selectEmpsMyCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectEmpsMyCombo.FormattingEnabled = true;
            this.selectEmpsMyCombo.Items.AddRange(new object[] {
            "พนักงาน ปัจจุบัน",
            "พนง. ออกแล้ว",
            "ทั้งหมด"});
            this.selectEmpsMyCombo.Location = new System.Drawing.Point(0, 0);
            this.selectEmpsMyCombo.Name = "selectEmpsMyCombo";
            this.selectEmpsMyCombo.Size = new System.Drawing.Size(236, 24);
            this.selectEmpsMyCombo.TabIndex = 0;
            this.selectEmpsMyCombo.SelectedIndexChanged += new System.EventHandler(this.selectEmpsMyCombo_SelectedIndexChanged);
            // 
            // empDataGroupBox
            // 
            this.empDataGroupBox.Controls.Add(this.ndateQuitDate);
            this.empDataGroupBox.Controls.Add(this.ndecBundle);
            this.empDataGroupBox.Controls.Add(this.chkisQuitted);
            this.empDataGroupBox.Controls.Add(this.empTypeIDMyCombo);
            this.empDataGroupBox.Controls.Add(idLabel);
            this.empDataGroupBox.Controls.Add(this.inbID);
            this.empDataGroupBox.Controls.Add(nameLabel);
            this.empDataGroupBox.Controls.Add(empTypeIDLabel);
            this.empDataGroupBox.Controls.Add(this.txtName);
            this.empDataGroupBox.Controls.Add(fullNameLabel);
            this.empDataGroupBox.Controls.Add(this.txtFullName);
            this.empDataGroupBox.Controls.Add(telLabel);
            this.empDataGroupBox.Controls.Add(this.txtTel);
            this.empDataGroupBox.Controls.Add(this.dateStartDate);
            this.empDataGroupBox.Controls.Add(emailLabel);
            this.empDataGroupBox.Controls.Add(startDateLabel);
            this.empDataGroupBox.Controls.Add(this.txtEmail);
            this.empDataGroupBox.Controls.Add(salaryLabel);
            this.empDataGroupBox.Controls.Add(this.decSalary);
            this.empDataGroupBox.Controls.Add(bundleLabel);
            this.empDataGroupBox.Location = new System.Drawing.Point(262, 65);
            this.empDataGroupBox.Name = "empDataGroupBox";
            this.empDataGroupBox.Size = new System.Drawing.Size(423, 323);
            this.empDataGroupBox.TabIndex = 90;
            this.empDataGroupBox.TabStop = false;
            this.empDataGroupBox.Text = "ข้อมูลพนักงาน";
            // 
            // ndateQuitDate
            // 
            this.ndateQuitDate.CustomFormat = "dd MMM yy";
            this.ndateQuitDate.Enabled = false;
            this.ndateQuitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndateQuitDate.Location = new System.Drawing.Point(301, 166);
            this.ndateQuitDate.Name = "ndateQuitDate";
            this.ndateQuitDate.Size = new System.Drawing.Size(109, 22);
            this.ndateQuitDate.TabIndex = 92;
            this.ndateQuitDate.Value = new System.DateTime(2020, 12, 26, 10, 16, 43, 593);
            // 
            // ndecBundle
            // 
            this.ndecBundle.Cue = null;
            this.ndecBundle.FormatString = "C2";
            this.ndecBundle.Location = new System.Drawing.Point(319, 128);
            this.ndecBundle.Name = "ndecBundle";
            this.ndecBundle.ReadOnly = true;
            this.ndecBundle.Size = new System.Drawing.Size(91, 22);
            this.ndecBundle.TabIndex = 91;
            this.ndecBundle.Text = "฿0.00";
            this.ndecBundle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ndecBundle.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // chkisQuitted
            // 
            this.chkisQuitted.AutoSize = true;
            this.chkisQuitted.Enabled = false;
            this.chkisQuitted.Location = new System.Drawing.Point(186, 170);
            this.chkisQuitted.Name = "chkisQuitted";
            this.chkisQuitted.Size = new System.Drawing.Size(63, 20);
            this.chkisQuitted.TabIndex = 90;
            this.chkisQuitted.Text = "ออกแล้ว";
            this.chkisQuitted.UseVisualStyleBackColor = true;
            this.chkisQuitted.CheckedChanged += new System.EventHandler(this.chkisQuitted_CheckedChanged);
            // 
            // empTypeIDMyCombo
            // 
            this.empTypeIDMyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empTypeIDMyCombo.Enabled = false;
            this.empTypeIDMyCombo.FormattingEnabled = true;
            this.empTypeIDMyCombo.Location = new System.Drawing.Point(220, 207);
            this.empTypeIDMyCombo.Name = "empTypeIDMyCombo";
            this.empTypeIDMyCombo.Size = new System.Drawing.Size(190, 24);
            this.empTypeIDMyCombo.TabIndex = 89;
            // 
            // FormEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1697, 579);
            this.Controls.Add(this.empDataGroupBox);
            this.Controls.Add(this.leftMyPanel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmp";
            this.Text = "พนักงาน";
            this.Load += new System.EventHandler(this.FormEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEmp)).EndInit();
            this.leftMyPanel.ResumeLayout(false);
            this.fillmyPanel.ResumeLayout(false);
            this.topMyPanel.ResumeLayout(false);
            this.empDataGroupBox.ResumeLayout(false);
            this.empDataGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private MyControls.IntegerBox inbID;
        private MyControls.StrBox txtName;
        private MyControls.StrBox txtFullName;
        private MyControls.StrBox txtTel;
        private MyControls.StrBox txtEmail;
        private MyControls.CurrencyBox decSalary;
        private MyControls.DateBox dateStartDate;
        private System.Windows.Forms.BindingSource bsEmp;
        private System.Windows.Forms.ListBox empListBox;
        private MyControls.MyPanel leftMyPanel;
        private MyControls.MyPanel topMyPanel;
        private MyControls.MyCombo selectEmpsMyCombo;
        private System.Windows.Forms.GroupBox empDataGroupBox;
        private MyControls.MyPanel fillmyPanel;
        private MyControls.MyCombo empTypeIDMyCombo;
        private System.Windows.Forms.CheckBox chkisQuitted;
        private MyControls.NCurrencyBox ndecBundle;
        private MyControls.NDateBox ndateQuitDate;
    }
}

