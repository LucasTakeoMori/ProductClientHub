using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductClientHub.Communication.Responses;
using ProductClientHub.Exceptions.ExceptionBase;

namespace ProductClientHub.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if(context.Exception is ProductsClientHubException productsClientHubException)
            {
                context.HttpContext.Response.StatusCode = (int)productsClientHubException.GetHttpStatusCode();

                context.Result = new ObjectResult(new ResponseErrorMessageJson(productsClientHubException.GetErrors()));

            }
            else
            {
                ThrowUnknowError(context);
            }
        }

        private void ThrowUnknowError(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(new ResponseErrorMessageJson("An unexpected error occurred. Please try again later."));
        }
    }
}
