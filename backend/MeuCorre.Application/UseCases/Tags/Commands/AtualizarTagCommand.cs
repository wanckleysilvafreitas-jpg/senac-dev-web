using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    public class AtualizarTagcommand : IRequest<(string, bool)>

    {
        [Required(ErrorMessage = "Id do usuario é obrigatorio")]
        public required Guid UsuarioId { get; set; }

        
        [Required(ErrorMessage = "Nome é obrigatorio")]
        public required string Nome { get; set; }

        
        [Required(ErrorMessage = "A cor é obrigatorio")]
        public string Cor { get; private set; }
    }
    internal class AtualizarTagCommandHandler : IRequestHandler<AtualizarTagcommand, (string, bool)>
    {
        public Task<(string, bool)> Handle(AtualizarTagcommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }