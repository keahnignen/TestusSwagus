﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestusSwagus
{
    class Program
    {
        private static NonStaticClass nsc;

        static void Main(string[] args)
        {
            nsc = new NonStaticClass();
        }   
    }
}
