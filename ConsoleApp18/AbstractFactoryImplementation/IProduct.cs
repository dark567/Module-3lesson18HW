﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.AbstractFactoryImplementation
{
    interface IProduct<TFactory>
    {
        void Operate();
    }
}
