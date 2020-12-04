using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using bet365DataSDK.config;
using bet365DataSDK.http;
using Newtonsoft.Json;

namespace bet365DataSDK
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Constant.ACCESS_TOKEN);
            client.DefaultRequestHeaders.ConnectionClose = true;

            var response = await client.PostAsync(Constant.FullTimeFullWin_API, content: null);
            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                Response contributors = JsonConvert.DeserializeObject<Response>(result);
                Console.WriteLine(contributors.code);
                Console.WriteLine(contributors.msg);
                Console.WriteLine(contributors.data.sync_time);
                // check team_pair is !null
                Console.WriteLine(contributors.data.data.channel[0]);
                Console.WriteLine(contributors.data.data.data[0].team_pair[0]);
                Console.WriteLine(contributors.data.data.data[0].team_score[0]);
                Console.WriteLine(contributors.data.data.data[0].play_time[0]);
                //Console.WriteLine(contributors.data.data.data[0].handicap_list[0]);
                Console.WriteLine(contributors.data.data.data[0].odds_list[0]);
            }
            else
                Console.Write("Error");
        }
    }
}
