using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
            await Navigation.PushAsync(new ButtonDemo());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ButtonCode());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new DatepickerDemo());
            };
            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new EditorDemo());
            };







            private void Item2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ButtonDemo());
        };

        private void Item3_Clicked(object sender, EventArgs e)
        {

        };

        private void Item4_Clicked(object sender, EventArgs e)
        {

        };

        private void Item5_Clicked(object sender, EventArgs e)
        {

        };

        Item6.Clicked += async (sender, e)=>
        {
                await Navigation.PushAsync(new EntryDemo());
        };
    }
    }
}
