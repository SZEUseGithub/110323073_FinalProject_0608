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
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelSize.Visible = false;
            panelKcal.Visible = false;
            if (comboBoxType.Text == "主餐")
            {
                panelKcal.Visible = true;
            }
            else if (comboBoxType.Text == "套餐")
            {
                panelKcal.Visible = false;
            }
            else if (comboBoxType.Text == "單點")
            {
                panelSize.Visible = true;
                panelKcal.Visible = true;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            int canValue = 0;
            ErrorCodes CurErrCode = ErrorCodes.NONE;
            if (comboBoxType.Text == "")
            {
                CurErrCode = ErrorCodes.WRONG_TYPE;
            }
            else if (textBoxItem.Text == "")
            {
                CurErrCode = ErrorCodes.WRONG_ITEM;
            }
            else if (textBoxPrice.Text == "" || !int.TryParse(textBoxPrice.Text, out canValue))
            {
                CurErrCode = ErrorCodes.WRONG_Price;
            }
            else if (comboBoxType.Text == "主餐" || comboBoxType.Text == "單點")
            {
                if (textBoxKcal.Text == "" || !int.TryParse(textBoxKcal.Text, out canValue))
                    CurErrCode = ErrorCodes.WRONG_KCAL;
                if (comboBoxType.Text == "單點")
                {
                    if ((!int.TryParse(textBoxLPrice.Text, out canValue))|| (!int.TryParse(textBoxLKcal.Text, out canValue)))
                        CurErrCode = ErrorCodes.WRONG_VALUE;
                }
            }
            

            switch (CurErrCode)
            {
                case ErrorCodes.WRONG_TYPE:
                    MessageBox.Show("請填入種類!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ErrorCodes.WRONG_ITEM:
                    MessageBox.Show("請填入品名!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ErrorCodes.WRONG_Price:
                    MessageBox.Show("請填入整數價錢!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ErrorCodes.WRONG_KCAL:
                    MessageBox.Show("請填整數熱量!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ErrorCodes.WRONG_VALUE:
                    MessageBox.Show("請填入整數!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case ErrorCodes.NONE:
                    if (comboBoxType.Text == "主餐")
                    {
                        NewItem = "主餐 : " + textBoxItem.Text + " " + textBoxPrice.Text + " " + textBoxKcal.Text;
                    }
                    else if (comboBoxType.Text == "套餐")
                    {
                        NewItem = "套餐 : " + textBoxItem.Text + " " + textBoxPrice.Text;
                    }
                    else if (comboBoxType.Text == "單點")
                    {
                        textBoxLPrice.Text = (textBoxLPrice.Text == "") ? "0" : textBoxLPrice.Text;
                        textBoxLKcal.Text = (textBoxLKcal.Text == "") ? "0" : textBoxLKcal.Text;

                        NewItem = "單點 : " + textBoxItem.Text + " " + textBoxPrice.Text + " " + textBoxKcal.Text + " " +
                                                                         textBoxLPrice.Text + " " + textBoxLKcal.Text;
                    }
                    this.Close();
                    break;
            }
        }
    }
}
