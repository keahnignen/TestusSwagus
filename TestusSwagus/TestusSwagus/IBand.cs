using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestusSwagus
{
    interface IBand<T>
    {
        string Title { get; set; }
        List<T> Listae { get; set; }
    }
}
