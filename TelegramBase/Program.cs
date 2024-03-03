using DAL;
using Domain;

using MyDbContext dbContext = new MyDbContext();

var user = new User(){Name = "Tyler Derden"};
dbContext.Users.Add(user);
var chat = new Channel() { Name = "Fight Club" };
dbContext.Channels.Add(chat);
var bob = new UserChat() { UserId = user.Id, ChatId = chat.Id };
dbContext.UserChats.Add(bob);
dbContext.SaveChanges();