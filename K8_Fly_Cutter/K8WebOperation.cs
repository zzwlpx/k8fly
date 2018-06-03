namespace K8_Fly_Cutter
{
    using System;
    using System.Net;
    using System.Text;
    using System.Text.RegularExpressions;

    public class K8WebOperation
    {
        public static string GetDomainName(string url)
        {
            if (url == null)
            {
                throw new Exception("输入的url为空");
            }
            Regex regex = new Regex(@"(?<=://)([\w-]+\.)+[\w-]+(?<=/?)");
            return regex.Match(url, 0).Value.Replace("/", string.Empty);
        }

        public static string GetHTML(string url)
        {
            try
            {
                byte[] bytes = new WebClient().DownloadData(url);
                return Encoding.Default.GetString(bytes);
            }
            catch (Exception)
            {
                return "k8err";
            }
        }

        public static int GetStatusCode(string url)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            int statusCode;
            try
            {
                request = (HttpWebRequest) WebRequest.Create(url);
            }
            catch (Exception)
            {
                return -1;
            }
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "UrlStatusSpider/1.0 (urlstatus-zds)";
            request.UserAgent = "Mozilla/5.0 (Windows NT 5.2) AppleWebKit/535.1 (KHTML, like Gecko) Chrome/14.0.835.186 Safari/535.1";
            request.Timeout = 0xbb8;
            request.Method = "GET";
            request.AllowAutoRedirect = false;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
                statusCode = (int) response.StatusCode;
            }
            catch (WebException exception)
            {
                response = (HttpWebResponse) exception.Response;
                if (response != null)
                {
                    return (int) response.StatusCode;
                }
                statusCode = -1;
            }
            catch
            {
                statusCode = -1;
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
            return statusCode;
        }

        public static bool IsExistURL(string k8url)
        {
            return (GetStatusCode(k8url) == 200);
        }

        public static bool IsExistURLfile(string k8url, int timeout)
        {
            bool flag2;
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(k8url);
            request.Timeout = timeout;
            try
            {
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                if (response.ContentLength == 0L)
                {
                    return false;
                }
                flag2 = true;
            }
            catch (Exception)
            {
                flag2 = false;
            }
            finally
            {
                request.Abort();
            }
            return flag2;
        }

        public static string k8getUrlStatusCode(string k8url)
        {
            HttpWebResponse response;
            string str = "";
            HttpWebRequest request = null;
            try
            {
                request = (HttpWebRequest) WebRequest.Create(k8url);
                str = "200";
            }
            catch (Exception)
            {
                str = "err";
            }
            try
            {
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (WebException exception2)
            {
                response = (HttpWebResponse) exception2.Response;
                if (response != null)
                {
                    return Convert.ToString((int) response.StatusCode);
                }
                str = "err";
            }
            return str;
        }

        public static string UrlEncode(string str)
        {
            StringBuilder builder = new StringBuilder();
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append("%" + Convert.ToString(bytes[i], 0x10));
            }
            return builder.ToString();
        }
    }
}

