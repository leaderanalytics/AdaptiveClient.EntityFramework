﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice
{
    public interface IPaymentsService
    {
        Task ApplyPayment(Payment payment);
        Task ReversePayment(Payment payment);
             
    }
}
