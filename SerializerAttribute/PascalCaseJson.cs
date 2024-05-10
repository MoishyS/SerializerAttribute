using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;


namespace SerializerAttribute
{
    public class PascalCaseJson : ActionFilterAttribute
    {
        private static readonly SystemTextJsonOutputFormatter Formatter = new SystemTextJsonOutputFormatter(new JsonSerializerOptions());

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is ObjectResult objectResult)
                objectResult.Formatters.Add(Formatter);
        }
    }
}