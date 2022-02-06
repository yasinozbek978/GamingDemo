using GamingDemo.Abstract;
using GamingDemo.Entity;
using Mernis;
using System;


namespace GamingDemo.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckGamerIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
           return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.TcNo), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
