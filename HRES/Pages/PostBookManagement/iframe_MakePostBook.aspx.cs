﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FineUI;
using Controls;
using DataStructure;

namespace HRES.Pages.PostBookManagement
{
    public partial class iframe_MakePostBook : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = Request.QueryString["id"];
            }

        }
    }
}