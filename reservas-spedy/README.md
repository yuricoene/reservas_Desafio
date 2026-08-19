# modelo-README.md
Modelo (template) de README para utilizar nas documentações dos seus projetos no GitHub. Deixe sua ⭐ se curtiu o template, para ficar salvo e utilizar depois.

# Título/Nome do projeto

Descreva brevemente o seu projeto. Aqui você pode utilizar texto e também imagens/diagramas.

* O [Mermaid](https://mermaid.live/edit#pako:eNpVkE1uwjAQha9izapIZFGWWVSCBFZUVCq7mMXInjSW_Fdji6Ikp2HRg3CxmmRDZzV633uj0etBOElQQqvdRXQYIjvW3LI862bttRJ4_73fHHs9saJ4GwJ9JzrHgW1enulqMWc2DxOr-u0PGa_dOKvVFD1YGljd7NFH50_P5HhxA9s26qNzlv6TLlBO7ZoWyxYLgYFVGCYLLMFQMKhk_r5_KBxiR4Y4lHmV1GLSkQO3Y7Ziiu7zagWUMSRaQvISI9UKvwIayLf1OaskVXThfW5kKmb8AyAeX3o) é uma opção bem legal para diagramas e você consegue utilizar diretamente no README.md:

[![](https://mermaid.ink/img/pako:eNpVkE1uwjAQha9izapIZFGWWVSCBFZUVCq7mMXInjSW_Fdji6Ikp2HRg3CxmmRDZzV633uj0etBOElQQqvdRXQYIjvW3LI862bttRJ4_73fHHs9saJ4GwJ9JzrHgW1enulqMWc2DxOr-u0PGa_dOKvVFD1YGljd7NFH50_P5HhxA9s26qNzlv6TLlBO7ZoWyxYLgYFVGCYLLMFQMKhk_r5_KBxiR4Y4lHmV1GLSkQO3Y7Ziiu7zagWUMSRaQvISI9UKvwIayLf1OaskVXThfW5kKmb8AyAeX3o?type=png)](https://mermaid.live/edit#pako:eNpVkE1uwjAQha9izapIZFGWWVSCBFZUVCq7mMXInjSW_Fdji6Ikp2HRg3CxmmRDZzV633uj0etBOElQQqvdRXQYIjvW3LI862bttRJ4_73fHHs9saJ4GwJ9JzrHgW1enulqMWc2DxOr-u0PGa_dOKvVFD1YGljd7NFH50_P5HhxA9s26qNzlv6TLlBO7ZoWyxYLgYFVGCYLLMFQMKhk_r5_KBxiR4Y4lHmV1GLSkQO3Y7Ziiu7zagWUMSRaQvISI9UKvwIayLf1OaskVXThfW5kKmb8AyAeX3o)

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
