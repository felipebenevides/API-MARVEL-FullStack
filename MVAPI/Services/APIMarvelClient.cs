using Microsoft.Extensions.Configuration;
using MVAPI.Contracts;
using MVAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace MVAPI.API
{
    public class APIMarvelClient : IAPIMarvelClient
    {
        private static string[] HEROIS = new string[]
        {
            "Captain America", "Iron Man", "Thor", "Hulk",
            "Wolverine", "Spider-Man", "Black Panther",
            "Doctor Strange", "Daredevil","3-D Man","A-Bomb (HAS)",
            "A.I.M.","Aaron Stack","Abomination (Emil Blonsky)",
            "Abomination (Ultimate)","Absorbing Man","Abyss",
            "Abyss (Age of Apocalypse)","Adam Destine"
        };

        private HttpClient _client;
        private IConfiguration _configuration;

        public APIMarvelClient(
            HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            _configuration = configuration;
        }

        private string GerarHash(string ts, string publicKey, string privateKey)
        {
            byte[] bytes =
               Encoding.UTF8.GetBytes(ts + privateKey + publicKey);
            var gerador = MD5.Create();
            byte[] bytesHash = gerador.ComputeHash(bytes);
            return BitConverter.ToString(bytesHash)
                .ToLower().Replace("-", String.Empty);
        }

        public Result BuscarPersonagemPorID(int id)
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

            string ts = DateTime.Now.Ticks.ToString();
            string publicKey =
                _configuration.GetSection("MarvelComicsAPI:PublicKey").Value;
            string hash = GerarHash(ts, publicKey,
                _configuration.GetSection("MarvelComicsAPI:PrivateKey").Value);


            string url2 = _configuration.GetSection("MarvelComicsAPI:BaseURL").Value +
               $"characters/{id}?ts={ts}&apikey={publicKey}&hash={hash}";

            HttpResponseMessage response = _client.GetAsync(url2).Result;

            response.EnsureSuccessStatusCode();

            string conteudo =
                response.Content.ReadAsStringAsync().Result;

            dynamic resultDeserialize = JsonConvert.DeserializeObject(conteudo);

            var resultado = JsonConvert.DeserializeObject<Data>(resultDeserialize.data.ToString());


            Result personagem = new Result();

            personagem.id = resultado.results[0].id;
            personagem.name = resultado.results[0].name;
            personagem.description = resultado.results[0].description;
            personagem.resourceURI = resultado.results[0].thumbnail.path + "." +
                resultado.results[0].thumbnail.extension;
            personagem.UrlWiki = resultado.results[0].urls[1].url;

            personagem.comics = resultado.results[0].comics;

            return personagem;
        }

        public Data ListaQuadrinhos()
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

            string ts = DateTime.Now.Ticks.ToString();
            string publicKey =
                _configuration.GetSection("MarvelComicsAPI:PublicKey").Value;
            string hash = GerarHash(ts, publicKey,
                _configuration.GetSection("MarvelComicsAPI:PrivateKey").Value);


            string url4 = _configuration.GetSection("MarvelComicsAPI:BaseURL").Value +
                $"comics?ts={ts}&apikey={publicKey}&hash={hash}";

            HttpResponseMessage response = _client.GetAsync(url4).Result;

            response.EnsureSuccessStatusCode();

            string conteudo =
                response.Content.ReadAsStringAsync().Result;

            dynamic resultDeserialize = JsonConvert.DeserializeObject(conteudo);

            var resultado = JsonConvert.DeserializeObject<Data>(resultDeserialize.data.ToString());

            return resultado;
        }


        public Data ListaPersonagens()
        {
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

            string ts = DateTime.Now.Ticks.ToString();
            string publicKey =
                _configuration.GetSection("MarvelComicsAPI:PublicKey").Value;
            string hash = GerarHash(ts, publicKey,
                _configuration.GetSection("MarvelComicsAPI:PrivateKey").Value);


            string url1 = _configuration.GetSection("MarvelComicsAPI:BaseURL").Value +
                $"characters?ts={ts}&apikey={publicKey}&hash={hash}";

            HttpResponseMessage response = _client.GetAsync(url1).Result;

            response.EnsureSuccessStatusCode();

            string conteudo =
                response.Content.ReadAsStringAsync().Result;

            dynamic resultDeserialize = JsonConvert.DeserializeObject(conteudo);

            var resultado = JsonConvert.DeserializeObject<Data>(resultDeserialize.data.ToString());

            return resultado;
        }
        public Result ObterDadosPersonagem()
        {
            string heroi = HEROIS[new Random().Next(0, 17)];

            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

            string ts = DateTime.Now.Ticks.ToString();
            string publicKey =
                _configuration.GetSection("MarvelComicsAPI:PublicKey").Value;
            string hash = GerarHash(ts, publicKey,
                _configuration.GetSection("MarvelComicsAPI:PrivateKey").Value);


            string url = _configuration.GetSection("MarvelComicsAPI:BaseURL").Value +
                $"characters?ts={ts}&apikey={publicKey}&hash={hash}&" +
                $"name={Uri.EscapeUriString(heroi)}";

            HttpResponseMessage response = _client.GetAsync(url).Result;

            response.EnsureSuccessStatusCode();

            string conteudo =
                response.Content.ReadAsStringAsync().Result;

            dynamic resultDeserialize = JsonConvert.DeserializeObject(conteudo);

            var resultado = JsonConvert.DeserializeObject<Data>(resultDeserialize.data.ToString());

            Result personagem = new Result();

            personagem.id = resultado.results[0].id;
            personagem.name = resultado.results[0].name;
            personagem.description = resultado.results[0].description;
            personagem.resourceURI = resultado.results[0].thumbnail.path + "." +
                resultado.results[0].thumbnail.extension;
            personagem.UrlWiki = resultado.results[0].urls[1].url;

            personagem.comics = resultado.results[0].comics;

            return personagem;
        }
    }
}
