using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    internal class BillDAO
    {
        private static BillDAO instance;

        internal static BillDAO Instance { get { if (instance == null) instance = new BillDAO();return instance; } private set => instance = value; }
        private BillDAO() { }
        /// <summary>
        /// Fail return -1
        /// Success return idBill
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetIdBill(int id)
        {
            int idBill;
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.Bill where idTable = " + id +" and status = 0");
            if(table.Rows.Count > 0)
            {
                idBill = Convert.ToInt32(table.Rows[0]["id"].ToString());
                return idBill;
            }
            return -1;
        }
        public int GetMaxIdBill()
        {
            try
            {
                int max = (int)DataProvider.Instance.ExcutScalar("Select max(id) from dbo.Bill");
                return max ;
            }
            catch { return 1; }

        }
        public void InsertBill(int idTable)
        {
            string query = "USP_InsertBill @idTable";
            DataProvider.Instance.ExcuteNonQuery(query,new object[] { idTable });
        }
        public void checkOut(int idBill,int idTable,int total)
        {
            int id = BillDAO.Instance.GetIdBill(idTable);
            string query = " update  dbo.Bill set status = 1 , Total = " + total +" where id = " + idBill + "\n update bill set DateCheckOut = GETDATE() where id = " + id;
            DataProvider.Instance.ExcuteNonQuery(query);
            DataProvider.Instance.ExcuteNonQuery("exec USP_Checkout @idTable", new object[] { idTable });
        }
        public DataTable ShowBillRevune(DateTime d1,DateTime d2)
        {
            DataTable dataTable = new DataTable();
            dataTable = DataProvider.Instance.ExcuteQuery("exec USP_GetBillByDatetime @d1 , @d2 ",new object[] { d1, d2 });
            return dataTable;
        }
    }
}
