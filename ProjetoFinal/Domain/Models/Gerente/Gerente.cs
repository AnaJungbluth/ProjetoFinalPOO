using System;

namespace Domain.Models.Gerente
{
    public class Gerente
    {
        public Guid? GerenteID { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public Gerente(string email, string senha, Guid? gerenteID = null)
        {
            Email = email;
            Senha = senha;
            GerenteID = gerenteID;
        }
    }


}
