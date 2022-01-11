using CoffeShopManagerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DAO
{
    public class Product_DAO
    {
        private static Product_DAO instance;

        public static Product_DAO Instance
        {
            get { if (instance == null) instance = new Product_DAO(); return Product_DAO.instance; }
            private set { Product_DAO.instance = value; }
        }

        private Product_DAO() { }

        public List<Product> GetProductByType(string type)
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product where Type = " + type;

            DataTable data = DBConnection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product Product = new Product(item);
                list.Add(Product);
            }

            return list;
        }

        public List<Product> GetListProduct()
        {
            List<Product> list = new List<Product>();

            string query = "select * from Product";

            DataTable data = DBConnection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Product Product = new Product(item);
                list.Add(Product);
            }

            return list;
        }


        public bool InsertProduct(string name, string type, long price, string image)
        {
            string query = string.Format("INSERT INTO Product ( name, type, price,image )VALUES  ( N'{0}', N'{1}', {2},N'{3}')", name, type, price, image);
            int result = DBConnection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateProduct(int idProduct, string name, string type, long price, string image)
        {
            string query = string.Format("UPDATE Product SET name = N'{0}', type = N'{1}', price = {2}, image = N'{3}' WHERE id = {4}", name, type, price, image,idProduct);
            int result = DBConnection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteProduct(int idProduct)
        {
            /*BillInfoDAO.Instance.DeleteBillInfoByProductID(idProduct);*/

            string query = string.Format("Delete From Product where id = {0}", idProduct);
            int result = DBConnection.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
