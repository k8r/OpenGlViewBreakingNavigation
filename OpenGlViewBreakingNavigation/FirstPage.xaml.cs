using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OpenGlViewBreakingNavigation
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();

            pushPageWithOpenGLView.Clicked += async (object sender, EventArgs e) => {
                await Navigation.PushModalAsync(new PageWithOpenGlView());
            };
        }
    }
}

