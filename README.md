# elumini-challenge

Após clonar o repositório e realizar o Build do projeto, utilize o comando Update-Database para persistir as informações no LocalDb.

Abra um terminal(CMD, Shell, PowerShell) e navegue até o diretório /src/crud-accounts
Execute os comandos: 
dotnet build
dotnet run

Os endereços abaixo poderão ser acessados após a mensagem de confirmação que o serviço está rodando na porta 5001.

A partir daqui serão disponibilizados os endpoints abaixo:

https://localhost:5001/api/pessoas 

https://localhost:5001/swagger

Se você receber um erro de segurança de HTTPS apenas adicione a exceção de segurança à página para conseguir acessar as informações. 
