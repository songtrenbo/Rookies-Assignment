using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public interface ISizeService
    {
        Task<IEnumerable<SizeProduct>> GetSizesByProductId(int productId);
    }
}
