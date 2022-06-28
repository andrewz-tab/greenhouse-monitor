using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using System.Collections.Generic;

namespace IoTClientProject
{

    class TelegramBot
    {
        public static Scoreboard scoreboard;
        static List<long> list = new List<long>();
        public  TelegramBot()
        {
            LaunchBot();
        }
        static void AddClient(long Id)
        {
            if(!list.Contains(Id))
                list.Add(Id);
        }
        static void RemoveClient(long Id)
        {
            list.Remove(Id);
        }

        void LaunchBot()
        {
            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
        }

        static string GetCondition()
        {
            return scoreboard.HandleRequest();
        }
        static public async Task SendMess(string Mess)
        {
            for(int i = 0; i < list.Count; i++)
            {
                await bot.SendTextMessageAsync(new ChatId(list[i]), Mess);
            }
        }
        public static ITelegramBotClient bot = new TelegramBotClient("5478811723:AAEe152wWOw7k4C9ipW3rfoCNSEYtoozYEo");
        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/sub")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Запущен бот для оповещения системы контроля освещенности и климата теплицы. Ожидайте оповещений!");
                    AddClient(update.Message.From.Id);
                    return;
                }
                else if(message.Text.ToLower() == "/get")
                {
                    await botClient.SendTextMessageAsync(message.Chat, GetCondition());
                }
                else if (message.Text.ToLower() == "/unsub")
                {
                    RemoveClient(update.Message.From.Id);
                }
                else if (message.Text.ToLower() == "/help")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "/sub - подписаться на оповещения\n /unsub - отписать от оповещений\n /get - получить текущее состояние датчиков");
                }
                else
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Неизвестная комманда. Отправте /help, для получения списка комманд");
                }
            }
        }
        

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }

     
    }
}