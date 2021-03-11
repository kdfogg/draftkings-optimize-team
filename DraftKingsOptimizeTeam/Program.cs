using DraftKingsOptimizeTeam.Services;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace DraftKingsOptimizeTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DraftKingsService();
            var salaries = service.LoadSalaries(@"C:\Repos\draftkings-optimize-team\DraftKingsOptimizeTeam\.vscode\ImportCSV\DKSalaries.csv");
            Console.WriteLine(salaries.Count);
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
