using System;

namespace Projeto_2_AED_1
{
    //Classe Cliente que Herda da Classe Pessoa
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

        //Mostrar dados na tela
        public override string ToString()
        {
            return Nome
                + "\n"
                + "CPF: "
                + Cpf
                + "\n"
                + "Telefone: "
                + Telefone
                +"\n"
                + "Cep: "                
                + Cep
                + "\n"
                + "rua ou Av: "
                + Rua
                + "\n"
                + "Numero da Residencia: "
                + Numero;

        }


    }
        

}
