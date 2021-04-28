using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TShop.UI.Web.Data
{
    public class MyAutorizationRequiment : IAuthorizationRequirement
    {
    }

    public class MyAutorizationRequimentHandler : AuthorizationHandler<MyAutorizationRequiment>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MyAutorizationRequiment requirement)
        {
            return Task.CompletedTask;
        }
    }
}
