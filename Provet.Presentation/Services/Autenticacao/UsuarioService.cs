using Nest;
using Newtonsoft.Json;
using Provet.Domain.Commands.Responses;
using Provet.Presentation.Configuration;

namespace Provet.Presentation.Services.Autenticacao
{
    public class UsuarioService
    {
        public async Task<GenericResponse> Login(string usuario, string senha)
        {
            var url = new Url();
            var baseUrl = url.ApiBaseUrlDev;

            var credentials = new Dictionary<string, string> 
            { 
                { "usuario", usuario }, 
                { "senha", senha } 
            };

            var encoded = new FormUrlEncodedContent(credentials);

            using (HttpClient client = new())
            {
                using (HttpResponseMessage res = await client.PostAsync($"{baseUrl}/autenticacao/usuario/login", encoded))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        var response = JsonConvert.DeserializeObject<GenericResponse>(data);

                        return response;
                    } 
                }
            }
        }
    }
}
