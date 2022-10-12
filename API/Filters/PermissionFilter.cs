using Application.Services.Interfaces;
using Common.Attributes;
using Common.BaseController;
using Common.Dtos;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace API.Filters;

public class PermissionFilter : CustomBaseController, IActionFilter
{
    private readonly IRoleService _roleService;

    public PermissionFilter(IRoleService roleService)
    {
        _roleService = roleService;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        var userId = context.HttpContext.Request.Headers["UserId"].FirstOrDefault();
        if (!HasRoleAttribute(context)) return;
        try
        {
            var arguments = ((ControllerActionDescriptor)context.ActionDescriptor).MethodInfo.CustomAttributes
                .FirstOrDefault(fd => fd.AttributeType == typeof(RoleAttribute))?.ConstructorArguments;

            var roleGroupId = (int)(arguments?[0].Value ?? throw new InvalidOperationException());
            var bitwiseId = (long)(arguments[1].Value ?? throw new InvalidOperationException());
            var role = _roleService.GetRoleById(userId ?? throw new InvalidOperationException(), roleGroupId, bitwiseId);
            if (role.Data.RoleId == 0)
            {
                context.Result = CreateActionResult(Response<NoContent>.Fail(
                    "You are not authorized for this app.",
                    (int)HttpStatusCode.Unauthorized));
            }
        }
        catch (Exception e)
        {
            context.Result = CreateActionResult(Response<NoContent>.Fail(
                $"You are not authorized for this page ...:::... ERROR :: {e.Message}",
                (int)HttpStatusCode.Forbidden));
        }

    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
    }

    public bool HasRoleAttribute(FilterContext context)
    {
        return ((ControllerActionDescriptor)context.ActionDescriptor).MethodInfo.CustomAttributes.Any(
            filterDescriptors => filterDescriptors.AttributeType == typeof(RoleAttribute));
    }
}