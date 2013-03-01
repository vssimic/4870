using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityClassLibrary;

public partial class Sales_Reports : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnGetReport_Click(object sender, EventArgs e)
    {
        DateTime start = calendarStart.SelectedDate;
        DateTime end = calendarEnd.SelectedDate;

        using(MaryPizzaEntities ctx = new MaryPizzaEntities())
        {
            var query = (from o in ctx.Orders
                         where o.orderDate >= start && o.orderDate <= end
                         select o).ToList();
            gvReports.DataSource = query;
            gvReports.DataBind();
        }
    }
}