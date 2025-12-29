using System.Net;

namespace ProductClientHub.Exceptions.ExceptionBase
{
    public abstract class ProductsClientHubException : SystemException
    {
        public ProductsClientHubException(string errorMessage) : base(errorMessage)
        {
            
        }

        public abstract List<string> GetErrors();
        public abstract HttpStatusCode GetHttpStatusCode();
    }
}
