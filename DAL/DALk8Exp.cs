namespace DAL
{
    using DBUtility;
    using Model;
    using System;
    using System.Data;
    using System.Data.OleDb;
    using System.Text;

    public class DALk8Exp
    {
        public static bool DeleteRecord(int id)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("delete from K8_ExploitS where id=@id");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@id", OleDbType.Integer, 20).Value = id;
                return K8accessHelper.ExecIDU(command);
            }
        }

        public static bool ExistsRecord(ModelK8Exp model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Select * from");
            builder.Append(" K8_ExploitS ");
            builder.Append(" where ");
            builder.Append("[appName]=@appName and [addURL]=@addURL and [method]=@method and [cookie]=@cookie and [sumbitData]=@sumbitData");
            builder.Append(" and [referer]=@referer and [userAgent]=@userAgent and [encode]=@encode and [allowRedirect]=@allowRedirect");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@appName", OleDbType.VarChar, 0x3e8).Value = model.appName;
                command.Parameters.Add("@addURL", OleDbType.VarChar).Value = model.addURL;
                command.Parameters.Add("@method", OleDbType.VarChar, 20).Value = model.method;
                command.Parameters.Add("@cookie", OleDbType.VarChar).Value = model.cookie;
                command.Parameters.Add("@sumbitData", OleDbType.VarChar).Value = model.sumbitData;
                command.Parameters.Add("@referer", OleDbType.VarChar).Value = model.referer;
                command.Parameters.Add("@userAgent", OleDbType.VarChar).Value = model.userAgent;
                command.Parameters.Add("@encode", OleDbType.VarChar, 20).Value = model.encode;
                command.Parameters.Add("@allowRedirect", OleDbType.VarChar, 20).Value = model.allowRedirect;
                if (K8accessHelper.GetRecordCount(command) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static DataSet ExistsRecordGetBtnNameDS(ModelK8Exp model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Select [btnName] from");
            builder.Append(" K8_ExploitS ");
            builder.Append(" where ");
            builder.Append("[appName]=@appName and [method]=@method and [cookie]=@cookie and [sumbitData]=@sumbitData");
            builder.Append(" and [referer]=@referer and [userAgent]=@userAgent and [encode]=@encode and [allowRedirect]=@allowRedirect");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@appName", OleDbType.VarChar, 0x3e8).Value = model.appName;
                command.Parameters.Add("@method", OleDbType.VarChar, 20).Value = model.method;
                command.Parameters.Add("@cookie", OleDbType.VarChar).Value = model.cookie;
                command.Parameters.Add("@sumbitData", OleDbType.VarChar).Value = model.sumbitData;
                command.Parameters.Add("@referer", OleDbType.VarChar).Value = model.referer;
                command.Parameters.Add("@userAgent", OleDbType.VarChar).Value = model.userAgent;
                command.Parameters.Add("@encode", OleDbType.VarChar, 20).Value = model.encode;
                command.Parameters.Add("@allowRedirect", OleDbType.VarChar, 20).Value = model.allowRedirect;
                return K8accessHelper.GetDataSet(command);
            }
        }

        public static DataSet GetAppNameDataSet()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select distinct appname from K8_ExploitS order by appname asc;");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                return K8accessHelper.GetDataSet(command);
            }
        }

        public static DataSet GetDataSet()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select * from K8_ExploitS order by appName asc,id asc;");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                return K8accessHelper.GetDataSet(command);
            }
        }

        public static DataSet GetIdDataSet(string id)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select ");
            builder.Append("*");
            builder.Append(" from ");
            builder.Append("K8_ExploitS");
            builder.Append(" where ");
            builder.Append("[id]=@id");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@id", OleDbType.VarChar, 20).Value = id;
                return K8accessHelper.GetDataSet(command);
            }
        }

        public static bool InsertRecord(ModelK8Exp model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Insert into");
            builder.Append(" K8_ExploitS ");
            builder.Append("([appName],[btnName],[btnTip],[addURL],[method],[cookie],[sumbitData],[referer],[userAgent],[encode],[allowRedirect],[AddTime])");
            builder.Append(" VALUES ");
            builder.Append("(@appName,@btnName,@btnTip,@addURL,@method,@cookie,@sumbitData,@referer,@userAgent,@encode,@allowRedirect,@AddTime)");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@appName", OleDbType.VarChar, 0x3e8).Value = model.appName;
                command.Parameters.Add("@btnName", OleDbType.VarChar, 0x3e8).Value = model.btnName;
                command.Parameters.Add("@btnTip", OleDbType.VarChar).Value = model.btnTip;
                command.Parameters.Add("@addURL", OleDbType.VarChar).Value = model.addURL;
                command.Parameters.Add("@method", OleDbType.VarChar, 20).Value = model.method;
                command.Parameters.Add("@cookie", OleDbType.VarChar).Value = model.cookie;
                command.Parameters.Add("@sumbitData", OleDbType.VarChar).Value = model.sumbitData;
                command.Parameters.Add("@referer", OleDbType.VarChar).Value = model.referer;
                command.Parameters.Add("@userAgent", OleDbType.VarChar).Value = model.userAgent;
                command.Parameters.Add("@encode", OleDbType.VarChar, 20).Value = model.encode;
                command.Parameters.Add("@allowRedirect", OleDbType.VarChar, 20).Value = model.allowRedirect;
                command.Parameters.Add("@AddTime", OleDbType.VarChar, 50).Value = model.AddTime;
                return K8accessHelper.ExecSQLparameter(command);
            }
        }

        public static bool UpdateRecord(ModelK8Exp model, int ID)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("UPDATE");
            builder.Append(" K8_ExploitS SET");
            builder.Append("[appName]=@appName,[btnName]=@btnName,[btnTip]=@btnTip,[method]=@method,");
            builder.Append("[cookie]=@cookie,[sumbitData]=@sumbitData,[referer]=@referer,[userAgent]=@userAgent,[encode]=@encode,[allowRedirect]=@allowRedirect,");
            builder.Append("[AddTime]=@AddTime");
            builder.Append(" WHERE ");
            builder.Append("ID=" + ID);
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@appName", OleDbType.VarChar, 0x3e8).Value = model.appName;
                command.Parameters.Add("@btnName", OleDbType.VarChar, 0x3e8).Value = model.btnName;
                command.Parameters.Add("@btnTip", OleDbType.VarChar).Value = model.btnTip;
                command.Parameters.Add("@method", OleDbType.VarChar, 20).Value = model.method;
                command.Parameters.Add("@cookie", OleDbType.VarChar).Value = model.cookie;
                command.Parameters.Add("@sumbitData", OleDbType.VarChar).Value = model.sumbitData;
                command.Parameters.Add("@referer", OleDbType.VarChar).Value = model.referer;
                command.Parameters.Add("@userAgent", OleDbType.VarChar).Value = model.userAgent;
                command.Parameters.Add("@encode", OleDbType.VarChar, 20).Value = model.encode;
                command.Parameters.Add("@allowRedirect", OleDbType.VarChar, 20).Value = model.allowRedirect;
                command.Parameters.Add("@AddTime", OleDbType.VarChar, 50).Value = model.AddTime;
                return K8accessHelper.ExecSQLparameter(command);
            }
        }
    }
}

