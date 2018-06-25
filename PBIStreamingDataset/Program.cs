using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PBIStreamingDataset
{
    class Program
    {
        static void Main(string[] args)
        {
            var category = "<Input your category name>";
            PBIRealtimeStreaming streaming = new PBIRealtimeStreaming();

            while (true)
            {
                Thread.Sleep(500);
                Random random = new Random();
                streaming.SendDataToPowerBI(category, random.Next(-10, 10));
            }
        }
    }
}
