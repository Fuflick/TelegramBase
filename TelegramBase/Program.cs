using DAL;
using Domain;

using MyDbContext dbContext = new MyDbContext();

var user = new User(){Name = "zuza"};
dbContext.Users.Add(user);
var chat = new Channel() { Name = "YarikLOX" };
dbContext.Channels.Add(chat);
var bot = new Bot() { Name = "bot3" };
dbContext.Bots.Add(bot);
var command = new Command() { Name = "banan" };
dbContext.Commands.Add(command);

dbContext.SaveChanges();

var userChat = new UserChat() { UserId = user.Id, ChatId = chat.Id };
dbContext.UserChats.Add(userChat);
var botChat = new BotChat() { BotId = bot.Id, ChatId = chat.Id };
dbContext.BotChats.Add(botChat);
var botCommand = new BotCommand() { BotId = bot.Id, CommandId = command.Id };
dbContext.BotCommands.Add(botCommand);

dbContext.SaveChanges();