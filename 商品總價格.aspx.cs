using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1003
{
    public partial class 商品總價格 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)   //Add
        {
            ListItem a=new ListItem();
            double p = 0;
            a.Text = ListBox1.SelectedItem.Text;        //item
            a.Value = ListBox1.SelectedItem.Value;      //item's price
            ListBox2.Items.Add(a);                      //把選中的item加進TextBox2裡面
            foreach(ListItem i in ListBox2.Items)       //計算總價格
            {
                p = p + Double.Parse(i.Value);
            }
            Label1.Text = p.ToString();
        }
        protected void Button2_Click(object sender, EventArgs e)     //Remove
        {
            double p = 0;
            ListBox2.Items.Remove(ListBox2.SelectedItem);
            foreach (ListItem i in ListBox2.Items)
            {
                p = p + Double.Parse(i.Value);
            }
            Label1.Text = p.ToString();
        }
    }
}