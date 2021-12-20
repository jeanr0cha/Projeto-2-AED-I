using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_2_AED_1
{
    class Vendedor : Pessoa
    {
        private int Loguin; 

        public Vendedor(string nome, long cpf, long telefone, int loguin) : base(nome, cpf, telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Loguin = loguin;

        }
    }
}
