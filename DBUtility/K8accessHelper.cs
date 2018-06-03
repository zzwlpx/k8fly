namespace DBUtility
{
    using System;
    using System.Data;
    using System.Data.OleDb;

    public class K8accessHelper
    {
        
        private static string k8pwd = string.Concat(new object[] { '\x0003', "K8team", '\r', '\t', '\n', '\x0002' });
        public static string K8SEOConnString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\K8data.mdb;Mode=Share Deny Read|Share Deny Write;Persist Security Info=False;Jet OLEDB:Database Password=\"" + k8pwd + "\"");
        //public static string K8SEOConnString = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=K8data.mdb;Jet OLEDB:Database Password=\"" + k8pwd + "\"");
        private static OleDbConnection conn = new OleDbConnection(K8SEOConnString);
        public static bool ExecIDU(OleDbCommand cmd)
        {
            bool flag;
            cmd.Connection = conn;
            K8open();
            try
            {
                cmd.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            finally
            {
                K8Close();
            }
            return flag;
        }

        public static bool ExecSQLparameter(OleDbCommand cmd)
        {
            bool flag2;
            cmd.Connection = conn;
            K8open();
            try
            {
                if (Convert.ToInt32(cmd.ExecuteNonQuery()) > 0)
                {
                    return true;
                }
                flag2 = false;
            }
            catch (Exception exception)
            {
                string message = exception.Message;
                flag2 = false;
            }
            finally
            {
                K8Close();
            }
            return flag2;
        }

        public static DataSet GetDataSet(OleDbCommand cmd)
        {
            DataSet set2;
            cmd.Connection = conn;
            using (OleDbDataAdapter adapter = new OleDbDataAdapter())
            {
                adapter.SelectCommand = cmd;
                using (DataSet set = new DataSet())
                {
                    set.Clear();
                    try
                    {
                        adapter.Fill(set);
                    }
                    catch (Exception)
                    {
                    }
                    set2 = set;
                }
            }
            return set2;
        }

        public static DataSet GetDataSet(string SqlStr)
        {
            DataSet set2;
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(SqlStr, conn))
            {
                using (DataSet set = new DataSet())
                {
                    set.Clear();
                    try
                    {
                        adapter.Fill(set);
                    }
                    catch (Exception)
                    {
                    }
                    set2 = set;
                }
            }
            return set2;
        }

        public static int GetRecordCount(OleDbCommand cmd)
        {
            int num = 0;
            cmd.Connection = conn;
            K8open();
            using (OleDbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    num = reader.GetInt32(0);
                }
            }
            K8Close();
            return num;
        }

        public static int GetRecordCount(string SqlStr)
        {
            int num = 0;
            using (OleDbCommand command = new OleDbCommand(SqlStr, conn))
            {
                K8open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        num = reader.GetInt32(0);
                    }
                }
            }
            K8Close();
            return num;
        }

        private static void K8Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private static void K8open()
        {
            conn.Open();
        }
    }
}

