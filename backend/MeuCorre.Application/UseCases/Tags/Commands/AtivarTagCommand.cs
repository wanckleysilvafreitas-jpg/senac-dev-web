using System.ComponentModel.DataAnnotations;
using MediatR;
using MeuCorre.Domain.Interfaces.Repositories;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    public class AtivarTagCommand : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "O ID é obrigatorio")]
        public required Guid Id { get; set; }
    }
    internal class AtivarTagCommandHandler : IRequestHandler<AtivarTagCommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(AtivarTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
