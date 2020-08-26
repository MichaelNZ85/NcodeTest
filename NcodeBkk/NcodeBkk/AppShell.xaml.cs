using System;
using System.Collections.Generic;
using NcodeBkk.ViewModels;
using NcodeBkk.Views;
using Xamarin.Forms;

namespace NcodeBkk
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
