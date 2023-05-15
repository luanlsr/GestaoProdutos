# Gestão de Produtos
Aplicação .NET API REST para gerenciamento de produtos, utilizando a arquitetura DDD (Domain-Driven Design) e Docker para gerenciamento de serviços e banco de dados. A aplicação está dividida em três pastas principais: API, DDD e TDD, sendo que esta última contém os testes automatizados.

## Pré-requisitos
Para executar esta aplicação, é necessário ter o Docker e o Docker Compose instalados no seu sistema operacional.

## Como executar os testes
Para executar os testes automatizados, siga os seguintes passos:

Abra o terminal na pasta raiz da aplicação
Execute o seguinte comando para construir a imagem dos testes:
Copy code
docker build -t gestaoprodutos-test -f TDD/Dockerfile .
Execute o seguinte comando para executar os testes:
arduino
Copy code
docker run gestaoprodutos-test

## Como executar a API
Para executar a API, siga os seguintes passos:

Abra o terminal na pasta raiz da aplicação
Execute o seguinte comando para construir a imagem do serviço da API:
Copy code
docker build -t gestaoprodutos-api -f API/Dockerfile .
Execute o seguinte comando para iniciar a aplicação:
Copy code
docker-compose up
O comando acima inicia o serviço da API e o banco de dados SQL em containers separados do Docker, permitindo que a aplicação seja executada de forma isolada e portátil.

## Endpoints disponíveis
A API oferece os seguintes endpoints:

GET /api/produtos: Retorna todos os produtos cadastrados
GET /api/produtos/{id}: Retorna um produto específico pelo seu ID
POST /api/produtos: Cria um novo produto
PUT /api/produtos/{id}: Atualiza um produto existente
DELETE /api/produtos/{id}: Exclui um produto existente

## Tecnologias utilizadas
A aplicação utiliza as seguintes tecnologias:

.NET 5.0
Docker
Docker Compose
Entity Framework Core
SQL Server
xUnit
Contribuindo
Contribuições são sempre bem-vindas! Se você quiser contribuir com este projeto, sinta-se à vontade para abrir uma issue ou enviar um pull request.
