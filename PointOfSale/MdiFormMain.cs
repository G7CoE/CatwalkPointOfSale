using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class MdiFormMain : Form
    {
        DataSet ds = MyGlobals.ds;
        public MdiFormMain()
        {
            InitializeComponent();
        }
        private void ReadSettingFile ()
        {
            // Read Setting From AccessFile
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Code\CatwalkPointOfSale\PointOfSale\Setting.accdb";
            string strSQL = "SELECT * FROM Setting";
            // Create a connection    
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection    
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                // Open the connection and execute the select command.    
                try
                {
                    // Open connecton    
                    connection.Open();
                    // Execute command    
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SettingClass.deviceID = int.Parse(reader["deviceID"].ToString());
                            SettingClass.brachID = int.Parse(reader["branchID"].ToString());
                            SettingClass.comPort = int.Parse(reader["comPort"].ToString());
                            SettingClass.resX = int.Parse(reader["resX"].ToString());
                            SettingClass.resY = int.Parse(reader["resY"].ToString());
                            SettingClass.dropboxPath = reader["dropboxPath"].ToString();
                            SettingClass.imagePath = reader["imagePath"].ToString();
                            SettingClass.moneyDrawer = decimal.Parse(reader["resY"].ToString());
                            SettingClass.dotPrinter = reader["imagePath"].ToString();
                            SettingClass.a4Printer = reader["imagePath"].ToString();
                            SettingClass.isHQ = int.Parse(reader["isHQ"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed becasuse of using block.    
            }
        }
        private void MdiFormMain_Load(object sender, EventArgs e)
        {
            ReadSettingFile(); // อ่าน Setting File

            // โหลดข้อมูลหลักที่ต้องใช้ใน form หลายฟอร์ม
            MyGlobals.dtCurrentEmp = Helper.LoadSql("SELECT * FROM Emp WHERE isQuitted <> 1");
            // ตอนทำเสร็จบรรทัดนี้ เอาออก ได้มาตั้งแต่ LogIn แล้ว
            MyGlobals.dtLogInEmp = Helper.LoadSql("SELECT * FROM Emp WHERE logInBranchID = 1 AND isQuitted <> 1");


            // show form buy
            FormBuy formBuy1 = new FormBuy();
            formBuy1.MdiParent = this;
            formBuy1.Show();
        }
    }
}
