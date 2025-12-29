using ProductClientHub.Exceptions.ExceptionBase;
using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : ProductsClientHubException
    {
        private readonly List<string> _errors;
        public ErrorOnValidationException(List<string> errorMessage) : base (string.Empty)
        {
            _errors = errorMessage;
        }

        public override List<string> GetErrors()
        {
            return _errors;
        }

        public override HttpStatusCode GetHttpStatusCode()
        {
            return HttpStatusCode.BadRequest;
        }
    }
}
