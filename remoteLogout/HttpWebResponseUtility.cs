﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace remoteLogout
{
    class HttpWebResponseUtility
    {
        /// <summary>    

        /// 创建POST方式的HTTP请求    

        /// </summary>    

        /// <param name="url">请求的URL</param>    

        /// <param name="parameters">随同请求POST的参数名称及参数值字典</param>    

        /// <param name="timeout">请求的超时时间</param>    

        /// <param name="userAgent">请求的客户端浏览器信息，可以为空</param>    

        /// <param name="requestEncoding">发送HTTP请求时所用的编码</param>    

        /// <param name="cookies">随同HTTP请求发送的Cookie信息，如果不需要身份验证可以为空</param>    

        /// <returns></returns>    
        public static HttpWebResponse CreatePostHttpResponse(string url, IDictionary<string, string> parameters)
        {

            if (string.IsNullOrEmpty(url))
            {

                throw new ArgumentNullException("url");

            }

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

            request.Referer = "http://10.255.44.33/srun_portal.html?&ac_id=6&sys=";

            request.Accept="text/html, application/xhtml+xml, */*";

            request.UserAgent ="Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; Touch; rv:11.0) like Gecko";

            request.Method = "POST";

            request.ContentType = "application/x-www-form-urlencoded;charset=UTF8";

            //如果需要POST数据    

            if (!(parameters == null || parameters.Count == 0))
            {

                StringBuilder buffer = new StringBuilder();

                int i = 0;

                foreach (string key in parameters.Keys)
                {

                    if (i > 0)
                    {

                        buffer.AppendFormat("&{0}={1}", key, parameters[key]);

                    }

                    else
                    {

                        buffer.AppendFormat("{0}={1}", key, parameters[key]);

                    }

                    i++;

                }

                byte[] data = Encoding.UTF8.GetBytes(buffer.ToString());

                using (Stream stream = request.GetRequestStream())
                {

                    stream.Write(data, 0, data.Length);

                }

            }

            return request.GetResponse() as HttpWebResponse;

        }
        //检查
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {

            return true; //总是接受    

        }

    }


}

