﻿using StructureMap;
using System;
using System.Threading;

namespace Capitalism.SharedKernel
{
    public static class ObjectFactory
    {
        private static readonly Lazy<Container> _containerBuilder =
                new Lazy<Container>(defaultContainer, LazyThreadSafetyMode.ExecutionAndPublication);

        public static IContainer Container
        {
            get { return _containerBuilder.Value; }
        }

        private static Container defaultContainer()
        {
            return new Container(x =>
            {
                // default config
            });
        }
    }
}
