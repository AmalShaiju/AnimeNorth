﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimeNorth.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        public Details()
        {
            InitializeComponent();
        }

        private void MoveToHome(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}