C# university assignment

*listar dependencies

Codificar classes de entidade

- [ ] Cliente
id int
nome string
cpf long
email string
senha string
endereco Endereco

- [ ] Carrinho
id int
dataPedido DateTime
valorTotal decimal
statusPedido int
cliente Cliente

- [ ] Produto
id int
descricao string
preco decimal
imagem string
status string
vendedor Vendedor
categoria Categoria

- [ ] Vendedor
id int
razaoSocial string
nomeFantasia string
cnpj string
email string
senha string
comissao decimal
endereco Endereco

Codificar a classe CarrinhoRepository

- [ ] CarrinhoRepository
Adicionar(entidade: Carrinho): void
Atualizar(entidade: Carrinho): void
Excluir(entidade: Carrinho): void
ObterPorId(id: int): Carrinho
ObterTodos(): List<Carrinho>
