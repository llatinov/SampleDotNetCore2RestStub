using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SampleDotNetCore2RestStub.Attributes
{
    public class AuthenticationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string authKey = context.HttpContext.Request.Headers["Authorization"].SingleOrDefault();

            if (string.IsNullOrWhiteSpace(authKey))
                throw new Exception();
        }
    }
}
