﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityClassLibrary;

public partial class Orders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            using (MaryPizzaEntities ctx = new MaryPizzaEntities())
            {
                var toppings = (from c in ctx.Toppings
                                select c).ToList();

                lbToppings.DataSource = toppings;
                lbToppings.DataTextField = "name";
                lbToppings.DataValueField = "toppingid";
                lbToppings.DataBind();
            }
        }
    }
    protected void btnOrder_Click(object sender, EventArgs e)
    {
        string delivery;
        if (rbDelivery.Checked)
        {
            delivery = "Delivery";
        }
        else
        {
            delivery = "Pick Up";
        }

        using (MaryPizzaEntities ctx = new MaryPizzaEntities())
        {
            Order order = new Order();

            foreach (ListItem item in lbToppings.Items)
            {
                if (item.Selected)
                {
                    order.Toppings.Add(
                        ctx.Toppings.Where(t => t.name == item.Text).Select(t => t).First());
                }
            }

            order.delivery = delivery;
            order.firstname = tbFirst.Text;
            order.lastName = tbLast.Text;
            order.email = tbEmail.Text;
            order.phone = tbPhone.Text;
            order.size = ddlSize.SelectedValue;
            order.noOfPizzas = Int32.Parse(tbQuantity.Text);
            order.orderDate = DateTime.Now;
            ctx.Orders.Add(order);
            ctx.SaveChanges();

            if (!ClientScript.IsClientScriptBlockRegistered("script"))
            {
                String str = "Order Submitted!\\n"
                    + order.lastName + ", " + order.firstname + "\\n"
                    + "Phone: " + order.phone + "\\n"
                    + order.email + "\\n"
                    + "Size: " + order.size + "\\n"
                    + "Quantity: " + order.noOfPizzas + "\\n"
                    + order.email + "\\n"
                    + order.delivery + "\\n";

                ClientScript.RegisterStartupScript(this.GetType(), "script", "<script language = 'javascript'>if(confirm('" + str + "')){ window.location.href = 'Orders.aspx';} else {window.location.href = 'Orders.aspx';}</script>");
            }
       
        }

    }
    protected void sizeSelected(object sender, EventArgs e)
    {
        if (ddlSize.SelectedValue.Equals("Small"))
        {
            rbDelivery.Enabled = false;
            rbDelivery.Checked = false;
            rbPickup.Checked = true;
        }
        else
        {
            rbDelivery.Enabled = true;
        }
    }

    protected void cvToppings_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = lbToppings.SelectedItem != null;
    }
}