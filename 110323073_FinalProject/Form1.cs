using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ManagementTaskProject;

namespace _110323073_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo ProjectDir = new DirectoryInfo(System.Windows.Forms.Application.StartupPath);
            openFileDialog_Load.InitialDirectory = ProjectDir.Parent.Parent.FullName;
            openFileDialog_Load.Filter = "txt FIles (*.txt)|*.txt|All Files (*.*)|*.*";
        }
        private void button_Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog_Load.ShowDialog() == DialogResult.OK)
            {
                CurManagementTask = new ManagementTask(); 
                CurManagementTask.LoadTaskFile(openFileDialog_Load.FileName);
                panelSave.Enabled = true;
                MealsItem2ListBox();
            }
            
            
        }
        private void MealsItem2ListBox()
        {
            MainMealSelectInListBox = CurManagementTask.Meals.FindAll(delegate (Object obj) { return obj.GetType() == typeof(MainMeal); });
            foreach (Object CurMeal in MainMealSelectInListBox)
            {
                MainMeal CurMainMeal = (MainMeal)CurMeal;
                listBox_MainMeal.Items.Add(CurMainMeal.Item + " : " + CurMainMeal.Price + "元,  " + CurMainMeal.Kcal + "Kcal");
                
            }
            ComboSelectInListBox = CurManagementTask.Meals.FindAll(delegate (Object obj) { return obj.GetType() == typeof(Combo); });
            foreach (Object CurMeal in ComboSelectInListBox)
            {
                Combo CurCombo = (Combo)CurMeal;
                listBox_Combo.Items.Add(CurCombo.Item + " : " + CurCombo.Price + "元");
            }
            ALaCarteSelectInListBox = CurManagementTask.Meals.FindAll(delegate (Object obj) { return obj.GetType() == typeof(ALaCarte); });
            foreach (Object CurMeal in ALaCarteSelectInListBox)
            {
                ALaCarte CurALaCarte = (ALaCarte)CurMeal;
                listBox_ALaCarte.Items.Add(CurALaCarte.Item + " : " + CurALaCarte.Price + "元, " + CurALaCarte.Kcal + "Kcal  " +
                                                       "L:(" + CurALaCarte.Price_max + "元, " + CurALaCarte.Kcal_max + "Kcal)");

            }
            Refresh();
        }
        private void FormAdd_FormClosedInMainForm(object sender, EventArgs e)
        {
            FormAdd CurrentFormAdd = (FormAdd)sender;
            NewItemInForm1 = CurrentFormAdd.NewItem;
            if (NewItemInForm1 != null)
            {
                CurManagementTask.AddItem2Meal(NewItemInForm1);
                MealsItem2ListBox();

                ModifyTxt();
                ReadTxt();
            }
        }
        private void button_Add_Click(object sender, EventArgs e)//開檔
        {
            FormAdd CurrentFormAdd = new FormAdd();
            CurrentFormAdd.Show();
            CurrentFormAdd.FormClosed += new FormClosedEventHandler(FormAdd_FormClosedInMainForm);
        }

        private void ModifyTxt()//寫入選取版本
        {
            FileInfo f = new FileInfo("..//..//NewMenu//"+ comboBoxSave.Text+".txt");
            StreamWriter sw = f.CreateText();
            foreach (MainMeal CurMeal in MainMealSelectInListBox)
            {
                sw.WriteLine("主餐 : " + CurMeal.Item + " " + CurMeal.Price + " " + CurMeal.Kcal);
            }
            foreach (Combo CurMeal in ComboSelectInListBox)
            {
                sw.WriteLine("套餐 : " + CurMeal.Item + " " + CurMeal.Price);
            }
            foreach (ALaCarte CurMeal in ALaCarteSelectInListBox)
            {
                sw.WriteLine("單點 : " + CurMeal.Item + " " + CurMeal.Price + " " + CurMeal.Kcal + " " +
                                                              CurMeal.Price_max + " " + CurMeal.Kcal_max);
            }
            sw.Flush(); //將存於Buffer緩衝區內資料寫入指定檔案
            sw.Close();//關閉目前資料流
            
        }
        private void ReadTxt() //讀檔、丟進listbox
        {
            listBox_MainMeal.Items.Clear();
            listBox_Combo.Items.Clear();
            listBox_ALaCarte.Items.Clear();
            CurManagementTask = new ManagementTask();
            CurManagementTask.LoadTaskFile("..//..//NewMenu//" + comboBoxSave.Text + ".txt");
            MealsItem2ListBox();
        }
        private void button_Delete_Click(object sender, EventArgs e)//刪除listbox選取項目
        {
            int Len1 = listBox_MainMeal.SelectedIndices.Count - 1;
            for (int i = Len1; i >= 0; i--)
            {
                MainMealSelectInListBox.RemoveAt(listBox_MainMeal.SelectedIndices[i]);
            }
            int Len2 = listBox_Combo.SelectedIndices.Count - 1;
            for (int i = Len2; i >= 0; i--)
            {
                ComboSelectInListBox.RemoveAt(listBox_Combo.SelectedIndices[i]);
            }
            int Len3 = listBox_ALaCarte.SelectedIndices.Count - 1;
            for (int i = Len3; i >= 0; i--)
            {
                ALaCarteSelectInListBox.RemoveAt(listBox_ALaCarte.SelectedIndices[i]);
            }
            SumPrice1 = 0; SumKcal1 = 0; SumKcalPerDay1 = 0; SumPricePerNTD1 = 0;//防止最後選取項殘留
            SumPrice2 = 0;
            SumPrice3 = 0; SumKcal3 = 0; SumKcalPerDay3 = 0; SumPricePerNTD3 = 0;

            ModifyTxt();
            ReadTxt();
            

        }
        private void listBox_Entire_SelectedIndexChanged(object sender, EventArgs e)//將3個listbox合併成一個來控制
        {
            if (CurManagementTask == null) return;

            if (sender.Equals(listBox_MainMeal))
            {
                SumPrice1 = 0; SumKcal1=0;
                SumKcalPerDay1 = 0; SumPricePerNTD1 = 0;
                for (int i = 0; i < listBox_MainMeal.SelectedIndices.Count; i++)
                {
                    object CurMainMeal = MainMealSelectInListBox[listBox_MainMeal.SelectedIndices[i]];
                    MainMeal curMain = (MainMeal)CurMainMeal;
                    SumPrice1 += curMain.Price; SumKcal1 += curMain.Kcal; SumKcalPerDay1 += curMain.CalKcalPerDay(comboBoxSize.Text);
                    SumPricePerNTD1 += curMain.CalKcalPerTWD(comboBoxSize.Text);
                }
            }
            else if (sender.Equals(listBox_Combo))
            {
                SumPrice2 = 0;
                for (int i = 0; i < listBox_Combo.SelectedIndices.Count; i++)
                {
                    object CurCombo = ComboSelectInListBox[listBox_Combo.SelectedIndices[i]];
                    Combo curCombo = (Combo)CurCombo;
                    SumPrice2 += curCombo.Price;
                }
            }
            else if (sender.Equals(listBox_ALaCarte))
            {
                SumPrice3 = 0; SumKcal3 = 0;
                SumKcalPerDay3 = 0; SumPricePerNTD3 = 0; 
                for (int i = 0; i < listBox_ALaCarte.SelectedIndices.Count; i++)
                {
                    object CurALaCarte = ALaCarteSelectInListBox[listBox_ALaCarte.SelectedIndices[i]];
                    ALaCarte curALa = (ALaCarte)CurALaCarte;


                    if (comboBoxSize.Text == "大")
                    {
                        SumPrice3 += curALa.Price_max; SumKcal3 += curALa.Kcal_max;
                    }
                    else
                    {
                        SumPrice3 += curALa.Price; SumKcal3 += curALa.Kcal;
                    }

                    SumKcalPerDay3 += curALa.CalKcalPerDay(comboBoxSize.Text);
                    SumPricePerNTD3 += curALa.CalKcalPerTWD(comboBoxSize.Text);
                }
            }
            labelSumPrice.Text = (SumPrice1+ SumPrice2 + SumPrice3).ToString(); labelSumKcal.Text = (SumKcal1+ SumKcal3).ToString();
            labelperNTD.Text = (SumPricePerNTD1+SumPricePerNTD3).ToString(); labelPerDay.Text = (SumKcalPerDay1+ SumKcalPerDay3).ToString();
        }
        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if (CurManagementTask == null) return;
            int newprice = Convert.ToInt32(textBox_NewPrice.Text);

            for (int i = 0; i < listBox_MainMeal.SelectedIndices.Count; i++)
            {
                object CurMainMeal = MainMealSelectInListBox[listBox_MainMeal.SelectedIndices[i]];
                MainMeal curMain = (MainMeal)CurMainMeal;
                CurManagementTask.Meals[CurManagementTask.MealsIndex(CurMainMeal)] = curMain * newprice;//operator修改價錢
            }


            for (int i = 0; i < listBox_Combo.SelectedIndices.Count; i++)
            {
                object CurCombo = ComboSelectInListBox[listBox_Combo.SelectedIndices[i]];
                Combo curCombo = (Combo)CurCombo;
                CurManagementTask.Meals[CurManagementTask.MealsIndex(CurCombo)] = curCombo * newprice;
            }

            for (int i = 0; i < listBox_ALaCarte.SelectedIndices.Count; i++)
            {
                object CurALaCarte = ALaCarteSelectInListBox[listBox_ALaCarte.SelectedIndices[i]];
                ALaCarte curALa = (ALaCarte)CurALaCarte;
                CurManagementTask.Meals[CurManagementTask.MealsIndex(CurALaCarte)] = curALa * newprice;

            }
            MealsItem2ListBox();
            ModifyTxt();
            ReadTxt();
        }
    }
}
