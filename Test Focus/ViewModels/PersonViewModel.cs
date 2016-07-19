using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Focus.Models;
using Test_Focus.ViewModels.Commands;
using Windows.UI.Popups;

namespace Test_Focus.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {

        public NameCommand NameCommand { get; set; }

        public PersonViewModel()
        {
            this.NameCommand = new NameCommand(this);
        }

        public override bool CanExcute(object parameter)
        {
            string name = parameter as string;
            return string.IsNullOrEmpty(name) ? false : name.Length >= 4;
        }

        public override async void Execute(object parameter)
        {
            string name = parameter as string;
            string text = string.Format("Se ha guardado {0}", name);
            MessageDialog msg = new MessageDialog(text);
            await msg.ShowAsync();
        }

    }
}
