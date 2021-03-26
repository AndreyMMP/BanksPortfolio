#PORTUGUÊS<br/>
Essa é uma aplicação multicamadas que possui três camadas, uma responsável pelas regras de negócios, outra pela a visão do usuário e a última responsável pelos testes unitários.
<br/>Na camada de negócios foi utilizado o Design Pattern Abstract Factory e princios SOLID para poder abstrair e desacoplar as regras de negócio para fácil alteração de regra de negócio quando necessário.
<br/>Para a camada de visão do usuário foi utilizado Windows Forms.
<br/>Para os testes unitários foi utilizado xUnit.
<br/>Nessa aplicação existe também o script de criação de um possível banco de dados para a aplicação, como também existe a reescrita das regras de negócios para T-SQL utilizando Stored Procedure e Function. Podem ser localizados dentro do projeto BanksPortfolio.Business na pasta SQLScripts.
<br/><br/>
Funcionalidades:<br/>
O usuário pode escolher um investimento e adicionar ao seu portifólio.<br/>
O usuário pode verificar a categoria dos investimentos de seu porifólio.<br/>
<br/>
Instruções para execução do projeto:<br/>
Definir BanksPortfolio.App como projeto de inicialização e executar<br/>
<br/><br/>
#ENGLISH<br/>
This is a multilayer application that has three layers, one responsible for business rules, another for the user's view and the last one for unit testing.
<br/>In the business layer, the Abstract Factory Design Pattern and SOLID principles were used to be able to abstract and decouple the business rules for easy change of the business rule when necessary.
<br/>Windows Forms was used for the user's view layer.
<br/>For unit tests, xUnit was used.
<br/>In this application there is also the script for creating a possible database for the application, as well as the rewriting of the business rules for T-SQL using Stored Procedure and Function. They can be located inside the BanksPortfolio.Business project in the SQLScripts folder.
<br/><br/>
Functionalities:<br/>
The user can choose a trade and add it to his portfolio..<br/>
The user can check the trade category of his portfolio.<br/>
<br/>
Project execution instructions:<br/>
Set BanksPortfolio.App as a startup project and run
