using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Script.Serialization;
using System.Drawing;

namespace GridSampleLiveData
{

    public delegate void NewDataReceivedEvent(List<News> news);
    public class DataFetcher
    {
        public event NewDataReceivedEvent NewDataReceivedEventHandler;

        private static readonly HttpClient httpClient = new HttpClient();

        public void GetData()
        {
            
            var requeststring = "https://finnhub.io/api/v1/news?category=general&token=bv643an48v6phr4c7iag";
            var responseString = httpClient.GetStringAsync(requeststring).Result;

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<News> news = serializer.Deserialize<List<News>>(responseString);

            NewDataReceivedEventHandler?.Invoke(news);
        }

        public Image GetImage(string URL)
        {
            var imageStream = httpClient.GetStreamAsync(URL).Result;
            return Image.FromStream(imageStream);
        }

    }
}
