using Serilog.MauiApp.Net9.Models;
using Serilog.MauiApp.Net9.PageModels;

namespace Serilog.MauiApp.Net9.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}