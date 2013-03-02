using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.User.IsInRole("admin"))
        {
            //lblUser.Text = "(" + Context.User.Identity.Name + ")";
            enableToppings(true);
            enableReports(true);
        }
        else
        {
            //lblUser.Text = "";
            enableToppings(false);
            enableReports(false);
        }

        if (HttpContext.Current.User.IsInRole("sales"))
        {
            //lblUser.Text = "(" + Context.User.Identity.Name + ")";
            enableToppings(false);
            enableReports(true);
        }
        img = this.TemplateSourceDirectory + "/images/banner.jpg";
    }
    private void enableToppings(bool tf)
    {
        imgToppingsEdit.Visible = tf;
    }

    private void enableReports(bool tf)
    {
        imgReports.Visible = tf;

    }
    protected string img = string.Empty;
}
