using System;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc.Filters;
using SampleDotNetCore2RestStub.Exceptions;

namespace SampleDotNetCore2RestStub.Attributes
{
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string authKey = context.HttpContext.Request.Headers["Authorization"].SingleOrDefault();

            if (string.IsNullOrWhiteSpace(authKey))
                throw new HttpException(HttpStatusCode.Unauthorized);
        }
    }
}
