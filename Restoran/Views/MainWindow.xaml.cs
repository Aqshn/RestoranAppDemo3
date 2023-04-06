using Restoran.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restoran.Views
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public ICommand ShowCommand { get; set; }

        public Button button { get; set; }

        public void Click(object sender, RoutedEventArgs e)
        {
            if (btn1 == sender)
            {
                button = btn1;

            }
            else if (btn2 == sender)
            {
                button = btn2;
            }
            else if (btn3 == sender)
            {
                button = btn3;
            }
            else if (btn4 == sender)
            {
                button = btn4;
            }
            else if (btn5 == sender)
            {
                button = btn5;
            }
            else if (btn6 == sender)
            {
                button = btn6;
            }
            ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand,sender);
        }

        void ExecuteShowCommand(object? parametr)
        {

        }
        bool CanExecuteShowCommand(object? parametr)
            => true;
    }

}