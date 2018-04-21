using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Refit;
using XF.RefitApp.Services;
using XF.RefitApp.Models;
using Akavache;
using System.Reactive.Linq;

namespace XF.RefitApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();                        
            //await CallApi();
        }

        async Task CallApi()
        {
            //var api = RestService.For<IMakeUpApi>("http://makeup-api.herokuapp.com");
            //var sugars = await api.GetMakeUps();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                await BlobCache.LocalMachine.InsertObject<string>("message", "Hola Akavache", DateTimeOffset.Now.AddDays(2));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje", ex.Message, "Ok");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var message = "";
            try
            {
                BlobCache.LocalMachine.GetObject<string>("message")
                .Subscribe(
                    ms => message = ms,
                    ex => message = ""
                );

            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje", ex.Message, "Ok");
            }
            
            await DisplayAlert("Mensaje", message, "Ok");
        }
    }
}
