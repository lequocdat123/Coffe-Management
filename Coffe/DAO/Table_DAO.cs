using CoffeShopManagerment.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CoffeShopManagerment.DAO
{
    public class Table_DAO
    {
        private static Table_DAO instance;

        public static Table_DAO Instance
        {
            get { if (instance == null) instance = new Table_DAO(); return Table_DAO.instance; }
            private set { Table_DAO.instance = value; }
        }

        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private Table_DAO() { }

/*        public void SwitchTable(int id1, int id2)
        {
            DBConnection.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }*/

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DBConnection.Instance.ExecuteQuery("SELECT * FROM SEAT");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }
        public int UpdateStatus(int id, int status)
        {
            string query = $"UPDATE Seat SET Status = {status} WHERE ID ={id}";
            return DBConnection.Instance.ExecuteNonQuery(query);
        }

        public int InsertTable (int id, int status)
        {
            string query = $"INSERT INTO SEAT(ID,Status) VALUES({id},{status})";

            return DBConnection.Instance.ExecuteNonQuery(query);
        }
        public int InsertTable(int status)
        {
            string query = $"INSERT INTO SEAT(Status) VALUES({status})";

            return DBConnection.Instance.ExecuteNonQuery(query);
        }
        public int DeleteTable(int id)
        {
            string query = $"Delete From SEAT Where id = {id}";

            return DBConnection.Instance.ExecuteNonQuery(query);
        }
    }
}
