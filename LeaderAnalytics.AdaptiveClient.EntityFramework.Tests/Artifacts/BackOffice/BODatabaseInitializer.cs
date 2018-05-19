﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeaderAnalytics.AdaptiveClient.EntityFramework;

namespace LeaderAnalytics.AdaptiveClient.EntityFramework.Tests.Artifacts.BackOffice
{
    public class BODatabaseInitializer : IDatabaseInitializer
    {
        private Db db;


        public BODatabaseInitializer(Db db)
        {
            this.db = db;
        }

        public async Task Seed(string migrationName)
        {
            Account account1 = new Account { Name = "XYZ Corp" };
            Payment payment1 = new Payment { Account = account1, Amount = 100, PaymentDate = DateTime.Now };

            db.Accounts.Add(account1);
            db.Payments.Add(payment1);

            await db.SaveChangesAsync();
        }
    }
}
