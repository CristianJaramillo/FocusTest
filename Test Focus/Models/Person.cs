using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Focus.Common;

namespace Test_Focus.Models
{
    public class Person : BindableBase
    {

        public Person()
        {
            name = string.Empty;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); } 
        }
    }
}
