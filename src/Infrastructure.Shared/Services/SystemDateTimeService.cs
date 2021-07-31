﻿using CustomerManager.Application.Interfaces.Services;
using System;

namespace CustomerManager.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}