﻿using System.Threading.Tasks;
using FlightPlanner.Core.IRepositories;
using FlightPlanner.Models;

namespace FlightPlanner.Core.IConfiguration
{
    public interface IUnitOfWork
    {
        IFlightRepository Flights { get; }

        Task CompleteAsync();
    }
}