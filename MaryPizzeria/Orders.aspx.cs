﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        List<Topping> selectedToppings = new List<Topping>();

        foreach (ListItem item in lbToppings.Items)
        {
            if (item.Selected)
            {
                Topping topping = new Topping();
                topping.toppingId = Int32.Parse(item.Value);
                selectedToppings.Add(topping);
            }
        }

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
            order.delivery = delivery;
            order.firstname = tbFirst.Text;
            order.lastName = tbLast.Text;
            order.email = tbEmail.Text;
            order.phone = tbPhone.Text;
            order.size = ddlSize.SelectedValue;
            order.noOfPizzas = Int32.Parse(tbQuantity.Text);
            order.orderDate = DateTime.Now;
            order.Toppings = selectedToppings;
            ctx.Orders.Add(order);
            ctx.SaveChanges();
        }
    }
}