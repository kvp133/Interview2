using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EzSqlServer;


namespace InterviewProject2
{
    public partial class Form1 : Form
    {
        //Part 1: Hello World
        #region
        private void buttonHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
        #endregion

        //Part 2: List
        #region
        List<int> listNumberInteger = null;
        private void buttonAddNumber_Click(object sender, EventArgs e)
        {
            string strNumber = textBoxInt.Text.Trim();
            if (string.IsNullOrEmpty(strNumber))
            {
                MessageBox.Show("Please enter a integer number!");
                return;
            }
            if (!int.TryParse(strNumber, out int number))
            {
                MessageBox.Show("Please enter a valid integer number!");
                textBoxInt.Clear();
                return;
            }
            listNumberInteger.Add(number);
            textBoxInt.Clear();
            DisplayListNumberInteger();
        }
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if(listNumberInteger.Count == 0)
            {
                MessageBox.Show("Please enter a integer number!");
                return;
            }
            listNumberInteger.Sort();
            DisplayListNumberInteger();

        }
        private void buttonSortManual_Click(object sender, EventArgs e)
        {
            if (listNumberInteger.Count == 0)
            {
                MessageBox.Show("Please enter a integer number!");
                return;
            }
            BubbleSort(listNumberInteger);
            DisplayListNumberInteger();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            listNumberInteger.Clear();
            textBoxList.Clear();

        }
        private void DisplayListNumberInteger()
        {
            string strList = string.Join(", ", listNumberInteger);
            textBoxList.Text = strList;


        }
        private void BubbleSort(List<int> lstNumber, string strOrder = "asc")
        {
            int[] arrNumber = lstNumber.ToArray();

            if (strOrder.ToUpper() == "ASC")
            {
                for (int i = 0; i < arrNumber.Length; i++)
                {
                    for (int j = 0; j < arrNumber.Length - 1 - i; j++)
                    {
                        if (arrNumber[j] > arrNumber[j + 1])
                        {
                            Swap(arrNumber, j, j + 1);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrNumber.Length; i++)
                {
                    for (int j = 0; j < arrNumber.Length - 1 - i; j++)
                    {
                        if (arrNumber[j] < arrNumber[j + 1])
                        {
                            Swap(arrNumber, j, j + 1);
                        }
                    }
                }
            }

            lstNumber.Clear();
            lstNumber.AddRange(arrNumber);
        }
        private void Swap(int[] arr, int i, int j)
        {
            int nSwap = arr[i];
            arr[i] = arr[j];
            arr[j] = nSwap;
            return;
        }
        #endregion

        //Part 3 Dictionary
        #region
        Dictionary<string, string> dicHash = null;
        private void buttonAddDic_Click(object sender, EventArgs e)
        {
            string strKey = textBoxKey.Text.Trim();
            string strValue = textBoxValue.Text.Trim();
            if (string.IsNullOrEmpty(strKey) || string.IsNullOrEmpty(strValue))
            {
                MessageBox.Show("Please enter a key and value!");
                return;
            }
            if (dicHash.ContainsKey(strKey))
            {
                MessageBox.Show("The key is already existed!");
                return;
            }
            dicHash.Add(strKey, strValue);
            textBoxKey.Clear();
            textBoxValue.Clear();
            DisplayDictionary();

        }
        private void buttonUpdDic_Click(object sender, EventArgs e)
        {
            string strKey = textBoxKey.Text.Trim();
            string strValue = textBoxValue.Text.Trim();
            if (string.IsNullOrEmpty(strKey) || string.IsNullOrEmpty(strValue))
            {
                MessageBox.Show("Please enter a key and value!");
                return;
            }
            if (!dicHash.ContainsKey(strKey))
            {
                MessageBox.Show("The key is not existed!");
                return;
            }
            dicHash[strKey] = strValue;
            textBoxKey.Clear();
            textBoxValue.Clear();
            DisplayDictionary();

        }
        private void buttonDelDic_Click(object sender, EventArgs e)
        {
            string strKey = textBoxKey.Text.Trim();
            if (string.IsNullOrEmpty(strKey))
            {
                MessageBox.Show("Please enter a key!");
                return;
            }
            if (!dicHash.ContainsKey(strKey))
            {
                MessageBox.Show("The key is not existed!");
                return;
            }
            dicHash.Remove(strKey);
            textBoxKey.Clear();
            textBoxValue.Clear();
            DisplayDictionary();

        }
        private void DisplayDictionary()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Key",typeof(string));
            dt.Columns.Add("Value", typeof(string));
            foreach (var item in dicHash)
            {
                DataRow dr = dt.NewRow();
                dr["Key"] = item.Key;
                dr["Value"] = item.Value;
                dt.Rows.Add(dr);
            }
            dataGridViewDictionary.DataSource = dt;
        }
        #endregion

        //Part 4: Database using ezSQL
        #region
        string strConn = @"Server=(local);uid = sa;pwd = 123;Database=idocNet.Test.DB;TrustServerCertificate = true;Integrated Security = true;";
        EzSqlServer.EzSqlServer _db = null;
        private void buttonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                LoadProvince();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Query Fail!");
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try {
                string strProvinceCode = textBoxProvinceCode.Text.Trim();
                string strProvinceName = textBoxProvinceName.Text.Trim();
                string strRemarks = textBoxRemark.Text.Trim();
                if (string.IsNullOrEmpty(strProvinceCode) || string.IsNullOrEmpty(strProvinceName))
                {
                    MessageBox.Show("Please enter a Province Code and Province Name!");
                    return;
                }
               Mst_Province_CheckDB(strProvinceCode, "0", "", out DataTable dtDB_Mst_Province);
          
                Mst_Province_Create(strProvinceCode, strProvinceName, strRemarks);
                MessageBox.Show("Add Successful!");
                textBoxProvinceCode.Clear();
                textBoxProvinceName.Clear();
                textBoxRemark.Clear();

                checkBoxFlagActive.Checked = false;
                checkBoxRemark.Checked = false;
                checkBoxProvinceName.Checked = false;
                LoadProvince();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Add Fail!");
            }
        }
        private void buttonUpdProvince_Click(object sender, EventArgs e)
        {
            try
            {
                // Data Validation:
                string strProvinceCode = textBoxProvinceCode.Text.Trim();
                string strProvinceName = textBoxProvinceName.Text.Trim();
                string strFlagActive = textBoxFlagActive.Text.Trim();
                string strRemark = textBoxRemark.Text.Trim();

                if (strProvinceCode == "")
                {
                    MessageBox.Show("Please enter a ProvinceCode");
                    return;
                }

                if (checkBoxFlagActive.Checked == false && checkBoxRemark.Checked == false && checkBoxProvinceName.Checked == false)
                {
                    MessageBox.Show("Please select check box");
                    return;
                }

                if (checkBoxProvinceName.Checked == true && strProvinceName == "")
                {
                    MessageBox.Show("ProvinceName can not empty");
                    return;
                }

                if (checkBoxFlagActive.Checked == true && strFlagActive != "0" && strFlagActive != "1")
                {
                    MessageBox.Show("FlagActive only value 0 or 1. Please try again");
                    textBoxFlagActive.Text = "";
                    return;
                }

                string strColsUpd = "";

                if (checkBoxProvinceName.Checked == true)
                {
                    strColsUpd = string.IsNullOrEmpty(strColsUpd) ? "ProvinceName" : strColsUpd + ", ProvinceName";
                }
                if (checkBoxFlagActive.Checked == true)
                {
                    strColsUpd = string.IsNullOrEmpty(strColsUpd) ? "FlagActive" : strColsUpd + ", FlagActive";
                }
                if (checkBoxRemark.Checked == true)
                {
                    strColsUpd = string.IsNullOrEmpty(strColsUpd) ? "Remark" : strColsUpd + ", Remark";
                }

                Mst_Province_Update(
                    strProvinceCode         // strProvinceCode
                    , strProvinceName       // strProvinceName
                    , strRemark             // strRemark
                    , strFlagActive         // strFlagActive
                    , strColsUpd            // strColsUpd
                    );

                // Show box message update success and clear all textbox
                {
                    MessageBox.Show("Update sucessful!");

                    textBoxProvinceCode.Clear();
                    textBoxProvinceName.Clear();
                    textBoxRemark.Clear();
                    textBoxFlagActive.Clear();

                    checkBoxFlagActive.Checked = false;
                    checkBoxRemark.Checked = false;
                    checkBoxProvinceName.Checked = false;
                }
            }
            catch (Exception exc)
            {
            
                MessageBox.Show(exc.Message);
                MessageBox.Show("Update fail!");
            }

            LoadProvince();

        }
        private void buttonDelProvince_Click(object sender, EventArgs e)
        {
            try
            {
                // Data Validation:
                string strProvinceCode = textBoxProvinceCode.Text.Trim();

                if (strProvinceCode == "")
                {
                    MessageBox.Show("Please enter a ProvinceCode");
                    return;
                }

                Mst_Province_Delete(
                    strProvinceCode     // strProvinceCode
                    );

             
                {
                    MessageBox.Show("Delete Successful!");

                    textBoxProvinceCode.Text = "";
                    textBoxProvinceName.Text = "";
                    textBoxRemark.Text = "";
                    textBoxFlagActive.Text = "";

                    checkBoxFlagActive.Checked = false;
                    checkBoxRemark.Checked = false;
                    checkBoxProvinceName.Checked = false;
                }
            }
            catch (Exception exc)
            {
               
                MessageBox.Show(exc.Message);
                MessageBox.Show("Delete Fail!");
            }

            LoadProvince();
        }
        private void LoadProvince()
        {
            string strSQL = "SELECT * FROM Mst_Province";
            DataSet ds_Mst_Province = _db.ExecQuery(strSQL);
            DataTable dt_Mst_Province = ds_Mst_Province.Tables[0];
            dataGridViewMst_Province.DataSource = dt_Mst_Province;
        }

