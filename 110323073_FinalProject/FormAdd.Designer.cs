namespace _110323073_FinalProject
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public string NewItem;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelItem = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxKcal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelKcal = new System.Windows.Forms.Panel();
            this.panelSize = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLPrice = new System.Windows.Forms.TextBox();
            this.textBoxLKcal = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelKcal.SuspendLayout();
            this.panelSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelItem.Location = new System.Drawing.Point(20, 39);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(56, 13);
            this.labelItem.TabIndex = 0;
            this.labelItem.Text = "種類 : ";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "主餐",
            "套餐",
            "單點"});
            this.comboBoxType.Location = new System.Drawing.Point(82, 36);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(83, 20);
            this.comboBoxType.TabIndex = 1;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "品名 : ";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(82, 75);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(83, 22);
            this.textBoxItem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "價錢 : ";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(82, 116);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(83, 22);
            this.textBoxPrice.TabIndex = 6;
            // 
            // textBoxKcal
            // 
            this.textBoxKcal.Location = new System.Drawing.Point(59, 0);
            this.textBoxKcal.Name = "textBoxKcal";
            this.textBoxKcal.Size = new System.Drawing.Size(83, 22);
            this.textBoxKcal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(-3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "熱量 : ";
            // 
            // panelKcal
            // 
            this.panelKcal.Controls.Add(this.label3);
            this.panelKcal.Controls.Add(this.textBoxKcal);
            this.panelKcal.Location = new System.Drawing.Point(23, 155);
            this.panelKcal.Name = "panelKcal";
            this.panelKcal.Size = new System.Drawing.Size(159, 22);
            this.panelKcal.TabIndex = 13;
            this.panelKcal.Visible = false;
            // 
            // panelSize
            // 
            this.panelSize.Controls.Add(this.label5);
            this.panelSize.Controls.Add(this.textBoxLPrice);
            this.panelSize.Controls.Add(this.textBoxLKcal);
            this.panelSize.Location = new System.Drawing.Point(191, 77);
            this.panelSize.Name = "panelSize";
            this.panelSize.Size = new System.Drawing.Size(125, 113);
            this.panelSize.TabIndex = 9;
            this.panelSize.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(44, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "L : ";
            // 
            // textBoxLPrice
            // 
            this.textBoxLPrice.Location = new System.Drawing.Point(20, 34);
            this.textBoxLPrice.Name = "textBoxLPrice";
            this.textBoxLPrice.Size = new System.Drawing.Size(83, 22);
            this.textBoxLPrice.TabIndex = 16;
            // 
            // textBoxLKcal
            // 
            this.textBoxLKcal.Location = new System.Drawing.Point(20, 73);
            this.textBoxLKcal.Name = "textBoxLKcal";
            this.textBoxLKcal.Size = new System.Drawing.Size(83, 22);
            this.textBoxLKcal.TabIndex = 17;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(134, 220);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 271);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelSize);
            this.Controls.Add(this.textBoxItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelKcal);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelItem);
            this.Name = "FormAdd";
            this.Text = "FormAdd";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.panelKcal.ResumeLayout(false);
            this.panelKcal.PerformLayout();
            this.panelSize.ResumeLayout(false);
            this.panelSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxKcal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelKcal;
        private System.Windows.Forms.Panel panelSize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLKcal;
        private System.Windows.Forms.TextBox textBoxLPrice;
    }
}