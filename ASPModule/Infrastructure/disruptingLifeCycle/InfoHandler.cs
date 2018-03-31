﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPModule.Infrastructure.disruptingLifeCycle
{
    public class InfoHandler : IHttpHandler
    {
        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("Content generated by InfoHandler for test purpose");
            context.Response.Write(string.Format("Time: {0}", DateTime.Now.ToShortTimeString()));
        }
    }
}