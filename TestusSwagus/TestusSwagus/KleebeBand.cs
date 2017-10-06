using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestusSwagus
{
    class KleebeBand<T> : IBand<T>
    {
        public string Title { get; set; }
        public List<T> Listae { get; set; }
    }
}
