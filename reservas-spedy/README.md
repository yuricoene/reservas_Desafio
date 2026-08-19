# Título/Nome do projeto

Aplicação de reservas de salas de coworking: back-end em C#/.NET, front-end em React, banco SQLite.
Lista reservas por dia em ordem cronológica, permite criar (sala, título, início, fim) e cancelar reservas. O back-end valida campos obrigatórios, fim > início e ausência de sobreposição de horários na mesma sala.
Cancelamento é soft delete (marca como cancelada, não remove do banco) para preservar histórico e evitar problemas de integridade futuros.

[Diagrama](https://mermaid.ai/app/projects/5941777c-bcc4-4ad6-8b5f-85b58117d067/diagrams/9df5e5f4-8068-4edc-8f7b-8784b14bff71/share/invite/eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkb2N1bWVudElEIjoiOWRmNWU1ZjQtODA2OC00ZWRjLThmN2ItODc4NGIxNGJmZjcxIiwiYWNjZXNzIjoiRWRpdCIsImlhdCI6MTc4NzE2NjUzOH0.mHen79JQkHGsJdol8nUBXHjpakTPKUEdJPMQjprpm_c?entryPoint=share-modal)

- No site, vá no campo: Actions > Copy Markdown. Copie o link e cole no seu arquivo README.md e o diagrama estará lá.


### Tecnologias Utilizadas

**Back-end**
* [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
* [ASP.NET Core](https://dotnet.microsoft.com/pt-br/apps/aspnet)
* [Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)
* [SQLite](https://www.sqlite.org/)

**Front-end**
* [React](https://react.dev/)
* [JavaScript](https://developer.mozilla.org/pt-BR/docs/Web/JavaScript)
* [CSS](https://developer.mozilla.org/pt-BR/docs/Web/CSS)

**Arquitetura e Padrões de Projeto**

*Clean Architecture*
*Feature-Sliced Design*
*Injeção de Dependência*
*DTOs*
*Soft Delete*

**Ferramentas e Versionamento**
* [Visual Studio Code](https://code.visualstudio.com/)
* [Git](https://git-scm.com/)
* [GitHub](https://github.com/)

### Dependências e Versões Necessárias
* **.NET SDK** - Versão: 8.0
* **Node.js** - Versão: 18.x ou superior (LTS)
* **npm** - Versão: 9.x ou superior
* **SQLite** - Versão: 3.x (gerenciado via Entity Framework Core)
  
## Como rodar o projeto ✅

Siga o passo a passo para executar a aplicação completa em seu ambiente local.

### 1. Clonar o repositório
Abra o terminal na pasta onde deseja salvar o projeto e execute:
```
git clone [https://github.com/SEU_USUARIO/reservas-spedy.git](https://github.com/SEU_USUARIO/reservas-spedy.git)
```

Depois, rode o seguinte comando:
```
cd reservas-spedy
```

## Como rodar o Back-end(.Net)
Passo 1: No terminal já dentro da pasta reservas-spedy, percorra até a pasta back-end e insira esse comando: 
```
cd backend
```

Passo 2: Restaure as dependências do projeto: 
```
dotnet restore
```

Passo 3: Inicie o servidor da API: 
```
dotnet run
```

Para confirmar o Entity Framework criará o banco de dados SQlite automaticamente. O terminal exibirá as seguintes mensagens confirmando a execução: 
#foto do meu terminal

## Como rodar o Front-end
1 Passo: Abra um segundo terminal, sem fechar o do back-end e encontre a pasta do front-end a partir da raiz
```
cd frontend
```

2 Passo: instale as dependências do node
```
npm install
```

3 Passo: Inicie o servidor local de desenvolvimento
```
npm run dev
```

4 Passo confirmar se o front-end está rodando
# print da minha tela

## Teste de Integração


## 📌 (Título) - Informações importantes sobre a aplicação (exemplo) 📌

Esse é o local para você preencher com outras informações que possam ser importantes para a aplicação. Coloquei um exemplo de título, mas você deve preencher de acordo com a necessidade do projeto. Pode ser que não seja necessário.

Um bom exemplo: se você estiver construindo uma API, liste as rotas da aplicação e quais serão os seus retornos. Isso facilita para quem vai consumir a API.


## ⚠️ Problemas enfrentados

Problema 1: Pastas duplicadas no clone/descompactação
Em alguns ambientes, a estrutura de arquivos era extraída como reservas-spedy/reservas-spedy/backend, impedindo a navegação direta via cd backend.

Como solucionar: Padronizou-se o guia de execução instruindo a navegar a partir da raiz ou ajustar o repositório para manter a estrutura única na pasta raiz.


## ⏭️ Próximos passos
*Orquestração com Docker: Configurar um docker-compose.yml para subir a API, o front-end e a base de dados em ecossistemas isolados utilizando apenas o docker compose up.
*Disparo Automático de E-mails: Integrar um serviço de mensageria (SMTP) para enviar confirmações e avisos de cancelamento diretamente para o e-mail do usuário.
