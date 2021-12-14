﻿using JeanStationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ICartService
    {
        bool DeleteCart(string id);
        List<Cart> GetAllCarts();
        Cart GetCartByUserId(string userid);
    }
}
