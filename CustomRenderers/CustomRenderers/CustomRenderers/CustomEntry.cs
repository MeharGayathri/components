using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomRenderers
{
    public class CustomEntry:Entry
    {
        public int borderWidth {
            get;
            set;
        }
        public BindableProperty borderColorProperty = BindableProperty.Create(nameof(borderColor),typeof(Color),typeof(CustomEntry),Color.Gray);
        public Color borderColor
        { get {return (Color)GetValue(borderColorProperty); }
            set { SetValue(borderColorProperty, value); }
        }
        public double cornerRadius {
            get;set;
        }
        public bool isCurvedCornersAvailable {
            get;
            set;
        }
    }
}
