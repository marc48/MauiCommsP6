using MauiCommsP6.ViewModels;

namespace MauiCommsP6.Views;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

	private void DragSource_DragStarting(object sender, DragStartingEventArgs e)
	{

	}

	private void TapSource_Tapped(object sender, EventArgs e)
	{
		DisplayAlert("Tapped", "SourceIitem Tapped: " + e, "OK");
	}

	private void ButtonCB_Clicked(object sender, EventArgs e)
	{
        DisplayAlert("Tapped", "SourceIitem Tapped: " + e, "OK");
    }
}

