using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace DTO
{
    public class Product_DTO : DBConnection
    {
        public string nameProduct;
        public int idProduct;
        public string typeProduct;
        public long price;
    

        public Product_DTO() { }
        public Product_DTO(int id, string name, string type, long price)
        {
            this.idProduct = id;
            this.nameProduct = name;
            this.typeProduct = type;
            this.price = price;
        }
        public bool InsertProduct()
        {
            try
            {
                con.Open();

                string SQL = string.Format($"INSERT INTO Product ( Name, Type, Price) VALUES (N'{nameProduct}',N'{typeProduct}',{price})");

                MySqlCommand cmd = new MySqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }
        public bool DeleteProduct(string ID)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from Product where ID ='{0}'", ID);

                MySqlCommand cmd = new MySqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }
        public bool EditProduct(int ID, string Name, string Type,long Price)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE Product SET " +
                    "Name = '{1}',Type = '{2}',Price = '{3}'   where ID = {0}", ID, Name, Type, Price);

                MySqlCommand cmd = new MySqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return false;
        }
        public DataTable DisplayProduct(string sql)
        {
            DataTable tblProduct = new DataTable();
            MySqlDataAdapter adt = new MySqlDataAdapter();

            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblProduct);  //Fill vào một biến kiểu Datatable
                return tblProduct;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }
    }

}
