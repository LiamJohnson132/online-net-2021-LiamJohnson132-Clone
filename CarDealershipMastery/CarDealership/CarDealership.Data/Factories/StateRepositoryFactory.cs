﻿using CarDealership.Data.DatabaseIntegration;
using CarDealership.Data.InMemoryIntegration;
using CarDealership.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Data.Factories
{
    public class StateRepositoryFactory
    {
        public static IStateRepository GetRepository()
        {
            switch (Settings.GetRepositoryType())
            {
                case "QA":
                    return new StateRepositoryQA();
                case "PROD":
                    return new StateRepositoryPROD();
                default:
                    throw new Exception("Could not find valid Mode configuration value");
            }
        }
    }
}
