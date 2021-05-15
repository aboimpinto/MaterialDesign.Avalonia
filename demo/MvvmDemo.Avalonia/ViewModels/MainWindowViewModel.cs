using System;
using System.Windows.Input;
using MaterialDesign.Avalonia.PackIcon;
using ReactiveUI;

namespace MvvmDemo.Avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private PackIconKind _icon;

        public PackIconKind Icon 
        { 
            get => this._icon;
            set => this.RaiseAndSetIfChanged(ref this._icon, value) ;
        }

        public ICommand MonitorIconCommand { get; }

        public ICommand NoneIconCommand { get; }

        public MainWindowViewModel()
        {
            this.MonitorIconCommand = ReactiveCommand.Create(this.OnMonitorIconClicked);
            this.NoneIconCommand = ReactiveCommand.Create(this.OnNoneIconClicked);
        }

        private void OnNoneIconClicked()
        {
            this.Icon = PackIconKind.None;
        }

        private void OnMonitorIconClicked()
        {
            this.Icon = PackIconKind.MonitorDashboard;
        }
    }
}
