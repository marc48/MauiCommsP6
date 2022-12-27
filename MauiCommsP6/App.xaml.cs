namespace MauiCommsP6;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        const int newWidth = 500;
        const int newHeight = 900;

        window.X = 100;
        window.Y = 200;

        window.Width = newWidth;
        window.Height = newHeight;

        return window;
    }
}
