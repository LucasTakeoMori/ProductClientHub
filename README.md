 API RESTful para gerenciamento de clientes e seus produtos, desenvolvida como projeto de estudo em .NET.

 ## Sobre o Projeto

 O **ProductClientHub** é uma API que permite o cadastro, consulta, atualização e exclusão de clientes e produtos. Cada
  cliente pode ter múltiplos produtos associados, estabelecendo um relacionamento um-para-muitos.

 ## Tecnologias Utilizadas

 - **.NET 10** - Framework principal
 - **ASP.NET Core Web API** - Construção da API REST
 - **Entity Framework Core** - ORM para acesso a dados
 - **SQLite** - Banco de dados relacional
 - **FluentValidation** - Validação de dados de entrada
 - **Scalar** - Documentação interativa da API

 ## Arquitetura

 O projeto segue uma arquitetura em camadas:

 ```
 ProductClientHub/
 ├── ProductClientHub.API/           # Camada principal (Controllers, UseCases, Entities)
 ├── ProductClientHub.Communication/ # DTOs de Request e Response
 └── ProductClientHub.Exceptions/    # Exceções personalizadas
 ```

 ## Endpoints

 ### Clientes (`/api/clients`)

 | Método | Rota | Descrição |
 |--------|------|-----------|
 | POST | `/api/clients` | Cadastrar cliente |
 | GET | `/api/clients` | Listar todos os clientes |
 | GET | `/api/clients/{id}` | Buscar cliente por ID |
 | PUT | `/api/clients/{id}` | Atualizar cliente |
 | DELETE | `/api/clients/{id}` | Remover cliente |

 ### Produtos (`/api/products`)

 | Método | Rota | Descrição |
 |--------|------|-----------|
 | POST | `/api/products` | Cadastrar produto |
 | DELETE | `/api/products/{id}` | Remover produto |

 ## Como Executar

 1. Clone o repositório
 ```bash
 git clone https://github.com/LucasTakeoMori/ProductClientHub.git
 ```

 2. Navegue até o projeto da API
 ```bash
 cd ProductClientHub/ProductClientHub.API
 ```

 3. Execute a aplicação
 ```bash
 dotnet run
 ```

 4. Acesse a documentação da API
 ```
 https://localhost:{porta}/scalar/v1
 ```

 ## Pré-requisitos

 - [.NET 10 SDK](https://dotnet.microsoft.com/download)

 ## Autor

 Desenvolvido como projeto de estudo.
