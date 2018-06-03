namespace DAL
{
    using DBUtility;
    using Model;
    using System;
    using System.Data;
    using System.Data.OleDb;
    using System.Text;

    public class DALk8shell
    {
        public static bool DeleteRecord(int id)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("delete from k8_shell where id=@id");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@id", OleDbType.Integer, 20).Value = id;
                return K8accessHelper.ExecIDU(command);
            }
        }

        public static bool ExistsRecord(ModelK8shell model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Select * from");
            builder.Append(" k8_shell ");
            builder.Append(" where ");
            builder.Append("[ShellPath]=@ShellPath");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@ShellPath", OleDbType.VarChar, 0x3e8).Value = model.ShellPath;
                if (K8accessHelper.GetRecordCount(command) > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static DataSet ExistsRecordGetTargetID(ModelK8shell model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Select [TargetID] from");
            builder.Append(" k8_shell ");
            builder.Append(" where ");
            builder.Append("[ShellPath]=@ShellPath");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@ShellPath", OleDbType.VarChar, 0x3e8).Value = model.ShellPath;
                return K8accessHelper.GetDataSet(command);
            }
        }

        public static DataSet GetDataSet()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select * from k8_shell");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                return K8accessHelper.GetDataSet(command);
            }
        }

        public static DataSet GetDataSet(string title)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select ");
            builder.Append("*");
            builder.Append(" from ");
            builder.Append("tb_demoTest");
            builder.Append(" where ");
            builder.Append("[title]=@title");
            builder.Append(" order by id desc");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@title", OleDbType.VarChar, 200).Value = title;
                return K8accessHelper.GetDataSet(command);
            }
        }

        public static DataSet GetDataSet(string title, string antiSoft)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select ");
            builder.Append("*");
            builder.Append(" from ");
            builder.Append("tb_demoTest");
            builder.Append(" where ");
            builder.Append("[title]=@title and [antiSoft]=@antiSoft");
            builder.Append(" order by id desc");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@title", OleDbType.VarChar, 200).Value = title;
                command.Parameters.Add("@antiSoft", OleDbType.VarChar, 200).Value = antiSoft;
                return K8accessHelper.GetDataSet(command);
            }
        }

        public static int GetPageCount(int PageNum)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select count(id) from tb_demoTest t where id=(select max(id) from tb_demoTest where title=t.title)");
            int recordCount = K8accessHelper.GetRecordCount(builder.ToString());
            int num2 = recordCount % PageNum;
            int num3 = recordCount / PageNum;
            if (num2 == 0)
            {
                return num3;
            }
            return (num3 + 1);
        }

        public static DataSet GetPageDataSet(int InPage, int PageNum)
        {
            StringBuilder builder = new StringBuilder();
            if ((InPage == 0) | (InPage == 1))
            {
                builder.Append("select top " + PageNum);
                builder.Append(" id,title,os,country,testTime,[level],[ReportImgPath]");
                builder.Append(" from ");
                builder.Append("tb_demoTest t");
                builder.Append(" where ");
                builder.Append("id=(select max(id) from tb_demoTest where title=t.title)");
            }
            else
            {
                builder.Append("select top " + PageNum);
                builder.Append(" id,title,os,country,testTime,[level],[ReportImgPath]");
                builder.Append(" from ");
                builder.Append("tb_demoTest t");
                builder.Append(" where ");
                builder.Append("id=(select max(id) from tb_demoTest where title=t.title)");
                builder.Append(" and id<>");
                builder.Append("(select top " + ((InPage - 1) * PageNum) + " id from tb_demoTest t where id=(select max(id) from tb_demoTest where title=t.title))");
            }
            return K8accessHelper.GetDataSet(builder.ToString());
        }

        public static bool InsertRecord(ModelK8shell model)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Insert into");
            builder.Append(" k8_shell ");
            builder.Append("([TargetID],[TargetLevel],[IsOnline],[Permission],[PR],[ShellPath],[ShellPass],[ShellCoding],[XssCookie],[IP],[Area],[OS],[ScritpType],[SQLType],[RemoteRat],[BackDoor],[AddTime])");
            builder.Append(" VALUES ");
            builder.Append("(@TargetID,@TargetLevel,@IsOnline,@Permission,@PR,@ShellPath,@ShellPass,@ShellCoding,@XssCookie,@IP,@Area,@OS,@ScritpType,@SQLType,@RemoteRat,@BackDoor,@AddTime)");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@TargetID", OleDbType.VarChar, 500).Value = model.TargetID;
                command.Parameters.Add("@TargetLevel", OleDbType.VarChar, 500).Value = model.TargetLevel;
                command.Parameters.Add("@IsOnline", OleDbType.VarChar, 500).Value = model.IsOnline;
                command.Parameters.Add("@Permission", OleDbType.VarChar, 500).Value = model.Permission;
                command.Parameters.Add("@PR", OleDbType.VarChar, 500).Value = model.PR;
                command.Parameters.Add("@ShellPath", OleDbType.VarChar, 0x3e8).Value = model.ShellPath;
                command.Parameters.Add("@ShellPass", OleDbType.VarChar, 500).Value = model.ShellPass;
                command.Parameters.Add("@ShellCoding", OleDbType.VarChar, 500).Value = model.ShellCoding;
                command.Parameters.Add("@XssCookie", OleDbType.VarChar).Value = model.XssCookie;
                command.Parameters.Add("@IP", OleDbType.VarChar, 500).Value = model.IP;
                command.Parameters.Add("@Area", OleDbType.VarChar, 500).Value = model.Area;
                command.Parameters.Add("@OS", OleDbType.VarChar, 500).Value = model.OS;
                command.Parameters.Add("@ScritpType", OleDbType.VarChar, 500).Value = model.ScritpType;
                command.Parameters.Add("@SQLType", OleDbType.VarChar, 500).Value = model.SQLType;
                command.Parameters.Add("@RemoteRat", OleDbType.VarChar, 500).Value = model.RemoteRat;
                command.Parameters.Add("@BackDoor", OleDbType.VarChar, 500).Value = model.BackDoor;
                command.Parameters.Add("@AddTime", OleDbType.VarChar, 500).Value = model.AddTime;
                return K8accessHelper.ExecSQLparameter(command);
            }
        }

        public static bool UpdateRecord(ModelK8shell model, int ID)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("UPDATE");
            builder.Append(" k8_shell SET");
            builder.Append("[TargetID]=@TargetID,[TargetLevel]=@TargetLevel,[IsOnline]=@IsOnline,[Permission]=@Permission,");
            builder.Append("[PR]=@PR,[ShellPath]=@ShellPath,[ShellPass]=@ShellPass,[ShellCoding]=@ShellCoding,[XssCookie]=@XssCookie,[IP]=@IP,");
            builder.Append("[Area]=@Area,[OS]=@OS,[ScritpType]=@ScritpType,[SQLType]=@SQLType,[RemoteRat]=@RemoteRat,[BackDoor]=@BackDoor,[AddTime]=@AddTime");
            builder.Append(" WHERE ");
            builder.Append("ID=" + ID);
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                command.Parameters.Add("@TargetID", OleDbType.VarChar, 500).Value = model.TargetID;
                command.Parameters.Add("@TargetLevel", OleDbType.VarChar, 500).Value = model.TargetLevel;
                command.Parameters.Add("@IsOnline", OleDbType.VarChar, 500).Value = model.IsOnline;
                command.Parameters.Add("@Permission", OleDbType.VarChar, 500).Value = model.Permission;
                command.Parameters.Add("@PR", OleDbType.VarChar, 500).Value = model.PR;
                command.Parameters.Add("@ShellPath", OleDbType.VarChar, 0x3e8).Value = model.ShellPath;
                command.Parameters.Add("@ShellPass", OleDbType.VarChar, 500).Value = model.ShellPass;
                command.Parameters.Add("@ShellCoding", OleDbType.VarChar, 500).Value = model.ShellCoding;
                command.Parameters.Add("@XssCookie", OleDbType.VarChar).Value = model.XssCookie;
                command.Parameters.Add("@IP", OleDbType.VarChar, 500).Value = model.IP;
                command.Parameters.Add("@Area", OleDbType.VarChar, 500).Value = model.Area;
                command.Parameters.Add("@OS", OleDbType.VarChar, 500).Value = model.OS;
                command.Parameters.Add("@ScritpType", OleDbType.VarChar, 500).Value = model.ScritpType;
                command.Parameters.Add("@SQLType", OleDbType.VarChar, 500).Value = model.SQLType;
                command.Parameters.Add("@RemoteRat", OleDbType.VarChar, 500).Value = model.RemoteRat;
                command.Parameters.Add("@BackDoor", OleDbType.VarChar, 500).Value = model.BackDoor;
                command.Parameters.Add("@AddTime", OleDbType.VarChar, 500).Value = model.AddTime;
                return K8accessHelper.ExecSQLparameter(command);
            }
        }
    }
}

