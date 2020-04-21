using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eCommerce.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepView : ContentPage
    {
        int statusFlag = 3;
        public StepView()
        {
            InitializeComponent();
            if (statusFlag==1)
            {
                
                line1.BackgroundColor = Color.FromHex("#DDDDDD");

                date2.TextColor = Color.White;
                date22.TextColor = Color.White;
                frame2.BackgroundColor = Color.Transparent;
                line2.BackgroundColor = Color.FromHex("#DDDDDD");

                date3.TextColor = Color.White;
                date33.TextColor = Color.White;
                frame3.BackgroundColor = Color.Transparent;
                line3.BackgroundColor = Color.FromHex("#DDDDDD");

                date4.TextColor = Color.White;
                date44.TextColor = Color.White;
                frame4.BackgroundColor = Color.Transparent;
                line4.BackgroundColor = Color.FromHex("#DDDDDD");

                date5.TextColor = Color.White;
                date55.TextColor = Color.White;
                frame5.BackgroundColor = Color.Transparent;
            }
            else if (statusFlag == 2)
            {

                
                line2.BackgroundColor = Color.FromHex("#DDDDDD");

                date3.TextColor = Color.White;
                date33.TextColor = Color.White;
                frame3.BackgroundColor = Color.Transparent;
                line3.BackgroundColor = Color.FromHex("#DDDDDD");

                date4.TextColor = Color.White;
                date44.TextColor = Color.White;
                frame4.BackgroundColor = Color.Transparent;
                line4.BackgroundColor = Color.FromHex("#DDDDDD");

                date5.TextColor = Color.White;
                date55.TextColor = Color.White;
                frame5.BackgroundColor = Color.Transparent;
            }
            else if (statusFlag == 3)
            {

                
                line3.BackgroundColor = Color.FromHex("#DDDDDD");

                date4.TextColor = Color.White;
                date44.TextColor = Color.White;
                frame4.BackgroundColor = Color.Transparent;
                line4.BackgroundColor = Color.FromHex("#DDDDDD");

                date5.TextColor = Color.White;
                date55.TextColor = Color.White;
                frame5.BackgroundColor = Color.Transparent;
            }
            else if (statusFlag == 4)
            {

               
                line4.BackgroundColor = Color.FromHex("#DDDDDD");

                date5.TextColor = Color.White;
                date55.TextColor = Color.White;
                frame5.BackgroundColor = Color.Transparent;
            }
            else if (statusFlag == 5)
            {

            }
            else
            {
                date1.TextColor = Color.White;
                date11.TextColor = Color.White;
                frame1.BackgroundColor = Color.Transparent;
                line1.BackgroundColor = Color.FromHex("#DDDDDD");

                date2.TextColor = Color.White;
                date22.TextColor = Color.White;
                frame2.BackgroundColor = Color.Transparent;
                line2.BackgroundColor = Color.FromHex("#DDDDDD");

                date3.TextColor = Color.White;
                date33.TextColor = Color.White;
                frame3.BackgroundColor = Color.Transparent;
                line3.BackgroundColor = Color.FromHex("#DDDDDD");

                date4.TextColor = Color.White;
                date44.TextColor = Color.White;
                frame4.BackgroundColor = Color.Transparent;
                line4.BackgroundColor = Color.FromHex("#DDDDDD");

                date5.TextColor = Color.White;
                date55.TextColor = Color.White;
                frame5.BackgroundColor = Color.Transparent;
               
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }

        
    }
}