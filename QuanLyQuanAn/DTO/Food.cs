using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DTO
{
    internal class Food
    {
        private int id;
        private string name;
        private int price;
        public Food(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public Food(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["name"].ToString();
            this.price = Convert.ToInt32(row["price"].ToString());
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
