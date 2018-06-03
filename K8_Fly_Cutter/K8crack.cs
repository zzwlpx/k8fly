namespace K8_Fly_Cutter
{
    using System;
    using System.Globalization;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web;

    public class K8crack
    {
        private static string Base64_decode(string str)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(str);
                return Encoding.Default.GetString(bytes);
            }
            catch
            {
                return "Base64 Decode Fail";
            }
        }

        public static string Base64_DecodeGB2312(string str)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(str);
                return Encoding.GetEncoding("gb2312").GetString(bytes);
            }
            catch
            {
                return "Base64 Decode Fail";
            }
        }

        public static string Base64_DecodeUnicode(string str)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(str);
                return Encoding.Unicode.GetString(bytes);
            }
            catch
            {
                return "Base64 Decode Fail";
            }
        }

        public static string Base64_DecodeUTF8(string str)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(str);
                return Encoding.UTF8.GetString(bytes);
            }
            catch
            {
                return "Base64 Decode Fail";
            }
        }

        private static string Base64_encode(string str)
        {
            return Convert.ToBase64String(Encoding.Default.GetBytes(str));
        }

        public static string Base64_encodeGB2312(string str)
        {
            return Convert.ToBase64String(Encoding.GetEncoding("gb2312").GetBytes(str));
        }

        public static string Base64_encodeUnicode(string str)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(str));
        }

        public static string Base64_encodeUTF8(string str)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
        }

        public static string ChineseToUnicode(string str)
        {
            string str2 = "";
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    str2 = str2 + @"\u" + ((int) str[i]).ToString("x");
                }
            }
            return str2;
        }

        public static string Chr(int asciiCode)
        {
            if ((asciiCode < 0) || (asciiCode > 0xff))
            {
                throw new Exception("ASCII Code is not valid.");
            }
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = new byte[] { (byte) asciiCode };
            return encoding.GetString(bytes);
        }

        private static string expBase64_decode(string k8str)
        {
            k8str = k8str.Replace("[K8", "").Replace("team]", "");
            byte[] bytes = Convert.FromBase64String(k8str);
            return Encoding.Unicode.GetString(bytes);
        }

        private static string expBase64_encode(string str)
        {
            string str2 = Convert.ToBase64String(Encoding.Unicode.GetBytes(str));
            return ("[K8" + str2 + "team]");
        }

        public static string FlashPostDecode(string str)
        {
            str = GetMidStr(str, "lv.", "\";");
            str = str.Replace(" = \"", "=");
            str = str.Replace("\";\r\nlv.", "&");
            return str;
        }

        public static string FlashPostEncode(string str)
        {
            str = str.Replace("=", " = \"");
            str = str.Replace("&", "\";\r\nlv.");
            str = "lv." + str + "\";";
            return str;
        }

        private static string GetMd5Str(string ConvertString)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            return BitConverter.ToString(provider.ComputeHash(Encoding.Default.GetBytes(ConvertString)), 4, 8).Replace("-", "").ToLower();
        }

        private static string GetMidStr(string Str, string StartStr, string EndStr)
        {
            try
            {
                MatchCollection matchs = new Regex("(?<=" + StartStr + @")[^\[\]]+(?=" + EndStr + ")").Matches(Str);
                foreach (Match match in matchs)
                {
                    return match.Value;
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            return "";
        }

        public static string Hex2String(string HexStr)
        {
            try
            {
                string str = "";
                string[] strArray = new string[HexStr.Length / 2];
                for (int i = 0; i < (HexStr.Length / 2); i++)
                {
                    strArray[i] = HexStr.Substring(2 * i, 2);
                }
                foreach (string str2 in strArray)
                {
                    int num3 = int.Parse(str2.ToString(), NumberStyles.AllowHexSpecifier);
                    str = str + ((char) num3).ToString();
                }
                return str;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string HexEncodeGB2312(string str)
        {
            string str2 = "";
            if (str == "")
            {
                return "";
            }
            byte[] bytes = Encoding.GetEncoding("gb2312").GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                str2 = str2 + bytes[i].ToString("X");
            }
            return str2;
        }

        public static string HexEncodeUnicode(string str)
        {
            string str2 = "";
            if (str == "")
            {
                return "";
            }
            byte[] bytes = Encoding.Unicode.GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                str2 = str2 + bytes[i].ToString("X");
            }
            return str2;
        }

        public static string HexEncodeUTF8(string str)
        {
            string str2 = "";
            if (str == "")
            {
                return "";
            }
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                str2 = str2 + bytes[i].ToString("X");
            }
            return str2;
        }

        public static string jqueryPostDecode(string str)
        {
            str = str.Replace(": \"", "=");
            str = str.Replace("\",", "&");
            str = str.TrimEnd(new char[] { '"' });
            return str;
        }

        public static string jqueryPostEncode(string str)
        {
            str = str.Replace("=", ": \"");
            str = str.Replace("&", "\",");
            str = str + "\"";
            return str;
        }

        public static string K8Ascii_encode(string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                int num2 = str[i];
                str2 = str2 + Convert.ToString(num2) + ",";
            }
            try
            {
                str2 = str2.Trim(new char[] { ',' });
            }
            catch (Exception)
            {
                return "";
            }
            return str2;
        }

        public static string K8ascii2string(string k8asciiString)
        {
            StringBuilder builder = new StringBuilder();
            string[] strArray = k8asciiString.Split(new char[] { ',' });
            foreach (string str in strArray)
            {
                try
                {
                    builder.Append(Chr(int.Parse(str)));
                }
                catch (Exception)
                {
                    return k8asciiString;
                }
            }
            return builder.ToString();
        }

        public static string K8AsciiSum(string str)
        {
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int num3 = str[i];
                num += num3;
            }
            return num.ToString();
        }

        public static string K8Base64(string str, int type)
        {
            if (type == 1)
            {
                return Base64_encode(str);
            }
            if (type == 0)
            {
                return Base64_decode(str);
            }
            return "K8Base64 调用错误";
        }

        public static string K8expBase64(string str, int type)
        {
            if (type == 1)
            {
                return expBase64_encode(expBase64_encode(str));
            }
            if (type == 0)
            {
                return expBase64_decode(expBase64_decode(str));
            }
            return "K8Base64 调用错误";
        }

        public static string K8HTMLCharacter10(string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                int num2 = str[i];
                str2 = str2 + "&#" + Convert.ToString(num2) + ";";
            }
            return str2;
        }

        public static string K8HTMLCharacter16(string str)
        {
            string str2 = "";
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    str2 = str2 + "&#x" + ((int) str[i]).ToString("x") + ";";
                }
            }
            return str2;
        }

        public static string K8HTMLCharacterUTF8(string str)
        {
            string str2 = "";
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    str2 = str2 + "&#x" + ((int) str[i]).ToString("x") + ";";
                }
            }
            return str2;
        }

        public static string K8JSescape(string str)
        {
            string str2 = HttpUtility.UrlEncode(str, Encoding.Default);
            return ("<script>document.write(unescape('" + str2 + "'));</script>");
        }

        public static string K8JSescapeAll(string str)
        {
            StringBuilder builder = new StringBuilder();
            byte[] bytes = Encoding.Default.GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append("%" + Convert.ToString(bytes[i], 0x10));
            }
            return ("<script>document.write(unescape('" + builder.ToString() + "'));</script>");
        }

        public static string K8MD5(string s, int length)
        {
            if (length == 0x10)
            {
                return GetMd5Str(s);
            }
            if (length == 0x20)
            {
                return md5(s);
            }
            return "MD5加密 只支持16位和32位";
        }

        public static string K8Path16_MSSQL(string webpath)
        {
            int length = Pathto16Encode(webpath).Length - 2;
            try
            {
                return ("0x" + Pathto16Encode(webpath).Substring(2, length) + "00");
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string K8Path16_Mysql(string webpath)
        {
            try
            {
                return ("0x" + StrToHex(webpath));
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string K8SQL_CHAR_Decode(string k8asciiString)
        {
            k8asciiString = k8asciiString.Trim().ToUpper();
            k8asciiString = k8asciiString.Trim(new char[] { ',' }).Trim(new char[] { '+' });
            k8asciiString = k8asciiString.Trim(new char[] { '|' }).Trim(new char[] { '|' });
            k8asciiString = k8asciiString.Trim(new char[] { '.' }).Trim(new char[] { '.' });
            try
            {
                if (k8asciiString.Contains("CHAR("))
                {
                    k8asciiString = k8asciiString.Replace("+", ",");
                    k8asciiString = k8asciiString.Replace("CHAR(", "").Replace(")", "");
                }
                else if (k8asciiString.Contains("CHR("))
                {
                    k8asciiString = k8asciiString.Replace("||", ",");
                    k8asciiString = k8asciiString.Replace(".", ",");
                    k8asciiString = k8asciiString.Replace("+", ",");
                    k8asciiString = k8asciiString.Replace("CHR(", "").Replace(")", "");
                }
            }
            catch (Exception)
            {
                return "输入的ASCII码字符串格式不正确:\r\nASCII码之间的分隔符不是逗号的请先把空格或其它符号转成逗号";
            }
            StringBuilder builder = new StringBuilder();
            string[] strArray = k8asciiString.Split(new char[] { ',' });
            foreach (string str2 in strArray)
            {
                try
                {
                    builder.Append(Chr(int.Parse(str2)));
                }
                catch (Exception)
                {
                    return "输入的ASCII码字符串格式不正确:\r\nASCII码之间的分隔符不是逗号的请先把空格或其它符号转成逗号";
                }
            }
            return builder.ToString();
        }

        public static string K8UrlDecodeGB2312(string str)
        {
            return HttpUtility.UrlDecode(str, Encoding.GetEncoding("gb2312"));
        }

        public static string K8UrlDecodeUnicode(string str)
        {
            return HttpUtility.UrlDecode(str, Encoding.Unicode);
        }

        public static string K8UrlDecodeUTF8(string str)
        {
            return HttpUtility.UrlDecode(str, Encoding.UTF8);
        }

        public static string K8UrlEncodeAllStr(string str)
        {
            StringBuilder builder = new StringBuilder();
            byte[] bytes = Encoding.Default.GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append("%" + Convert.ToString(bytes[i], 0x10));
            }
            return builder.ToString();
        }

        public static string K8UrlEncodeGB2312(string str)
        {
            return HttpUtility.UrlEncode(str, Encoding.GetEncoding("gb2312"));
        }

        public static string K8UrlEncodeUnicode(string str)
        {
            return HttpUtility.UrlEncode(str, Encoding.Unicode);
        }

        public static string K8UrlEncodeUTF8(string str)
        {
            return HttpUtility.UrlEncode(str, Encoding.UTF8);
        }

        private static string md5(string s)
        {
            MD5 md = new MD5CryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            bytes = md.ComputeHash(bytes);
            md.Clear();
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str = str + Convert.ToString(bytes[i], 0x10).PadLeft(2, '0');
            }
            return str.PadLeft(0x20, '0').ToLower();
        }

        public static string MSSQL_ChrCode(string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                int num2 = str[i];
                str2 = str2 + "CHAR(" + Convert.ToString(num2) + ")+";
            }
            try
            {
                str2 = str2.Trim(new char[] { '+' });
            }
            catch (Exception)
            {
                return "";
            }
            return str2;
        }

        public static string MYSQL_ChrCode(string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                int num2 = str[i];
                str2 = str2 + Convert.ToString(num2) + ",";
            }
            try
            {
                str2 = str2.Trim(new char[] { ',' });
            }
            catch (Exception)
            {
                return "";
            }
            return ("CHAR(" + str2 + ")");
        }

        public static string MYSQL_ChrCode2(string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                int num2 = str[i];
                str2 = str2 + "CHAR(" + Convert.ToString(num2) + "),";
            }
            try
            {
                str2 = str2.Trim(new char[] { ',' });
            }
            catch (Exception)
            {
                return "";
            }
            return str2;
        }

        public static string Oracle_ChrCode(string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                int num2 = str[i];
                str2 = str2 + "Chr(" + Convert.ToString(num2) + ")||";
            }
            try
            {
                str2 = str2.Trim(new char[] { '|' });
            }
            catch (Exception)
            {
                return "";
            }
            return str2;
        }

        private static string Pathto16Encode(string strEncode)
        {
            string str = "";
            foreach (short num2 in strEncode.ToCharArray())
            {
                str = str + num2.ToString("X4");
            }
            return str;
        }

        public static string PHP_ChrCode(string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                int num2 = str[i];
                str2 = str2 + "Chr(" + Convert.ToString(num2) + ").";
            }
            try
            {
                str2 = str2.Trim(new char[] { '.' });
            }
            catch (Exception)
            {
                return "";
            }
            return str2;
        }

        public static string PHP_ChrCodePlus(string str)
        {
            string str2 = "";
            for (int i = 0; i < str.Length; i++)
            {
                int num2 = str[i];
                str2 = str2 + "Chr(" + Convert.ToString(num2) + ")+";
            }
            try
            {
                str2 = str2.Trim(new char[] { '+' });
            }
            catch (Exception)
            {
                return "";
            }
            return str2;
        }

        public static string PHPPostDecode(string str)
        {
            str = str.Replace("$post_data['", "lv.");
            str = str.Replace("'] = \"", " = \"");
            str = GetMidStr(str, "lv.", "\";");
            str = "lv." + str + "\";";
            str = FlashPostDecode(str);
            return str;
        }

        public static string PHPPostEncode(string str)
        {
            str = str.Replace("=", "'] = \"");
            str = str.Replace("&", "\";\r\n$post_data['");
            str = "$post_data['" + str + "\";";
            return str;
        }

        public static string PythonPostDecode(string str)
        {
            str = GetMidStr(str, "{'", "'}");
            str = str.Replace("':'", "=");
            str = str.Replace("',\r\n'", "&");
            return str;
        }

        public static string PythonPostEncode(string str)
        {
            str = str.Replace("=", "':'");
            str = str.Replace("&", "',\r\n'");
            str = "{'" + str + "'}";
            return str;
        }

        public static string SHA1_Encrypt(string Source_String)
        {
            byte[] bytes = Encoding.Default.GetBytes(Source_String);
            bytes = new SHA1CryptoServiceProvider().ComputeHash(bytes);
            StringBuilder builder = new StringBuilder();
            foreach (byte num2 in bytes)
            {
                builder.AppendFormat("{0:x2}", num2);
            }
            return builder.ToString();
        }

        public static string SHA256Encrypt(string str)
        {
            SHA256 sha = new SHA256Managed();
            byte[] inArray = sha.ComputeHash(Encoding.Default.GetBytes(str));
            sha.Clear();
            return Convert.ToBase64String(inArray);
        }

        public static string SHA384Encrypt(string str)
        {
            SHA384 sha = new SHA384Managed();
            byte[] inArray = sha.ComputeHash(Encoding.Default.GetBytes(str));
            sha.Clear();
            return Convert.ToBase64String(inArray);
        }

        public static string SHA512Encrypt(string str)
        {
            SHA512 sha = new SHA512Managed();
            byte[] inArray = sha.ComputeHash(Encoding.Default.GetBytes(str));
            sha.Clear();
            return Convert.ToBase64String(inArray);
        }

        public static string Str2JS_Unicode(string str)
        {
            string str2 = "";
            if (str != null)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    string str3 = ((int) str[i]).ToString("x");
                    if (str3.Length < 4)
                    {
                        str3 = "00" + str3;
                    }
                    str2 = str2 + @"\u" + str3;
                }
            }
            return str2;
        }

        public static string str2JSstringHex(string str)
        {
            string str2 = "";
            if (str == "")
            {
                return "";
            }
            byte[] bytes = Encoding.Default.GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                str2 = str2 + @"\x" + bytes[i].ToString("X");
            }
            return str2;
        }

        public static string StrToHex(string str)
        {
            string str2 = "";
            if (str == "")
            {
                return "";
            }
            byte[] bytes = Encoding.Default.GetBytes(str);
            for (int i = 0; i < bytes.Length; i++)
            {
                str2 = str2 + bytes[i].ToString("X");
            }
            return str2;
        }

        public static string UnicodeToChinese(string str)
        {
            string message = "";
            if (str != null)
            {
                string[] strArray = str.Replace(@"\", "").Split(new char[] { 'u' });
                try
                {
                    for (int i = 1; i < strArray.Length; i++)
                    {
                        message = message + ((char) int.Parse(strArray[i], NumberStyles.HexNumber));
                    }
                    Console.WriteLine(message);
                    Console.ReadLine();
                }
                catch (FormatException exception)
                {
                    message = exception.Message;
                }
            }
            return message;
        }
    }
}

