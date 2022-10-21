using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1003
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cc = new HttpCookie("hello");     //建一個cookie的物件
            cc["name"] = TextBox1.Text;
            cc.Expires = DateTime.Now.AddYears(1);       //cookie一年後失效
            Response.Cookies.Add(cc);                    //把cc檔加進去，把cookie加進去
            Response.Redirect("WebForm3.aspx");
        }
    }
}