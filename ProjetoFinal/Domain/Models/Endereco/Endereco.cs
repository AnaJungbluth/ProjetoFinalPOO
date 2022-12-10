using System;

namespace Domain.Models.Pessoas.Endereco
{
    public class Endereco
    {
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }

        public Endereco(string rua, string numero, string bairro)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
        }
    }
}
