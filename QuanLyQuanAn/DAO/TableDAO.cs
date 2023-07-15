using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    internal class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance { get { if (instance == null) instance = new TableDAO(); return instance; } set => instance = value; }
        private TableDAO() { }
        public static int tableWidth = 90;
        public static int tableHeight = 90;
        public List<Table> LoadListTable()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExcuteQuery("EXEC USP_GetTableList");
            foreach (DataRow row in data.Rows)
            {
                Table t = new Table(row);
                tableList.Add(t);
            }
            
            return tableList;
        }
        public int addTable(string name)
        {
            int i = DataProvider.Instance.ExcuteNonQuery("insert TableFood(name,status) values(N'" + name + "',N'Trống')");
            return i;
        }
        public int editTable(int id,string name)
        {
            int i = DataProvider.Instance.ExcuteNonQuery(string.Format("update dbo.TableFood set name = N'{0}' where id = {1}",name, id));
            return i;
        }
        public int deleteTable(int id)
        {
            int i = DataProvider.Instance.ExcuteNonQuery("delete from TableFood where id = " + id);
            return i;
        }
    }
}
