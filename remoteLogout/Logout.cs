using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace remoteLogout
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)] 
    public partial class Logout : Form
    {
        string loginUrl = "http://10.255.44.33/rad_online.php";
        public Logout()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (tbx_userName.Text==string.Empty||tbx_password.Text==string.Empty)
            {
                MessageBox.Show("请检查用户名和密码！","ERROR");
            }
            else
            {
                IDictionary<string, string> postform = new Dictionary<string, string>();
                postform.Add("username", tbx_userName.Text);
                postform.Add("password", tbx_password.Text);
                HttpWebResponse response = null;
                try
                {
                    response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, postform);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(
                        "Sorry，请求失败\n" + ex.Message.ToString() + "请检查网络连接是否正常，并重试!",
                        "错误",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (response != null)
                {
                    // 得到返回的数据流  
                    Stream receiveStream = response.GetResponseStream();
                    // 如果有压缩,则进行解压  
                    if (response.ContentEncoding.ToLower().Contains("gzip"))
                    {
                        receiveStream = new GZipStream(receiveStream, CompressionMode.Decompress);

                    }
                    string html = new StreamReader(receiveStream).ReadToEnd();

                    int index = html.IndexOf("a href=\"#\" onclick=\"do_drop(");
                    if (index != -1)
                    {
                        try
                        {


                            string value = html.Substring(index + 29, 33);
                            IDictionary<string, string> dropform = new Dictionary<string, string>();
                            dropform.Add("action", "dm");
                            dropform.Add("sid", value);
                            response = HttpWebResponseUtility.CreatePostHttpResponse(loginUrl, dropform);
                            MessageBox.Show("下线成功！", "SUCCESS");

                        }
                        catch
                        {
                            MessageBox.Show("网络错误，下线失败", "ERROR");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("您不在线或账号错误！", "ERROR");
                    }
                }
            }
        }

        private void tbx_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btn_logout_Click(null, null);
            }
        }
    }
}
