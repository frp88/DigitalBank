using DigitalBank.Domain.Entities;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace DigitalBank.Infra.CrossCutting.ExternalServices
{
    public class EnderecoExternalService
    {
        public EnderecoExternalService() { }

        public static async Task<Endereco> BuscarPorCep(string cep)
        {
            HttpClient cliente = new HttpClient();

            HttpResponseMessage resposta = await cliente.GetAsync("https://viacep.com.br/ws/" + cep + "/json/");
            resposta.EnsureSuccessStatusCode();

            string result = await resposta.Content.ReadAsStringAsync();

            JObject jsonRetorno = JObject.Parse(result);

            Endereco endereco = new Endereco();
            endereco.cep = jsonRetorno["cep"].ToString();
            endereco.logradouro = jsonRetorno["logradouro"].ToString();
            endereco.complemento = jsonRetorno["complemento"].ToString();
            endereco.bairro = jsonRetorno["bairro"].ToString();
            endereco.localidade = jsonRetorno["localidade"].ToString();
            endereco.uf = jsonRetorno["uf"].ToString();

            return endereco;
        }

    }
}