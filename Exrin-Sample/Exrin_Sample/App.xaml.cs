namespace ExrinSample
{
    using Abstraction.Enums;
    using Exrin.Abstraction;
    using Exrin.Framework;
    using Xamarin.Forms;

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Intializes everything and sets the MainPage to the navigation option set.
            Bootstrapper.GetInstance()
                        .Init()
                        .Get<INavigationService>()
                        .Navigate(new StackOptions()
                        {
                            StackChoice = Stack.Authentication
                        });
        }

        protected override void OnStart()
        {

    
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
        }
    }
}
