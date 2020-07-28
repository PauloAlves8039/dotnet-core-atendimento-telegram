using AppBotTelegram.Util;
using System;

namespace AppBotTelegram
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteBotTelegram clienteBotTelegram = new ClienteBotTelegram();
            
            clienteBotTelegram.botCliente.OnMessage += clienteBotTelegram.ObterMensagem;
            clienteBotTelegram.botCliente.StartReceiving();

            Console.ReadKey();

            clienteBotTelegram.botCliente.StopReceiving();
        }
    }
}
