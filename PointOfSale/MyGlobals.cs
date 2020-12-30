using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    static class SettingClass
    {
        public static int deviceID;
        public static int brachID;
        public static int comPort;
        public static int resX;
        public static int resY;
        public static string dropboxPath;
        public static string imagePath;
        public static decimal moneyDrawer;
        public static string dotPrinter;
        public static string a4Printer;
        public static int isHQ;

        public static string deviceName = "G7-PC"; // ต้องเอาชื่อโดย Query จาก Device 
    }

    static class MyGlobals
    {
        public static DataSet ds = new DataSet();
        public static DataTable dtCurrentEmp = new DataTable(); // id, name เท่านั้น
        public static DataTable dtLogInEmp = new DataTable();
    }
    enum EditState
    {
        Viewing,
        Editing,
        Adding
    }
}
