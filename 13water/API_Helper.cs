using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
//using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
//using WebApplication1;

namespace _13water
{
    class API_Helper
    {
        //Post
        public static string HttpPost(string Url, string postDataStr, string value)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers["x-auth-token"] = value;
            //request.ContentLength = postDataStr.Length;
            StreamWriter writer = new StreamWriter(request.GetRequestStream(), Encoding.UTF8);
            writer.Write(postDataStr);
            writer.Flush();

            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }
            string encoding = response.ContentEncoding;
            if (encoding == null || encoding.Length < 1)
            {
                encoding = "UTF-8"; //默认编码 
            }
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));
            string retString = reader.ReadToEnd();
            Console.WriteLine(retString);
            return retString;

        }
        // Get
        public static string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "GET";
            request.ContentType = "application/json;charset=UTF-8";
            //request.Headers["x-auth-token"] = postDataStr;
            request.Headers.Add("x-auth-token", postDataStr);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            Console.WriteLine(retString);
            return retString;
        }

        //public static void Main(String[] args)
        //{
        //    HttpPost("https://api.shisanshui.rtxux.xyz/auth/login", "{\"username\":\"aze\",\"password\":\"aze\"}", "");
        //    HttpGet("https://api.shisanshui.rtxux.xyz/auth/validate", "2227a0e6-532a-4f7d-91b4-ed9c2d0cd319");
        //    HttpPost("https://api.shisanshui.rtxux.xyz/game/open", "{\"username\":\"aze\",\"password\":\"aze\"}", "2227a0e6-532a-4f7d-91b4-ed9c2d0cd319");
        //    Console.ReadKey();
        //}

    }
}
