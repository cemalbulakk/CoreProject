using Common.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Common.BaseController;

public class CustomBaseController : ControllerBase
{
    public IActionResult CreateActionResult<T>(Response<T> response)
    {
        return new ObjectResult(response)
        {
            StatusCode = response.StatusCode
        };
    }
}