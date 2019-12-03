using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamloading
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //BindingContext =new vm_sq();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            UiState.AnimationIsRunning("true");
            UiState.StateKey = Xamarin.Forms.StateSquid.State.Loading;
        }
    }
}
