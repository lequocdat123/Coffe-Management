using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopManagerment.DTO
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int id, string name, string type, long price, string image)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.Price = price;
            this.Image = image;
        }
        public Product(Product product)
        {
            this.ID = product.ID;
            this.Name = product.Name;
            this.Type = product.Type;
            this.Price = product.Price;
            this.Image = product.Image;
        }
        public Product(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Type = (string)row["Type"];
            this.Price = (long)Convert.ToDouble(row["price"].ToString());
            this.Image = row["Image"].ToString();

        }
        private string image;

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        private long price;

        public long Price
        {
            get { return price; }
            set { price = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
