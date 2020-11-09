using DemoDoAnWinform.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDoAnWinform.DAO
{
     public class MainFoodDAO
    {
        private static MainFoodDAO instance;

        public static MainFoodDAO Instance
        {
            get { if (instance == null) instance = new MainFoodDAO(); return MainFoodDAO.instance; }  
            private set { MainFoodDAO.instance = value;}
        }
        public static int FoodWidth = 70;
        public static int FoodHeight = 70;
        private MainFoodDAO() { }
        
      public List<MainFood> loadMainFood()
        {
            List<MainFood> foodList = new List<MainFood>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetMainFoodList");
            foreach(DataRow item in data.Rows)
            {
                MainFood food = new MainFood(item);
                foodList.Add(food);
            }
            return foodList;
        }
    }
}
