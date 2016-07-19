using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Test_Focus.Models;
using Windows.UI.Popups;

namespace Test_Focus.ViewModels.Commands
{
    public class NameCommand : ICommand
    {
        public ViewModelBase ViewModel { get; set; }
        public event EventHandler CanExecuteChanged;

        public NameCommand(ViewModelBase viewModel)
        {
            this.ViewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return ViewModel.CanExcute(parameter);
        }

        public void Execute(object parameter)
        {
            ViewModel.Execute(parameter);
        }
    }
}
