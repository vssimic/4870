using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityClassLibrary;

public partial class Admin_Toppings : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
    }
    protected void btnInsert_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow row in gvToppings.Rows)
        {
            if (row.Cells[2].Text.ToLower().Equals(tbToppingName.Text.ToLower()))
            {
                if (!ClientScript.IsClientScriptBlockRegistered("script"))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "script", "<script language = 'javascript'>alert('Topping already exists')</script>");
                        
                }
                return;
            }
        }

        if (tbToppingName.Text != String.Empty)
        {
            Topping topping = new Topping();
            topping.name = tbToppingName.Text;
            topping.active = "yes";

            using (MaryPizzaEntities ctx = new MaryPizzaEntities())
            {
                ctx.Toppings.Add(topping);
                ctx.SaveChanges();
                gvToppings.DataBind();
            }
        }
    }
}