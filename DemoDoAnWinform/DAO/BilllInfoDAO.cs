using DemoDoAnWinform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnWinform.DAO
{
    public class BilllInfoDAO
    {
        private static BilllInfoDAO instance;

        public static BilllInfoDAO Instance
        {
            get { if (instance == null) instance = new BilllInfoDAO(); return BilllInfoDAO.instance; }
            private set { BilllInfoDAO.instance = value; }
        }
        private BilllInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.BillInfo where idBill =" + id);
            foreach(DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }
    }
}
