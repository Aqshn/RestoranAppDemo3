using Restoran.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Restoran.Commands
{
    public class RelayCommand : ICommand
    {
        private Action<object?> executeShowCommand;
        private Func<object?, bool> canExecuteShowCommand;
        private Button Btn;

        public RelayCommand(Action<object?> executeShowCommand, Func<object?, bool> canExecuteShowCommand,Button btn)
        {
            this.executeShowCommand = executeShowCommand;
            this.canExecuteShowCommand = canExecuteShowCommand;
            Btn = btn;
        }

        public event EventHandler? CanExecuteChanged;

        public void Execute(object? parameter)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        public bool CanExecute(object? parameter) => Btn.Background == new SolidColorBrush(Colors.Green);


    }
}