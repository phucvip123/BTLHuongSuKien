using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
    public class Account
    {
        private string username;
        private string password;
        private string displayname;
        private int type;
        public Account(string username, string password, int type, string displayname)
        {
            this.username = username;
            this.password = password;
            this.type = type;
            this.displayname = displayname;

        }
        public Account(DataRow row)
        {
            this.username = row["UserName"].ToString();
            this.password = row["Password"].ToString();
            this.displayname = row["DisplayName"].ToString();
            this.type = int.Parse(row["Type"].ToString());
        }


        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Displayname { get => displayname; set => displayname = value; }
        public int Type { get => type; set => type = value; }
    }
}
