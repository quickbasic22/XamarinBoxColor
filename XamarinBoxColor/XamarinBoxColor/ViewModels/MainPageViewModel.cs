using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Color = Xamarin.Forms.Color;

namespace XamarinBoxColor.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        double hue, saturation, luminosity;
        Xamarin.Forms.Color color;

        public double Hue
        {
            get => hue;
            set
            {
                if (hue != value) 
                {
                    hue = value;
                    OnPropertyChanged();
                    SetNewColor();
                }
            }
        }
        public Double Saturation
        { 
            get => saturation;
            set
            {
                if (saturation != value) 
                {
                    saturation = value;
                    OnPropertyChanged();
                    SetNewColor();
                }
            }
        }
        public Double Luminosity
        { 
            get => luminosity;
            set
            {
                if (luminosity != value)
                {
                    luminosity = value;
                    OnPropertyChanged();
                    SetNewColor();
                }
            }
        }
        public Color Color
        {
            get => color;
            set
            {
                if (color != value) 
                {
                    color = value;
                    OnPropertyChanged();
                    Hue = value.Hue;
                    Saturation = value.Saturation;
                    Luminosity = value.Luminosity;
                }
            }
        }
        void SetNewColor()
        {
            Color = Color.FromHsla(Hue, Saturation, Luminosity);
        }

    }
}
