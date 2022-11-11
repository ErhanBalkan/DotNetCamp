using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ServiceReference.KPSPublicSoapClient;
namespace _001_GameSales
{
    public class UserValidationManager : IUserValidationService
    {
        public Task<bool> Validate(Gamer gamer)
        {
            bool result = false;
            try
            {
                using(ServiceReference.KPSPublicSoapClient mernis = new ServiceReference.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap)){
                    var response = mernis.TCKimlikNoDogrulaAsync(gamer.IdentityNumber,gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.BirthYear)
                    .GetAwaiter().GetResult();
                    result = response.Body.TCKimlikNoDogrulaResult;
                }
            }
            catch (Exception ex)
            {
                result = false;
            }
            return Task.FromResult(result);
            
        }
    }
}
