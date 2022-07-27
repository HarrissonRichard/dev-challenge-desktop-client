# dev-challenge-desktop-client
# Solução do desáfio para criar uma aplicação rest em C#.
* O Desáfio pede para elaborar uma interface gráfica em C# para poder criar, listar e editar os dados de um produto e sincronizar com a API do Reqwest.
* O desáfio também pede que as seguintes condiçoões sejam satisfeitas:
  - Ao criar os dados de um produto a partir da GUI deverá guardar na API do Reqwest e guardar localmente na base de dados SQL Server;
  - Ao editar os dados do produto a partir da GUI deverá atualizar os dados na API do Reqwest e guardar localmente na base de dados SQL Server.

# Esse repositório contém apenas o código do cliente rest (desktop app)
* Responsavel por efectuar as operaçoes de criação edição e retornar os produtos da base de dados local.
* Para ver o código do servidor restlocal (API local) clique no link <a href="https://github.com/HarrissonRichard/dev-challenge-webapi" target="_blank">Servidor Rest - ASP.NET Core Web API </a>

# Tecnologias
- Refit - para se comunicar com a API local e remota(rekwest)
- Aplicativo do Windows Forms - para criar a interface gráfica
- Newtonsoft.Json - dependência do Refit para operações internas de serialização e deserialização.

# Funcionalidades:
* Visualizar todos os produtos base de dados local SQL SERVER numa interface gráfica
* Adicionar um novo produto na base de dados local(se comunicando com a API local) e remotamente (Rekwest API)
* Editar dados de um produto e actualizar localmente(se comunicando com a API) e remotamente com rekwest API

# Testes
- 1. para executar localmente, a aplicação depende de .NET 4.7.2 SDK 
- 2. Refit na versão 4.0.0
- 3. Newtonsoft.Json versão 10.0.3 
- 2. Clonar este repositótio e abrir com o visual studio 2015 ou superior

# Sobre mim
Harrisson Richard
- <a href="https://www.linkedin.com/in/harrisson-richard/">LinkedIn</a>
