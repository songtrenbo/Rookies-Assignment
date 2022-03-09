using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public interface IRateService
    {
        Task<IEnumerable<Rate>> GetRates();
        Task<IEnumerable<Rate>> GetRatesByProductId(int productId);
        Task<double> GetSumRateByProductId(int productId);

    }
}
