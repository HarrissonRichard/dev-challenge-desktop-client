# Soluçao do desáfio para criar um aplicação rest em C#.
O desáfio pede que as seguintes condicoes sejam satisfeitas:
- Ao criar os dados de um produto a partir da GUI deverá guardar na API do Reqwest e guardar localmente na base de dados SQL Server;
- Ao editar os dados do produto a partir da GUI deverá atualizar os dados na API do Reqwest e guardar localmente na base de dados SQL Server.

# Esse repositorio contem o código do cliente rest(desktop app)

#Tecnologias
- SQL SERVER
- DAPPER
- ASP.NET Core Web API
- Aplicativo do Windows Forms
- Refit

# Funcionalidades
a presente aplicação apresenta as seguintes funcionalidades a partir da GUI:
* Visualizar na Todos os produtos na base de dados local SQL SERVER
* Adicionar um novo produto na base de dados local e remota(Rekwest).
* Editar dados de um produto e actualizar localmente assim como na API rekwest

# Testes
- para testar a aplicação é preciso antes iniciar o servidor, cujo o código está nesse <a href="https://github.com/HarrissonRichard/dev-challenge-webapi">repositório</a> para que possa persistir os dados localmente  e depois sincroniza-los remotamente com API rekwest.
- para executar localmente, a aplicação depende de .NET 4.7.2 e visual studio 2015 ou superior

# Sobre mim
Harrisson Richard
- <a href="https://www.linkedin.com/in/harrisson-richard/">LinkedIn</a>
