using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace DraftKingsOptimizeTeam.Services
{
    public class DraftKingsService
    {
        private string _userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.150 Safari/537.36";
        public DraftKingsService()
        {

        }
        public async Task LoginAsync()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("username:password")));
            var response = await client.GetStringAsync("https://google.com");
        }
    }
}

//AWS4-HMAC-SHA256 Credential=ASIAVB2JBRHDBJIMRMBJ/20210225/us-east-1/kinesis/aws4_request, SignedHeaders=host;x-amz-content-sha256;x-amz-date;x-amz-security-token;x-amz-target;x-amz-user-agent, Signature=253fd0cb5369014739e2f9b6a457e288db43afff43e048f7295f79f7bed350d9