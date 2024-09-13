using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taqui.Models;
using Taqui.Models.DTO;

namespace Taqui.Service
{
    public class ClienteService
    {
        //Métodos de conversão
        public Cliente requestToCliente(ClienteDTORequest clienteDtoRequest) { 
            Cliente cliente = new Cliente();

            cliente.DsCPF = clienteDtoRequest.DsCPF;
            cliente.DsEmail = clienteDtoRequest.DsEmail;
            cliente.DsUser = clienteDtoRequest.DsUser;
            cliente.DsSenha = clienteDtoRequest.DsSenha;

            return cliente;
        }

        public ClienteDTOResponse clienteToResponse(Cliente cliente)
        {
            ClienteDTOResponse clienteDtoResponse = new ClienteDTOResponse();

            clienteDtoResponse.DsUser = cliente.DsUser;
            clienteDtoResponse.DsEmail = cliente.DsEmail;
            clienteDtoResponse.IdUsuario = cliente.IdUsuario;

            return clienteDtoResponse;
        }

        public IEnumerable<ClienteDTOResponse> clientesToResponseIEnumerable(IEnumerable<Cliente> clientes)
        {
            var clienteDTOResponses = clientes.Select(cliente => new ClienteDTOResponse
            {
                DsUser = cliente.DsUser,
                DsEmail = cliente.DsEmail,
                IdUsuario = cliente.IdUsuario
            });

            return clienteDTOResponses;
        }


    }
}
