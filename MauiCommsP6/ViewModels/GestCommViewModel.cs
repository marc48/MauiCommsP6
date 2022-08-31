using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCommsP6.ViewModels
{
    public partial class GestCommViewModel : BaseViewModel
    {
        public ObservableCollection<Action> Actions { get; set; } = new();
        public ObservableCollection<Action> Targets { get; set; } = new();

        [ObservableProperty]
        Action dragAction;

        public GestCommViewModel()
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

        }

        //[RelayCommand]
        //async Task DragStartingAsync<Action>(title)
        //{
        //    dragAction = ;
        //}

        //public ICommand DragStartingCommand => new Command<Action>((param) =>
        //{
        //    dragAction = param;
        //    //Debug.WriteLine(param.ToString());
        //});

        //public ICommand DropTargetCommand => new Command(() =>
        //{
        //    if (Actions.Contains(dragAction))
        //    {
        //        Targets.Add(dragAction);
        //        Actions.Remove(dragAction);
        //    }
        //});

        //[RelayCommand]
        //async Task TapSrcAsync<Action>()
        //{
        //    await Shell.Current.DisplayAlert("Tap auf Source", "Message", "OK");
        //    //Targets.Add(dragAction);
        //    //Actions.Remove(dragAction);
        //}

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
