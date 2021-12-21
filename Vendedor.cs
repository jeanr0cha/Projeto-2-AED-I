using System;

namespace Projeto_2_AED_1
{
    //Classe Vendedor que herda da Classe Pessoa
    class Vendedor : Pessoa
    {
        private int Login; 

        public Vendedor()
        {

        }

        public Vendedor(string nome, long cpf, long telefone, int login) : base(nome, cpf, telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Login = login;

        }

        public override string ToString()
        {
            return Nome + " Seu login de vendedor é: " + Login;           
               
        }
    }
}
