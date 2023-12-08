# Biblioteca-Mundo-Infinito
 
Documentação do Programa

Estrutura do Projeto
O projeto está organizado em várias pastas para separar diferentes partes do código:

Menus: Contém as classes responsáveis por exibir os menus e processar as opções escolhidas pelo usuário.
Modelos: Define as classes que representam os principais objetos do sistema, como Autor, Livro, Usuario e Emprestimo.
Services: Contém classes responsáveis por realizar operações específicas, como cadastrar autores, livros, usuários, exibir detalhes de livros, etc.
Data: Inclui o contexto do Entity Framework para interagir com o banco de dados e realizar operações de CRUD.
Fluxo Principal (Program.cs)

O ponto de entrada do programa é o arquivo Program.cs, onde é exibido um menu principal com várias opções. O usuário pode escolher entre listar livros, listar autores, pesquisar livros, realizar empréstimos/devoluções ou sair do programa. O código continua executando até que o usuário opte por sair.

Contexto do Banco de Dados (BibliotecaContext)
O contexto do banco de dados (BibliotecaContext) é responsável por interagir com o banco de dados utilizando o Entity Framework. Ele contém métodos para adicionar autores, livros, usuários, realizar empréstimos e devoluções, verificar a existência de autores, etc.

Menus (Menu, Menu1, Menu2, Menu3, Menu4, MenuAvançado)
Menu: Classe principal que gerencia as opções escolhidas pelo usuário.
Menu1: Exibe a lista de livros disponíveis.
Menu2: Exibe a lista de autores disponíveis.
Menu3: Permite pesquisar e exibir detalhes de um livro.
Menu4: Gerencia as opções de empréstimo e devolução.
MenuAvançado: Oferece opções avançadas como cadastrar autor, livro ou usuário.
Services (CadastrarAutor, CadastrarLivro, CadastrarUsuario, DetalhesDoLivro, ExibirAutores, ExibirLivros, PesquisarLivro, ServicoEmprestimo)
CadastrarAutor: Permite cadastrar um novo autor.
CadastrarLivro: Permite cadastrar um novo livro, incluindo a seleção de um autor existente.
CadastrarUsuario: Permite cadastrar um novo usuário.
DetalhesDoLivro: Exibe detalhes de um livro específico.
ExibirAutores: Exibe a lista de autores disponíveis.
ExibirLivros: Exibe a lista de livros disponíveis.
PesquisarLivro: Permite pesquisar livros por título.
ServicoEmprestimo: Gerencia as operações de empréstimo e devolução de livros.
Modelos (Autor, Emprestimo, Livro, Usuario)
Define as classes que representam os objetos principais do sistema, como autores, livros, usuários e empréstimos.

Instalação
Pré-requisitos
Antes de iniciar a instalação, certifique-se de ter os seguintes pré-requisitos instalados em seu ambiente de desenvolvimento:

SDK do .NET


Configuração do Banco de Dados
Migrações do Entity Framework
O projeto utiliza o Entity Framework Core para gerenciar o banco de dados. Para criar ou atualizar o banco de dados, siga os passos abaixo:

Abra um terminal na raiz do projeto.

Execute o seguinte comando para criar uma nova migração:
"dotnet ef migrations add NomeDaMigracao"

Substitua NomeDaMigracao por um nome significativo para a migração.

Em seguida, aplique as migrações ao banco de dados:
"dotnet ef database update"
Isso criará ou atualizará o banco de dados de acordo com o modelo definido no código.

Conclusão
O seu programa é uma aplicação de console que simula um sistema de biblioteca, permitindo a interação com autores, livros, usuários e operações de empréstimo e devolução. A estrutura modular e a divisão em diferentes pastas facilitam a manutenção e expansão do código. Certifique-se de manter o código bem documentado e considere adicionar mais detalhes sobre a implementação específica de cada método, especialmente no contexto do banco de dados e nas operações de empréstimo e devolução.
