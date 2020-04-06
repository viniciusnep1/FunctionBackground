
Projeto construido como forma de aprendizado sobre como funciona uma função em background.
https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-run-an-operation-in-the-background

O Backend foi desenvolvido em dotnet core 2.1. Para rodar o Backend é necessário a sdk do dotnet core 2.1 e o banco de dados Postgres 11 e criar a base de dados chamada 'portal_xpto' (sem as aspas). 

Ao abrir o projeto é necessário gerar o banco de dados, caso o sistema operacional seja o linux, rodar com o comando: 
<b> dotnet ef database update </b>

Caso seja o Visual Studio no Windows abrir o Package Manager Console e rodar o comando:
<b> update-database </b>

Feito isso, se voce estiver no visual studio é só apertar F5, caso esteja no linux rodar o seguinte comando:
<b> dotnet run </b>
