﻿using ElectroMarket.Domain.Entities;

namespace ElectroMarket.WebUI.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}