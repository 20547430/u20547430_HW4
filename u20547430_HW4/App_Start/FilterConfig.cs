﻿using System.Web;
using System.Web.Mvc;

namespace u20547430_HW4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}