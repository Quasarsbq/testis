using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace NetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Telegram.Bot.TelegramBotClient bot = new Telegram.Bot.TelegramBotClient("443096045:AAG6r5n2SgzhLvi_Pgx4ZvLDjrtm9dOu3xU");
            var config = new ConfigurationBuilder().AddEnvironmentVariables("").Build();
            // 2nd line added
            var url = config["ASPNETCORE_URLS"] ?? "http://*:8080";
            // 3rd line added
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls(url) // 4th line added
                .Build();

            host.Run();
            
            bot.OnMessage += Bot_OnMessage;
            bot.StartReceiving();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Telegram.Bot.TelegramBotClient bot = new Telegram.Bot.TelegramBotClient("443096045:AAG6r5n2SgzhLvi_Pgx4ZvLDjrtm9dOu3xU");

            bot.SendTextMessageAsync(e.Message.Chat.Id, "run");
        }
    }
}
