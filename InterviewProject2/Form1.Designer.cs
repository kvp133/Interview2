
namespace InterviewProject2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonHelloWorld = new System.Windows.Forms.Button();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxInt = new System.Windows.Forms.TextBox();
            this.buttonAddNumber = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddDic = new System.Windows.Forms.Button();
            this.buttonUpdDic = new System.Windows.Forms.Button();
            this.buttonDelDic = new System.Windows.Forms.Button();
            this.dataGridViewDictionary = new System.Windows.Forms.DataGridView();
            this.dataGridViewMst_Province = new System.Windows.Forms.DataGridView();
            this.buttonQuery = new System.Windows.Forms.Button();
            this.buttonAddProvince = new System.Windows.Forms.Button();
            this.labelProvinceCode = new System.Windows.Forms.Label();
            this.textBoxProvinceCode = new System.Windows.Forms.TextBox();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.labelRemark = new System.Windows.Forms.Label();
            this.textBoxProvinceName = new System.Windows.Forms.TextBox();
            this.labelProvinceName = new System.Windows.Forms.Label();
            this.textBoxFlagActive = new System.Windows.Forms.TextBox();
            this.labelFlagActive = new System.Windows.Forms.Label();
            this.buttonUpdProvince = new System.Windows.Forms.Button();
            this.buttonDelProvince = new System.Windows.Forms.Button();
            this.checkBoxRemark = new System.Windows.Forms.CheckBox();
            this.checkBoxFlagActive = new System.Windows.Forms.CheckBox();
            this.checkBoxProvinceName = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSortManual = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMst_Province)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelloWorld
            // 
            this.buttonHelloWorld.Location = new System.Drawing.Point(12, 12);
            this.buttonHelloWorld.Name = "buttonHelloWorld";
            this.buttonHelloWorld.Size = new System.Drawing.Size(75, 23);
            this.buttonHelloWorld.TabIndex = 0;
            this.buttonHelloWorld.Text = "HelloWorld";
            this.buttonHelloWorld.UseVisualStyleBackColor = true;
            this.buttonHelloWorld.Click += new System.EventHandler(this.buttonHelloWorld_Click);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(55, 121);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 20);
            this.textBoxKey.TabIndex = 1;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(55, 154);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(100, 20);
            this.textBoxValue.TabIndex = 2;
            // 
            // textBoxInt
            // 
            this.textBoxInt.Location = new System.Drawing.Point(5, 60);
            this.textBoxInt.Name = "textBoxInt";
            this.textBoxInt.Size = new System.Drawing.Size(100, 20);
            this.textBoxInt.TabIndex = 3;
            // 
            // buttonAddNumber
            // 
            this.buttonAddNumber.Location = new System.Drawing.Point(120, 58);
            this.buttonAddNumber.Name = "buttonAddNumber";
            this.buttonAddNumber.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNumber.TabIndex = 4;
            this.buttonAddNumber.Text = "Add";
            this.buttonAddNumber.UseVisualStyleBackColor = true;
            this.buttonAddNumber.Click += new System.EventHandler(this.buttonAddNumber_Click);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(306, 68);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(23, 13);
            this.labelList.TabIndex = 5;
            this.labelList.Text = "List";
            // 
            // textBoxList
            // 
            this.textBoxList.Location = new System.Drawing.Point(335, 60);
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.Size = new System.Drawing.Size(363, 20);
            this.textBoxList.TabIndex = 6;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(704, 57);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 7;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Value";
            // 
            // buttonAddDic
            // 
            this.buttonAddDic.Location = new System.Drawing.Point(161, 119);
            this.buttonAddDic.Name = "buttonAddDic";
            this.buttonAddDic.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDic.TabIndex = 10;
            this.buttonAddDic.Text = "Add";
            this.buttonAddDic.UseVisualStyleBackColor = true;
            this.buttonAddDic.Click += new System.EventHandler(this.buttonAddDic_Click);
            // 
            // buttonUpdDic
            // 
            this.buttonUpdDic.Location = new System.Drawing.Point(161, 152);
            this.buttonUpdDic.Name = "buttonUpdDic";
            this.buttonUpdDic.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdDic.TabIndex = 11;
            this.buttonUpdDic.Text = "Update";
            this.buttonUpdDic.UseVisualStyleBackColor = true;
            this.buttonUpdDic.Click += new System.EventHandler(this.buttonUpdDic_Click);
            // 
            // buttonDelDic
            // 
            this.buttonDelDic.Location = new System.Drawing.Point(242, 119);
            this.buttonDelDic.Name = "buttonDelDic";
            this.buttonDelDic.Size = new System.Drawing.Size(75, 23);
            this.buttonDelDic.TabIndex = 12;
            this.buttonDelDic.Text = "Delete";
            this.buttonDelDic.UseVisualStyleBackColor = true;
            this.buttonDelDic.Click += new System.EventHandler(this.buttonDelDic_Click);
            // 
            // dataGridViewDictionary
            // 
            this.dataGridViewDictionary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDictionary.Location = new System.Drawing.Point(344, 119);
            this.dataGridViewDictionary.Name = "dataGridViewDictionary";
            this.dataGridViewDictionary.RowHeadersWidth = 51;
            this.dataGridViewDictionary.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewDictionary.TabIndex = 13;
            // 
            // dataGridViewMst_Province
            // 
            this.dataGridViewMst_Province.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMst_Province.Location = new System.Drawing.Point(5, 294);
            this.dataGridViewMst_Province.Name = "dataGridViewMst_Province";
            this.dataGridViewMst_Province.RowHeadersWidth = 51;
            this.dataGridViewMst_Province.Size = new System.Drawing.Size(692, 217);
            this.dataGridViewMst_Province.TabIndex = 14;
            // 
            // buttonQuery
            // 
            this.buttonQuery.Location = new System.Drawing.Point(703, 294);
            this.buttonQuery.Name = "buttonQuery";
            this.buttonQuery.Size = new System.Drawing.Size(75, 23);
            this.buttonQuery.TabIndex = 15;
            this.buttonQuery.Text = "Query";
            this.buttonQuery.UseVisualStyleBackColor = true;
            this.buttonQuery.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // buttonAddProvince
            // 
            this.buttonAddProvince.Location = new System.Drawing.Point(242, 528);
            this.buttonAddProvince.Name = "buttonAddProvince";
            this.buttonAddProvince.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProvince.TabIndex = 16;
            this.buttonAddProvince.Text = "Add";
            this.buttonAddProvince.UseVisualStyleBackColor = true;
            this.buttonAddProvince.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelProvinceCode
            // 
            this.labelProvinceCode.AutoSize = true;
            this.labelProvinceCode.Location = new System.Drawing.Point(3, 533);
            this.labelProvinceCode.Name = "labelProvinceCode";
            this.labelProvinceCode.Size = new System.Drawing.Size(74, 13);
            this.labelProvinceCode.TabIndex = 17;
            this.labelProvinceCode.Text = "ProvinceCode";
            // 
            // textBoxProvinceCode
            // 
            this.textBoxProvinceCode.Location = new System.Drawing.Point(83, 530);
            this.textBoxProvinceCode.Name = "textBoxProvinceCode";
            this.textBoxProvinceCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvinceCode.TabIndex = 18;
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(111, 594);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(100, 20);
            this.textBoxRemark.TabIndex = 22;
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Location = new System.Drawing.Point(3, 596);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(44, 13);
            this.labelRemark.TabIndex = 21;
            this.labelRemark.Text = "Remark";
            // 
            // textBoxProvinceName
            // 
            this.textBoxProvinceName.Location = new System.Drawing.Point(111, 563);
            this.textBoxProvinceName.Name = "textBoxProvinceName";
            this.textBoxProvinceName.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvinceName.TabIndex = 20;
            // 
            // labelProvinceName
            // 
            this.labelProvinceName.AutoSize = true;
            this.labelProvinceName.Location = new System.Drawing.Point(3, 562);
            this.labelProvinceName.Name = "labelProvinceName";
            this.labelProvinceName.Size = new System.Drawing.Size(77, 13);
            this.labelProvinceName.TabIndex = 19;
            this.labelProvinceName.Text = "ProvinceName";
            // 
            // textBoxFlagActive
            // 
            this.textBoxFlagActive.Location = new System.Drawing.Point(111, 620);
            this.textBoxFlagActive.Name = "textBoxFlagActive";
            this.textBoxFlagActive.Size = new System.Drawing.Size(100, 20);
            this.textBoxFlagActive.TabIndex = 24;
            // 
            // labelFlagActive
            // 
            this.labelFlagActive.AutoSize = true;
            this.labelFlagActive.Location = new System.Drawing.Point(3, 622);
            this.labelFlagActive.Name = "labelFlagActive";
            this.labelFlagActive.Size = new System.Drawing.Size(57, 13);
            this.labelFlagActive.TabIndex = 23;
            this.labelFlagActive.Text = "FlagActive";
            // 
            // buttonUpdProvince
            // 
            this.buttonUpdProvince.Location = new System.Drawing.Point(242, 562);
            this.buttonUpdProvince.Name = "buttonUpdProvince";
            this.buttonUpdProvince.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdProvince.TabIndex = 25;
            this.buttonUpdProvince.Text = "Update";
            this.buttonUpdProvince.UseVisualStyleBackColor = true;
            this.buttonUpdProvince.Click += new System.EventHandler(this.buttonUpdProvince_Click);
            // 
            // buttonDelProvince
            // 
            this.buttonDelProvince.Location = new System.Drawing.Point(242, 596);
            this.buttonDelProvince.Name = "buttonDelProvince";
            this.buttonDelProvince.Size = new System.Drawing.Size(75, 23);
            this.buttonDelProvince.TabIndex = 26;
            this.buttonDelProvince.Text = "Delete";
            this.buttonDelProvince.UseVisualStyleBackColor = true;
            this.buttonDelProvince.Click += new System.EventHandler(this.buttonDelProvince_Click);
            // 
            // checkBoxRemark
            // 
            this.checkBoxRemark.AutoSize = true;
            this.checkBoxRemark.Location = new System.Drawing.Point(90, 595);
            this.checkBoxRemark.Name = "checkBoxRemark";
            this.checkBoxRemark.Size = new System.Drawing.Size(15, 14);
            this.checkBoxRemark.TabIndex = 29;
            this.checkBoxRemark.UseVisualStyleBackColor = true;
            // 
            // checkBoxFlagActive
            // 
            this.checkBoxFlagActive.AutoSize = true;
            this.checkBoxFlagActive.Location = new System.Drawing.Point(90, 621);
            this.checkBoxFlagActive.Name = "checkBoxFlagActive";
            this.checkBoxFlagActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxFlagActive.TabIndex = 30;
            this.checkBoxFlagActive.UseVisualStyleBackColor = true;
            // 
            // checkBoxProvinceName
            // 
            this.checkBoxProvinceName.AutoSize = true;
            this.checkBoxProvinceName.Location = new System.Drawing.Point(90, 566);
            this.checkBoxProvinceName.Name = "checkBoxProvinceName";
            this.checkBoxProvinceName.Size = new System.Drawing.Size(15, 14);
            this.checkBoxProvinceName.TabIndex = 31;
            this.checkBoxProvinceName.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 10);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(5, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 10);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(5, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(753, 10);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // buttonSortManual
            // 
            this.buttonSortManual.Location = new System.Drawing.Point(796, 57);
            this.buttonSortManual.Name = "buttonSortManual";
            this.buttonSortManual.Size = new System.Drawing.Size(75, 23);
            this.buttonSortManual.TabIndex = 35;
            this.buttonSortManual.Text = "SortManual";
            this.buttonSortManual.UseVisualStyleBackColor = true;
            this.buttonSortManual.Click += new System.EventHandler(this.buttonSortManual_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(200, 58);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(56, 24);
            this.buttonClear.TabIndex = 36;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 749);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSortManual);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxProvinceName);
            this.Controls.Add(this.checkBoxFlagActive);
            this.Controls.Add(this.checkBoxRemark);
            this.Controls.Add(this.buttonDelProvince);
            this.Controls.Add(this.buttonUpdProvince);
            this.Controls.Add(this.textBoxFlagActive);
            this.Controls.Add(this.labelFlagActive);
            this.Controls.Add(this.textBoxRemark);
            this.Controls.Add(this.labelRemark);
            this.Controls.Add(this.textBoxProvinceName);
            this.Controls.Add(this.labelProvinceName);
            this.Controls.Add(this.textBoxProvinceCode);
            this.Controls.Add(this.labelProvinceCode);
            this.Controls.Add(this.buttonAddProvince);
            this.Controls.Add(this.buttonQuery);
            this.Controls.Add(this.dataGridViewMst_Province);
            this.Controls.Add(this.dataGridViewDictionary);
            this.Controls.Add(this.buttonDelDic);
            this.Controls.Add(this.buttonUpdDic);
            this.Controls.Add(this.buttonAddDic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.buttonAddNumber);
            this.Controls.Add(this.textBoxInt);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.buttonHelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMst_Province)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        
    }

       

        #endregion
        private System.Windows.Forms.Button buttonHelloWorld;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxInt;
        private System.Windows.Forms.Button buttonAddNumber;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.TextBox textBoxList;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddDic;
        private System.Windows.Forms.Button buttonUpdDic;
        private System.Windows.Forms.Button buttonDelDic;
        private System.Windows.Forms.DataGridView dataGridViewDictionary;
        private System.Windows.Forms.DataGridView dataGridViewMst_Province;
        private System.Windows.Forms.Button buttonQuery;
        private System.Windows.Forms.Button buttonAddProvince;
        private System.Windows.Forms.Label labelProvinceCode;
        private System.Windows.Forms.TextBox textBoxProvinceCode;
        private System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.TextBox textBoxProvinceName;
        private System.Windows.Forms.Label labelProvinceName;
        private System.Windows.Forms.TextBox textBoxFlagActive;
        private System.Windows.Forms.Label labelFlagActive;
        private System.Windows.Forms.Button buttonUpdProvince;
        private System.Windows.Forms.Button buttonDelProvince;
        private System.Windows.Forms.CheckBox checkBoxRemark;
        private System.Windows.Forms.CheckBox checkBoxFlagActive;
        private System.Windows.Forms.CheckBox checkBoxProvinceName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonSortManual;
        private System.Windows.Forms.Button buttonClear;
    }
}
