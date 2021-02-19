using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareLog.Middleware
{
    public class RequestMiddleware
    {   
        private readonly RequestDelegate _next;
        Guid _id;
        public RequestMiddleware(RequestDelegate next)
        {
            _next = next;
            _id = Guid.NewGuid();
        }

        public async Task Invoke(HttpContext context)
        {
            string path = @"C:\Users\ozgur\source\repos\KodluyoruzHomework\MiddlewareLog\request.txt";
            string log = "Date Time:" + DateTime.Now + " ID:" + _id +
                        " Content Type:" + context.Request.ContentType +
                        " Host:" + context.Request.Host +
                        " Path:" + context.Request.Path +
                        " Protocol:" + context.Request.Protocol;

            File.AppendAllText(path, log + Environment.NewLine);


            await _next.Invoke(context);
        }
    }
}