        private void Mst_Province_CheckDB(
            string strProvinceCode
            , string strFlagExistToCheck
            , string strFlagActiveListToCheck
            , out DataTable dtDB_Mst_Province
            )
        {
            string strSqlCheckDB = @"
                    select
                        t.*
                    from Mst_Province t
                    where (1=1)
                        and t.ProvinceCode = @strProvinceCode
                ";

            DataSet dsGetData = _db.ExecQuery(
                strSqlCheckDB
                , "@strProvinceCode", strProvinceCode
                );

            dtDB_Mst_Province = dsGetData.Tables[0];

            dtDB_Mst_Province.TableName = "Mst_Province";

            if (strFlagExistToCheck.Length > 0)
            {
                if (string.Equals(strFlagExistToCheck, "1") && dtDB_Mst_Province.Rows.Count < 1)
                {
                    Exception e = new Exception("Err.Mst_Province_CheckDB_ProvinceCodeNotFound");
                    throw e;
                }
                if (string.Equals(strFlagExistToCheck, "0") && dtDB_Mst_Province.Rows.Count > 0)
                {
                    Exception e = new Exception("Err.Mst_Province_CheckDB_ProvinceCodeExist");
                    throw e;
                }
            }
            if (strFlagActiveListToCheck.Length > 0 && !strFlagActiveListToCheck.Contains(Convert.ToString(dtDB_Mst_Province.Rows[0]["FlagActive"])))
            {
                Exception e = new Exception("Err.Mst_Province_CheckDB_FlagActiveNotMatched");
                throw e;
            }
        }

