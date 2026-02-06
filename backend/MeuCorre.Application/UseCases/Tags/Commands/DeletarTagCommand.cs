using System.ComponentModel.DataAnnotations;
using MediatR;
using MeuCorre.Domain.Interfaces.Repositories;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    public class DeletarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "O ID é obrigatorio")]
        public required Guid CategoriaId { get; set; }
    }
    internal class DeletarCategoriaCommandHandler : IRequestHandler<DeletarTagCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(DeletarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
