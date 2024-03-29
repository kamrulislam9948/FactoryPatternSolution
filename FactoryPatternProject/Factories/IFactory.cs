﻿using FactoryPatternProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternProject.Factories
{
    public interface IFactory
    {
        T Create<T>(params object[] args) where T : class, IProduct, new();
    }
}
