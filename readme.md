# CRUD Entity Framework - MVC - xUnit

![Badge em Desenvolvimento](https://img.shields.io/static/v1?label=STATUS&message=FINALIZADO&color=GREEN&style=for-the-badge)

## Introdução
Projeto .NET estruturado através da Arquitetura MVC e demonstra a implementação de operações CRUD (Create, Read, Update, Delete) 
persistidas em uma base de dados SQL Server através do Entity Framework.

* TDD desenvolvido através do uso de testes unitários xUnit.
* Aplicação de interface login segura, bloqueando qualquer tentativa de acesso indevido ou forçado, bem como uso de Filters e BaseControllers.
* Design do frontend com o framework visual Bootstrap e sua bliblioteca de ícones.
* Consulta de Feriados Nacionais obtidos através da API externa Nager.Date.
* Consulta de Endereços através da API externa ViaCEP.
* Imagens obtidas randomicamente de forma assíncrona através de APIs externas variadas.

### Tecnologias Utilizadas:
* .NET
* Entity Framework
* SQL Server
* Arquitetura MVC
* TDD
* API
* Filters e BaseControllers
* Bootstrap

### TO-DO
Nas próximas etapas serão desenvolvidos neste projeto:
* Controle e armazenamento de Log de acesso através do MongoDB

## O que é o Entity Framework?
O Entity Framework (EF) é um ORM (Object-Relational Mapper) moderno que permite aos desenvolvedores .NET trabalhar com um banco de dados usando objetos .NET. Ele elimina a necessidade de escrever a maior parte do código de acesso a dados que os desenvolvedores normalmente precisariam escrever. EF permite criar uma camada de acesso a dados limpa, portátil e de alto nível, suportando vários bancos de dados.

## O que é MVC?
O padrão MVC (Model-View-Controller) no .NET Core organiza aplicações em três componentes principais: Modelos (dados e lógica de negócios), Visões (interface do usuário), e Controladores (processamento de requisições e ligação entre Modelos e Visões). Isso facilita a separação de responsabilidades e a manutenção do código.

## Estrutura do Projeto
O projeto principal está organizado da seguinte forma:
* **Models**: Contém as classes de modelo que representam as tabelas do banco de dados.
* **Data**: Contém o contexto do EF, que gerencia a conexão com o banco de dados e a configuração dos modelos.
* **Views**: Interface do usuário para interagir com os dados.
* **Filters**: Contém as classes de filtros globais da aplicação.
* **Api**: Classes dos objetos das APIs e arquivos de acesso aos endpoints das APIs externas utilizadas.

O projeto de testes está organizado da seguinte forma:
* **Raiz**: Contém as classes para testes unitários do projeto principal.

## Funcionalidades
* **Create**: Adicionar novos registros ao banco de dados.
* **Read**: Visualizar registros existentes.
* **Update**: Editar registros existentes.
* **Delete**: Remover registros do banco de dados.

## Configuração e Execução
Para executar este projeto localmente, siga os passos abaixo:

1. **Clone o repositório**:
   ```bash
   git clone <URL-do-repositorio>
   ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd nome-do-projeto
   ```

3. **Instale as dependências**:
   Certifique-se de que você tenha o .NET SDK instalado em sua máquina. Instale as dependências com:
   ```bash
   dotnet restore
   ```

4. **Atualize as configurações do banco de dados**:
   No arquivo `appsettings.json`, configure a string de conexão para o seu servidor SQL Server.

5. **Execute as migrações do banco de dados**:
   ```bash
   dotnet ef database update
   ```

6. **Execute o projeto**:
   ```bash
   dotnet run
   ```