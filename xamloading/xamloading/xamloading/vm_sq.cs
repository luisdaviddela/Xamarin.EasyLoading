using System.Windows.Input;
using Xamarin.Forms;

namespace xamloading
{
    public class vm_sq
    {
        //public State CurrentState { get; set; }
        public ICommand ToggleLoadingCommand { get; set; }
        public vm_sq()
        {
            //ToggleLoadingCommand = new Command(async (x) => {
            //    CurrentState = State.Loading;
            //    await Task.Delay(2000);
            //    CurrentState = State.None;
            //});
        }
    }
}
