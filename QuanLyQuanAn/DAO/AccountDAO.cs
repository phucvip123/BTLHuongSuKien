using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        internal static AccountDAO Instance { get { if (instance == null) instance = new AccountDAO(); return instance; } private set => instance = value; }
        private AccountDAO() { }
        public int Login(string username, string password)
        {
            string query = @"USP_Login @username , @password";
            DataProvider.Instance.ExcutScalar("update Account set count = count + 1 where username = N'" + username+"'");
            int i = Convert.ToInt16(DataProvider.Instance.ExcutScalar("select count from account where username = N'" + username+"'"));
            if (i > 3)
            {
                return -1;
            }
            else
            {
                DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { username, password });
                return result.Rows.Count;
            }
            
        }
        public int GetTypeAccount(string username)
        {
            int type = 0;
            
            type = int.Parse(DataProvider.Instance.ExcutScalar(@"select type from dbo.Account where username = '" + username + @"'").ToString());

            return type;
        }
        public Account GetAccountByUserName(string username)
        {
            Account account = null;
            DataTable dt = DataProvider.Instance.ExcuteQuery(@"select * from Account where UserName =  '" + username +@"'");
            foreach (DataRow row in dt.Rows)
            {
                account = new Account(row);
            }

            return account;     

        }
        public void UpdateAccount(Account account,string newPassword)
        {
            DataProvider.Instance.ExcuteQuery("USP_UpdateAccount @displayname , @password , @username",new object[] {account.Displayname,newPassword,account.Username});
        }
        public int deleteAccount(string user)
        {
            int i = 0;
            DataTable kt = DataProvider.Instance.ExcuteQuery("select * from account where username = N'" + user + "'");
            if (kt.Rows.Count == 1)
                i = DataProvider.Instance.ExcuteNonQuery("delete from account where username = N'"+user+"'");
            return i;
        }
        public int addAccount(string user,string displayname,int type)
        {
            int i = 0;
            DataTable kt = DataProvider.Instance.ExcuteQuery("select * from account where username = N'" + user + "'");
            if(kt.Rows.Count == 0)
                i = DataProvider.Instance.ExcuteNonQuery(string.Format("insert account(username,displayname,type,password) values(N'{0}',N'{1}',{2},N'{3}')",user,displayname,type,"12345"));
            return i;
        }
        public int editAccount(string user, string displayname, int type)
        {
            int i = 0;
            DataTable kt = DataProvider.Instance.ExcuteQuery("select * from account where username = N'" + user + "'");
            if (kt.Rows.Count == 1)
                i = DataProvider.Instance.ExcuteNonQuery(string.Format("update account set username = N'{0}',displayname = N'{1}',type = {2}", user, displayname, type));
            return i;
        }
    }
}
