﻿using System;
using System.Web.UI;
using vtnCore.Methods;

namespace VTNORTON.app
{
    public partial class timecalculator : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                rssRepeater.DataSource = GetRSS.Get("http://dev.vtnorton.com/category/apps/time-calculator/feed", 3);
                rssRepeater.DataBind();
            }
            catch (Exception)
            {

            }
        }
    }
}