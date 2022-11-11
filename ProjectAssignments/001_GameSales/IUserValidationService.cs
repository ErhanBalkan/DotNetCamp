using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _001_GameSales
{
    public interface IUserValidationService
    {
        Task<bool> Validate(Gamer gamer);
    }
}