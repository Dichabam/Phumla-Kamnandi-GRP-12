using Phumla_Kamnandi_GRP_12.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_GRP_12.Database
{
     public class DB
    {
        public string strConn = Settings.Default.PhumlaKamnandiConnectionString;
        public SqlConnection cnMain = new SqlConnection(Properties.Settings.Default.PhumlaKamnandiConnectionString);
        public DataSet dsMain = new DataSet();
        public SqlDataAdapter daMain = new SqlDataAdapter();
        public DB()
        {
            try
            {
                cnMain = new SqlConnection(strConn);
                cnMain.Open();
                dsMain = new DataSet();
                cnMain.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("The following error occurred: " + ex.Message);
            }
        }
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + " " + errObj.StackTrace);
            }
        }
        public bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success = false;
            try
            {
                cnMain.Open();
                daMain.Update(dsMain, table);
                cnMain.Close();
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + " " + errObj.StackTrace);
                success = false;
            }
            finally
            {

            }
            return success;
        }
    }
}