        private void Mst_Province_Create(string strProvinceCode, string strProvinceName, string strRemarks)
        {
            //Start Transaction:
            _db.BeginTransaction();
            try
            {
                if(string.IsNullOrEmpty(strProvinceCode) || string.IsNullOrEmpty(strProvinceName))
                {
                    Exception e = new Exception("Err.Mst_Province_Create_ProvinceCodeOrProvinceNameIsEmpty");
                    throw e;
                }
                DataTable dtDB_Mst_Province = null;
                Mst_Province_CheckDB(strProvinceCode, "0", "", out dtDB_Mst_Province);
                DataRow dr = dtDB_Mst_Province.NewRow();
                dr["ProvinceCode"] = strProvinceCode;
                dr["ProvinceName"] = strProvinceName;
                dr["Remark"] = strRemarks;
                dr["FlagActive"] = "1";
                dtDB_Mst_Province.Rows.Add(dr);
                _db.SaveData("Mst_Province",dtDB_Mst_Province);

                //Commit Transaction
                _db.Commit();
            }
            catch (Exception ex)
            {
                _db.Rollback();
                throw ex;
            }
        }
        private void Mst_Province_Update(string strProvinceCode,string strProvinceName,string strRemarks,string strFlagActive,string strColumnUpdate)
        {
            //Start Transaction:
            _db.BeginTransaction();
            try
            {
                // Data Validation
                bool bUpd_ProvinceName = strColumnUpdate.Contains("ProvinceName");
                bool bUpd_Remark = strColumnUpdate.Contains("Remark");
                bool bUpd_FlagActive = strColumnUpdate.Contains("FlagActive");

                DataTable dtDB_Mst_Province = null;

                Mst_Province_CheckDB(
                    strProvinceCode             // strProvinceCode
                    , "1"                       // strFlagExistToCheck
                    , ""                        // strFlagActiveListToCheck
                    , out dtDB_Mst_Province     // dtDB_Mst_Province
                    );

                if (bUpd_ProvinceName && string.IsNullOrEmpty(strProvinceName))
                {
                    Exception e = new Exception("Err.Mst_Province_Update_InvalidProvinceName");
                    throw e;
                }

                ArrayList alColumnEffective = new ArrayList();
                string strFN = "";
                DataRow drDB = dtDB_Mst_Province.Rows[0];

                if (bUpd_ProvinceName)
                {
                    strFN = "ProvinceName"; drDB[strFN] = strProvinceName; alColumnEffective.Add(strFN);
                }
                if (bUpd_FlagActive)
                {
                    strFN = "FlagActive"; drDB[strFN] = strFlagActive; alColumnEffective.Add(strFN);
                }
                if (bUpd_Remark)
                {
                    strFN = "Remark"; drDB[strFN] = strRemarks; alColumnEffective.Add(strFN);
                }

                _db.SaveData(
                    "Mst_Province"
                    , dtDB_Mst_Province
                    , alColumnEffective.ToArray()
                    );

                //Commit Transaction
                _db.Commit();
            }
            catch (Exception ex)
            {
                _db.Rollback();
                throw ex;
            }
        }
        private void Mst_Province_Delete(
            string strProvinceCode
            )
        {
            //Start Transaction:
            _db.BeginTransaction();

            try
            {
                DataTable dtDB_Mst_Province = null;

                Mst_Province_CheckDB(
                    strProvinceCode             // strProvinceCode
                    , "1"                       // strFlagExistToCheck
                    , ""                        // strFlagActiveListToCheck
                    , out dtDB_Mst_Province     // dtDB_Mst_Province
                    );

                dtDB_Mst_Province.Rows[0].Delete();

                _db.SaveData(
                    "Mst_Province"
                    , dtDB_Mst_Province
                    );
                //Commit Transaction
                _db.Commit();
            }
            catch (Exception exc)
            {
                _db.Rollback();
                throw exc;
            }
        }
        #endregion












        private void Form1_Load(object sender, EventArgs e)
        {
            //Nothing .
        }



        public Form1()
        {
            InitializeComponent();

            //Initialize listNumberInteger
            listNumberInteger = new();

            //Initialize Dictionary
            dicHash = new();

            //Initialize ezSQL
            _db = new EzSqlServer.EzSqlServer(strConn);
        }
    }
}
