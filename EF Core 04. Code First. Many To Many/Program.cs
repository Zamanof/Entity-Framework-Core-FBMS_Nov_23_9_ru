// Relationships
// One To One
// One To Many
// Many To Many

using EF_Core_04._Code_First._Many_To_Many;
using Microsoft.EntityFrameworkCore;

using SocialContext db = new();

SocialNetwork facebook = new SocialNetwork() { Name = "Facebook" };
SocialNetwork instagram = new SocialNetwork() { Name = "Instagram" };
SocialNetwork ok = new SocialNetwork() { Name = "Ok" };

User user = new User()
{
    FirstName = "Nadir",
    LastName = "Zamanov",
    Login = "MoguDa",
    Password = "qwerty12345",
};
facebook.Users.Add(user);
instagram.Users.Add(user);
ok.Users.Add(user);

db.SocialNetworks.AddRange(facebook, instagram, ok);

db.SaveChanges();

//var instagram = db.SocialNetworks.Where(cn => cn.Name == "Instagram")
//    .Include(sc => sc.Users).First();
//instagram.Users.Add(new User()
//{
//    FirstName = "Salam",
//    LastName = "Salamzade",
//    Login = "Hello",
//    Password = "GoodBye",
//});
//db.SaveChanges();

//var networks = db.SocialNetworks.Include(sc => sc.Users).ToList();

//foreach (var network in networks)
//{
//    Console.WriteLine(network);
//    foreach (var user in network.Users)
//    {
//        Console.WriteLine($"    {user}");
//    }
//}
