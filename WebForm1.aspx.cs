using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1003
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee ee = new Employee();
            List<string> ss=new List<string>();
            ee.Name = TextBox1.Text;
            if (RadioButtonList1.SelectedValue == "Male")
            {
                ee.Gender = true;
            }
            else
            {
                ee.Gender = false;
            }
            foreach(ListItem i in CheckBoxList2.Items)
            {
                if (i.Selected)
                {
                    //ee.Skills.Add(i.Value);           //skill在Employee裡面沒有new
                    ss.Add(i.Value);
                }                                       //(也就是說根本沒有產生skill的物件)
            }                                           //電腦找不到這個東西
            ee.Skills = ss;                             //直接把ee.Skills assign給 ss
            Label1.Text = ee.get_info();
        }
    }
}