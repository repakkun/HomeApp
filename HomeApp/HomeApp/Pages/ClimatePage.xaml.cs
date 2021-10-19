using System;
using System.Collections;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    public partial class ClimatePage : ContentPage
    {
        public ClimatePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Внешние датчики
        /// </summary>
        public void ScanOutside()
        {
            relativeLayout.Children.Add(new BoxView
            {
                Color = Color.Chocolate
            }, () => new Rectangle(100, 100, 250, 100));

            relativeLayout.Children.Add(
                new Label
                {
                    Text = $"Outside",
                    VerticalTextAlignment = TextAlignment.Start,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 13,
                    TextColor = Color.Black
                }, () => new Rectangle(100, 100, 250, 100));


            relativeLayout.Children.Add(
                new Label
                {
                    Text = "- 15 °C",
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 20,
                    TextColor = Color.Black
                    
                },
                () => new Rectangle(100, 100, 250, 100));
        }

        /// <summary>
        /// Внутренние датчики
        /// </summary>
        public void ScanInside()
        {
            relativeLayout.Children.Add(new BoxView
            {
                Color = Color.Yellow
            }, () => new Rectangle(100, 200, 250, 100));

            relativeLayout.Children.Add(
                new Label
                {
                    Text = $"Inside",
                    VerticalTextAlignment = TextAlignment.Start,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 13,
                    TextColor = Color.Black
                },
                () => new Rectangle(100, 200, 250, 100));

            relativeLayout.Children.Add(
                new Label
                {
                    Text = "+ 24 °C",
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 20,
                    TextColor = Color.Black
                },
                () => new Rectangle(100, 200, 250, 100));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ScanInside();
            ScanOutside();
            climateButton.IsEnabled = false;
        }

        private void climateButton_Focused(object sender, FocusEventArgs e)
        {
            
        }
    }
}