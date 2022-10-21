using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1003
{
    public partial class PostBack次數_連結次數_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = (Int32.Parse(Label1.Text) + 1).ToString();
            int counter;
            if (ViewState["counter"] == null)     //當作是第一次
            {
                counter = 1;                      //counter = 1
            }
            else                                 //只要"counter"!=NULL 那就要做強制型別轉換成int
            {                                    //再+1         
                counter = (int)ViewState["counter"]+1;    //將counters拿出來做強制型別轉換成int
            }
            ViewState["counter"]=counter;           //把結果assign給viewstate的這個變數裡面去
            Label1.Text = counter.ToString();
        }
    }
}