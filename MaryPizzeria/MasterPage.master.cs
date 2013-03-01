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
        if (HttpContext.Current.User.IsInRole("Admin"))
        {
            imgToppingsEdit.Visible = true;
        }
        else
        {
            imgToppingsEdit.Visible = false;
        }
        img = this.TemplateSourceDirectory + "/images/banner.jpg";
    }

    protected string img = string.Empty;
}
