using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManagementTaskProject
{
    public enum ErrorCodes
    {
        NONE = 0,
        WRONG_TYPE,
        WRONG_ITEM,
        WRONG_Price,
        WRONG_KCAL,
        WRONG_VALUE 
    }
    interface ICalulateKcalPerS
    {
        double CalKcalPerDay(string size);//計算熱量佔每日總量佔比
        double CalKcalPerTWD(string size);//計算每元能買到多少熱量
    }
    public class AllMeals
    {
        public string Item;
        protected int _Price;

        public int Price //沒有0元的東西
        {
            get { return this._Price; }
            set
            {
                if (value < 0)
                    value = 1;
                this._Price = value;
            }
        } 
    }
    public class MainMeal: AllMeals, ICalulateKcalPerS
    {
        public int Kcal;
        public MainMeal(string item, int price, int kcal)
        {
            this.Item = item;
            this.Price = price;
            this.Kcal = kcal;
        }
        public double CalKcalPerDay(string size)
        {
            return (double)Kcal / 2000*100;
        }
        public double CalKcalPerTWD(string size)
        {
            return (double)Kcal / (double)Price;
        }
        public static MainMeal operator *(MainMeal mainmeal,int newprice)
        {
            int Price = newprice;
            return new MainMeal(mainmeal.Item, Price, mainmeal.Kcal);
        }
        public static MainMeal operator *(int newprice, MainMeal mainmeal)
        {
            return mainmeal* newprice;
        }
    }
    public class Combo : AllMeals
    {
        public Combo(string item, int price)
        {
            this.Item = item;
            this.Price = price;
        }
        public static Combo operator *(Combo combo, int newprice)
        {
            int Price = newprice;
            return new Combo(combo.Item, Price);
        }
        public static Combo operator *(int newprice, Combo combo)
        {
            return combo* newprice;
        }
    }
    public class ALaCarte : AllMeals, ICalulateKcalPerS
    {
        public int Price_max;
        public int Kcal, Kcal_max;
        public ALaCarte(string item, int price, int kcal, int price_max, int kcal_max)
        {
            this.Item = item;
            this.Price = price;
            this.Kcal = kcal;
            this.Price_max = price_max;
            this.Kcal_max = kcal_max;
        }
        public double CalKcalPerDay(string size)
        {
            if (size == "大")
                return (double)Kcal_max * 100 / 2000;
            else
                return (double)Kcal * 100 / 2000;
        }
        public double CalKcalPerTWD(string size)
        {
            if (size == "大")
                if (Price_max != 0)
                    return (double)Kcal_max / (double)Price_max;
                else
                    return 0;
            else
                if (Price != 0)
                    return (double)Kcal / (double)Price;
                else
                    return 0;
        }
        public static ALaCarte operator *(ALaCarte alacarte, int newprice)
        {
            int Price = newprice;
            return new ALaCarte(alacarte.Item, Price, alacarte.Kcal,alacarte.Price_max,alacarte.Kcal_max);
        }
        public static ALaCarte operator *(int newprice, ALaCarte alacarte)
        {
            return alacarte * newprice;
        }
    }

    public class ManagementTask
    {
        public List<Object> Meals = new List<Object>();
        public ManagementTask()
        {

        }
        public void LoadTaskFile(String FileName)
        {
            String CurLine;
            StreamReader TaskText = new StreamReader(FileName);
            while (TaskText.Peek() >= 0)
            {
                CurLine = TaskText.ReadLine();
                AddItem2Meal(CurLine);
            }
            TaskText.Close();//關掉不然不能覆寫掉
        }
        public void AddItem2Meal(string CurLine)//讀檔存入class
        {
            String[] Piecewise;
            if (CurLine.Contains("主餐"))
            {
                Piecewise = CurLine.Trim().Split(':');
                Piecewise = Piecewise[1].Trim().Split(' ');
                Meals.Add(new MainMeal(Piecewise[0], Convert.ToInt32(Piecewise[1]), Convert.ToInt32(Piecewise[2])));
            }
            else if (CurLine.Contains("套餐"))
            {
                Piecewise = CurLine.Trim().Split(':');
                Piecewise = Piecewise[1].Trim().Split(' ');
                Meals.Add(new Combo(Piecewise[0], Convert.ToInt32(Piecewise[1])));
            }
            else if (CurLine.Contains("單點"))
            {
                Piecewise = CurLine.Trim().Split(':');
                Piecewise = Piecewise[1].Trim().Split(' ');
                Meals.Add(new ALaCarte(Piecewise[0], Convert.ToInt32(Piecewise[1]), Convert.ToInt32(Piecewise[2]), Convert.ToInt32(Piecewise[3]),Convert.ToInt32(Piecewise[4])));
            }
        }
        public int MealsIndex(Object meals)
        {
            for (int i = 0; i < Meals.Count(); i++)
            {
                if (Meals[i] == meals)
                    return i;
            }
            return -1;
        }
    }
}
