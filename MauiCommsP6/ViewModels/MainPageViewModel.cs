using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace MauiCommsP6.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Action> Actions { get; set; } = new();
        public ObservableCollection<Action> Targets { get; set; } = new();

        [ObservableProperty]
        Action dragAction;

        ICommand TapSource_Tapped;
        int taps = 0;
        string numberOfTapsTapped;

        public MainPageViewModel()
        {
            Targets = new ObservableCollection<Action>()
            {
                {new Action("Nix Besonderes", Color.FromArgb("#FF87CEFA")) },
            };

            Actions = new ObservableCollection<Action>()
            {
                {new Action("Go for a walk", Color.FromArgb("#FFFF4500")) },
                {new Action("Finish PR", Color.FromArgb("#FF228B22")) },
                {new Action("Watch a movie", Color.FromArgb("#FF87CEFA")) },
                {new Action("Second movie", Color.FromArgb("#FFFFFF00")) },
            };
            // OrangeRed //ForestGreen  // LightSkyBlue)

            TapSource_Tapped = new Command(OnTapped);
        }

        void OnTapped(object s)
        {
            taps++;
            Debug.WriteLine("parameter: " + s);
            numberOfTapsTapped = String.Format("{0} tap{1} so far!",
                taps,
                taps == 1 ? "" : "s");
        }


        [RelayCommand]
        async Task FillActionsAsync()
        {
            Actions.Add(new Action("Do some work", Color.FromArgb("#FF228B22")));
            Actions.Add(new Action("Watch a movie", Color.FromArgb("#FF87CEFA")));
            Actions.Add(new Action("Second movie", Color.FromArgb("#FFFFFF00")));
            Actions.Add(new Action("Go for a walk", Color.FromArgb("#FFFF4500")));
        }

        [RelayCommand]
        async Task FillTargetsAsync()
        {
            Targets.Add(new Action("Do some work", Color.FromArgb("#FF228B22")));
            Targets.Add(new Action("Watch a movie", Color.FromArgb("#FF87CEFA")));
            Targets.Add(new Action("Second movie", Color.FromArgb("#FFFFFF00")));
        }

        [RelayCommand]
        void ClearSo()
        {
            Actions.Clear();
        }

        [RelayCommand]
        void ClearTg()
        {
            Targets.Clear();
        }
    }
}
