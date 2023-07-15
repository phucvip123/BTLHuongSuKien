using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    internal class BillInforDAO
    {
        private static BillInforDAO instance;

        internal static BillInforDAO Instance { get { if (instance == null) instance = new BillInforDAO();return instance; }
        private set => instance = value; }

       
        public void InsertBillInfor(int idBill,int idFood,int count)
        {
            string query = "USP_InsertBillInfor @idBill , @idFood , @count";
            DataProvider.Instance.ExcuteQuery(query, new object[] {idBill,idFood,count });
        }
    }
}
