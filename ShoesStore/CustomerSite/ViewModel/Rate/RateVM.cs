using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.ViewModel.Rate
{
    public class RateVM
    {
        public int RateId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int OrderId { get; set; }
        public int Points { get; set; }
        public string Content { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
