using Newtonsoft.Json;

namespace Provet.Presentation.Utils
{
    public class Helpers
    {
        public T ParseObject<T>(string objeto)
        {
            var result = JsonConvert.DeserializeObject<T>(objeto);

            return result;
        }
    }
}
