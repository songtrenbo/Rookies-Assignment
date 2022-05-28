using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IRateRepository
    {
        Task<IEnumerable<Rate>> GetRates();
        Task<IEnumerable<Rate>> GetRatesByProductId(int productId);
        Task<double> GetSumRateByProductId(int productId);

    }
}
