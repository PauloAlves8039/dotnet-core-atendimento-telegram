using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace AppBotTelegram.Util
{
    /// <summary>
    /// Classe responsável pela iteração do bot com o cliente no Telegram.
    /// </summary>
    public class ClienteBotTelegram
    {
        /// <value>
        /// Propriedade responsável pelo recebimento do token de comunicação com o bot do Telegram.
        /// </value>
        public readonly TelegramBotClient botCliente = new TelegramBotClient("1351304466:AAEbVHuwkA-3pAMRMa1L8kdKQvJRkGYFq9g");

        /// <value>
        /// Atribui opções de mensagens de resposta para o cliente.
        /// </value>
        String opcao;

        /// <summary>
        /// Método responsável pelo gerenciamento das mensagens do atendimento com o cliente.
        /// </summary>
        /// <param name="sender">Obtem referência as propriedades dos textos.</param>
        /// <param name="e">Obtem os valores dos textos no Telegram.</param>
        public void ObterMensagem(object sender, MessageEventArgs e)
        {
            Console.WriteLine("O cliente " + e.Message.Chat.FirstName + " diz: " + e.Message.Text);

            opcao = e.Message.Text;

            if (e.Message.Text.ToLower() == "oi" || e.Message.Text.ToLower() == "olá")
            {
                botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Olá "
                                               + e.Message.Chat.FirstName
                                               + ", seja vindo-vindo(a)!"
                                               + Environment.NewLine
                                               + "Por favor, digite a opção desejada: "
                                               + Environment.NewLine
                                               + "* 1 - Cartão de Crédito Carrefour."
                                               + Environment.NewLine
                                               + "* 2 - Seguros Carrefour."
                                               + Environment.NewLine
                                               + "* 3 - Serviços Carrefour."
                                               + Environment.NewLine
                                               + "* 4 - Promoções."
                                               + Environment.NewLine
                                               + "* 5 - Finalizar.");
            }

            switch (opcao)
            {
                case "1":
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Pois não "
                                               + e.Message.Chat.FirstName
                                               + ". Para conferir os bebeficios de nosso cartão de crédito acesse: https://www.carrefoursolucoes.com.br/cartao/beneficios");
                    break;

                case "2":
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Pois não "
                                               + e.Message.Chat.FirstName
                                               + ". Para conferir nossos seguros acesse: https://www.carrefoursolucoes.com.br/seguros1");
                    break;

                case "3":
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Pois não "
                                               + e.Message.Chat.FirstName
                                               + ". Para conferir nossos serviços acesse: https://www.carrefoursolucoes.com.br/servicos");
                    break;

                case "4":
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Pois não "
                                               + e.Message.Chat.FirstName
                                               + ". Para conferir nossas promoções acesse: https://www.carrefoursolucoes.com.br/promocao");
                    break;
                case "5":
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "O Banco Carrefour agradece o seu contato "
                                           + e.Message.Chat.FirstName
                                           + ". Até a próxima!");

                    break;
            }
        }
    }
}
