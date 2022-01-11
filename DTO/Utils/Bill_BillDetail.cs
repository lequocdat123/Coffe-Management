using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DTO.Utils
{
    public class Bill_BillDetail
    {
        Bill_DTO bill = new Bill_DTO();
        List<Bill_Detail_DTO> billDetails = new List<Bill_Detail_DTO>();
        public Bill_BillDetail(Bill_DTO bill, List<Bill_Detail_DTO> billDetails)
        {
            //Deep Clone
            string billJSON = JsonSerializer.Serialize(bill);
            this.bill = JsonSerializer.Deserialize<Bill_DTO>(billJSON);


            foreach (var item in billDetails)
            {
                string billDetailsJSON = JsonSerializer.Serialize(item);
                this.billDetails.Add(JsonSerializer.Deserialize<Bill_Detail_DTO>(billDetailsJSON));
            }
        }
        public Bill_BillDetail()
        {

        }
        public void  setBill(Bill_DTO bill)
        {
            //Deep Clone
            string billJSON = JsonSerializer.Serialize(bill);
            this.bill = JsonSerializer.Deserialize<Bill_DTO>(billJSON);

        }
        public void setBillDetails(List<Bill_Detail_DTO> billDetails)
        {
            foreach (var item in billDetails)
            {
                string billDetailsJSON = JsonSerializer.Serialize(item);
                this.billDetails.Add(JsonSerializer.Deserialize<Bill_Detail_DTO>(billDetailsJSON));
            }

        }

    }
}
