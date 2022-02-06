using GamingDemo.Abstract;
using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerIfRealPerson(gamer) == true)
            {
                Console.WriteLine("Tebrikler ! " + gamer.FirstName + " " + gamer.LastName + " adlı oyuncu başarıyl eklendi");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız. Lütfen Tekrar Deneyiniz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Tebrikler ! " + gamer.FirstName + " " + gamer.LastName + " adlı oyuncu başarıyla silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Tebrikler ! " + gamer.FirstName + " " + gamer.LastName + " adlı oyuncu başarıyla güncellendi");
        }
    }
}
