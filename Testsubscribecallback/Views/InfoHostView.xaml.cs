using System;
using System.Collections.Generic;
using Testsubscribecallback.ViewModels;
using Xamarin.Forms;

namespace Testsubscribecallback.Views
{
    public partial class InfoHostView : ContentPage
    {
        public InfoHostView()
        {
            InitializeComponent();
            BindingContext = new InfoHostViewModel();
        }
    }
}
