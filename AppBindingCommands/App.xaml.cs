namespace AppBindingCommands
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DateTime data = DateTime.Now;
            Preferences.Set("dtAtual", data);
            Preferences.Set("AcaoInicial", string.Format("* App executado ás [0]. \n", data));
            MainPage = new AppShell();
        }

        protected override void OnStart() 
        {
            base.OnStart();
            Preferences.Set("AcaoStart", string.Format("* App iniciando ás {0}. \n", DateTime.Now));

        }
        protected override void OnSleep()
        {
            base.OnSleep();
            Preferences.Set("AcaoStart", string.Format("* App em segundo plano ás {0}. \n", DateTime.Now));
        }
        protected override void OnResume()
        {
            base.OnResume();
            Preferences.Set("AcaoStart", string.Format("* App reativado ás {0}. \n", DateTime.Now));
        }

        /* protected override Window CreateWindow(IActivationState? activationState)
         {
             return new Window(new AppShell());
         }*/
    }
    }