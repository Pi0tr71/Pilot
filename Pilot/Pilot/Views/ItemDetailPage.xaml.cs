﻿using Pilot.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Pilot.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}