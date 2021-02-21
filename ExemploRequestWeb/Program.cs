using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ExemploRequestWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = WebRequest.CreateHttp(@"https://viacep.com.br/ws/01001-000/json/");

            using (var response = request.GetResponse())
            {
                var responseStream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                object objResponse = streamReader.ReadToEnd();

                var result = JsonConvert.DeserializeObject<Endereco>(objResponse.ToString());

                Console.WriteLine(result);
                responseStream.Close();
                response.Close();
            }
        }
    }
}