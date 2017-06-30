// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using ExtCore.Data.EntityFramework;
using Incomes.Data.Abstractions;
using Incomes.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Incomes.Data.EntityFramework.Sqlite
{
  public class IncomeRepository : RepositoryBase<Income>, IIncomeRepository
  {
    public Income WithKey(int id)
    {
      return this.dbSet.FirstOrDefault(i => i.Id == id);
    }

    public IEnumerable<Income> All()
    {
      return this.dbSet.OrderByDescending(i => i.Created);
    }

    public void Create(Income income)
    {
      this.dbSet.Add(income);
    }

    public void Edit(Income income)
    {
      this.storageContext.Entry(income).State = EntityState.Modified;
    }

    public void Delete(int id)
    {
      this.Delete(this.WithKey(id));
    }

    public void Delete(Income income)
    {
      this.dbSet.Remove(income);
    }

    public decimal Total()
    {
      return this.dbSet.Sum(i => i.Amount);
    }
  }
}