﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace source.Admin_SRC
{
    public partial class Admin_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int adminID;
            if (Session == null || Session["adminID"] == null)
            {
                Response.Redirect("~/Error_Page.aspx");
            }
            else
            {
                adminID = int.Parse(Session["adminID"].ToString());
            }
        }
    }
}