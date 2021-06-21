﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfPreset.Model;

namespace WpfPreset.ViewModel
{
    internal class ProductListViewModel : ViewModelBase
    {

        private ObservableCollection<Product> products = new ObservableCollection<Product>();
        public ObservableCollection<Product> Products
        {
            get
            {
                return products;
            }
        }

        public Product NewProduct
        {
            get
            {
                return products.LastOrDefault();
            }
            set
            {
                products.Add(value);
                OnPropertyChanged("ProductAdded");
            }
        }
    }
}