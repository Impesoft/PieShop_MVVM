﻿using PieShop_MVVM.Models;
using System.Collections.Generic;

namespace PieShop_MVVM.Services
{
    public interface IPieRepository
    {
        List<Pie> GetAllPies();
    }
}