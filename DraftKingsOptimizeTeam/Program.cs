using DraftKingsOptimizeTeam.Services;
using System.Threading.Tasks;

namespace DraftKingsOptimizeTeam
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var service = new DraftKingsService();
            await service.LoginAsync();

            // var clientHttpClient();
            // client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("username:password")));
            // var response = await client.GetStringAsync("https://google.com");

            // //System.Console.WriteLine(response);

            // var startIndex = response.IndexOf("<span class=gbts>Images<") + 17;
            // var endIndex= response.IndexOf("<",startIndex);
            // var value = response.Substring(startIndex,endIndex-startIndex);
            // System.Console.WriteLine(value);
        }

    }
}
