using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace AppBotTelegram.Util
{
    /// <summary>
    /// Classe responsável pela iteração do bot com o cliente no Telegram.
    /// </summary>
    public static class ClienteBotTelegram
    {
        /// <value>
        /// Propriedade responsável pelo recebimento do token de comunicação com o bot do Telegram.
        /// </value>
        public static readonly TelegramBotClient botCliente = new TelegramBotClient("1230212831:AAGes7As-laThsW0hUG8vBzXNlPOa8uosR0");

        /// <summary>
        /// Método responsável por obter o carregamento das mensagens.
        /// </summary>
        /// <param name="sender">Obtem referência as propriedades dos textos.</param>
        /// <param name="e">Obtem os valores dos textos no Telegram.</param>
        public static void ObterMensagem(object sender, MessageEventArgs e)
        {
            try
            {
                GerarMensagens(e);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu o seguinte erro: " + ex.Message);
            }

        }

        /// <summary>
        /// Método responsável por gerar as mensagens do atendimento ao cliente.
        /// </summary>
        /// <param name="e">Obtem os valores dos textos no Telegram.</param>
        private static void GerarMensagens(MessageEventArgs e)
        {
            try
            {
                Console.WriteLine("O cliente " + e.Message.Chat.FirstName + " diz: " + e.Message.Text);

                /// <summary>
                /// Array responsável por definir mensagens enviadas pelo cliente.
                /// </summary>
                string[] msgCliente = new string[8];

                msgCliente[0] = "oi";
                msgCliente[1] = "olá";
                msgCliente[2] = "estou bem, obrigado!";
                msgCliente[3] = "consulta rápida!";
                msgCliente[4] = "benefícios";
                msgCliente[5] = "sim";
                msgCliente[6] = "ok";
                msgCliente[7] = "não, obrigado!";

                if ((e.Message.Text.ToLower() == msgCliente[0] || e.Message.Text.ToLower() == msgCliente[1])
                    || (e.Message.Text.ToUpper() == msgCliente[0] || e.Message.Text.ToUpper() == msgCliente[1]))

                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Olá "
                                                   + e.Message.Chat.FirstName
                                                   + ", tudo bom?");

                if (e.Message.Text.ToLower() == msgCliente[2] || e.Message.Text.ToLower() == msgCliente[2])
                {
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Que ótmio Sr(a) "
                                                   + e.Message.Chat.FirstName
                                                   + "!"
                                                   + Environment.NewLine
                                                   + Environment.NewLine
                                                   + "Como posso lhe ajudar?");
                }

                if (e.Message.Text.ToLower() == msgCliente[3] || e.Message.Text.ToLower() == msgCliente[3])

                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Pois não Sr(a) "
                                                   + e.Message.Chat.FirstName
                                                   + "!"
                                                   + Environment.NewLine
                                                   + Environment.NewLine
                                                   + "O que gostaria de saber? ");

                if (e.Message.Text.ToLower() == msgCliente[4] || e.Message.Text.ToLower() == msgCliente[4])
                {
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Ok Sr(a) "
                                                    + e.Message.Chat.FirstName
                                                    + "!"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Gostaria de consultar nossos benefícos atráves de links diretos?");
                }

                if (e.Message.Text.ToLower() == msgCliente[5] || e.Message.Text.ToLower() == msgCliente[5])
                {
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Ok Sr(a) "
                                                    + e.Message.Chat.FirstName
                                                    + ", vou disponibilizar links referêntes a todos os nossos benefícios!"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Você pode conferir com maiores detalhes as vantagens de cada benefício:"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Cartão de Crédito Carrefour"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "https://www.carrefoursolucoes.com.br/cartao/beneficios"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Seguros Carrefour"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "https://www.carrefoursolucoes.com.br/seguros1"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Serviços Carrefour"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "https://www.carrefoursolucoes.com.br/servicos"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Promoções"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "https://www.carrefoursolucoes.com.br/promocao"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Localizar Loja"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "https://www.carrefoursolucoes.com.br/encontre-loja");

                }

                if (e.Message.Text.ToLower() == msgCliente[6] || e.Message.Text.ToLower() == msgCliente[6])
                {
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Algo mais Sr(a) " + e.Message.Chat.FirstName + "?");
                }

                if (e.Message.Text.ToLower() == msgCliente[7] || e.Message.Text.ToLower() == msgCliente[7])
                {
                    botCliente.SendTextMessageAsync(e.Message.Chat.Id, "Sr(a) "
                                                    + e.Message.Chat.FirstName
                                                    + ", O Banco Carrefour agradece seu contato!"
                                                    + Environment.NewLine + Environment.NewLine
                                                    + "Até a próxima!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu o seguinte erro: " + ex.Message);
            }
        }
    }
}
