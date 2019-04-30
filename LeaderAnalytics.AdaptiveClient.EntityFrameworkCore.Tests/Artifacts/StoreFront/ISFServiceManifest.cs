﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeaderAnalytics.AdaptiveClient.EntityFrameworkCore.Tests.Artifacts.StoreFront
{
    public interface ISFServiceManifest : IDisposable
    {
        IOrdersService OrdersService {get;}
        IProductsService ProductsService { get; }
    }
}
