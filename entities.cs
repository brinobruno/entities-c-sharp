using System;
using System.Collections.Generic;

// Classes de entidade
public class Entidade
{
  public int Id { get; set; }
}

public class Endereco : Entidade
{
  public string Rua { get; private set; }
  public string Cidade { get; private set; }
  public string Estado { get; private set; }
  public string CEP { get; private set; }

  public Endereco(int id, string rua, string cidade, string estado, string cep)
  {
    Id = id;
    Rua = rua;
    Cidade = cidade;
    Estado = estado;
    CEP = cep;
  }
}

public class Cliente : Entidade
{
  public string Nome { get; private set; }
  public long CPF { get; private set; }
  public string Email { get; private set; }
  public string Senha { get; private set; }
  public Endereco Endereco { get; private set; }

  public Cliente(int id, string nome, long cpf, string email, string senha, Endereco endereco)
  {
    Id = id;
    Nome = nome;
    CPF = cpf;
    Email = email;
    Senha = senha;
    Endereco = endereco;
  }
}

public class Carrinho : Entidade
{
  public DateTime DataPedido { get; private set; }
  public decimal ValorTotal { get; private set; }
  public int StatusPedido { get; private set; }
  public Cliente Cliente { get; private set; }

  public Carrinho(int id, DateTime dataPedido, decimal valorTotal, int statusPedido, Cliente cliente)
  {
    Id = id;
    DataPedido = dataPedido;
    ValorTotal = valorTotal;
    StatusPedido = statusPedido;
    Cliente = cliente;
  }
}

public class Produto : Entidade
{
  public string Descricao { get; private set; }
  public decimal Preco { get; private set; }
  public string Imagem { get; private set; }
  public string Status { get; private set; }
  public Vendedor Vendedor { get; private set; }
  public Categoria Categoria { get; private set; }

  public Produto(int id, string descricao, decimal preco, string imagem, string status, Vendedor vendedor, Categoria categoria)
  {
    Id = id;
    Descricao = descricao;
    Preco = preco;
    Imagem = imagem;
    Status = status;
    Vendedor = vendedor;
    Categoria = categoria;
  }
}

public class Vendedor : Entidade
{
  public string RazaoSocial { get; private set; }
  public string NomeFantasia { get; private set; }
  public string CNPJ { get; private set; }
  public string Email { get; private set; }
  public string Senha { get; private set; }
  public decimal Comissao { get; private set; }
  public Endereco Endereco { get; private set; }

  public Vendedor(int id, string razaoSocial, string nomeFantasia, string cnpj, string email, string senha, decimal comissao, Endereco endereco)
  {
    Id = id;
    RazaoSocial = razaoSocial;
    NomeFantasia = nomeFantasia;
    CNPJ = cnpj;
    Email = email;
    Senha = senha;
    Comissao = comissao;
    Endereco = endereco;
  }
}

public class Categoria : Entidade
{
  public string Nome { get; private set; }

  public Categoria(int id, string nome)
  {
    Id = id;
    Nome = nome;
  }
}

// Interface Repository
public interface IRepositorio<T>
{
  void Adicionar(T entidade);
  void Atualizar(T entidade);
  void Excluir(T entidade);
  T ObterPorId(int id);
  List<T> ObterTodos();
}

// Classe CarrinhoRepository
public class CarrinhoRepository : IRepositorio<Carrinho>
{
  private List<Carrinho> carrinhos = new List<Carrinho>();

  // Métodos CarrinhoRepo
  public void Adicionar(Carrinho entidade)
  {
    carrinhos.Add(entidade);
  }

  public void Atualizar(Carrinho entidade)
  {
    // Lógica do atualizar aqui
  }

  public void Excluir(Carrinho entidade)
  {
    carrinhos.Remove(entidade);
  }

  public Carrinho ObterPorId(int id)
  {
    // Retorna um novo Carrinho se não encontrado
    return carrinhos.FirstOrDefault(c => c.Id == id) ?? new Carrinho();
  }

  public List<Carrinho> ObterTodos()
  {
    return carrinhos;
  }
}
