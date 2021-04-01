using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DraftKingsOptimizeTeam.Models;
using System.Linq;

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

        public List<Salary> LoadSalaries(string csvPath)
        {
            var lines = File.ReadAllLines(csvPath);
            var container = new List<Salary>();

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                //1B,Freddie Freeman (16631090),Freddie Freeman,16631090,1B,4500,TB@ATL 03/11/2021 01:05PM ET,ATL,10.88
                var salary = new Salary(parts);
                container.Add(salary);
            }

            return container;
        }
        public void CreateTeam(List<Salary> salaries) 
        {
            //Team consists of 2 Pitchers (P), Catcher (C), 1B, 2B, 3B, SS, and 3 OF
            var grouped = salaries.GroupBy(s => s.RosterPosition).ToList();
            var requiredPositions = new List<string>(){ "P", "P", "C", "1B", "2B", "3B", "SS", "OF", "OF", "OF"};
            var lineUp = new List<Salary>();

            while(requiredPositions.Count > 0){
              
              var findPosition = requiredPositions[0];

            //   for (int i = 0; i < grouped.Count; i++)
            //   {
            //       var selectedGroup = grouped[i];
            //       if(selectedGroup.Key == findPosition){
            //           lineUp.Add(selectedGroup.First());
            //       }
            //   }

   
              var selectedGroup = grouped.Where(salaryByPosition => salaryByPosition.Key == findPosition).First();
              var selectedPlayer = selectedGroup.First();
           
              lineUp.Add(selectedPlayer);
              requiredPositions.RemoveAt(0);
            }

            

        }
    }
}

//AWS4-HMAC-SHA256 Credential=ASIAVB2JBRHDBJIMRMBJ/20210225/us-east-1/kinesis/aws4_request, SignedHeaders=host;x-amz-content-sha256;x-amz-date;x-amz-security-token;x-amz-target;x-amz-user-agent, Signature=253fd0cb5369014739e2f9b6a457e288db43afff43e048f7295f79f7bed350d9