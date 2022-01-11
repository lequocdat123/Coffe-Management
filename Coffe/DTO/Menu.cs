using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DTO
{
    public class Menu
    {
        public Menu(int id,int idproduct,string productName, int count, long price,string img, long totalPrice = 0)
        {
            this.ProductName = productName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
            this.ID = id; //ID Bill
            this.IDProduct = idproduct; //ID của product
            this.Image = img;
        }

        public Menu()
        {
          
        }
        public Menu(DataRow row)
        {
            this.ProductName = row["Name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (long)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (long)Convert.ToDouble(row["totalPrice"].ToString());
            this.ID = (int)Convert.ToInt32(row["ID"].ToString());
            this.IDProduct = (int)Convert.ToInt32(row["IDProduct"].ToString());
            this.Image = row["Image"].ToString();




        }

        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        private long totalPrice;

        public long TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        private long price;

        public long Price
        {
            get { return price; }
            set { price = value; }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private int idProduct;

        public int IDProduct
        {
            get { return idProduct; }
            set { idProduct = value; }
        }
    }
}
