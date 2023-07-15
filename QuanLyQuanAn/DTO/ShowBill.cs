using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
    internal class ShowBill
    {
        private string name;
        private int count;
        private int price;
        private int amount;
        public ShowBill(string name, int count, int price, int amount)
        {
            this.name = name;
            this.count = count; 
            this.price = price;
            this.amount = amount;
        }
        public ShowBill(DataRow row) {
            this.name = row["Name"].ToString();
            this.count = int.Parse(row["Count"].ToString());
            this.price = int.Parse(row["Price"].ToString());
            this.amount = int.Parse(row["Amount"].ToString());
        }
        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public int Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
    }

}
