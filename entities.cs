using System;
using System.Collections.Generic;

public class Endereco
{
    public int Id { get; set; }
    public string Rua { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string Estado { get; set; } = string.Empty;
    public string CEP { get; set; } = string.Empty;
}

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public long CPF { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public Endereco Endereco { get; set; } = new Endereco();
}

public class Carrinho
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public decimal ValorTotal { get; set; }
    public int StatusPedido { get; set; }
    public Cliente Cliente { get; set; } = new Cliente();
}

public class Produto
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public string Imagem { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public Vendedor Vendedor { get; set; } = new Vendedor();
    public Categoria Categoria { get; set; } = new Categoria();
}

public class Vendedor
{
    public int Id { get; set; }
    public string RazaoSocial { get; set; } = string.Empty;
    public string NomeFantasia { get; set; } = string.Empty;
    public string CNPJ { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
    public decimal Comissao { get; set; }
    public Endereco Endereco { get; set; } = new Endereco();
}

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
}

// Classe CarrinhoRepository
public class CarrinhoRepository
{
    private List<Carrinho> carrinhos = new List<Carrinho>();

    public void Adicionar(Carrinho entidade)
    {
        carrinhos.Add(entidade);
    }

    public void Atualizar(Carrinho carrinhoAtualizado)
    {
        Carrinho carrinhoExistente = carrinhos.FirstOrDefault(c => c.Id == carrinhoAtualizado.Id);

        if (carrinhoExistente != null)
        {
            carrinhoExistente.DataPedido = carrinhoAtualizado.DataPedido;
            carrinhoExistente.ValorTotal = carrinhoAtualizado.ValorTotal;
            carrinhoExistente.StatusPedido = carrinhoAtualizado.StatusPedido;
            carrinhoExistente.Cliente = carrinhoAtualizado.Cliente;
            // Atualize outros campos conforme necessário
        }
        else
        {
            // Lidar com a situação em que o carrinho não existe na lista
            // Podemos lançar uma exceção, ou até mesmo adicionar o produto
            throw new InvalidOperationException("Carrinho não encontrado para atualização.");
        }
    }

    public void Excluir(Carrinho entidade)
    {
        carrinhos.Remove(entidade);
    }

    public Carrinho ObterPorId(int id)
    {
        return carrinhos.FirstOrDefault(c => c.Id == id) ?? new Carrinho();
    }

    public List<Carrinho> ObterTodos()
    {
        return carrinhos;
    }
}
