﻿using GamingDemo.Abstract;
using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Concrete
{
    public class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Tebrikler ! " + campaing.CampaingName + " adlı kampanya başarıyla eklendi");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Tebrikler ! " + campaing.CampaingName + " adlı kampanya başarıyla silindi");
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Tebrikler ! " + campaing.CampaingName + " adlı kampanya başarıyla güncellendi");
        }
    }
}
