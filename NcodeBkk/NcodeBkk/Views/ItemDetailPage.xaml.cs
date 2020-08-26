using System.ComponentModel;
using Xamarin.Forms;
using NcodeBkk.ViewModels;

namespace NcodeBkk.Views
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