using System;
using System.Collections.Generic;
using Testsubscribecallback.ViewModels;
using Xamarin.Forms;

namespace Testsubscribecallback.Views
{
    public partial class InfoView : ContentPage
    {
        public InfoView()
        {
            InitializeComponent();
            BindingContext = new InfoViewModel();
        }

        protected override bool OnBackButtonPressed()
        {
            return base.OnBackButtonPressed();
        }
    }
}
