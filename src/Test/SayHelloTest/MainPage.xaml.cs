using Plugin.SayHello;
using Xamarin.Forms;

namespace SayHelloTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var message = CrossSayHello.Current.SayHello();
            DisplayAlert("Multi targeting", message, "OK");
        }
    }
}
