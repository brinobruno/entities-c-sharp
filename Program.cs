using System;
using System.Collections.Generic;

namespace PimProject
{
  class Program
  {
    static void Main(string[] args)
    {
      // Criar uma instância do CarrinhoRepository
      CarrinhoRepository carrinhoRepository = new CarrinhoRepository();

      // Criar um cliente
      Cliente cliente = new Cliente
      {
        Id = 1,
        Nome = "Cliente Teste",
        CPF = 1234567890,
        Email = "cliente@teste.com",
        Senha = "senha123",
        Endereco = new Endereco
        {
          Id = 1,
          Rua = "Rua da Amostra",
          Cidade = "Cidade Teste",
          Estado = "Estado Teste",
          CEP = "12345-678"
        }
      };

      // Criar um carrinho
      Carrinho carrinho = new Carrinho
      {
        Id = 1,
        DataPedido = DateTime.Now,
        ValorTotal = 100.0m,
        StatusPedido = 1,
        Cliente = cliente
      };

      // Adicionar o carrinho ao repositório
      carrinhoRepository.Adicionar(carrinho);

      // Obter todos os carrinhos
      List<Carrinho> carrinhos = carrinhoRepository.ObterTodos();

      // Exibir os carrinhos
      foreach (var c in carrinhos)
      {
        Console.WriteLine($"Dados: {Environment.NewLine}Id: {c.Cliente.Id}{Environment.NewLine}Nome: {c.Cliente.Nome}{Environment.NewLine}CPF: {c.Cliente.CPF}{Environment.NewLine}Email: {c.Cliente.Email}");
        Console.WriteLine("# --- Transação: --- #");
        Console.WriteLine($"ID: {c.Id}, Cliente: {c.Cliente.Nome}, Valor Total: {c.ValorTotal:C}");
      }
    }
  }
}