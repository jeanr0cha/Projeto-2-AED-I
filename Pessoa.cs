using System;

namespace Projeto_2_AED_1
{
    //Classe "Pai" do Projeto
    class Pessoa
    {
        protected string Nome { get; set; }
        protected long Cpf { get; set; }
        protected long Telefone { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome, long cpf, long telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
