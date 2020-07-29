using AppBotTelegram.Util;
using System;

namespace AppBotTelegram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** ATENDIMENTO AO CLIENTE *****");
            
            ClienteBotTelegram.botCliente.OnMessage += ClienteBotTelegram.ObterMensagem;
            ClienteBotTelegram.botCliente.StartReceiving();

            Console.ReadKey();

            ClienteBotTelegram.botCliente.StopReceiving();
        }
    }
}
