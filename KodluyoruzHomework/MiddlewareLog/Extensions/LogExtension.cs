using Microsoft.AspNetCore.Builder;
using MiddlewareLog.Controllers;
using MiddlewareLog.Middleware;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareLog.Extensions
{
    public static class LogExtension
    {
        public static void catchLog(this IApplicationBuilder app)
        {
            app.UseMiddleware<RequestMiddleware>();
            app.UseMiddleware<ResponseMiddleware>();
        }
    }
}

