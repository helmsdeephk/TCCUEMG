﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using TCC.Servico.Modelo;
using Newtonsoft.Json;

namespace TCC.Servico
{
    public class viaCepservico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null) return null;
            
            return end;
        }
    }
}
