using ExpenseTracker.Services;

namespace ExpenseTracker
{
    public partial class App : Application
    {
        public App(DatabaseService databaseService)
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                await databaseService.InitializeAsync();
            });
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}