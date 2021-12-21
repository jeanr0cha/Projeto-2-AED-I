using System;
using System.Globalization;
using System.Collections.Generic;

namespace Projeto_2_AED_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************\nELETRO SHARP ELETRÔNCOS\n***********************************************\n\n");

            Console.WriteLine("Seu estoque atualmente está vazio, Vamos cadastrar 2 itens.\n");

            //Cadastrando Primeiro Produto
            Console.WriteLine("Entre com os dados do produto 1: \n");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto1 = new Produto(nome, preco, quantidade);
            Console.WriteLine("_______________________________");
            Console.WriteLine("Dados do produto 1: " + produto1);

            Console.WriteLine("\n");

            //Cadastrando Segundo Produto
            Console.WriteLine("Entre com os dados do produto 2: \n");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Preço: ");
            preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            Produto produto2 = new Produto(nome, preco, quantidade);
            Console.WriteLine("_________________________________");
            Console.WriteLine("Dados do produto 2: " + produto2);

            Console.WriteLine("******************************************************\n");

            // Vendedor que ja é cadastrado no Sistema
            Vendedor vendedor1 = new Vendedor("André Ribeiro", 14218927850, 991238455, 142);
            Console.WriteLine(vendedor1);
            Console.WriteLine("\n");


            Console.WriteLine("***********************************\n CADASTROS DE CLIENTES \n***********************************\n\n");

            Console.Write("Digite o nome do cliente: ");
            nome = Console.ReadLine();
            Console.Write("Digite o cpf do cliente: ");
            long cpf = long.Parse(Console.ReadLine());
            Console.Write("Digite o telefone do cliente: ");
            long telefone = long.Parse(Console.ReadLine());
            Console.Write("Digite o cep do cliente: ");
            long cep = long.Parse(Console.ReadLine());
            Console.Write("Digite a rua ou avenida do cliente: ");
            string Rua = Console.ReadLine();
            Console.Write("Digite o numero da residencia do cliente: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Cliente cliente1 = new Cliente(nome, cpf, telefone, cep, Rua, numero);

            List<Cliente> lista = new List<Cliente>();

            lista.Add(cliente1);

            foreach (Cliente obj in lista)
            {
                Console.WriteLine("Confira os dados do seu cliente\n");
                Console.WriteLine(obj);
            }
            Console.WriteLine("*******************************************\n*******************************************\n");

            Console.WriteLine(" Qual Produto seu cliente deseja comprar? ");
            Console.WriteLine("\n");

            Console.WriteLine("***********************************************");
            Console.WriteLine("Produto 1\n " + produto1);
            Console.WriteLine("_______________________________\n");
            Console.WriteLine("Produto 2 \n " + produto2);
            Console.WriteLine("***********************************************\n");

            Console.WriteLine("Digite 1 para produto 1 e 2 para produto 2\n");

            int vender_produto = int.Parse(Console.ReadLine());
            int qtd_produto = 0;

            if ( vender_produto == 1)
            {
                Console.WriteLine("Quantos itens seu cliente deseja comprar ?");               
                qtd_produto = int.Parse(Console.ReadLine());
                produto1.RemoverProduto(qtd_produto);

            }
            else
            {
                Console.WriteLine("Quantos itens seu cliente deseja comprar ?");
                qtd_produto = int.Parse(Console.ReadLine());
                produto2.RemoverProduto(qtd_produto);
            }

            Console.WriteLine("*********VENDA REALIZADA COM SUCESSO*********");

            Console.WriteLine("Deseja ver a atualização do estoque? digite 1 para sim e 2 para não");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                //Mostra a atualzação dos produtos em estoque após realzar a venda
                Console.WriteLine("************************************************\n");
                Console.WriteLine("Dados atualizados dos Produtos\n______________________________");
                Console.WriteLine("Produto 1\n " + produto1);
                Console.WriteLine("_______________________________");
                Console.WriteLine("Produto 2 \n " + produto2);
            }
            else
            {
                
            }

            Console.WriteLine(" ");

            //Caso Aconteça uma adição de mais produtos do mesmo tipo
            Console.WriteLine("Deseja adicionar mais itens em algum produto no estoque ?\n" +
                              "Digite 1 para o primeiro produto e 2 para o segundo produto\n" +
                              "Caso contrario pressone 3");

            num = int.Parse(Console.ReadLine());
            int qtd = 0;
            //inicialização da adição do produto 
            produto1.AdicionarProduto(0);
            produto2.AdicionarProduto(0);


            if (num == 1)
            {
                Console.WriteLine("Digite a quantidade de itens a ser adicionado no produto 1: ");
                qtd = int.Parse(Console.ReadLine());
                produto1.AdicionarProduto(qtd);

            }
            else if (num == 2)
            {
                Console.WriteLine("Digite a quantidade de itens a ser adicionado no produto 2: ");
                qtd = int.Parse(Console.ReadLine());
                produto2.AdicionarProduto(qtd);

            }
            else
            {
                Console.WriteLine("Não foi adicionado nenhum produto em seu estoque ");
            }

            //Mostra a atualização do estoque
            Console.WriteLine("*************************************\n");

            Console.WriteLine("Dados atualizados produto 1: " + produto1);
            Console.WriteLine("\n");
            Console.WriteLine("______________________________________");
            Console.WriteLine("Dados atualizados: " + produto2);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("\n");
            Console.WriteLine("Chegamos ao fim do programa, pressione qualquer tecla");
            Console.ReadKey();

        }
      
    }
}
