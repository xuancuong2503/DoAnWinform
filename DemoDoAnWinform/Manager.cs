using DemoDoAnWinform.DAO;
using DemoDoAnWinform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace DemoDoAnWinform
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            loadFood();
        }
        #region Method
        void loadFood()
        {
           List<MainFood> foodList = MainFoodDAO.Instance.loadMainFood();
            foreach(MainFood item in foodList)
            {
                Button btn = new Button() { Width = MainFoodDAO.FoodWidth, Height = MainFoodDAO.FoodHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click +=btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Hot Deal":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flpMon.Controls.Add(btn);
            }
        }
        void showBill(int id)
        {
            lsvBill.Items.Clear();
            List<BillInfo> listBillInfo = BilllInfoDAO.Instance.GetListBillInfo(BillDAO.Instance.GetUnCheckBillIDByFoodID(id));
            foreach(BillInfo item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodID.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvBill.Items.Add(lsvItem);
            }
        }

        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int foodID=((sender as Button).Tag as MainFood).ID;
            showBill(foodID);
        }
        private void nmFoodCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile f = new AccountProfile();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        #endregion
    }
}
