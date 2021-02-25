using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace KANYEWEST
{
    public class QuoteGenerator
    {
        public static void KANYEQUOTE()
        {
            var client = new HttpClient();

            var kayneURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kayneURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"---------------------------------");
        }
        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes;

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine($"---------------------------------");
        }
   }
}
