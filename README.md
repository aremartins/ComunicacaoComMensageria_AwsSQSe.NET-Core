# Exemplo de comunicação com mensageria por meio de AWS SQS e .NET Core

<img src="https://github.com/aremartins/ComunicacaoComMensageria_AwsSQSe.NET-Core/blob/main/Diagrama.jpg?raw=true" />
<h2>Exemplo de comunicação com mensageria por meio de AWS SQS e .NET Core</h2>
<h3>Pequeno código que exemplifica o processo de comunicação pelo serviço de filas na AWS entre dois micro serviços.</h3>
<p>Fluxo completo de recebimento, processamento e exclusão de mensagem em uma fila na AWS,  para desenvolvimento de aplicativos que rodam em qualquer servidor como EC2 por exemplo.</p>

<ul>Para testar o projeto em sua máquina, você precisará ter uma conta na AWS e após entrar no console pesquisar por SQS e criar uma fila.</ul>
<li>Foi criada uma fila para teste na AWS chamada teste2;
<li>Foram criados dois projetos de exemplo de micro serviços que se comunicam por meio de uma fila:
<li>Fornecedor - vai enviar mensagens para fila;
<li>Consumidor - vai receber mensagens da fila.

<p>Para consumir o serviço de SQS, tal como qualquer serviço da Amazon (ou de qualquer outro fornecedor) nós precisamos do SDK, que é o pacote que vai nos fornecer acesso aos recursos. No Google, pesquisa nuget SQS, e copia o PackageReference que vai aparecer dentro do primeiro link para os dois projetos.</p>

<h3>É preciso importar nos dois projetos:</h3>
<li>using Amazon;
<li>using Amazon.SQS;
<li>using Amazon.SQS.Model;

<p>Para testar, primeiro faça a simulação de envio da mensagem rodando o projeto Fornecedor e após o rode o projeto Consumidor.</p>

<p>O resultado deve ser parecido com este:</p>
<img src="https://github.com/aremartins/ComunicacaoComMensageria_AwsSQSe.NET-Core/blob/main/Untitled_%20Oct%2013,%202021%209_15%20AM.gif?raw=true" />

