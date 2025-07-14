﻿using System.Collections.Generic;
using ElectronicsStore.Domain.Entities;

namespace ElectronicsStore.WebUI.Models {
    public class ProductsListViewModel {

        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}