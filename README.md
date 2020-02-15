# DTI
Projetos desenvolvidos para a DTI.
# Backend
O Backend foi desenvolvido em dotnet core 2.1. Para rodar o Backend é necessário a sdk do dotnet core 2.1 e o banco de dados Postgres 11 e criar a base de dados chamada 'portal_xpto' (sem as aspas). 

Ao abrir o projeto é necessário gerar o banco de dados, caso o sistema operacional seja o linux, rodar com o comando: dotnet ef database update


Caso seja o Visual Studio no Windows abrir o Package Manager Console e rodar o comando: update-database

Feito isso, se voce estiver no visual studio é só apertar F5, caso esteja no linux rodar o seguinte comando:
dotnet run

Minha idéia para a resolução do problema foi a seguinte:
Eu preciso de uma Api para ser consumida em uma aplicação frontend. O problema então me descreveu "O ABCData é feito em Java, tem um banco de dados SQL Server"(sic), porém eu não possuo essa Api então a minha ideia para resolver o problema foi simular esses dados vindo da Api através de um mapeamento qualquer que eu criei com as entidades que poderiam ser recuperadas da Api escrita em Java e em cima disso eu populei uma base de dados em um Schema do banco diferente, para não misturar com os dados da minha "real" aplicação e assim simular uma Api externa. O Schema criado para a simulação é chamado 'xpto'.

Dessa forma com a necessidade de recuperar e tratar esses dados da suposta Api em Java, a minha idéia para a aplicação foi a seguinte:
Vou mapear todas entidades resultantes do Join das tabelas “volume produzido” x “volume planejado” (como descrito no problema) e criar uma nova tabela chamada 'xpto' em um Schema diferente chamado 'entity' como se fosse o Schema do meu banco principal. Com o mapeamento gerado a partir dessas duas tabelas (“volume produzido” x “volume planejado”) eu iria popular esse meu banco que seria o banco principal da aplicação.

Como descrito no problema, "A tabela de volume produzido tem aproximadamente 500.000 mil linhas e 12 colunas
• A tabela de volume planejado tem aproximadamente 480.000 mil linhas e 11 colunas" (sic), seria inviável a criação de um endpoint que fizesse essa varredura na Api externa e devolvesse meus valores calculados toda vez que alguem acessasseo conteúdo da página.

Para resolver esse problema eu criei um método que vai buscar todos os valores da tabela 'volume produzido' e da tabela 'volume planejado' vindos do Schema 'xpto' (como se simulasse a Api externa escrita em Java) e popular minha nova tabela  (a tabela 'xpto') com os valores atualizados resultantes da minha busca. 

O método será um Job (uma operação que roda em segundo plano a cada determinado tempo) e atualizará os dados da minha nova tabela. O tempo de atualização que estipulei foi de 30 minutos, porem podemos colocar quanto tempo quisermos. 

Dessa forma, mesmo que a busca e os cálculos demorem muito tempo, não teremos atrasos na interface de usuário pois a mesma será alimentada através de um endpoint que consultura uma unica linha de uma unica tabela fazendo com que o sistema seja rapido e eficiente.

# FrontEnd
O frontend foi desenvolvido em React. Foram criadas duas aplicações e para roda-las é necessário instalar as dependencias nas duas aplicalções da seguinte forma:
abrir um terminal na pasta de cada aplicação e executar o seguinte comando:
<b> npm install </b>
Feita as instalações das depencias é só exetar os dois projetos usando o mesmo comando:
 npm start
Os dois sistemas são independentes onde um sistema é um 'Portal' que servirá como base para qualquer outra aplicação desenvolvida, independente de linguagem. Para rodar uma aplicação "dentro da outra" eu usei uma biblioteca do react chamada Iframe.

A aplicação que está dentro do 'Portal' possui um gráfico que é alimentado pelos dados vindos do servidor (backend), sendo assim para que o usuário consiga ver os dados é necessário que a aplicação servidora (O backend) esteja rodando e com dados os respectivos bancos alimentados. Caso contrario não aparecerá dado algum no gráfico. 

O gráfico que aparece é um componente de uma biblioteca chamda Rechart.
