using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OpenGlViewBreakingNavigation
{
    public partial class PageWithOpenGlView : ContentPage
    {
        public PageWithOpenGlView()
        {
            InitializeComponent();

            back.Clicked += async (object sender, EventArgs e) => {
                await Navigation.PopModalAsync();
            };
        }
    }
}

