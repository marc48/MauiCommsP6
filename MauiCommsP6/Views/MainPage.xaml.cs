using MauiCommsP6.ViewModels;

namespace MauiCommsP6.Views;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }

}

