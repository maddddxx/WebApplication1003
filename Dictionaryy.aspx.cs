using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1003
{
    public partial class Dictionaryy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Dictionary<string,string> d=new Dictionary<string,string>();
                d.Add("Find", "Discover something");
                d.Add("Kill", "Let someone died");
                DropDownList1.Items.Add(d["Find"]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}