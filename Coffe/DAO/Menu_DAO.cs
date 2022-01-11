using CoffeShopManagerment.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DAO
{
    public class Menu_DAO
    {
        private static Menu_DAO instance;

        public static Menu_DAO Instance
        {
            get { if (instance == null) instance = new Menu_DAO(); return Menu_DAO.instance; }
            private set { Menu_DAO.instance = value; }
        }

        private Menu_DAO() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = $"SELECT b.id,f.ID as IDProduct,f.name,f.image, f.price,bi.Count, bi.totalPrice  FROM Bill_Detail AS bi, Bill AS b, Product AS f WHERE bi.idBill = b.id AND bi.idProduct = f.id AND b.status = 0 AND b.idTable = {id}";
            DataTable data = DBConnection.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
