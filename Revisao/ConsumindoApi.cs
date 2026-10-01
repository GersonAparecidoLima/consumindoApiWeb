using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Revisao.Modelos; // Importante: para enxergar a classe Endereco

namespace Revisao
{
    public class ConsumindoApi
    {
        public async Task<Endereco> BuscarEnderecoAsync(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";

                    // 1. Busca o JSON bruto como texto
                    string resposta = await client.GetStringAsync(url);

                    // 2. Converte o texto JSON para o objeto Endereco
                    Endereco endereco = JsonSerializer.Deserialize<Endereco>(resposta);

                    return endereco;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
                    return null;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                    return null;
                }
            }
        }
    }
}