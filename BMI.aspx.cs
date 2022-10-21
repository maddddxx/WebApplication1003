using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1003
{
    public partial class BMI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double h;
            double w;
            double x;
            if (RadioButtonList1.SelectedValue == "inch")
            {
                h = Double.Parse(TextBox2.Text) * 2.54 / 100;
            }else{
                h = Double.Parse(TextBox2.Text) / 100;
            }
            if (RadioButtonList2.SelectedValue == "pound")
            {
                w = Double.Parse(TextBox3.Text)*0.45;
            }else{
                w = Double.Parse(TextBox3.Text);
            }
            x = w / (h * h);
            string s;
            if (x<18.5){s = "太輕";}
            else if(x >25){s="太胖";}
            else{s = "體重正常";}
            string r= "Your bmi : " + (x).ToString() + s + "<br>";
            r = r.Replace("\r\n", "<br>");      
            r = "<hr>" + "Gender : " + TextBox4.Text + "<br>" + r;   
            Label1.Text = r + Label1.Text;
        }
    }
}