using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1003
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)   //page_lord是一定被執行的
        {                                                      //且資料都會被存起來
            //DropDownList1.Items.Clear();
            if (!this.IsPostBack) {      //不是postback的時候做
                ListItem a = new ListItem();   //也就是說只有是第一次的時候做(Find Kill就不會重複了)
                ListItem b = new ListItem();   //利用運算子new透過ListItem()這個constructor
                a.Text = "Find";               //建構出ListItem物件 a,b
                a.Value = "Discover something";
                DropDownList1.Items.Add(a);    //把ListItem a加進去
                b.Text = "Kill";
                b.Value = "Let someone died";
                DropDownList1.Items.Add(b);    //把ListItem b加進去
            }
        }
        /*protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1
        }*/
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Value;
                                        //SelectedValue; 
        }

        
    }
}