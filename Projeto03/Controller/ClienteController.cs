using Projeto03.Entity;
using Projeto03.Input;
using Projeto03.Repository;
using System;

namespace Projeto03.Controller
{
    public class ClienteController
    {
        public void InsertCliente()
        {
            Console.WriteLine("\n****CADASTRO DE CLIENTE****");
            try
            {
                Cliente cliente = ClienteInput.LerCliente();
                ClienteRepository repository = new ClienteRepository();
                repository.Insert(cliente);
                Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nErro: " + e.Message);
            }
        }
    }
}
