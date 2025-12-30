using ProductClientHub.API.Infrastructure;
using ProductClientHub.Communication.Responses;

namespace ProductClientHub.API.UseCases.Clients.GetAll
{
    public class GetAllClientsUseCase
    {
        public ResponseAllClientJson Execute()
        {
            //instancia com o banco
            var dbContext = new ProductClientHubDbContext();

            var clients = dbContext.Clients.ToList();

            var response = clients.Select(client => new ResponseShortClientJson
            {
                Id = client.Id,
                Name = client.Name,
                Email = client.Email,
            }).ToList();

            return new ResponseAllClientJson
            {
                Clients = response
            };
        }
    }
}
