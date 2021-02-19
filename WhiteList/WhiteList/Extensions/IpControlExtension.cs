using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteList.Middleware;

namespace WhiteList.Extensions
{
    public static class IpControlExtension
    {
        public static void catchIp(this IApplicationBuilder app)
        {
            app.UseMiddleware<IpControl>();
        }
    }
}
