using ProductClientHub.API.Infrastructure;
using ProductClientHub.API.UseCases.Clients.SharedValidator;
using ProductClientHub.Communication.Requests;
using ProductClientHub.Exceptions.ExceptionsBase;

namespace ProductClientHub.API.UseCases.Clients.Update
{
    public class UpdateClientUseCase
    {
        public void Execute(Guid ClientId, RequestClientJson request)
        {
            Validade(request);

            var dbContext = new ProductClientHubDbContext();

            var entity = dbContext.Clients.FirstOrDefault(client => client.Id == ClientId);
            if (entity == null)
            {
                throw new NotFoundException("Cliente não encontrado.");
            }

            entity.Name = request.Name;
            entity.Email = request.Email;

            dbContext.Clients.Update(entity);
            dbContext.SaveChanges();
        }

        private void Validade(RequestClientJson request)
        {
            var validator = new RequestClientValidator();

            var result = validator.Validate(request);

            //if (result == false)
            //{
            //    var errors = result.Errors.Select(faiulre => faiulre.ErrorMessage).ToList();

            //    throw errors.First();
            //}
        }
    }
}
