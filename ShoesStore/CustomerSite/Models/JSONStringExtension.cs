using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Models
{
    public static class JSONStringExtension
    {
        public static string ToJsonString(this object model)
        {
            if (model is string) throw new ArgumentException("mode should not be a string");
            return JsonConvert.SerializeObject(model);
        }
    }
}
