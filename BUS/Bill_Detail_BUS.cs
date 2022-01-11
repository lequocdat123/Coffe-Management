using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Bill_Detail_BUS
    {
            Bill_Detail_DTO billdetail = new Bill_Detail_DTO();
            public Bill_Detail_BUS() { }
            public Bill_Detail_BUS(int idbill, int idproduct, int quantity, long price)
            {
                billdetail = new Bill_Detail_DTO( idbill, idproduct,quantity, price);
            }
            public bool Insert()
            {
                return billdetail.InsertBill_Detail();
            }
            public DataTable DisplayBill(string sql)
            {
                return billdetail.Display_Bill_Detail(sql);
            }
        }
    }
