using ExemploJson.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ExemploJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\pessoa.json");

            // System.Runtime.Serialization
            //var js = new DataContractJsonSerializer(typeof(List<Pessoa>)); // Lendo formato -> Lista de pessoas
            //var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)); // Converte para Byte
            //var pessoa = (List<Pessoa>)js.ReadObject(ms); // Transforma em objeto

            /* Console.WriteLine(pessoa[0].Nome);
            Console.WriteLine(pessoa[0].Endereco[0].Logradouro); Exibindo informações */

            // Newtonsoft.Json
            var pessoa = JsonConvert.DeserializeObject<List<Pessoa>>(json);

            // Criando nova pessoa
            Pessoa novaPessoa = new Pessoa();
            novaPessoa.Nome = "Michael De Santa";
            novaPessoa.Idade = 55;
            novaPessoa.Empresa = "Trevor Philips Industries";
            novaPessoa.Endereco = new List<Endereco>();
            Endereco endereco = new Endereco();
            endereco.Logradouro = "Portola Drive";
            endereco.Numero = 301;
            endereco.Bairro = "Rockford Hills";
            endereco.Cidade = "Los Santos";
            endereco.UF = "SA";
            novaPessoa.Endereco.Add(endereco);

            pessoa.Add(novaPessoa);

            // Object para Json
            var json_serializado = JsonConvert.SerializeObject(pessoa);
        }
    }
}
