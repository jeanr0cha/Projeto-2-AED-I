using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_2_AED_1
{
    class Cliente : Pessoa
    {

        private long Cep { get; set; }
        private string Rua { get; set; }
        private int Numero { get; set; }

       public Cliente(string nome, long cpf, long telefone, long cep, string rua, int numero) : base(nome, cpf, telefone)    
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Cep = cep;
            Rua = rua;
            Numero = numero;

        }

    }
    
}
