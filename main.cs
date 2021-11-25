using System;
using System.Globalization;

//Classe Para cadastro dos clientes que efetuarem a compra no estabelecimento.
class Cliente
{
  private string nome;
  private int cpf;
  private int telefone;
  private string endereço;  
  private int cep;

  public Cliente( string nome_cliente, int cpf_cliente, int tel_cliente, string end_cliente,  int cep_cliente)
  {
    nome = nome_cliente;
    cpf = cpf_cliente;
    telefone = tel_cliente;
    endereço = end_cliente;
    cep = cep_cliente;
  }
}

//Classe para cadastro dos venedores
class Vendedor
{
  private string usuario;
  private int cod_usuario; // Código de usuário para cada vendedor
  private int tel_usuario;
  
  public Vendedor(string n_usuario, int cod_user, int tel_user)
  {
    usuario = n_usuario;
    cod_usuario = cod_user;
    tel_usuario = tel_user;
  } 
}

class CalculaVendas
{
  private float vend_mensal;
  private float v_diaria;

} 

class Program {
  public static void Main (string[] args) {
 
   Console.WriteLine("|**********************|\n|***ELETRÔNICA INOVA***|\n|**********************|\n\n");
        
   Console.WriteLine("")
   Vendedor cleidson = new Vendedor("Cleidson", 1, 987654321 );
   Console.WriteLine("Nome do vendedor: {0}",cleidson);

  }
}