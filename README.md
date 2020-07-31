<h1 align="center">DotNet Core Atendimento Telegram</h1>

## :computer: Projeto
Repositório de aplicação responsável por simular o atendimento de clientes para uma multinacional em um Chabot no aplicativo Telegram, 
projeto desenvolvido durante no evento [Tech Challenge](https://digitalinnovation.one/) da Digital Innovation One. 

## :rocket: Funcionalidade
O cliente entra em contato solicitando ajuda para consultar informações sobre benefícios da instituição, o bot por sua vez lhe fornece esse atendimento de forma 
rápida e simplificada.

No caso desse atendimento o bot da uma sugestão ao cliente para acessar links no site da instituição, com isso o cliente poderá acessar qualquer um dos benefícios e obter maiores detalhes.

## :exclamation: Observação
Na classe [ClienteBotTelegram](https://github.com/PauloAlves8039/dotnet-core-atendimento-telegram/blob/master/AppAtendimentoBotTelegram/AppBotTelegram/Util/ClienteBotTelegram.cs) foi feita uma alteração do token de comunicação com a API do Telegram na linha 15, essa mudança foi necessária por conta de questões de segurança com o GitHub.

```public static readonly TelegramBotClient botCliente = new TelegramBotClient("ADICIONE UM TOKEN DA API DO TELEGRAM AQUI!"); ```

Para testar essa aplicação pode ser gerado um novo token no Telegram, ou pode utilizar o [token](https://github.com/PauloAlves8039/dotnet-core-atendimento-telegram/blob/master/AppAtendimentoBotTelegram/AppBotTelegram/Resources/Token%20Telegram.txt) usado no desenvolvimento do projeto.

## :wrench: Recursos Utilizados
- [Microsoft Visual Studio 2019](https://visualstudio.microsoft.com/pt-br/downloads/).
- [.NET Core v3.1.302](https://dotnet.microsoft.com/download/dotnet-core/3.1).
- [C#](https://code.visualstudio.com/).
- [Telegram Bot](https://telegrambots.github.io/book/index.html).

## :floppy_disk: Clonar repositório
```git clone https://github.com/PauloAlves8039/dotnet-core-atendimento-telegram.git```

## :camera: Screenshot
<p align="center">
  <img src="https://github.com/PauloAlves8039/dotnet-core-atendimento-telegram/blob/master/AppAtendimentoBotTelegram/AppBotTelegram/Resources/screenshot.png" title="Screenshot">
</p>

## Author
:boy: [Paulo Alves](https://github.com/PauloAlves8039)
