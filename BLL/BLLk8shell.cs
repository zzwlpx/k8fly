namespace BLL
{
    using DAL;
    using Model;
    using System;
    using System.Data;

    public class BLLk8shell
    {
        public static bool DeleteRecord(int id)
        {
            return DALk8shell.DeleteRecord(id);
        }

        public static bool ExistsRecord(string[] ModelArray)
        {
            ModelK8shell model = new ModelK8shell {
                ShellPath = ModelArray[0]
            };
            return DALk8shell.ExistsRecord(model);
        }

        public static string ExistsRecordGetTargetID(string[] ModelArray)
        {
            ModelK8shell model = new ModelK8shell {
                ShellPath = ModelArray[0]
            };
            return DALk8shell.ExistsRecordGetTargetID(model).Tables[0].Rows[0][0].ToString();
        }

        public static DataSet GetDataSet()
        {
            ModelK8shell lkshell = new ModelK8shell();
            return DALk8shell.GetDataSet();
        }

        public static DataSet GetDataSet(string title)
        {
            return DALk8shell.GetDataSet(title);
        }

        public static DataSet GetDataSet(string title, string antiSoft)
        {
            return DALk8shell.GetDataSet(title, antiSoft);
        }

        public static int GetPageCount(int PageNum)
        {
            return DALk8shell.GetPageCount(PageNum);
        }

        public static DataSet GetPageDataSet(int InPage, int PageNum)
        {
            return DALk8shell.GetPageDataSet(InPage, PageNum);
        }

        public static bool InsertRecord(string[] ModelArray)
        {
            ModelK8shell model = new ModelK8shell {
                TargetID = ModelArray[0],
                TargetLevel = ModelArray[1],
                IsOnline = ModelArray[2],
                Permission = ModelArray[3],
                PR = ModelArray[4],
                ShellPath = ModelArray[5],
                ShellPass = ModelArray[6],
                ShellCoding = ModelArray[7],
                XssCookie = ModelArray[8],
                IP = ModelArray[9],
                Area = ModelArray[10],
                OS = ModelArray[11],
                ScritpType = ModelArray[12],
                SQLType = ModelArray[13],
                RemoteRat = ModelArray[14],
                BackDoor = ModelArray[15],
                AddTime = ModelArray[0x10]
            };
            return DALk8shell.InsertRecord(model);
        }

        public static DataSet SplitDataSet(DataSet ds, int InPage, int PageNum)
        {
            DataSet set = new DataSet();
            set = ds.Clone();
            int num = PageNum * (InPage - 1);
            int num2 = (PageNum * InPage) - 1;
            for (int i = num; i <= num2; i++)
            {
                if (i >= ds.Tables[0].Rows.Count)
                {
                    break;
                }
                set.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
            }
            ds.Dispose();
            return set;
        }

        public static bool UpdateRecord(string[] ModelArray, int ID)
        {
            ModelK8shell model = new ModelK8shell {
                TargetID = ModelArray[0],
                TargetLevel = ModelArray[1],
                IsOnline = ModelArray[2],
                Permission = ModelArray[3],
                PR = ModelArray[4],
                ShellPath = ModelArray[5],
                ShellPass = ModelArray[6],
                ShellCoding = ModelArray[7],
                XssCookie = ModelArray[8],
                IP = ModelArray[9],
                Area = ModelArray[10],
                OS = ModelArray[11],
                ScritpType = ModelArray[12],
                SQLType = ModelArray[13],
                RemoteRat = ModelArray[14],
                BackDoor = ModelArray[15],
                AddTime = ModelArray[0x10]
            };
            return DALk8shell.UpdateRecord(model, ID);
        }
    }
}

