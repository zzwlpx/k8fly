namespace BLL
{
    using DAL;
    using Model;
    using System;
    using System.Data;

    public class BLLk8EXP
    {
        public static bool DeleteRecord(int id)
        {
            return DALk8Exp.DeleteRecord(id);
        }

        public static bool ExistsRecord(string[] ModelArray)
        {
            ModelK8Exp model = new ModelK8Exp {
                appName = ModelArray[0],
                method = ModelArray[1],
                cookie = ModelArray[2],
                sumbitData = ModelArray[3],
                referer = ModelArray[4],
                userAgent = ModelArray[5],
                encode = ModelArray[6],
                allowRedirect = ModelArray[7],
                addURL = ModelArray[8]
            };
            return DALk8Exp.ExistsRecord(model);
        }

        public static string ExistsRecordGetBtnName(string[] ModelArray)
        {
            ModelK8Exp model = new ModelK8Exp {
                appName = ModelArray[0],
                method = ModelArray[1],
                cookie = ModelArray[2],
                sumbitData = ModelArray[3],
                referer = ModelArray[4],
                userAgent = ModelArray[5],
                encode = ModelArray[6],
                allowRedirect = ModelArray[7]
            };
            return DALk8Exp.ExistsRecordGetBtnNameDS(model).Tables[0].Rows[0][0].ToString();
        }

        public static DataSet GetAppNameDataSet()
        {
            return DALk8Exp.GetAppNameDataSet();
        }

        public static DataSet GetDataSet()
        {
            return DALk8Exp.GetDataSet();
        }

        public static DataSet GetIdDataSet(string id)
        {
            return DALk8Exp.GetIdDataSet(id);
        }

        public static bool InsertRecord(string[] ModelArray)
        {
            ModelK8Exp model = new ModelK8Exp {
                appName = ModelArray[0],
                btnName = ModelArray[1],
                btnTip = ModelArray[2],
                method = ModelArray[3],
                cookie = ModelArray[4],
                sumbitData = ModelArray[5],
                referer = ModelArray[6],
                userAgent = ModelArray[7],
                encode = ModelArray[8],
                allowRedirect = ModelArray[9],
                AddTime = ModelArray[10],
                addURL = ModelArray[11]
            };
            return DALk8Exp.InsertRecord(model);
        }

        public static bool UpdateRecord(string[] ModelArray, int ID)
        {
            ModelK8Exp model = new ModelK8Exp {
                appName = ModelArray[0],
                btnName = ModelArray[1],
                btnTip = ModelArray[2],
                method = ModelArray[3],
                cookie = ModelArray[4],
                sumbitData = ModelArray[5],
                referer = ModelArray[6],
                userAgent = ModelArray[7],
                encode = ModelArray[8],
                allowRedirect = ModelArray[9],
                AddTime = ModelArray[10]
            };
            return DALk8Exp.UpdateRecord(model, ID);
        }
    }
}

