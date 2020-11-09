using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnWinform.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dataCheckIn,DateTime? dataCheckout,int status)
        {
            this.ID = id;
            this.DataCheckIn = dataCheckIn;
            this.DataCheckout = dataCheckout;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DataCheckIn = (DateTime?)row["dataCheckIn"];
            var dataCheckoutTemp = row["dataCheckout"];
            if(dataCheckoutTemp.ToString()!="")
             this.DataCheckout = (DateTime?)dataCheckoutTemp;

            this.Status = (int)row["status"];
        }
        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private DateTime? dataCheckout;
        public DateTime? DataCheckout 
        {
            get { return dataCheckout; }
            set { dataCheckout = value; }
        }
        private DateTime? dataCheckIn;
        public DateTime? DataCheckIn 
        { get { return dataCheckIn; }
          set { dataCheckIn = value; } 
        }
        private int iD;

        public int ID 
        { get {return iD; }
          set { iD = value;}
        }

       
    }
}
