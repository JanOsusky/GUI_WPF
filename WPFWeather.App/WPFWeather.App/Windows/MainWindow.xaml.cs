using System.Windows;
using WPFWeather.App.Services;
using WPFWeather.App.ViewModels;

namespace WPFWeather.App.Windows
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WeatherViewModel viewmodel = new WeatherViewModel(new WeatherDiskService());
            DataContext = viewmodel;
            viewmodel.DownloadWeatherCommand.Execute("Brno");
        }
    }
}