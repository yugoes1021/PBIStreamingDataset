using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PBIStreamingDataset
{
    public class PBIRealtimeStreaming
    {
        public async void SendDataToPowerBI(string category, double value)
        {
            // Power BI REST API URL of your Streaming Dataset
            string realTimePushURL = "<This is a Power BI REST API URL of your Streaming Dataset>";

            try
            {
                // Current Time
                String currentTime = DateTime.Now.ToString();

                string json = "[{\"DateTime\":\"" + currentTime + "\",\"Category\":\"" + category + "\",\"Value\":" + value + "}]";
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // Send POST request to the push URL
                Debug.WriteLine(String.Format("Making POST request with data: {0}", content));

                HttpClient client = new HttpClient();
                var response = await client.PostAsync(realTimePushURL, content);

                // Display the status.
                Debug.WriteLine(String.Format("Service response: {0}", response.StatusCode));
                // Display the content.
                Debug.WriteLine(response.Content);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
