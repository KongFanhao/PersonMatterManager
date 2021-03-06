﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonMatterManager.Web.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //统一校验登陆
            if (Session["UserInfo"] == null)
            {
                //filterContext.HttpContext.Response.Redirect("/Login/Index");
                //返回Result不用执行控制器方法代码返回ActionResult提高性能
                filterContext.Result = Redirect("/Login/LoginError");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}