using Avaliacao.API.Domain.Entities;
using Avaliacao.API.Model;

namespace Avaliacao.API.Mapper
{
    public static class ClienteMapper
    {
        public static ClienteViewModel EntityToViewModel(this Cliente cliente)
        {
            if (cliente == null)
            {
                return null;
            }
             
            var ClienteViewModel = new ClienteViewModel()
            {
                ClienteId = cliente.Id,
                ClienteNome = cliente.Nome,
                ClienteEmail = cliente.Email,
                ClienteAldeia = cliente.Aldeia
            };

            return ClienteViewModel;
        }

        public static Cliente ViewModelToEntity(this ClienteViewModel clienteVM)
        {
            if (clienteVM == null)
            {
                return null;
            }

            var cliente = new Cliente()
            {
                Id = clienteVM.ClienteId,
                Nome = clienteVM.ClienteNome,
                Email = clienteVM.ClienteEmail,
                Aldeia = clienteVM.ClienteAldeia
            };

            return cliente;
        }
    }
}
