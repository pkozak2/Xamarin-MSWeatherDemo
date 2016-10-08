using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MSWeatherDemo
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.Title = "WeatherAppDemo";
            getWeatherBtn.Clicked += getWeatherBtn_Clicked;

            this.BindingContext = new Weather();
        }
        private async void getWeatherBtn_Clicked(object sender, EventArgs e)
        {
            Weather weather = await Core.GetWeather(nameEntry.Text);
            this.BindingContext = weather;
            getWeatherBtn.Text = "Search again";
        }
    }
}
