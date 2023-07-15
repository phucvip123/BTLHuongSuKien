using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    internal class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance { get { if (instance == null) instance = new FoodDAO();return instance; } private set => instance = value; }
        private FoodDAO() { }
        public List<Food> GetListFoodByID(int id)
        {
            List<Food> list = new List<Food> ();
            string query = "select id,name,price from Food where idCategory = " + id;
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow dr in dt.Rows)
            {
                Food f = new Food (dr);
                list.Add(f);
            }
            return list;
        }
        public DataTable GetListFood()
        {
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExcuteQuery(@"select f.id as N'Id', f.name as N'Name',f.price as N'Price', fc.name as N'Category' from food as f,FoodCategory as fc where f.idCategory = fc.id");
            return dt;
        }
        public List<Food> GetListFoodByName(string name)
        {
            List<Food> listFood = new List<Food>();
            string query = string.Format("select * from dbo.Food where name like N'%{0}%'", name);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                Food f = new Food (dr);
                listFood.Add(f);
            }
            return listFood;
        }
        public int AddFood(string name,int type,int price)
        {
            int i = 0;
            string query = string.Format("insert dbo.Food(Name,idCategory,price) values(N'{0}',{1},{2})", name, type, price);
            i = DataProvider.Instance.ExcuteNonQuery(query);
            return i;
        }
        public int DeleteFood(int id)
        {
            int i = 0;
            string query = string.Format("delete from dbo.Food where id = {0}", id);
            i = DataProvider.Instance.ExcuteNonQuery(query);
            return i;
        }
        public int EditFood(int id,string name,int type,int price)
        {
            int i = 0;
            string query = string.Format("update Food set name = N'{0}', price = {1}, idCategory = {2} where id = {3}", name, price, type, id);
            i = DataProvider.Instance.ExcuteNonQuery(query);
            return i;
        }
    }
}
