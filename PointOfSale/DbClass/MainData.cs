using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.DbClass
{
#pragma warning disable IDE1006 // Naming Styles
	public class BaseTable
	{
        public int id { get; set; }
        public string name { get; set; }
	}

	public class Brand
    {
		public int id { get; set; }
		public string name { get; set; }
		public string fullName { get; set; }
		public int? brandProductTypeID { get; set; }
		public int? defaultSizeSetID { get; set; }
	}

	public class BrandView : Brand
    {
		public string brandProductTypeName { get; set; }
		public string sizeSetName { get; set; }
		public int isRequiredColor { get; set; }
		public int isRequireSize { get; set; }
		public List<BaseTable> modelCodes { get; set; }

	}

	public class BuyBill
    {
		public int id { get; set; }
		public int branchID { get; set; }
		public int? supplierID { get; set; }
		public DateTime? billDate { get; set; }
		public int? transportExpenseID { get; set; }
		public int? checkEmpID { get; set; }
		public int? barcodeEmpID { get; set; }
		public int? barcodeEmpID2 { get; set; }
		public int? modelInfoEmpID { get; set; }
		public string remark { get; set; }
		public decimal? discount { get; set; }
		public int? payID { get; set; }
		public int deviceID { get; set; }
		public int keyInEmpID { get; set; }
		public DateTime keyInDateTime { get; set; }
		public DateTime updated { get; set; }
		public string updateBy { get; set; }
	}

	public class BuyBillView : BuyBill
    {
		public string deviceName { get; set; }
		public string checkEmpName { get; set; }
		public string barcodeEmpName { get; set; }
		public string barcodeEmpName2 { get; set; }
		public string modelInfoEmpName { get; set; }
		public string keyInEmpName { get; set; }
	}

	public class Buy
    {
		public int id { get; set; }
		public int buyBillID { get; set; }
		public int productID { get; set; }
		public decimal? cost { get; set; }
		public int? sets { get; set; }
		public int? sizeSetID { get; set; }
		public string remark { get; set; }
		public int? deviceID { get; set; }
		public int? keyInEmpID { get; set; }
		public DateTime? keyInDateTime { get; set; }
		public DateTime? updated { get; set; }
		public string updateBy { get; set; }
	}

	public class BuyView : Buy
    {
		public string brandName { get; set; }
		public string modelCode { get; set; }
		public string colorName { get; set; }
		public string sizeSetName { get; set; }
		public string deviceName { get; set; }
		public string keyInEmpName { get; set; }

    }
	#region Emp // Emp EmpType
	public partial class Emp : BaseTable
	{
		public string fullName { get; set; }
		public string tel { get; set; }
		public string email { get; set; }
		public decimal salary { get; set; }
		public decimal? bundle { get; set; }
		public int isQuitted { get; set; }
		public DateTime startDate { get; set; }
		public DateTime? quitDate { get; set; }
		public string password { get; set; }
		public int empTypeID { get; set; }
		public int? logInBranchID { get; set; }

		private DataTable selectEmp (string command)
        {
			DataTable dt = new DataTable();
			dt.Load(Helper.ExecuteReader(command, System.Data.CommandType.Text));
			return dt;
		}

		public DataTable Select()
        {
			return selectEmp("SELECT * FROM Emp ORDER BY id");
        }
		public DataTable Select(string criteria)
        {
			return selectEmp("SELECT * FROM Emp " + criteria);
        }
		// Insert กับ Update ไม่ยุ่งเกี่ยวกับ LogInBranchID
		public int Insert(Emp emp1)
        {
			string command = "INSERT Emp (name, fullName, tel, email, salary, bundle, isQuitted, startDate, quitDate, empTypeID)" +
				"OUTPUT Inserted.id VALUES (@name, @fullName, @tel, @email, @salary, @bundle, @isQuitted, @startDate, @quitDate, @empTypeID)";
			return (int)Helper.ExecuteScalar(command, System.Data.CommandType.Text,
				new SqlParameter("@name", (object)emp1.name ?? DBNull.Value),
				new SqlParameter("@fullName", (object)emp1.fullName ?? DBNull.Value),
				new SqlParameter("@tel", (object)emp1.tel ?? DBNull.Value),
				new SqlParameter("@email", (object)emp1.email ?? DBNull.Value),
				new SqlParameter("@salary", (object)emp1.salary ?? DBNull.Value),
				new SqlParameter("@bundle", (object)emp1.bundle ?? DBNull.Value),
				new SqlParameter("@isQuitted", (object)emp1.isQuitted ?? DBNull.Value),
				new SqlParameter("@startDate", (object)emp1.startDate ?? DBNull.Value),
				new SqlParameter("@quitDate", (object)emp1.quitDate ?? DBNull.Value),
				new SqlParameter("@empTypeID", (object)emp1.empTypeID ?? DBNull.Value));
		}
		
		public int Update(Emp emp1)
        {
			string command = "UPDATE Emp SET name=@name, fullName=@fullName, tel=@tel, email=@email, salary=@salary, bundle=@bundle," +
				" isQuitted=@isQuitted, startDate=@startDate, quitDate=@quitDate, empTypeID=@empTypeID WHERE id = @id";
			return Helper.ExecuteNonQuery(command, System.Data.CommandType.Text,
				new SqlParameter("@name", (object)emp1.name ?? DBNull.Value),
				new SqlParameter("@fullName", (object)emp1.fullName ?? DBNull.Value),
				new SqlParameter("@tel", (object)emp1.tel ?? DBNull.Value),
				new SqlParameter("@email", (object)emp1.email ?? DBNull.Value),
				new SqlParameter("@salary", (object)emp1.salary ?? DBNull.Value),
				new SqlParameter("@bundle", (object)emp1.bundle ?? DBNull.Value),
				new SqlParameter("@isQuitted", (object)emp1.isQuitted ?? DBNull.Value),
				new SqlParameter("@startDate", (object)emp1.startDate ?? DBNull.Value),
				new SqlParameter("@quitDate", (object)emp1.quitDate ?? DBNull.Value),
				new SqlParameter("@empTypeID", (object)emp1.empTypeID ?? DBNull.Value),
				new SqlParameter("@id", (object)emp1.id ?? DBNull.Value));
		}
		public int Delete(int id)
		{
			string command = "DELETE FROM Emp WHERE id = " + id.ToString();
			return (int)Helper.ExecuteNonQuery(command, CommandType.Text);
		}
	}
    #endregion

	public class SizeSetView: BaseTable
    {
		public List<SizeSetItemGroupSize> sizeUnits;
    }

	public class SizeSetItemGroupSize
    {
		public int sizeSetID;
		public int sizeID;
		public string sizeName;
		public int units;
    }
	public class Supplier : BaseTable
    {
		public string abbrev;
		public string tel;
		public string address;
		public int isQuitted;

		private DataTable selectSupplier(string command)
        {
			DataTable dt = new DataTable();
			dt.Load(Helper.ExecuteReader(command, System.Data.CommandType.Text));
			return dt;
		}
		public DataTable select ()
        {
			return selectSupplier("SELECT * FROM Supplier Order By ID");
		}
		public DataTable select (string criteria)
        {
			return selectSupplier("SELECT * FROM Emp " + criteria);
		}
	}
#pragma warning restore IDE1006 // Naming Styles
}
