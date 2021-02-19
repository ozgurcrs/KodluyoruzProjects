using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhiteList.Controllers;

namespace WhiteList.Filters
{
    public class JsonExceptionFilters : IExceptionFilter
    {
        public JsonExceptionFilters()
        {

        }
        public void OnException(ExceptionContext context)
        {
            var err = new ApiError
            {
                Message = "Unauthorized entry",
                Detail = context.HttpContext.Connection.LocalIpAddress.ToString() + " " + context.Exception.Message
            };

            context.Result = new ObjectResult(err) { StatusCode = 405 };
        }
    }
}
