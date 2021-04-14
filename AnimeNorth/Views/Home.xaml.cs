using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimeNorth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private async void NavigateToDetails(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Details());
        }

        private void OnSearchBarButtonPressed(object sender, EventArgs e)
        {

        }

        private void ShowSearchBar(object sender, EventArgs e)
        {
            btnSearch.IsVisible = false;
            btnCancelSearch.IsVisible = true;
            searchBar.IsVisible = true;
        }

        private void HideSearchBar(object sender, EventArgs e)
        {
            btnSearch.IsVisible = true;
            btnCancelSearch.IsVisible = false;
            searchBar.IsVisible = false;
        }
    }
}