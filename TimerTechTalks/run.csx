using System.Net.Http;
using System.Threading.Tasks;
using System;

public static async Task Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"C# Timer trigger function executed at: {DateTime.Now}");    
    try{
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://techtalksbot.azurewebsites.net");
            var result = await client.PostAsync("/api/talks/invitation", new StringContent(""));
            string resultContent = await result.Content.ReadAsStringAsync();
            log.Info($"Post: {resultContent}");
        }   
    }catch(Exception e){
        log.Info($"C# Timer trigger error: {e.Message}");    
    }
    
}