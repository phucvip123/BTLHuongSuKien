using QuanLyQuanAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanAn.DAO
{
    internal class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance { get { if (instance == null) instance = new FoodCategoryDAO();return instance; } private set => instance = value; }
        private FoodCategoryDAO() { }

        public List<FoodCategory> GetListCategory()
        {
            List<FoodCategory> list = new List<FoodCategory>();
            DataTable tb = DataProvider.Instance.ExcuteQuery("select * from FoodCategory");
            foreach (DataRow dr in tb.Rows)
            {
                FoodCategory fc = new FoodCategory(dr);
                list.Add(fc);
            }
            return list;
        }
        public List<FoodCategory> GetListFoodCategory()
        {
            List<FoodCategory> listCategory = new List<FoodCategory>();
            DataTable dt = DataProvider.Instance.ExcuteQuery("select * from dbo.FoodCategory");
            foreach (DataRow dr in dt.Rows)
            {
                FoodCategory f = new FoodCategory(dr);
                listCategory.Add(f);
            }
            return listCategory;
        }
        public int deleteFoodCategory(int id)
        {
            int i = DataProvider.Instance.ExcuteNonQuery("delete from dbo.FoodCategory where id = " + id);
            return i;
        }
        public int addFoodCategory(string name)
        {
            int i = DataProvider.Instance.ExcuteNonQuery("insert FoodCategory(name) values(N'"+name+"')");
            return i;
        }
        public int editFoodCategory(int id, string name)
        {
            string query = string.Format("update FoodCategory set name = N'{0}' where id = {1}",name,id);
            int i = DataProvider.Instance.ExcuteNonQuery(query);
            return i;
        }
    }
}
