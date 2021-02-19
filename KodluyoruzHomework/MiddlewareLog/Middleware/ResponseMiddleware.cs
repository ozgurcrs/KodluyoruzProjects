using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareLog.Middleware
{
    public class ResponseMiddleware
    {   
        private readonly RequestDelegate _next;
        Guid _id;
        public ResponseMiddleware(RequestDelegate next)
        {
            _next = next;
            _id = Guid.NewGuid();
        }

        public async Task Invoke(HttpContext context)
        {
            string path = @"C:\Users\ozgur\source\repos\KodluyoruzHomework\MiddlewareLog\response.txt";
            string log = "Date Time:" + DateTime.Now + " ID:" + _id +
                         " Status Code:" + context.Response.StatusCode +
                         " Content Type:" + context.Request.ContentType;

            File.AppendAllText(path, log + Environment.NewLine);


            await _next.Invoke(context);
        }
    }
}
