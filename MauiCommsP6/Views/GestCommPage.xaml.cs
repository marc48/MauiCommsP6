using MauiCommsP6.ViewModels;

namespace MauiCommsP6.Views;

public partial class GestCommPage : ContentPage
{
    public GestCommPage(GestCommViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

}