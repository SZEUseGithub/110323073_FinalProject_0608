using System.Drawing;
using ManagementTaskProject;
using System.Collections.Generic;
using System;
namespace _110323073_FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ManagementTask CurManagementTask;
        private List<Object> MainMealSelectInListBox;
        private List<Object> ComboSelectInListBox;
        private List<Object> ALaCarteSelectInListBox;
        int SumPrice1 = 0; int SumKcal1 = 0;
        double SumKcalPerDay1 = 0; double SumPricePerNTD1 = 0;

        int SumPrice2 = 0;

        int SumPrice3 = 0; int SumKcal3 = 0;
        double SumKcalPerDay3 = 0; double SumPricePerNTD3 = 0;

        /*
        private int SumKcal;
        private int SumPrice;
        private double SumKcalPerDay, SumPricePerNTD;*/
        private string NewItemInForm1;
        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog_Load = new System.Windows.Forms.OpenFileDialog();
            this.listBox_MainMeal = new System.Windows.Forms.ListBox();
            this.button_Load = new System.Windows.Forms.Button();
            this.listBox_Combo = new System.Windows.Forms.ListBox();
            this.listBox_ALaCarte = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.panelSave = new System.Windows.Forms.Panel();
            this.button_modify = new System.Windows.Forms.Button();
            this.comboBoxSave = new System.Windows.Forms.ComboBox();
            this.labelSumPrice = new System.Windows.Forms.Label();
            this.labelSumKcal = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.labelperNTD = new System.Windows.Forms.Label();
            this.labelPerDay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_NewPrice = new System.Windows.Forms.TextBox();
            this.panelSave.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_Load
            // 
            this.openFileDialog_Load.FileName = "openFileDialog1";
            // 
            // listBox_MainMeal
            // 
            this.listBox_MainMeal.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_MainMeal.FormattingEnabled = true;
            this.listBox_MainMeal.ItemHeight = 17;
            this.listBox_MainMeal.Location = new System.Drawing.Point(51, 74);
            this.listBox_MainMeal.Name = "listBox_MainMeal";
            this.listBox_MainMeal.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_MainMeal.Size = new System.Drawing.Size(352, 123);
            this.listBox_MainMeal.TabIndex = 0;
            this.listBox_MainMeal.SelectedIndexChanged += new System.EventHandler(this.listBox_Entire_SelectedIndexChanged);
            // 
            // button_Load
            // 
            this.button_Load.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Load.Location = new System.Drawing.Point(51, 12);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 32);
            this.button_Load.TabIndex = 1;
            this.button_Load.Text = "Load";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // listBox_Combo
            // 
            this.listBox_Combo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_Combo.FormattingEnabled = true;
            this.listBox_Combo.ItemHeight = 17;
            this.listBox_Combo.Location = new System.Drawing.Point(51, 245);
            this.listBox_Combo.Name = "listBox_Combo";
            this.listBox_Combo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_Combo.Size = new System.Drawing.Size(352, 123);
            this.listBox_Combo.TabIndex = 2;
            this.listBox_Combo.SelectedIndexChanged += new System.EventHandler(this.listBox_Entire_SelectedIndexChanged);
            // 
            // listBox_ALaCarte
            // 
            this.listBox_ALaCarte.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listBox_ALaCarte.FormattingEnabled = true;
            this.listBox_ALaCarte.ItemHeight = 17;
            this.listBox_ALaCarte.Location = new System.Drawing.Point(51, 421);
            this.listBox_ALaCarte.Name = "listBox_ALaCarte";
            this.listBox_ALaCarte.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_ALaCarte.Size = new System.Drawing.Size(352, 157);
            this.listBox_ALaCarte.TabIndex = 3;
            this.listBox_ALaCarte.SelectedIndexChanged += new System.EventHandler(this.listBox_Entire_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(48, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "主餐:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(48, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "配餐:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(48, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "飲料點心:";
            // 
            // button_Delete
            // 
            this.button_Delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(181, 3);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 32);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(89, 3);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 32);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.button_modify);
            this.panelSave.Controls.Add(this.comboBoxSave);
            this.panelSave.Controls.Add(this.button_Delete);
            this.panelSave.Controls.Add(this.button_Add);
            this.panelSave.Enabled = false;
            this.panelSave.Location = new System.Drawing.Point(427, 12);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(347, 44);
            this.panelSave.TabIndex = 14;
            // 
            // button_modify
            // 
            this.button_modify.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modify.Location = new System.Drawing.Point(272, 3);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(75, 32);
            this.button_modify.TabIndex = 14;
            this.button_modify.Text = "Modify";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // comboBoxSave
            // 
            this.comboBoxSave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSave.FormattingEnabled = true;
            this.comboBoxSave.Items.AddRange(new object[] {
            "New_Menu1",
            "New_Menu2",
            "New_Menu3"});
            this.comboBoxSave.Location = new System.Drawing.Point(0, 12);
            this.comboBoxSave.Name = "comboBoxSave";
            this.comboBoxSave.Size = new System.Drawing.Size(83, 20);
            this.comboBoxSave.TabIndex = 13;
            // 
            // labelSumPrice
            // 
            this.labelSumPrice.AutoSize = true;
            this.labelSumPrice.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumPrice.Location = new System.Drawing.Point(589, 421);
            this.labelSumPrice.Name = "labelSumPrice";
            this.labelSumPrice.Size = new System.Drawing.Size(60, 27);
            this.labelSumPrice.TabIndex = 15;
            this.labelSumPrice.Text = "NTD";
            // 
            // labelSumKcal
            // 
            this.labelSumKcal.AutoSize = true;
            this.labelSumKcal.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSumKcal.Location = new System.Drawing.Point(589, 474);
            this.labelSumKcal.Name = "labelSumKcal";
            this.labelSumKcal.Size = new System.Drawing.Size(52, 27);
            this.labelSumKcal.TabIndex = 16;
            this.labelSumKcal.Text = "kcal";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "中",
            "大"});
            this.comboBoxSize.Location = new System.Drawing.Point(320, 395);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(83, 20);
            this.comboBoxSize.TabIndex = 17;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // labelperNTD
            // 
            this.labelperNTD.AutoSize = true;
            this.labelperNTD.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelperNTD.Location = new System.Drawing.Point(589, 519);
            this.labelperNTD.Name = "labelperNTD";
            this.labelperNTD.Size = new System.Drawing.Size(107, 27);
            this.labelperNTD.TabIndex = 18;
            this.labelperNTD.Text = "kcal/NTD";
            // 
            // labelPerDay
            // 
            this.labelPerDay.AutoSize = true;
            this.labelPerDay.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerDay.Location = new System.Drawing.Point(589, 564);
            this.labelPerDay.Name = "labelPerDay";
            this.labelPerDay.Size = new System.Drawing.Size(32, 27);
            this.labelPerDay.TabIndex = 19;
            this.labelPerDay.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 568);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "每日熱量佔比(%):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(486, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "熱量/元 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(495, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "總熱量 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(513, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "總價 :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_NewPrice);
            this.panel1.Location = new System.Drawing.Point(430, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 45);
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(3, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "新價錢:";
            // 
            // textBox_NewPrice
            // 
            this.textBox_NewPrice.Location = new System.Drawing.Point(68, 12);
            this.textBox_NewPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_NewPrice.Name = "textBox_NewPrice";
            this.textBox_NewPrice.Size = new System.Drawing.Size(76, 22);
            this.textBox_NewPrice.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPerDay);
            this.Controls.Add(this.labelperNTD);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.labelSumKcal);
            this.Controls.Add(this.labelSumPrice);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_ALaCarte);
            this.Controls.Add(this.listBox_Combo);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.listBox_MainMeal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSave.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_Load;
        private System.Windows.Forms.ListBox listBox_MainMeal;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.ListBox listBox_Combo;
        private System.Windows.Forms.ListBox listBox_ALaCarte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.ComboBox comboBoxSave;
        private System.Windows.Forms.Label labelSumPrice;
        private System.Windows.Forms.Label labelSumKcal;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label labelperNTD;
        private System.Windows.Forms.Label labelPerDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_NewPrice;
    }
}

