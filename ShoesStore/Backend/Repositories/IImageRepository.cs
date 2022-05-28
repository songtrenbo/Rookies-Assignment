﻿using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IImageRepository
    {
        Task <IEnumerable<Image>> GetImages(int productId);
    }
}
