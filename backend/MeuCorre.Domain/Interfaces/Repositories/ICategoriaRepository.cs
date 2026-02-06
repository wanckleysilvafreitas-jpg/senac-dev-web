using MeuCorre.Domain.Entities;
using MeuCorre.Domain.Enums;

namespace MeuCorre.Domain.Interfaces.Repositories
{
    public interface ITagRepository
    {
        //Retorna do banco de dados os dados de uma tag que possua o Id informado
        Task<Tag?>ObterPorIdAsync(Guid Tag);

        //Retorna do banco de dados todas as tag que pertençam ao usuário informado
        Task<IList<Tag>> ListarTodasPorUsuarioAsync(Guid usuarioId);

        //Verificar se uma tag existe no banco de dados com o Id informado
        //SELECT * FROM tag WHERE Id = 5
        Task<bool> ExisteAsync(Guid TagId);

        //Verifica se já existe uma tag com o mesmo
        //nome e tipo para o usuário informado
        //nome e tipo para o usuário informado
        Task<bool> NomeExisteParaUsuarioAsync(string nome, TipoTransacao tipo, Guid usuarioId);

        //Adiciona uma nova tag no banco de dados
        Task AdicionarAsync(Tag Tag);

        //Atualiza os dados de uma tag no banco de dados
        Task AtualizarAsync(Tag Tag);

        //Remove uma tag do banco de dados
        Task RemoverAsync(Tag Tag);
    }
}