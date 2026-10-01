using System;
using System.Text.Json.Serialization;

namespace Revisao.Modelos
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("estado")]
        public string Estado { get; set; }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"CEP:        {Cep}");
            Console.WriteLine($"Logradouro: {Logradouro}");
            Console.WriteLine($"Bairro:     {Bairro}");
            Console.WriteLine($"Cidade/UF:  {Localidade}/{Uf}");
            Console.WriteLine($"Estado:     {Estado}");
            Console.WriteLine("-----------------------------");
        }
    }
}