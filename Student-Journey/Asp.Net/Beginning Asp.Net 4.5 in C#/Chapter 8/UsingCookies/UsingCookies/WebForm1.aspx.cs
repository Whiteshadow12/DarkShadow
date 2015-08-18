﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsingCookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];
            if (cookie == null)
            {
                lblWelcome.Text = "<b>Unknown Customer</b>";
            }
            else
            {
                lblWelcome.Text = "<b>Cookie Found.</b><br /><br />";
                lblWelcome.Text += "Welcome, " + cookie["Name"];
            }
        }

        protected void btnCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Preferences"];
            if (cookie == null)
            {
                cookie = new HttpCookie("Preferences");
            }

            cookie["Name"] = txtName.Text;
            cookie.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(cookie);
            lblWelcome.Text = "<b>Cookie Created.</b><br /><br />";
            lblWelcome.Text += "New Customer: " + cookie["Name"];
        }
    }
}