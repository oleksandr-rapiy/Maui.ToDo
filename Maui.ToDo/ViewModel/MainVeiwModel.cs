using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Maui.ToDo.ViewModel
{
    public partial class MainVeiwModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<string> tasks;

        [ObservableProperty]
        string task;

        public MainVeiwModel()
        {
            tasks = new ObservableCollection<string>();
        }


        [ICommand]
        void Add()
        {
            if (string.IsNullOrEmpty(task))
                return;

            Tasks.Add(task);
            Task = string.Empty;

        }

        [ICommand]
        void Remove(string task)
        {
            if (Tasks.Contains(task))
            {
                Tasks.Remove(task);
            }
        }
    }
}
