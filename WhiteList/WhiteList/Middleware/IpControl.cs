using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WhiteList.Controllers;
using WhiteList.Filters;
using WhiteList.Models;

namespace WhiteList.Middleware
{
    public class IpControl
    {
        private readonly RequestDelegate _next;

        
        public IpList _ipList = null;

        public IpControl(RequestDelegate next,IOptions<IpList> ipListOption)
        {
            _next = next;
            _ipList = ipListOption.Value;
        }



        public async Task Invoke(HttpContext context)
        {
            string requestHost = context.Connection.LocalIpAddress.ToString();
            if (context.Request.Path.Value == "/api/Home" || context.Request.Path.Value == "/api/Customer")
            {
             if(requestHost == _ipList.IP)
                {
                    await _next.Invoke(context);
                }   
            }


            else if(context.Request.Path.Value == "/api/Person")
            {
                if (requestHost == _ipList.IP2)
                {
                    await _next.Invoke(context);
                }
            }
            else
            {

                Console.WriteLine(context.Request.Path.Value);
                throw new HttpListenerException(405, "Unauthorized entry");
        
            }
            
            
         

        }
    }
}
