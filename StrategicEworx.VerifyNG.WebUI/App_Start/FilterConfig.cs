﻿using System.Web;
using System.Web.Mvc;

namespace StrategicEworx.VerifyNG.WebUI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
