using Refit;
using System;
using System.Threading.Tasks;

namespace RefitCepExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
            string meuCep = "13300390";
            Console.WriteLine("Consultando dados do Cep:" + meuCep);

            var address = await cepClient.GetAddressAsync(meuCep);

            Console.Write($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}" +
                $"\nEstado:{address.Uf}\nCódigo Ibge:{address.Ibge}");
            Console.ReadKey();
        }
    }
}
