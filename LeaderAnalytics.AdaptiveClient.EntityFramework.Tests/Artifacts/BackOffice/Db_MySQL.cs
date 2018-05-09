﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using LeaderAnalytics.AdaptiveClient.EntityFramework;

namespace LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice
{
    public class Db_MySQL : Db, IMigrationContext
    {
        public Db_MySQL(DbContextOptions options) : base(options)
        {
        }
    }
}
