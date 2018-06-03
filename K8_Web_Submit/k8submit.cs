namespace K8_Web_Submit
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;

    public class k8submit
    {
        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        public static string GetSubmit(string k8url, string k8submitData, string k8Cookie, int k8timeout, int k8coding)
        {
            Exception exception;
            if (!k8url.Contains("http://") & !k8url.Contains("https://"))
            {
                k8url = "http://" + k8url;
            }
            StringBuilder builder = new StringBuilder();
            k8url = k8url + k8submitData.Trim();
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(k8submit.RemoteCertificateValidationCallback);
            new X509Store(StoreName.My, StoreLocation.CurrentUser).Open(OpenFlags.OpenExistingOnly);
            HttpWebRequest request = null;
            try
            {
                request = (HttpWebRequest) WebRequest.Create(k8url);
            }
            catch (Exception exception1)
            {
                exception = exception1;
                return exception.Message;
            }
            request.AllowAutoRedirect = false;
            request.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
            request.Referer = k8url;
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; MAXTHON 2.0)";
            if (k8Cookie.Trim() != "")
            {
                CookieContainer cookieContainer = new CookieContainer();
                string[] strArray = k8Cookie.Split(";".ToCharArray());
                foreach (string str2 in strArray)
                {
                    cookieContainer.SetCookies(new Uri(k8url), str2);
                }
                if (cookieContainer.Count != 0)
                {
                    request.CookieContainer = cookieContainer;
                }
                else
                {
                    request.CookieContainer = new CookieContainer();
                    cookieContainer = request.CookieContainer;
                }
            }
            request.KeepAlive = true;
            request.Timeout = k8timeout;
            request.Method = "GET";
            request.KeepAlive = true;
            request.ProtocolVersion = HttpVersion.Version10;
            try
            {
                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse) request.GetResponse();
                }
                catch (WebException exception2)
                {
                    response = (HttpWebResponse) exception2.Response;
                    return Convert.ToString((int) response.StatusCode);
                }
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(k8coding));
                string str3 = reader.ReadToEnd().Trim();
                reader.Close();
                return str3;
            }
            catch (Exception exception4)
            {
                exception = exception4;
                return (builder.ToString() + exception.Message);
            }
        }

        public static string PostSubmit(string k8url, string k8submitData, string k8Cookie, int k8timeout, int k8coding)
        {
            Exception exception;
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(k8submit.RemoteCertificateValidationCallback);
            new X509Store(StoreName.My, StoreLocation.CurrentUser).Open(OpenFlags.OpenExistingOnly);
            if (!k8url.Contains("http://") & !k8url.Contains("https://"))
            {
                k8url = "http://" + k8url;
            }
            StringBuilder builder = new StringBuilder();
            try
            {
                HttpWebResponse response;
                WebException exception2;
                HttpWebRequest request = null;
                try
                {
                    request = (HttpWebRequest) WebRequest.Create(k8url);
                }
                catch (Exception exception1)
                {
                    exception = exception1;
                    return exception.Message;
                }
                request.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
                request.Referer = k8url;
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 2.0.50727; MAXTHON 2.0)";
                request.KeepAlive = true;
                request.Timeout = k8timeout;
                if (k8Cookie.Trim() != "")
                {
                    CookieContainer cookieContainer = new CookieContainer();
                    string[] strArray = k8Cookie.Split(";".ToCharArray());
                    foreach (string str2 in strArray)
                    {
                        cookieContainer.SetCookies(new Uri(k8url), str2);
                    }
                    if (cookieContainer.Count != 0)
                    {
                        request.CookieContainer = cookieContainer;
                    }
                    else
                    {
                        request.CookieContainer = new CookieContainer();
                        cookieContainer = request.CookieContainer;
                    }
                }
                request.ProtocolVersion = HttpVersion.Version10;
                request.Method = "POST";
                string s = "";
                byte[] bytes = new ASCIIEncoding().GetBytes(s);
                request.ContentLength = bytes.Length;
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(bytes, 0, bytes.Length);
                requestStream.Close();
                if (k8coding == 1)
                {
                    try
                    {
                        response = (HttpWebResponse) request.GetResponse();
                    }
                    catch (WebException exception3)
                    {
                        exception2 = exception3;
                        response = (HttpWebResponse) exception2.Response;
                        return Convert.ToString((int) response.StatusCode);
                    }
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(response.CharacterSet));
                    return reader.ReadToEnd().Trim();
                }
                try
                {
                    response = (HttpWebResponse) request.GetResponse();
                }
                catch (WebException exception4)
                {
                    exception2 = exception4;
                    response = (HttpWebResponse) exception2.Response;
                    return Convert.ToString((int) response.StatusCode);
                }
                StreamReader reader2 = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(k8coding));
                string str4 = "";
                string str5 = "";
                while ((str4 = reader2.ReadLine()) != null)
                {
                    str5 = str5 + str4 + "\r\n";
                }
                string str6 = str5.Trim();
                reader2.Close();
                return str6;
            }
            catch (Exception exception5)
            {
                exception = exception5;
                return exception.ToString();
            }
        }

        public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}

