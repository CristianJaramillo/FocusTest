using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Focus.ViewModels
{
    public abstract class ViewModelBase
    {
        public abstract bool CanExcute(object parameter);
        public abstract void Execute(object parameter);
    }
}
