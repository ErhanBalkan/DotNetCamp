using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_GameSales
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService){
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer){
            if (_userValidationService.Validate(gamer).GetAwaiter().GetResult())
            {
                System.Console.WriteLine(gamer.FirstName + " kayıt oldu.");
            }else{
                System.Console.WriteLine("Doğrulama başarısız. Kayıt başarısız.");
            }
            
        }
        public void Update(Gamer gamer){
            System.Console.WriteLine(gamer.FirstName + " kayıt güncellendi.");
        }
        public void Delete(Gamer gamer){
            System.Console.WriteLine(gamer.FirstName + " kayıt silindi.");
        }
    }
}