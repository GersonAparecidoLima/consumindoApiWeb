using System;
using System.Threading.Tasks;
using Revisao.Modelos; // Importante: para tipar e acessar o objeto Endereco

namespace Revisao
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var api = new ConsumindoApi();

            // Busca o endereço e desempacota o Task<Endereco>
            Endereco endereco = await api.BuscarEnderecoAsync("71573211");

            // Se a busca deu certo, exibe a ficha técnica
            if (endereco != null)
            {
                endereco.ExibirFichaTecnica();
            }
            else
            {
                Console.WriteLine("Não foi possível carregar os dados do endereço.");
            }
        }
    }
}