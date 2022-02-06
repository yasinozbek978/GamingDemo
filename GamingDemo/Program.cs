using GamingDemo.Concrete;
using GamingDemo.Entity;
using System;

namespace GamingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Yasin";
            gamer1.LastName = "ÖZBEK";
            gamer1.TcNo = "22580742083";
            gamer1.BirthYear = 2007;

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Said";
            gamer2.LastName = "ÖZBEK";
            gamer2.TcNo = "76387159623";
            gamer2.BirthYear = 2001;

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer1);

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Kırmızı ve Beyaz";
            game1.UnitPrice = 300.00;
            game1.DiscountedPrice = 150.00;

            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "Sarı ve Kırmızı";
            game2.UnitPrice = 249;
            game2.DiscountedPrice = 124.50;

            Campaing campaing1 = new Campaing();
            campaing1.Id = 1;
            campaing1.CampaingName = "Ay Sonu Kampanyası";

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing1);

            OrderManager orderManager = new OrderManager();
            orderManager.Sales(game1, gamer1, campaing1);
        }
    }
}
