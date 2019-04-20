﻿using Capitalism.Logic.Types;
using Capitalism.SharedKernel.Model;
using System;

namespace Capitalism.Logic.Models.Buildings
{
    public class Farm : WritableEntity, IMappable, IOwnable, IWorkable
    {
        public string TownId { get; private set; }
        public int XCoordinate { get; private set; }
        public int YCoordinate { get; private set; }
        public string Image => "tractor";
        public string Name { get; private set; }

        public int EnergyRequirement => 10;
        public int Wage { get; private set; }
        public string OwnerId { get; private set; }
        public bool IsForSale { get; private set; }
        public int? Price { get; private set; }
        
        public WorkResult Work(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
