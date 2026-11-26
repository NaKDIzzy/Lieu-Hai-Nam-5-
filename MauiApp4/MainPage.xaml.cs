namespace MauiApp4

using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp4.ViewModel;

namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}