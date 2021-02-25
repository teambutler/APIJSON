using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KANYEWEST
{
    class Program
    {
        static void Main(string[] args)
        {
            QuoteGenerator.KANYEQUOTE();

            QuoteGenerator.RonQuote();
        }
    }
}
