using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eCommerce;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(PickerRenderer))]
namespace eCommerce.iOS
{
    public class BorderPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            var view = e.NewElement as CustomPicker;
            this.Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}