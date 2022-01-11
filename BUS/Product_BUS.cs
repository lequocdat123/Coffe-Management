using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace BUS
{
    public class Product_BUS
    {
        public string nameProduct;
        public int idProduct;
        public string typeProduct;
        public long price;

        Product_DTO product = new Product_DTO();
        string imgURL = "../../Resources/Images/product-1.png";
        public Product_BUS()
        {
            product = new Product_DTO();
        }
        public Product_BUS(Product_BUS _prod)
        {
            nameProduct = _prod.nameProduct;
            idProduct = _prod.idProduct;
            typeProduct = _prod.typeProduct;
            this.price = _prod.price;
            product = new Product_DTO(idProduct,nameProduct, typeProduct, price);
        }
        public Product_BUS(int id, string name, string type, long price)
        {
            nameProduct = name;
            idProduct = id;
            typeProduct = type;
            this.price = price;
            product = new Product_DTO(id, name, type, price);
        }

        public string getProductName()
        {
            return product.nameProduct;
        }
        public string getProductImg()
        {
            return imgURL;
        }
        public long getProductPrice()
        {
            return product.price;
        }
        public int getProductId()
        {
            return product.idProduct;
        }
        public bool insertProduct()
        {
            return product.InsertProduct();
        }
        public bool deleteProduct(string s)
        {
            return product.DeleteProduct(s);
        }
        public bool editProduct(int id, string name, string type, long price)
        {
            return product.EditProduct(id, name, type, price);
        }
        public DataTable displayProduct(string sql)
        {
            return product.DisplayProduct(sql);
        }
    }
}
